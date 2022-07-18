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
    public class MuaqebsController : Controller
    {
        private readonly alkafidb2019Context _context;

        public MuaqebsController(alkafidb2019Context context)
        {
            _context = context;
        }

        // GET: Muaqebs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Muaqebs.ToListAsync());
        }

        // GET: Muaqebs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muaqeb = await _context.Muaqebs
                .FirstOrDefaultAsync(m => m.MuaqebId == id);
            if (muaqeb == null)
            {
                return NotFound();
            }

            return View(muaqeb);
        }

        // GET: Muaqebs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Muaqebs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MuaqebId,MuaqebName,MuaqebPhone,MoaccId")] Muaqeb muaqeb)
        {
            if (ModelState.IsValid)
            {
                _context.Add(muaqeb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(muaqeb);
        }

        // GET: Muaqebs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muaqeb = await _context.Muaqebs.FindAsync(id);
            if (muaqeb == null)
            {
                return NotFound();
            }
            return View(muaqeb);
        }

        // POST: Muaqebs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MuaqebId,MuaqebName,MuaqebPhone,MoaccId")] Muaqeb muaqeb)
        {
            if (id != muaqeb.MuaqebId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(muaqeb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MuaqebExists(muaqeb.MuaqebId))
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
            return View(muaqeb);
        }

        // GET: Muaqebs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muaqeb = await _context.Muaqebs
                .FirstOrDefaultAsync(m => m.MuaqebId == id);
            if (muaqeb == null)
            {
                return NotFound();
            }

            return View(muaqeb);
        }

        // POST: Muaqebs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var muaqeb = await _context.Muaqebs.FindAsync(id);
            _context.Muaqebs.Remove(muaqeb);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MuaqebExists(int id)
        {
            return _context.Muaqebs.Any(e => e.MuaqebId == id);
        }
    }
}
