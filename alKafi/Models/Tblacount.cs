using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Tblacount
    {
        public int AcountId { get; set; }
        public string AcountName { get; set; }
        public string AccountCode { get; set; }
        public int? AcountMain { get; set; }
        public int? AcountEnd { get; set; }
        public bool? AcountType { get; set; }
        public int? AccountLevel { get; set; }
        public bool? AccountMd { get; set; }
        public double? AcountDebit { get; set; }
        public double? AcountCredet { get; set; }
        public double? AcountTotal { get; set; }
        public bool? AcountDelete { get; set; }
        public int? Lev1 { get; set; }
        public int? Lev2 { get; set; }
        public int? Lev3 { get; set; }
        public int? Lev4 { get; set; }
        public int? Lev5 { get; set; }
    }
}
