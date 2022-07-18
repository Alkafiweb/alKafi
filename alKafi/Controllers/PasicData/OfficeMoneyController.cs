using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using alKafi.Models;

namespace alKafi.Controllers.PasicData
{
    public class OfficeMoneyController : Controller
    {
        private readonly alkafidb2019Context _context;

        public OfficeMoneyController(alkafidb2019Context context)
        {
            _context = context;
        }

        // GET: OfficeMoney
        public async Task<IActionResult> Index()
        {
            var alkafidb2019Context = _context.OfficeMoneyTbls.Include(o => o.Job).Include(o => o.Office).Include(o => o.Relegin);
            return View(await alkafidb2019Context.ToListAsync());
        }

        // GET: OfficeMoney/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officeMoneyTbl = await _context.OfficeMoneyTbls
                .Include(o => o.Job)
                .Include(o => o.Office)
                .Include(o => o.Relegin)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (officeMoneyTbl == null)
            {
                return NotFound();
            }

            return View(officeMoneyTbl);
        }

        // GET: OfficeMoney/Create
        public IActionResult Create()
        {
            ViewData["JobId"] = new SelectList(_context.JobTbls, "Id", "Job");
            ViewData["OfficeId"] = new SelectList(_context.OfficeTbls, "Id", "OfficeName");
            ViewData["ReleginId"] = new SelectList(_context.RelegionTbls, "Id", "Relegion");
            return View();
        }

        // POST: OfficeMoney/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OfficeId,JobId,ReleginId,Price,PriceUs")] OfficeMoneyTbl officeMoneyTbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(officeMoneyTbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["JobId"] = new SelectList(_context.JobTbls, "Id", "Job", officeMoneyTbl.JobId);
            ViewData["OfficeId"] = new SelectList(_context.OfficeTbls, "Id", "OfficeName", officeMoneyTbl.OfficeId);
            ViewData["ReleginId"] = new SelectList(_context.RelegionTbls, "Id", "Relegion", officeMoneyTbl.ReleginId);
            return View(officeMoneyTbl);
        }

        // GET: OfficeMoney/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officeMoneyTbl = await _context.OfficeMoneyTbls.FindAsync(id);
            if (officeMoneyTbl == null)
            {
                return NotFound();
            }
            ViewData["JobId"] = new SelectList(_context.JobTbls, "Id", "Job", officeMoneyTbl.JobId);
            ViewData["OfficeId"] = new SelectList(_context.OfficeTbls, "Id", "OfficeName", officeMoneyTbl.OfficeId);
            ViewData["ReleginId"] = new SelectList(_context.RelegionTbls, "Id", "Relegion", officeMoneyTbl.ReleginId);
            return View(officeMoneyTbl);
        }

        // POST: OfficeMoney/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OfficeId,JobId,ReleginId,Price,PriceUs")] OfficeMoneyTbl officeMoneyTbl)
        {
            if (id != officeMoneyTbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(officeMoneyTbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OfficeMoneyTblExists(officeMoneyTbl.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["JobId"] = new SelectList(_context.JobTbls, "Id", "Job", officeMoneyTbl.JobId);
            ViewData["OfficeId"] = new SelectList(_context.OfficeTbls, "Id", "OfficeName", officeMoneyTbl.OfficeId);
            ViewData["ReleginId"] = new SelectList(_context.RelegionTbls, "Id", "Relegion", officeMoneyTbl.ReleginId);
            return View(officeMoneyTbl);
        }

        // GET: OfficeMoney/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officeMoneyTbl = await _context.OfficeMoneyTbls
                .Include(o => o.Job)
                .Include(o => o.Office)
                .Include(o => o.Relegin)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (officeMoneyTbl == null)
            {
                return NotFound();
            }

            return View(officeMoneyTbl);
        }

        // POST: OfficeMoney/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var officeMoneyTbl = await _context.OfficeMoneyTbls.FindAsync(id);
            _context.OfficeMoneyTbls.Remove(officeMoneyTbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OfficeMoneyTblExists(int id)
        {
            return _context.OfficeMoneyTbls.Any(e => e.Id == id);
        }
    }
}
