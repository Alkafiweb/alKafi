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
    public class NationalityController : Controller
    {
        private readonly alkafidb2019Context _context;

        public NationalityController(alkafidb2019Context context)
        {
            _context = context;
        }

        // GET: Nationality
        public async Task<IActionResult> Index()
        {
            return View(await _context.NationalityTbls.ToListAsync());
        }

        // GET: Nationality/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nationalityTbl = await _context.NationalityTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nationalityTbl == null)
            {
                return NotFound();
            }

            return View(nationalityTbl);
        }

        // GET: Nationality/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nationality/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NationalName,CountryName,NationalNameEn,Active")] NationalityTbl nationalityTbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nationalityTbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nationalityTbl);
        }

        // GET: Nationality/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nationalityTbl = await _context.NationalityTbls.FindAsync(id);
            if (nationalityTbl == null)
            {
                return NotFound();
            }
            return View(nationalityTbl);
        }

        // POST: Nationality/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NationalName,CountryName,NationalNameEn,Active")] NationalityTbl nationalityTbl)
        {
            if (id != nationalityTbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nationalityTbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NationalityTblExists(nationalityTbl.Id))
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
            return View(nationalityTbl);
        }

        // GET: Nationality/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nationalityTbl = await _context.NationalityTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nationalityTbl == null)
            {
                return NotFound();
            }

            return View(nationalityTbl);
        }

        // POST: Nationality/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nationalityTbl = await _context.NationalityTbls.FindAsync(id);
            _context.NationalityTbls.Remove(nationalityTbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NationalityTblExists(int id)
        {
            return _context.NationalityTbls.Any(e => e.Id == id);
        }
    }
}
