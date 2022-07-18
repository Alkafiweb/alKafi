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
    public class StatusNameController : Controller
    {
        private readonly alkafidb2019Context _context;

        public StatusNameController(alkafidb2019Context context)
        {
            _context = context;
        }

        // GET: StatusName
        public async Task<IActionResult> Index()
        {
            var alkafidb2019Context = _context.StatusNameTbls.Include(s => s.Country);
            return View(await alkafidb2019Context.ToListAsync());
        }

        // GET: StatusName/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusNameTbl = await _context.StatusNameTbls
                .Include(s => s.Country)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statusNameTbl == null)
            {
                return NotFound();
            }

            return View(statusNameTbl);
        }

        // GET: StatusName/Create
        public IActionResult Create()
        {
            ViewData["CountryId"] = new SelectList(_context.NationalityTbls, "Id", "CountryName");
            return View();
        }

        // POST: StatusName/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SName,SNameEn,CountryId,TotalDays,Color,AfterSend,SOrder")] StatusNameTbl statusNameTbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(statusNameTbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryId"] = new SelectList(_context.NationalityTbls, "Id", "CountryName", statusNameTbl.CountryId);
            return View(statusNameTbl);
        }

        // GET: StatusName/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusNameTbl = await _context.StatusNameTbls.FindAsync(id);
            if (statusNameTbl == null)
            {
                return NotFound();
            }
            ViewData["CountryId"] = new SelectList(_context.NationalityTbls, "Id", "CountryName", statusNameTbl.CountryId);
            return View(statusNameTbl);
        }

        // POST: StatusName/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SName,SNameEn,CountryId,TotalDays,Color,AfterSend,SOrder")] StatusNameTbl statusNameTbl)
        {
            if (id != statusNameTbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(statusNameTbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatusNameTblExists(statusNameTbl.Id))
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
            ViewData["CountryId"] = new SelectList(_context.NationalityTbls, "Id", "CountryName", statusNameTbl.CountryId);
            return View(statusNameTbl);
        }

        // GET: StatusName/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusNameTbl = await _context.StatusNameTbls
                .Include(s => s.Country)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statusNameTbl == null)
            {
                return NotFound();
            }

            return View(statusNameTbl);
        }

        // POST: StatusName/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var statusNameTbl = await _context.StatusNameTbls.FindAsync(id);
            _context.StatusNameTbls.Remove(statusNameTbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StatusNameTblExists(int id)
        {
            return _context.StatusNameTbls.Any(e => e.Id == id);
        }
    }
}
