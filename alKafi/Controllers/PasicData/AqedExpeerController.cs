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
    public class AqedExpeerController : Controller
    {
        private readonly alkafidb2019Context _context;

        public AqedExpeerController(alkafidb2019Context context)
        {
            _context = context;
        }

        // GET: AqedExpeer
        public async Task<IActionResult> Index()
        {
            return View(await _context.AqedExpeerTbls.ToListAsync());
        }

        // GET: AqedExpeer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aqedExpeerTbl = await _context.AqedExpeerTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aqedExpeerTbl == null)
            {
                return NotFound();
            }

            return View(aqedExpeerTbl);
        }

        // GET: AqedExpeer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AqedExpeer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AqedTxt")] AqedExpeerTbl aqedExpeerTbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aqedExpeerTbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aqedExpeerTbl);
        }

        // GET: AqedExpeer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aqedExpeerTbl = await _context.AqedExpeerTbls.FindAsync(id);
            if (aqedExpeerTbl == null)
            {
                return NotFound();
            }
            return View(aqedExpeerTbl);
        }

        // POST: AqedExpeer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AqedTxt")] AqedExpeerTbl aqedExpeerTbl)
        {
            if (id != aqedExpeerTbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aqedExpeerTbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AqedExpeerTblExists(aqedExpeerTbl.Id))
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
            return View(aqedExpeerTbl);
        }

        // GET: AqedExpeer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aqedExpeerTbl = await _context.AqedExpeerTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aqedExpeerTbl == null)
            {
                return NotFound();
            }

            return View(aqedExpeerTbl);
        }

        // POST: AqedExpeer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aqedExpeerTbl = await _context.AqedExpeerTbls.FindAsync(id);
            _context.AqedExpeerTbls.Remove(aqedExpeerTbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AqedExpeerTblExists(int id)
        {
            return _context.AqedExpeerTbls.Any(e => e.Id == id);
        }
    }
}
