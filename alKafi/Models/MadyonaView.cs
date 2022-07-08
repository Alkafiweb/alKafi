using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class MadyonaView
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string Visano { get; set; }
        public double? TotalAmount { get; set; }
        public decimal Paymentmony { get; set; }
        public double? RemainBalance { get; set; }
        public DateTime AqedDate { get; set; }
        public string NationalName { get; set; }
        public bool IsEnd { get; set; }
        public int? AqedSource { get; set; }
        public bool IsPayedForVisa { get; set; }
        public bool VisaIsOur { get; set; }
        public bool IsNone { get; set; }
        public bool IsAqed { get; set; }
        public bool? IsSpeed { get; set; }
        public bool IsDefined { get; set; }
        public bool IsVip { get; set; }
        public bool IsReturned { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }
        public DateTime? Lastpaymentdate { get; set; }
        public string LastStatus { get; set; }
        public string Mouqeb { get; set; }
    }
}
