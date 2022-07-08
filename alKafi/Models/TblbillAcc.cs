using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TblbillAcc
    {
        public int? Bilid { get; set; }
        public DateTime? BillDt { get; set; }
        public int? BillAccount { get; set; }
        public double? BillInvalue { get; set; }
        public double? BillOutvalue { get; set; }
        public int? BillCostId { get; set; }
        public int? BillCurnceyId { get; set; }
        public string BillType { get; set; }
        public int? MainBillId { get; set; }
        public string BillNotice { get; set; }
        public bool? BillDelete { get; set; }
        public int? YearId { get; set; }
        public bool? YearClose { get; set; }
    }
}
