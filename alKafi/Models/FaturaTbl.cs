using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class FaturaTbl
    {
        public int FId { get; set; }
        public int FYearId { get; set; }
        public DateTime? FDate { get; set; }
        public string FDisc { get; set; }
        public string FType { get; set; }
        public decimal FAmount { get; set; }
        public decimal FTax { get; set; }
        public bool FQabdSarf { get; set; }
        public int FQabdSarfId { get; set; }
        public string Towhom { get; set; }
        public int? SourceId { get; set; }
    }
}
