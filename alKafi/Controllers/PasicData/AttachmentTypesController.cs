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
    public class AttachmentTypesController : Controller
    {
        private readonly alkafidb2019Context _context;

        public AttachmentTypesController(alkafidb2019Context context)
        {
            _context = context;
        }

        // GET: AttachmentTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.AttachmentTypes.ToListAsync());
        }

        // GET: AttachmentTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attachmentType = await _context.AttachmentTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (attachmentType == null)
            {
                return NotFound();
            }

            return View(attachmentType);
        }

        // GET: AttachmentTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AttachmentTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AttcahName")] AttachmentType attachmentType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(attachmentType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(attachmentType);
        }

        // GET: AttachmentTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attachmentType = await _context.AttachmentTypes.FindAsync(id);
            if (attachmentType == null)
            {
                return NotFound();
            }
            return View(attachmentType);
        }

        // POST: AttachmentTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AttcahName")] AttachmentType attachmentType)
        {
            if (id != attachmentType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(attachmentType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AttachmentTypeExists(attachmentType.Id))
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
            return View(attachmentType);
        }

        // GET: AttachmentTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attachmentType = await _context.AttachmentTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (attachmentType == null)
            {
                return NotFound();
            }

            return View(attachmentType);
        }

        // POST: AttachmentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var attachmentType = await _context.AttachmentTypes.FindAsync(id);
            _context.AttachmentTypes.Remove(attachmentType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AttachmentTypeExists(int id)
        {
            return _context.AttachmentTypes.Any(e => e.Id == id);
        }
    }
}
