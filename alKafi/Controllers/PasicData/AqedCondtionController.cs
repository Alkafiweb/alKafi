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
    public class AqedCondtionController : Controller
    {
        private readonly alkafidb2019Context _context;

        public AqedCondtionController(alkafidb2019Context context)
        {
            _context = context;
        }

        // GET: AqedCondtion
        public async Task<IActionResult> Index()
        {
            return View(await _context.AqedCondtionTbls.ToListAsync());
        }

        // GET: AqedCondtion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aqedCondtionTbl = await _context.AqedCondtionTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aqedCondtionTbl == null)
            {
                return NotFound();
            }

            return View(aqedCondtionTbl);
        }

        // GET: AqedCondtion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AqedCondtion/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AqedTxt")] AqedCondtionTbl aqedCondtionTbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aqedCondtionTbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aqedCondtionTbl);
        }

        // GET: AqedCondtion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aqedCondtionTbl = await _context.AqedCondtionTbls.FindAsync(id);
            if (aqedCondtionTbl == null)
            {
                return NotFound();
            }
            return View(aqedCondtionTbl);
        }

        // POST: AqedCondtion/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AqedTxt")] AqedCondtionTbl aqedCondtionTbl)
        {
            if (id != aqedCondtionTbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aqedCondtionTbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AqedCondtionTblExists(aqedCondtionTbl.Id))
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
            return View(aqedCondtionTbl);
        }

        // GET: AqedCondtion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aqedCondtionTbl = await _context.AqedCondtionTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aqedCondtionTbl == null)
            {
                return NotFound();
            }

            return View(aqedCondtionTbl);
        }

        // POST: AqedCondtion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aqedCondtionTbl = await _context.AqedCondtionTbls.FindAsync(id);
            _context.AqedCondtionTbls.Remove(aqedCondtionTbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AqedCondtionTblExists(int id)
        {
            return _context.AqedCondtionTbls.Any(e => e.Id == id);
        }
    }
}
