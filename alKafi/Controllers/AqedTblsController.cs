using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using alKafi.Models;
using alKafi.ViewModels;
using System.Data;
using Microsoft.Extensions.Logging;
using alKafi.PagesControl;

namespace alKafi.Controllers
{
    public class AqedTblsController : Controller
    {
        private readonly alkafidb2019Context _context;
        private readonly ILogger<AqedTblsController> _logger;


        public AqedTblsController(alkafidb2019Context context , ILogger<AqedTblsController> logger)
        {
            _context = context;
            _logger = logger;

        }
        // GET: AqedTbls
        public async Task<IActionResult> Index(int? pageNumber , string? searchString)
        {
            List<Dashboard> mymodel = new List<Dashboard>();
            int pageSize = 10;
            if (pageNumber == null) { pageNumber = 1; }
            if (searchString != null)
            {
                ViewData["CurrentFilter"] = searchString;
                List<CustomerTbl> name = await _context.CustomerTbls.Where(x => x.OwnernameEn.Contains(searchString))
                    .Skip((int)((pageNumber - 1) * pageSize))
                    .Take(pageSize).ToListAsync();
                getPaginginfo(name.Count(), (int)pageNumber , pageSize);
                _logger.LogError(name.Count() + " aaaaaaaaaaaaaaaaaaaaaaaa");
                if (name.Count() == 0)
                    return NotFound();
                foreach (var item in name)
                {
                    _logger.LogError(item.CName);
                    mymodel.Add(await getDataAsync(await _context.AqedTbls.FirstOrDefaultAsync(X => X.CustId == item.Id)));
                }

                return View(mymodel);
            }
            IEnumerable<AqedTbl> aqedTblLis = _context.AqedTbls
                .Skip((int)((pageNumber - 1) * pageSize))
                    .Take(pageSize).ToList();
            getPaginginfo(_context.AqedTbls.ToList().Count(), (int)pageNumber, pageSize);
            foreach (AqedTbl aqedTbl in aqedTblLis)
            {

                mymodel.Add(await getDataAsync(aqedTbl));
            }
            return View(mymodel);
        }

        void getPaginginfo(int TotalPages, int pageNumber ,int pageSize)
        {
            _logger.LogError(TotalPages + " tot  " + pageNumber + " pNam  " + pageSize + " pZis");
            ViewData["Skip"] = (int)((pageNumber - 1) * pageSize) + 1;
            double pageCount = (double)Math.Ceiling(((decimal)TotalPages / Convert.ToDecimal(pageSize)));
            _logger.LogError(pageCount + " pageCount  ");
            if ((int)pageNumber > 5)
            {
                ViewData["HasPreviousPage"] = true;
                _logger.LogError(true + " HasPreviousPage  ");
            }
            else
            {
                ViewData["HasPreviousPage"] = false;
                _logger.LogError(false + " HasPreviousPage  ");
            }
            if ((int)pageNumber + 5 < pageCount)
            {
                ViewData["HasNextPage"] = true;
            }
            else
            {
                ViewData["HasNextPage"] = false;
            }
            ViewData["currentPage"] = pageNumber;
            ViewData["TotalPages"] = TotalPages;

            if ((pageNumber + 5) > pageCount)
            {
                ViewData["ViewPages"] = pageCount + 1;
            }
            else
            {
                ViewData["ViewPages"] = pageNumber + 5;
            }
        }



       async Task<Dashboard> getDataAsync(AqedTbl aqedTbl)
        {
            Dashboard model;

            string sName = "";
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
            return model;
        }

        // GET: AqedTbls/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

           
            var aqedTbl = await _context.AqedTbls
                .FirstOrDefaultAsync(m => m.Id == id);

            if (aqedTbl == null)
            {
                return NotFound();
            }
            var job = GetJob(aqedTbl);
            var nationality = GetNationality(aqedTbl);
            var recuriment = GetRecruitmenter(aqedTbl);
            var officeTbl = GetOffice(aqedTbl);
            var notes = GetNotes(aqedTbl);
            var status = GetStatus(recuriment);
            var statusName = GetStatusName(status);
            var customer = GetCustomer(aqedTbl);
            var airport = GetAirport(aqedTbl);
            var relegion = GetRelegion(aqedTbl);
            var source = GetSource(aqedTbl);
            var costC = GetCostCenter(aqedTbl);
            var Curncey = GetCurrency(aqedTbl);
            var Mouqeb = GetMuaqep(aqedTbl);
            ViewBag.job = job != null ? job.Job : "";
            ViewBag.nationality = nationality != null ? nationality.NationalNameEn : "";
            ViewBag.recE = recuriment != null ? recuriment.RecName : "";
            ViewBag.recA = recuriment != null ? recuriment.RecNameAr : "";
            ViewBag.office = officeTbl != null ? officeTbl.OfficeName : "";
            ViewBag.source = source != null ? source.OfficeSource : "";
            ViewBag.costCenter = costC != null ? costC.CostCenterNameEn : "";
            ViewBag.Curncey = Curncey != null ? Curncey.CunameEn : "";
            ViewBag.Mouqeb = Mouqeb != null ? Mouqeb.MuaqebName : "";
            ViewBag.statusName = statusName != null ? statusName.SNameEn : "";
            ViewBag.cName = customer != null ? customer.OwnernameEn : "";
            ViewBag.airport = airport != null ? airport.AirportEn : "";
            ViewBag.relegion = relegion != null ? relegion.RelegionEn : "";
            return View(aqedTbl);
        }
        
        // GET: AqedTbls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AqedTbls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustId,Visano,Visadate,RecCount,JobId,NationalityId,IsDefined,Salary,AqedFrom,AqedTo,IjazaNum,TotalAmount,AirportId,SevenCond,EightCond,FourteenCond,IsEnd,AqedDate,IsVip,UserId,VisaSource,AgeFrom,AgeTo,MuaqpMoney,MuaqpId,AqedPeriod,ReleginId,IsReturned,IsDeleted,UserDelete,DateDelete,IsWakeel,Wakeelname,AqedDateH,VisaIsOur,VisaMoney,IsPayedForVisa,IsNone,Idd,Pw,Pt,Dm,TaakherAmount,OfficerequirmentId,IsAqed,AqedSource,IsSpeed,OutsidemouqebMoney,OutsidemouqebId,CostCenterId,CurnceyId,BillMainId,BillDeleteId,BillRecId,Ckvisa,Ckarrivel,DisCountVl,Ckstat,ReturnValue,MusanedTotalMoney,MusanedTotalPayed,MusanedTotalPayedDate,MusanedToOurAccountPayed,MusanedToOurAccountPayedDate,WhoPayedToMusaned,AqedStatusInMusaned,ReturnDate,Taxval,SadadType,ChvisaDate,YearId,YearIdRet,ArrivalBillId,ArrivalYearId,ArrivalRetBillId,ArrivalRetYearId,Ckticket,CkticketDate")] AqedTbl aqedTbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aqedTbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aqedTbl);
        }

        // GET: AqedTbls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aqedTbl = await _context.AqedTbls.FindAsync(id);
            
            if (aqedTbl == null)
            {
                return NotFound();
            }

            ViewData["JobId"] = new SelectList(_context.JobTbls, "Id", "JobEn", aqedTbl.JobId);
            ViewData["OfficeId"] = new SelectList(_context.OfficeTbls, "Id", "OfficeName", aqedTbl.OfficerequirmentId);
            ViewData["ReleginId"] = new SelectList(_context.RelegionTbls, "Id", "RelegionEn", aqedTbl.ReleginId);
            ViewData["NationalityId"] = new SelectList(_context.NationalityTbls, "Id", "NationalNameEn", aqedTbl.NationalityId);
            ViewData["AirportId"] = new SelectList(_context.AirportTbls, "Id", "AirportEn", aqedTbl.AirportId);
            ViewData["AqedSource"] = new SelectList(_context.AqedSourceTbls, "Id", "OfficeSource", aqedTbl.AqedSource);
            ViewData["YearId"] = new SelectList(_context.Years, "Id", "YearName", aqedTbl.YearId);
            ViewData["CostCenterId"] = new SelectList(_context.TblcostCenters, "Id", "CostCenterNameEn", aqedTbl.CostCenterId);
            ViewData["CurnceyId"] = new SelectList(_context.Tblcurrnceys, "Crid", "CunameEn", aqedTbl.CurnceyId);
            ViewData["MuaqpId"] = new SelectList(_context.Muaqebs, "MoaccId", "MuaqebName", aqedTbl.MuaqpId);
            ViewBag.custName = GetCustomer(aqedTbl) != null ? GetCustomer(aqedTbl).OwnernameEn : "";
            return View(aqedTbl);
        }

       

        // POST: AqedTbls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, 
            [Bind("Id,CustId,Visano,Visadate,RecCount,JobId,NationalityId,IsDefined,Salary,AqedFrom,AqedTo,IjazaNum," +
            "TotalAmount,AirportId,SevenCond,EightCond,FourteenCond,IsEnd,AqedDate,IsVip,UserId,VisaSource,AgeFrom,AgeTo," +
            "MuaqpMoney,MuaqpId,AqedPeriod,ReleginId,IsReturned,IsDeleted,UserDelete,DateDelete,IsWakeel,Wakeelname," +
            "AqedDateH,VisaIsOur,VisaMoney,IsPayedForVisa,IsNone,Idd,Pw,Pt,Dm,TaakherAmount,OfficerequirmentId,IsAqed," +
            "AqedSource,IsSpeed,OutsidemouqebMoney,OutsidemouqebId,CostCenterId,CurnceyId,BillMainId,BillDeleteId,BillRecId" +
            ",Ckvisa,Ckarrivel,DisCountVl,Ckstat,ReturnValue,MusanedTotalMoney,MusanedTotalPayed,MusanedTotalPayedDate," +
            "MusanedToOurAccountPayed,MusanedToOurAccountPayedDate,WhoPayedToMusaned,AqedStatusInMusaned,ReturnDate,Taxval" +
            ",SadadType,ChvisaDate,YearId,YearIdRet,ArrivalBillId,ArrivalYearId,ArrivalRetBillId,ArrivalRetYearId,Ckticket" +
            ",CkticketDate")] AqedTbl aqedTbl)
        {

            if (id != aqedTbl.Id)
            {
                return NotFound();
            }
            
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aqedTbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                    if (!AqedTblExists(aqedTbl.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index) , "Home");
            }
            return View(aqedTbl);
        }

        // GET: AqedTbls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aqedTbl = await _context.AqedTbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aqedTbl == null)
            {
                return NotFound();
            }

            return View(aqedTbl);
        }

        // POST: AqedTbls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aqedTbl = await _context.AqedTbls.FindAsync(id);
            _context.AqedTbls.Remove(aqedTbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AqedTblExists(int id)
        {
            return _context.AqedTbls.Any(e => e.Id == id);
        }
        
        private  CustomerTbl GetCustomer(AqedTbl aqedTbl)
        {
            if (aqedTbl?.CustId != null || aqedTbl?.CustId != 0 )
                return _context.CustomerTbls.FirstOrDefault(x => x.Id == aqedTbl.CustId);
            else
                return null;
             
        }
        private  JobTbl GetJob(AqedTbl aqedTbl)
        {
            if (aqedTbl?.JobId != null || aqedTbl?.JobId != 0)
                return _context.JobTbls.FirstOrDefault(x => x.Id == aqedTbl.JobId);
            else
                return null;
        }
        private  NationalityTbl GetNationality(AqedTbl aqedTbl)
        {
            if(aqedTbl?.NationalityId != null || aqedTbl?.NationalityId != 0)
                return _context.NationalityTbls.FirstOrDefault(x => x.Id == aqedTbl.NationalityId);
            else
                return null;

        }
        private  RecruitmenterTbl GetRecruitmenter(AqedTbl aqedTbl)
        {
            if (_context.RecruitmenterTbls.Any(e => e.AqedId == aqedTbl.Id))
                return _context.RecruitmenterTbls.FirstOrDefault(x => x.AqedId == aqedTbl.Id);
            else
                return null;


        }
        private OfficeTbl GetOffice(AqedTbl aqedTbl)
        {
            if (!_context.OfficeTbls.Any(e => e.Id == aqedTbl.OfficerequirmentId))
                return null;
            else
                return _context.OfficeTbls.FirstOrDefault(x => x.Id == aqedTbl.OfficerequirmentId);
        }
        private  AqedNotesTbl GetNotes(AqedTbl aqedTbl)
        {
            if (_context.AqedNotesTbls.Any(e => e.AqedId == aqedTbl.Id))
                return _context.AqedNotesTbls.FirstOrDefault(x => x.AqedId == aqedTbl.Id);
            else
                return null;
        }
        private  StatusTbl GetStatus(RecruitmenterTbl recuriment)
        {
            if ( recuriment?.Id != null)
                return _context.StatusTbls.OrderByDescending(x => x.DoneDate).FirstOrDefault(x => x.RecId == recuriment.Id);
            else
                return null;
        }
        private  StatusNameTbl GetStatusName(StatusTbl status)
        {
            if (status?.StatusId != null)
                return _context.StatusNameTbls.FirstOrDefault(x => x.Id == status.StatusId);
            else
                return null;

        }
        private  AirportTbl GetAirport(AqedTbl aqedTbl)
        {
            if (aqedTbl?.AirportId != null || aqedTbl?.AirportId != 0)
                return _context.AirportTbls.FirstOrDefault(x => x.Id == aqedTbl.AirportId);
            else
                return null;
        }
        private  RelegionTbl GetRelegion(AqedTbl aqedTbl)
        {
            if (aqedTbl?.ReleginId != null || aqedTbl?.ReleginId != 0)
                return _context.RelegionTbls.FirstOrDefault(x => x.Id == aqedTbl.ReleginId);
            else
                return null;
        }
        private  AqedSourceTbl GetSource(AqedTbl aqedTbl)
        {
            if (aqedTbl?.AqedSource != null || aqedTbl?.AqedSource != 0)
                return _context.AqedSourceTbls.FirstOrDefault(x => x.Id == aqedTbl.AqedSource);
            else
                return null;
        }
        private  Year GetYear(AqedTbl aqedTbl)
        {
            if (aqedTbl?.YearId != null || aqedTbl?.YearId != 0)
                return _context.Years.FirstOrDefault(x => x.Id == aqedTbl.YearId && x.IsActive == true);
            else
                return null;
        }
        private  TblcostCenter GetCostCenter(AqedTbl aqedTbl)
        {
            if (aqedTbl?.CostCenterId != null || aqedTbl?.CostCenterId != 0)
                return _context.TblcostCenters.FirstOrDefault(x => x.Id == aqedTbl.CostCenterId);
            else
                return null;
        }
        private  Tblcurrncey GetCurrency(AqedTbl aqedTbl)
        {
            if ( aqedTbl?.CurnceyId != null || aqedTbl?.CurnceyId != 0)
                return _context.Tblcurrnceys.FirstOrDefault(x => x.Crid == aqedTbl.CurnceyId);
            else
                return null;
        }
        private  Muaqeb GetMuaqep(AqedTbl aqedTbl)
        {
            if (aqedTbl?.MuaqpId != null || aqedTbl?.MuaqpId != 0)
                return _context.Muaqebs.FirstOrDefault(x => x.MuaqebId == aqedTbl.MuaqpId);
            else
                return null;
        }
    }
}
