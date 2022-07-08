using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TaxToTview
    {
        public int? Id { get; set; }
        public int? YearId { get; set; }
        public DateTime? AqedDate { get; set; }
        public string NationalName { get; set; }
        public string Job { get; set; }
        public int IsReturned { get; set; }
        public string Cuname { get; set; }
        public string CostCenterName { get; set; }
        public double DisCountVl { get; set; }
        public double? TotalAmount { get; set; }
        public double Tot1 { get; set; }
        public string CName { get; set; }
        public bool VisaIsOur { get; set; }
        public double? Tax { get; set; }
        public double? TotwithTax { get; set; }
        public string UserName { get; set; }
        public string RecName { get; set; }
        public string OfficeName { get; set; }
        public int? Crid { get; set; }
        public int? CostId { get; set; }
        public int UserId { get; set; }
        public string IdNum { get; set; }
    }
}
