using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class BillInView
    {
        public int Bilid { get; set; }
        public int? AcountId { get; set; }
        public string AcountName { get; set; }
        public string FaturaType { get; set; }
        public bool IsFatura { get; set; }
        public int? SourceId { get; set; }
        public int? Actoid { get; set; }
        public string Actoname { get; set; }
        public double? BillInvalue { get; set; }
        public DateTime? BillDt { get; set; }
        public string BillNotice { get; set; }
        public int? Id { get; set; }
        public string CostCenterName { get; set; }
        public int? Crid { get; set; }
        public string Cuname { get; set; }
        public string BillType { get; set; }
        public int? YearId { get; set; }
        public string BillTypeId { get; set; }
        public DateTime? BillTypeDt { get; set; }
        public bool SadadType { get; set; }
        public int Taxval { get; set; }
        public int? MainBillId { get; set; }
        public bool? BillDelete { get; set; }
        public bool Withouttax { get; set; }
        public decimal Taxamount { get; set; }
    }
}
