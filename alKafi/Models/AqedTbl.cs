using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AqedTbl
    {
        public AqedTbl()
        {
            AqedHasemTbls = new HashSet<AqedHasemTbl>();
            AqedMoneys = new HashSet<AqedMoney>();
            AqedNotesTbls = new HashSet<AqedNotesTbl>();
            Arrivals = new HashSet<Arrival>();
            AttachmentTbls = new HashSet<AttachmentTbl>();
            MouqebMoneys = new HashSet<MouqebMoney>();
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public int CustId { get; set; }
        public string Visano { get; set; }
        public DateTime Visadate { get; set; }
        public int RecCount { get; set; }
        public int JobId { get; set; }
        public int NationalityId { get; set; }
        public bool IsDefined { get; set; }
        public double Salary { get; set; }
        public DateTime AqedFrom { get; set; }
        public DateTime AqedTo { get; set; }
        public int IjazaNum { get; set; }
        public double TotalAmount { get; set; }
        public int AirportId { get; set; }
        public string SevenCond { get; set; }
        public string EightCond { get; set; }
        public byte[] FourteenCond { get; set; }
        public bool IsEnd { get; set; }
        public DateTime AqedDate { get; set; }
        public bool IsVip { get; set; }
        public int UserId { get; set; }
        public string VisaSource { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public double MuaqpMoney { get; set; }
        public int MuaqpId { get; set; }
        public int AqedPeriod { get; set; }
        public int ReleginId { get; set; }
        public bool IsReturned { get; set; }
        public bool IsDeleted { get; set; }
        public int? UserDelete { get; set; }
        public DateTime? DateDelete { get; set; }
        public bool IsWakeel { get; set; }
        public string Wakeelname { get; set; }
        public string AqedDateH { get; set; }
        public bool VisaIsOur { get; set; }
        public decimal VisaMoney { get; set; }
        public bool IsPayedForVisa { get; set; }
        public bool IsNone { get; set; }
        public string Idd { get; set; }
        public string Pw { get; set; }
        public string Pt { get; set; }
        public string Dm { get; set; }
        public decimal? TaakherAmount { get; set; }
        public int? OfficerequirmentId { get; set; }
        public bool? IsAqed { get; set; }
        public int? AqedSource { get; set; }
        public bool? IsSpeed { get; set; }
        public decimal? OutsidemouqebMoney { get; set; }
        public int? OutsidemouqebId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CurnceyId { get; set; }
        public int? BillMainId { get; set; }
        public int? BillDeleteId { get; set; }
        public int? BillRecId { get; set; }
        public bool Ckvisa { get; set; }
        public bool Ckarrivel { get; set; }
        public double? DisCountVl { get; set; }
        public bool Ckstat { get; set; }
        public double? ReturnValue { get; set; }
        public decimal? MusanedTotalMoney { get; set; }
        public decimal? MusanedTotalPayed { get; set; }
        public DateTime? MusanedTotalPayedDate { get; set; }
        public decimal? MusanedToOurAccountPayed { get; set; }
        public DateTime? MusanedToOurAccountPayedDate { get; set; }
        public int? WhoPayedToMusaned { get; set; }
        public string AqedStatusInMusaned { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int Taxval { get; set; }
        public bool? SadadType { get; set; }
        public string ChvisaDate { get; set; }
        public int? YearId { get; set; }
        public int? YearIdRet { get; set; }
        public int? ArrivalBillId { get; set; }
        public int? ArrivalYearId { get; set; }
        public int? ArrivalRetBillId { get; set; }
        public int? ArrivalRetYearId { get; set; }
        public bool Ckticket { get; set; }
        public string CkticketDate { get; set; }

        public virtual ICollection<AqedHasemTbl> AqedHasemTbls { get; set; }
        public virtual ICollection<AqedMoney> AqedMoneys { get; set; }
        public virtual ICollection<AqedNotesTbl> AqedNotesTbls { get; set; }
        public virtual ICollection<Arrival> Arrivals { get; set; }
        public virtual ICollection<AttachmentTbl> AttachmentTbls { get; set; }
        public virtual ICollection<MouqebMoney> MouqebMoneys { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
