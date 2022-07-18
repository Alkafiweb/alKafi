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
    public class RelegionController : Controller
    {
        private readonly alkafidb2019Context _context;

        public RelegionController(alkafidb2019Context context)
        {
            _context = context;
        }

        // GET: Relegion
        public async Task<IActionResult> Index()
        {
            return View(await _context.RelegionTbls.ToListAsync());
        }

        // GET: Relegion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relegionTbl = await _context.RelegionTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (relegionTbl == null)
            {
                return NotFound();
            }

            return View(relegionTbl);
        }

        // GET: Relegion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Relegion/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Relegion,RelegionEn")] RelegionTbl relegionTbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(relegionTbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(relegionTbl);
        }

        // GET: Relegion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relegionTbl = await _context.RelegionTbls.FindAsync(id);
            if (relegionTbl == null)
            {
                return NotFound();
            }
            return View(relegionTbl);
        }

        // POST: Relegion/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Relegion,RelegionEn")] RelegionTbl relegionTbl)
        {
            if (id != relegionTbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(relegionTbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RelegionTblExists(relegionTbl.Id))
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
            return View(relegionTbl);
        }

        // GET: Relegion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relegionTbl = await _context.RelegionTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (relegionTbl == null)
            {
                return NotFound();
            }

            return View(relegionTbl);
        }

        // POST: Relegion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var relegionTbl = await _context.RelegionTbls.FindAsync(id);
            _context.RelegionTbls.Remove(relegionTbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RelegionTblExists(int id)
        {
            return _context.RelegionTbls.Any(e => e.Id == id);
        }
    }
}
