using alKafi.Models;
using alKafi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace alKafi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly alkafidb2019Context _context;


        public HomeController(ILogger<HomeController> logger , alkafidb2019Context context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<Dashboard> mymodel = new List<Dashboard>();
            Dashboard model;
            IEnumerable<AqedTbl> aqedTblLis = _context.AqedTbls.OrderByDescending(x => x.AqedDate).Take(3);
                //.Where(x => x.IsDeleted == false).Take(3); if the data is normal

            var sName = "";

            foreach (AqedTbl aqedTbl in aqedTblLis) {

                
                 var customer = await _context.CustomerTbls.FirstOrDefaultAsync(x => x.Id == aqedTbl.CustId);
                var job = await _context.JobTbls.FirstOrDefaultAsync(x => x.Id == aqedTbl.JobId);
                var nationality = await _context.NationalityTbls.FirstOrDefaultAsync(x => x.Id == aqedTbl.NationalityId);
                
                var officeTbl = await _context.OfficeTbls.FirstOrDefaultAsync(x => x.Id == aqedTbl.OfficerequirmentId);
                var payment = await _context.Payments.FirstOrDefaultAsync(x => x.AqedId == aqedTbl.Id);
                var notes = await _context.AqedNotesTbls.FirstOrDefaultAsync(x => x.AqedId == aqedTbl.Id);
                var recuriment = await _context.RecruitmenterTbls.FirstOrDefaultAsync(x => x.AqedId == aqedTbl.Id);
                if (recuriment != null)
                {
                    var status = await _context.StatusTbls.OrderByDescending(x => x.DoneDate).FirstOrDefaultAsync(x => x.RecId == recuriment.Id);
                    if (status != null)
                    {
                        var statusName = await _context.StatusNameTbls.FirstOrDefaultAsync(x => x.Id == status.StatusId);
                        sName = statusName.SNameEn;
                    }
                    else
                    {
                        sName = "NOT SET YET.";
                    }
                }
                else
                {
                    sName = "NOT SET YET.";
                }
                model = new Dashboard();
                model.aqedTbl = aqedTbl;
                model.customerTbl = customer;
                model.jobTbl = job;
                model.nationalityTbl = nationality;
                model.officeTbl = officeTbl;
                model.payment = payment;
                model.recruitmenterTbl = recuriment;
                model.notesTbl = notes;
                model.statusNames = sName;
                mymodel.Add(model);
            }
            ViewBag.data = mymodel;
            if (mymodel == null)
            {
                return NotFound();
            }
            return View(mymodel);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            AqedNotesTbl note = _context.AqedNotesTbls.OrderByDescending(x => x.NoteDate).FirstOrDefault(x => x.AqedId == id);
            return PartialView("Details", note);
        }




        // GET: AqedTbls/GetLast

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
