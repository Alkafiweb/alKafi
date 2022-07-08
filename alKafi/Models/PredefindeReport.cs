using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class PredefindeReport
    {
        public int Id { get; set; }
        public string Visano { get; set; }
        public int RecCount { get; set; }
        public bool IsDefined { get; set; }
        public double Salary { get; set; }
        public int IjazaNum { get; set; }
        public string SevenCond { get; set; }
        public string EightCond { get; set; }
        public DateTime AqedDate { get; set; }
        public string VisaSource { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public string NationalName { get; set; }
        public string Airport { get; set; }
        public string Job { get; set; }
        public string CName { get; set; }
        public string IdNum { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string HomePhone { get; set; }
        public string Pox { get; set; }
        public string Postmail { get; set; }
        public string OtherPhone { get; set; }
        public string Notes { get; set; }
        public string IdPlace { get; set; }
        public byte[] FourteenCond { get; set; }
        public string Relegion { get; set; }
        public DateTime AqedFrom { get; set; }
        public DateTime AqedTo { get; set; }
        public int AqedPeriod { get; set; }
        public double FinalAmount { get; set; }
        public double TotalAmount { get; set; }
        public int? TotalDays { get; set; }
        public string DayName { get; set; }
        public bool IsWakeel { get; set; }
        public string Wakeelname { get; set; }
        public string OfficeName { get; set; }
        public string AqedDateH { get; set; }
        public decimal? TaakherAmount { get; set; }
        public decimal VisaMoney { get; set; }
    }
}
