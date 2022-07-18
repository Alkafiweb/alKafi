using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using alKafi.Models;

namespace alKafi.Controllers
{
    public class CustomerTblsController : Controller
    {
        private readonly alkafidb2019Context _context;

        public CustomerTblsController(alkafidb2019Context context)
        {
            _context = context;
        }

        // GET: CustomerTbls
        public async Task<IActionResult> Index()
        {
            return View(await _context.CustomerTbls.ToListAsync());
        }

        // GET: CustomerTbls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerTbl = await _context.CustomerTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerTbl == null)
            {
                return NotFound();
            }

            return View(customerTbl);
        }

        // GET: CustomerTbls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerTbls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CName,IdNum,Nationality,Phone,HomePhone,Pox,Postmail,OtherPhone,Notes,IdPlace,IsBlacklist,OwnerAddressAr,OwnerAddressEn,OwnerStreetAr,OwnerStreetEn,OwnerReginAr,OwnerReginEn,OwnerMadinaAr,OwnerMadinaEn,OwnerStatusAr,OwnerStatusEn,OwnerChildNum,OwnernameEn,OwnerAge,Custnote,Email,IdCN,BulldingNo,IdExpdate,IdPlaceOfIssued,IdPlaceOfBirthdate,IdDateofbirth,FiilingNo,FillingPlace,IdDated,KidsNum,SakanType,Issickpeople,Isoldpeoplr,Visanum,CusJop,CusOld,CusWifeOld,CusSonOld,CusAccId")] CustomerTbl customerTbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerTbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customerTbl);
        }

        // GET: CustomerTbls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerTbl = await _context.CustomerTbls.FindAsync(id);
            if (customerTbl == null)
            {
                return NotFound();
            }
            return View(customerTbl);
        }

        // POST: CustomerTbls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CName,IdNum,Nationality,Phone,HomePhone,Pox,Postmail,OtherPhone,Notes,IdPlace,IsBlacklist,OwnerAddressAr,OwnerAddressEn,OwnerStreetAr,OwnerStreetEn,OwnerReginAr,OwnerReginEn,OwnerMadinaAr,OwnerMadinaEn,OwnerStatusAr,OwnerStatusEn,OwnerChildNum,OwnernameEn,OwnerAge,Custnote,Email,IdCN,BulldingNo,IdExpdate,IdPlaceOfIssued,IdPlaceOfBirthdate,IdDateofbirth,FiilingNo,FillingPlace,IdDated,KidsNum,SakanType,Issickpeople,Isoldpeoplr,Visanum,CusJop,CusOld,CusWifeOld,CusSonOld,CusAccId")] CustomerTbl customerTbl)
        {
            if (id != customerTbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerTbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerTblExists(customerTbl.Id))
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
            return View(customerTbl);
        }

        // GET: CustomerTbls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerTbl = await _context.CustomerTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerTbl == null)
            {
                return NotFound();
            }

            return View(customerTbl);
        }

        // POST: CustomerTbls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerTbl = await _context.CustomerTbls.FindAsync(id);
            _context.CustomerTbls.Remove(customerTbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerTblExists(int id)
        {
            return _context.CustomerTbls.Any(e => e.Id == id);
        }
    }
}
