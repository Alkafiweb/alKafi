using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class BillAccView
    {
        public int? Bilid { get; set; }
        public DateTime? BillDt { get; set; }
        public int? AcountId { get; set; }
        public string AcountName { get; set; }
        public double? BillInvalue { get; set; }
        public int? Id { get; set; }
        public string CostCenterName { get; set; }
        public int? Crid { get; set; }
        public string Cuname { get; set; }
        public string BillType { get; set; }
        public int? MainBillId { get; set; }
        public string BillNotice { get; set; }
        public bool? BillDelete { get; set; }
        public double? BillOutvalue { get; set; }
        public int? YearId { get; set; }
    }
}
