using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AccountsView
    {
        public int AcountId { get; set; }
        public string AcountName { get; set; }
        public int? MainId { get; set; }
        public string MainName { get; set; }
        public int? Endid { get; set; }
        public string Endname { get; set; }
        public bool? AcountType { get; set; }
        public string AccountCode { get; set; }
        public double? AcountDebit { get; set; }
        public double? AcountCredet { get; set; }
        public double? AcountTotal { get; set; }
        public bool? AcountDelete { get; set; }
        public int? AccountLevel { get; set; }
        public bool? AccountMd { get; set; }
    }
}
