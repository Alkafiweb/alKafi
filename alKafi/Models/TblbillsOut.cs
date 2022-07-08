using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TblbillsOut
    {
        public int Bilid { get; set; }
        public DateTime? BillDt { get; set; }
        public int? BillAcFrom { get; set; }
        public int? BillAcTo { get; set; }
        public double? BillInvalue { get; set; }
        public int? BillCostId { get; set; }
        public int? BillCurnceyId { get; set; }
        public string BillType { get; set; }
        public string BillTypeId { get; set; }
        public DateTime? BillTypeDt { get; set; }
        public int? MainBillId { get; set; }
        public string BillNotice { get; set; }
        public bool? BillDelete { get; set; }
        public int? Taxval { get; set; }
        public bool? SadadType { get; set; }
        public bool? Withouttax { get; set; }
        public decimal? Taxamount { get; set; }
        public int? YearId { get; set; }
        public bool? YearClose { get; set; }
        public bool? IsFatura { get; set; }
        public string FaturaType { get; set; }
        public int? SourceId { get; set; }
    }
}
