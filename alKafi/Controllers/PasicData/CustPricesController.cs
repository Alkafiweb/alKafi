using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using alKafi.Models;
using alKafi.ViewModels;
using Microsoft.Extensions.Logging;

namespace alKafi.Controllers.PasicData
{
    public class CustPricesController : Controller
    {
        private readonly alkafidb2019Context _context;
        private readonly ILogger<CustPricesController>  _logger;

        public CustPricesController(alkafidb2019Context context , ILogger<CustPricesController> logger)
        {
            _logger = logger;
            _context = context;
        }

        // GET: CustPrices
        public async Task<IActionResult> Index()
        {
           
            return View(GetAllData());
        }

        // GET: CustPrices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            custPriceViewModel custPriceViewModel = GetItem(id);
            if (custPriceViewModel == null)
            {
                return NotFound();
            }

            return View(custPriceViewModel);
        }

        // GET: CustPrices/Create
        public IActionResult Create()
        {
            ViewData["JobList"] = new SelectList(_context.JobTbls, "Id", "JobEn");
            ViewData["ReleginList"] = new SelectList(_context.RelegionTbls, "Id", "RelegionEn");
            ViewData["Nationality"] = new SelectList(_context.NationalityTbls, "Id", "NationalNameEn");
            return View();
        }

        // POST: CustPrices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NatId,JobId,RelejonId,Price,Visaprice")] CustPricesTbl custPricesTbl)
        {
            if (ModelState.IsValid)
            {
               _context.Add(custPricesTbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(custPricesTbl);
        }

        // GET: CustPrices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var custPricesTbl = await _context.CustPricesTbls.FindAsync(id);
            if (custPricesTbl == null)
            {
                return NotFound();
            }
            ViewData["JobList"] = new SelectList(_context.JobTbls, "Id", "JobEn");
            ViewData["RelejonList"] = new SelectList(_context.RelegionTbls, "Id", "RelegionEn");
            ViewData["Nationality"] = new SelectList(_context.NationalityTbls, "Id", "NationalNameEn");


            return View(custPricesTbl);
        }

        // POST: CustPrices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id ,NatId,JobId,RelejonId,Price,Visaprice")] CustPricesTbl custPricesTbl)
        {

            if (id != custPricesTbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustPricesTblExists(custPricesTbl.Id))
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
            return View(custPricesTbl);
        }

        // GET: CustPrices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custPricesTbl = await _context.CustPricesTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (custPricesTbl == null)
            {
                return NotFound();
            }

            return View(custPricesTbl);
        }

        // POST: CustPrices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var custPricesTbl = await _context.CustPricesTbls.FindAsync(id);
            _context.CustPricesTbls.Remove(custPricesTbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustPricesTblExists(int id)
        {
            return _context.CustPricesTbls.Any(e => e.Id == id);
        }

        private List<custPriceViewModel> GetAllData()
        {
            List<custPriceViewModel> custPrice = new List<custPriceViewModel>();
            foreach (CustPricesTbl custP in _context.CustPricesTbls.ToList())
            {
                var nat = _context.NationalityTbls.FirstOrDefault(x => x.Id == custP.NatId);
                var rel = _context.RelegionTbls.FirstOrDefault(x => x.Id == custP.RelejonId);
                var job = _context.JobTbls.FirstOrDefault(x => x.Id == custP.JobId);
                custPrice.Add( new custPriceViewModel(custP.Id, nat.Id, job.Id, rel.Id, nat.NationalNameEn
               , job.JobEn, rel.RelegionEn, custP.Price, custP.Visaprice));

            }
            return custPrice;
        }
        
        private custPriceViewModel GetItem( int? id)
        {
            if(id == null) { return null; }
            CustPricesTbl custP = _context.CustPricesTbls.FirstOrDefault(x => x.Id == id);
            var nat = _context.NationalityTbls.FirstOrDefault(x => x.Id == custP.NatId);
            var rel = _context.RelegionTbls.FirstOrDefault(x => x.Id == custP.RelejonId);
            var job = _context.JobTbls.FirstOrDefault(x => x.Id == custP.JobId);  
            custPriceViewModel custPrice = new custPriceViewModel(custP.Id, nat.Id, job.Id , rel.Id, nat.NationalNameEn,job.JobEn,
                rel.RelegionEn ,custP.Price , custP.Visaprice );
            return custPrice;
        }
    }
}
