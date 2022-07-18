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
    public class HRPoolController : Controller
    {
        private readonly alkafidb2019Context _context;

        public HRPoolController(alkafidb2019Context context)
        {
            _context = context;
        }

        // GET: HRPool
        public async Task<IActionResult> Index()
        {
            var alkafidb2019Context = _context.RecruitmenterTbls.Include(r => r.Job).Include(r => r.Nationality).Include(r => r.OfficeTblNavigation).Include(r => r.Relegion);
            RecruitmenterViewModel model = new RecruitmenterViewModel(await alkafidb2019Context.Take(5).ToListAsync<RecruitmenterTbl>(), null, "");

            ViewData["JobId"] = new SelectList(_context.JobTbls, "Id", "Job");
            ViewData["NationalityId"] = new SelectList(_context.NationalityTbls, "Id", "CountryName");
            ViewData["OfficeTbl"] = new SelectList(_context.OfficeTbls, "Id", "OfficeName");
            ViewData["RelegionId"] = new SelectList(_context.RelegionTbls, "Id", "Relegion");

            return View(model);
        }

        // GET: HRPool/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recruitmenterTbl = await _context.RecruitmenterTbls
                .Include(r => r.Job)
                .Include(r => r.Nationality)
                .Include(r => r.OfficeTblNavigation)
                .Include(r => r.Relegion)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recruitmenterTbl == null)
            {
                return NotFound();
            }
            ViewData["JobId"] = new SelectList(_context.JobTbls, "Id", "Job");
            ViewData["NationalityId"] = new SelectList(_context.NationalityTbls, "Id", "CountryName");
            ViewData["OfficeTbl"] = new SelectList(_context.OfficeTbls, "Id", "OfficeName");
            ViewData["RelegionId"] = new SelectList(_context.RelegionTbls, "Id", "Relegion");

            return PartialView(recruitmenterTbl);
        }

        // GET: HRPool/AllDetails/5
        public async Task<IActionResult> AllDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recruitmenterTbl = await _context.RecruitmenterTbls
                .Include(r => r.Job)
                .Include(r => r.Nationality)
                .Include(r => r.OfficeTblNavigation)
                .Include(r => r.Relegion)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recruitmenterTbl == null)
            {
                return NotFound();
            }
            ViewData["JobId"] = new SelectList(_context.JobTbls, "Id", "Job");
            ViewData["NationalityId"] = new SelectList(_context.NationalityTbls, "Id", "CountryName");
            ViewData["OfficeTbl"] = new SelectList(_context.OfficeTbls, "Id", "OfficeName");
            ViewData["RelegionId"] = new SelectList(_context.RelegionTbls, "Id", "Relegion");

            return PartialView(recruitmenterTbl);
        }


        // GET: HRPool/Create
        public IActionResult Create()
        {
            ViewData["JobId"] = new SelectList(_context.JobTbls, "Id", "Job");
            ViewData["NationalityId"] = new SelectList(_context.NationalityTbls, "Id", "CountryName");
            ViewData["OfficeTbl"] = new SelectList(_context.OfficeTbls, "Id", "OfficeName");
            ViewData["RelegionId"] = new SelectList(_context.RelegionTbls, "Id", "Relegion");
            return View();
        }

        // POST: HRPool/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(  [Bind("Id,NationalityId,RelegionId,Age,HasExper,OfficeTbl,IsChoosed,RecName,RecMobiile,CvFileName,IsDef,AqedId,SendDate,OfficePrice,Address,Passportno,Passportsdate,Passportplace,Passportedate,Nameofaqareb,Phone,RecStatusAr,RecStatusEn,TransmitId,Cvno,RecNotes,BanknameAr,BanknameEn,Bankaccount,BankaddressAr,BankaddressEn,RecNameAr,PassportplaceAr,NameofaqarebAr,AqarebselaAr,AqarebselaEn,AqarebAddress,AqarebAddressAr,RecAddressAr,JobId,PriceUs,SelectedDate,IsOffical,IsReplace,IsReturn,IsBlacklist,Personouside,Personcode,Education,University,Courses,Rsa1,Rsa2,Rsa3,Rsa4,Rsa5,Rsa6,Rsa7,Interview1,Interview11,Interview12,Interview13,Interview14,Interview15,Interview16,Interview17,Interview18,Strimg,WedCk,WebShow")] RecruitmenterTbl recruitmenterTbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recruitmenterTbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["JobId"] = new SelectList(_context.JobTbls, "Id", "Job", recruitmenterTbl.JobId);
            //ViewData["NationalityId"] = new SelectList(_context.NationalityTbls, "Id", "CountryName", recruitmenterTbl.NationalityId);
            //ViewData["OfficeTbl"] = new SelectList(_context.OfficeTbls, "Id", "OfficeName", recruitmenterTbl.OfficeTbl);
            //ViewData["RelegionId"] = new SelectList(_context.RelegionTbls, "Id", "Relegion", recruitmenterTbl.RelegionId);
            return View("Index",recruitmenterTbl);
        }

        // GET: HRPool/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recruitmenterTbl = await _context.RecruitmenterTbls.FindAsync(id);
            if (recruitmenterTbl == null)
            {
                return NotFound();
            }
            ViewData["JobId"] = new SelectList(_context.JobTbls, "Id", "Job", recruitmenterTbl.JobId);
            ViewData["NationalityId"] = new SelectList(_context.NationalityTbls, "Id", "CountryName", recruitmenterTbl.NationalityId);
            ViewData["OfficeTbl"] = new SelectList(_context.OfficeTbls, "Id", "OfficeName", recruitmenterTbl.OfficeTbl);
            ViewData["RelegionId"] = new SelectList(_context.RelegionTbls, "Id", "Relegion", recruitmenterTbl.RelegionId);
            return PartialView(recruitmenterTbl);
        }



        // GET: HRPool/EditAllDetails/5
        public async Task<IActionResult> EditAllDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recruitmenterTbl = await _context.RecruitmenterTbls.FindAsync(id);
            if (recruitmenterTbl == null)
            {
                return NotFound();
            }
            ViewData["JobId"] = new SelectList(_context.JobTbls, "Id", "Job", recruitmenterTbl.JobId);
            ViewData["NationalityId"] = new SelectList(_context.NationalityTbls, "Id", "CountryName", recruitmenterTbl.NationalityId);
            ViewData["OfficeTbl"] = new SelectList(_context.OfficeTbls, "Id", "OfficeName", recruitmenterTbl.OfficeTbl);
            ViewData["RelegionId"] = new SelectList(_context.RelegionTbls, "Id", "Relegion", recruitmenterTbl.RelegionId);
            return PartialView(recruitmenterTbl);
        }


        // POST: HRPool/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NationalityId,RelegionId,Age,HasExper,OfficeTbl,RecName,IsDef,Passportno,,Cvno,JobId,WedCk,WebShow")] RecruitmenterTbl recruitmenterTbl)
        {
            if (id != recruitmenterTbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recruitmenterTbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecruitmenterTblExists(recruitmenterTbl.Id))
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

           return View(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAllDetails(int id, [Bind("Id,Age,IsChoosed,RecName,RecMobiile,,IsDef,AqedId," +
            "Address,Passportno,Passportsdate,Passportplace,Passportedate,Nameofaqareb,Phone,RecStatusAr,RecStatusEn," +
            "RecNotes,BanknameAr,BanknameEn,Bankaccount,RecNameAr,PassportplaceAr,NameofaqarebAr," +
            "AqarebselaAr,AqarebselaEn,AqarebAddress,AqarebAddressAr,RecAddressAr,IsOffical,IsReplace,IsReturn," +
            "IsBlacklist")] RecruitmenterTbl recruitmenterTbl)
        {
              

            if (id != recruitmenterTbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recruitmenterTbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecruitmenterTblExists(recruitmenterTbl.Id))
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
          return View(nameof(Index));
        }

        // GET: HRPool/Edit/5
        public async Task<IActionResult> Evaluate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recruitmenterTbl = await _context.RecruitmenterTbls.FindAsync(id);
            if (recruitmenterTbl == null)
            {
                return NotFound();
            }

            return PartialView(recruitmenterTbl);
        }


            // GET: HRPool/Delete/5
            public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recruitmenterTbl = await _context.RecruitmenterTbls
                .Include(r => r.Job)
                .Include(r => r.Nationality)
                .Include(r => r.OfficeTblNavigation)
                .Include(r => r.Relegion)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recruitmenterTbl == null)
            {
                return NotFound();
            }

            return View(recruitmenterTbl);
        }

        // POST: HRPool/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recruitmenterTbl = await _context.RecruitmenterTbls.FindAsync(id);
            _context.RecruitmenterTbls.Remove(recruitmenterTbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecruitmenterTblExists(int id)
        {
            return _context.RecruitmenterTbls.Any(e => e.Id == id);
        }


       
    }
}
