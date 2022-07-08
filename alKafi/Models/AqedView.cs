using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AqedView
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string Visano { get; set; }
        public double? TotalAmount { get; set; }
        public decimal Paymentmony { get; set; }
        public decimal Aqedmoney { get; set; }
        public decimal Mouqebmoney { get; set; }
        public int UserId { get; set; }
        public DateTime AqedDate { get; set; }
        public bool IsVip { get; set; }
        public bool IsEnd { get; set; }
        public decimal? TotalOffice { get; set; }
        public decimal? Finalrbh { get; set; }
        public int? Numrec { get; set; }
        public int? RecRes { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsReturned { get; set; }
        public int NationalityId { get; set; }
        public bool Isdel { get; set; }
        public bool IsPayedForVisa { get; set; }
        public bool IsNone { get; set; }
        public bool? IsSpeed { get; set; }
        public bool IsDefined { get; set; }
        public int? AqedSource { get; set; }
    }
}
