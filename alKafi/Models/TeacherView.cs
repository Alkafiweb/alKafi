using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TeacherView
    {
        public int? Bilid { get; set; }
        public int? AcountId { get; set; }
        public string AcountName { get; set; }
        public double? BillInvalue { get; set; }
        public int? YearId { get; set; }
        public double? BillOutvalue { get; set; }
        public DateTime? BillDt { get; set; }
        public string BillNotice { get; set; }
        public int? BillType { get; set; }
        public int? Endid { get; set; }
        public string Endname { get; set; }
        public int? Id { get; set; }
        public string CostCenterName { get; set; }
        public int? Crid { get; set; }
        public string Cuname { get; set; }
        public string PNotice { get; set; }
        public int? SubBillId { get; set; }
        public bool? BillDelete { get; set; }
        public string BillHeaderInfo { get; set; }
        public double? Total { get; set; }
    }
}
