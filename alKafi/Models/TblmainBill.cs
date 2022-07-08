using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TblmainBill
    {
        public int? Bilid { get; set; }
        public int? BillAccId { get; set; }
        public double? BillInvalue { get; set; }
        public double? BillOutvalue { get; set; }
        public DateTime? BillDt { get; set; }
        public string BillNotice { get; set; }
        public int? BillType { get; set; }
        public int? BillCostId { get; set; }
        public int? BillCurnceyId { get; set; }
        public string PNotice { get; set; }
        public int? SubBillId { get; set; }
        public string BillDetils { get; set; }
        public bool? BillDelete { get; set; }
        public int? YearId { get; set; }
        public bool? YearClose { get; set; }
    }
}
