using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TransMadyonaView
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string Visano { get; set; }
        public double? TotalAmount { get; set; }
        public decimal Paymentmony { get; set; }
        public double? RemainBalance { get; set; }
        public DateTime AqedDate { get; set; }
        public string OfficeSource { get; set; }
        public int TransmitId { get; set; }
        public string RecName { get; set; }
        public string Personouside { get; set; }
        public string Personcode { get; set; }
    }
}
