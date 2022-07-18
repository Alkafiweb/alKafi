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
    public class AirportTblsController : Controller
    {
        private readonly alkafidb2019Context _context;

        public AirportTblsController(alkafidb2019Context context)
        {
            _context = context;
        }

        // GET: AirportTbls
        public async Task<IActionResult> Index()
        {
            return View(await _context.AirportTbls.ToListAsync());
        }

        // GET: AirportTbls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airportTbl = await _context.AirportTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (airportTbl == null)
            {
                return NotFound();
            }

            return View(airportTbl);
        }

        // GET: AirportTbls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AirportTbls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Airport,AirportEn")] AirportTbl airportTbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(airportTbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(airportTbl);
        }

        // GET: AirportTbls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airportTbl = await _context.AirportTbls.FindAsync(id);
            if (airportTbl == null)
            {
                return NotFound();
            }
            return View(airportTbl);
        }

        // POST: AirportTbls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Airport,AirportEn")] AirportTbl airportTbl)
        {
            if (id != airportTbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(airportTbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AirportTblExists(airportTbl.Id))
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
            return View(airportTbl);
        }

        // GET: AirportTbls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airportTbl = await _context.AirportTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (airportTbl == null)
            {
                return NotFound();
            }

            return View(airportTbl);
        }

        // POST: AirportTbls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var airportTbl = await _context.AirportTbls.FindAsync(id);
            _context.AirportTbls.Remove(airportTbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AirportTblExists(int id)
        {
            return _context.AirportTbls.Any(e => e.Id == id);
        }
    }
}
