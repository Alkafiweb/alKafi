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
    public class OfficeController : Controller
    {
        private readonly alkafidb2019Context _context;

        public OfficeController(alkafidb2019Context context)
        {
            _context = context;
        }

        // GET: Office
        public async Task<IActionResult> Index()
        {
            return View(await _context.OfficeTbls.ToListAsync());
        }

        // GET: Office/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officeTbl = await _context.OfficeTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (officeTbl == null)
            {
                return NotFound();
            }

            return View(officeTbl);
        }

        // GET: Office/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Office/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OfficeName,IsBlacklist,OfficeAddress,OfficeDist,OfficeStreat,OfficePhones,OfficeNote,Trkhees,Email,OfficeNameAr,OfficeAddressAr,OfficeDistAr,OfficeStreatAr,Aqentname,OfaccId")] OfficeTbl officeTbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(officeTbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(officeTbl);
        }

        // GET: Office/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officeTbl = await _context.OfficeTbls.FindAsync(id);
            if (officeTbl == null)
            {
                return NotFound();
            }
            return View(officeTbl);
        }

        // POST: Office/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OfficeName,IsBlacklist,OfficeAddress,OfficeDist,OfficeStreat,OfficePhones,OfficeNote,Trkhees,Email,OfficeNameAr,OfficeAddressAr,OfficeDistAr,OfficeStreatAr,Aqentname,OfaccId")] OfficeTbl officeTbl)
        {
            if (id != officeTbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(officeTbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OfficeTblExists(officeTbl.Id))
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
            return View(officeTbl);
        }

        // GET: Office/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officeTbl = await _context.OfficeTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (officeTbl == null)
            {
                return NotFound();
            }

            return View(officeTbl);
        }

        // POST: Office/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var officeTbl = await _context.OfficeTbls.FindAsync(id);
            _context.OfficeTbls.Remove(officeTbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OfficeTblExists(int id)
        {
            return _context.OfficeTbls.Any(e => e.Id == id);
        }
    }
}
