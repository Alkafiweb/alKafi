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
    public class AqedSourceController : Controller
    {
        private readonly alkafidb2019Context _context;

        public AqedSourceController(alkafidb2019Context context)
        {
            _context = context;
        }

        // GET: AqedSource
        public async Task<IActionResult> Index()
        {
            return View(await _context.AqedSourceTbls.ToListAsync());
        }

        // GET: AqedSource/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aqedSourceTbl = await _context.AqedSourceTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aqedSourceTbl == null)
            {
                return NotFound();
            }

            return View(aqedSourceTbl);
        }

        // GET: AqedSource/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AqedSource/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OfficeSource")] AqedSourceTbl aqedSourceTbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aqedSourceTbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aqedSourceTbl);
        }

        // GET: AqedSource/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aqedSourceTbl = await _context.AqedSourceTbls.FindAsync(id);
            if (aqedSourceTbl == null)
            {
                return NotFound();
            }
            return View(aqedSourceTbl);
        }

        // POST: AqedSource/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OfficeSource")] AqedSourceTbl aqedSourceTbl)
        {
            if (id != aqedSourceTbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aqedSourceTbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AqedSourceTblExists(aqedSourceTbl.Id))
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
            return View(aqedSourceTbl);
        }

        // GET: AqedSource/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aqedSourceTbl = await _context.AqedSourceTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aqedSourceTbl == null)
            {
                return NotFound();
            }

            return View(aqedSourceTbl);
        }

        // POST: AqedSource/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aqedSourceTbl = await _context.AqedSourceTbls.FindAsync(id);
            _context.AqedSourceTbls.Remove(aqedSourceTbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AqedSourceTblExists(int id)
        {
            return _context.AqedSourceTbls.Any(e => e.Id == id);
        }
    }
}
