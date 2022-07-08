using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AqedStautsVw
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string Visano { get; set; }
        public double TotalAmount { get; set; }
        public int Status { get; set; }
        public int? FromBegin { get; set; }
        public int? ToEnd { get; set; }
        public int? TotalPeriod { get; set; }
        public decimal Paymentmony { get; set; }
        public decimal Aqedmoney { get; set; }
        public decimal Mouqebmoney { get; set; }
        public DateTime AqedDate { get; set; }
        public bool IsVip { get; set; }
        public bool IsEnd { get; set; }
        public int? Numrec { get; set; }
        public int? RecRes { get; set; }
        public DateTime AqedFrom { get; set; }
        public DateTime AqedTo { get; set; }
        public string Phone { get; set; }
        public bool IsNone { get; set; }
        public int NationalityId { get; set; }
        public string Officesend { get; set; }
        public string Officename { get; set; }
        public string IdNum { get; set; }
        public string NationalName { get; set; }
    }
}
