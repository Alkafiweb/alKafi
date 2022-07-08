using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Officemoneyview
    {
        public int Id { get; set; }
        public DateTime AqedDate { get; set; }
        public string OfficeName { get; set; }
        public string RecName { get; set; }
        public string CName { get; set; }
        public decimal? OfficePrice { get; set; }
        public int Officeid { get; set; }
        public int Totalpayments { get; set; }
        public int Totalreturn { get; set; }
        public decimal? Totalremain { get; set; }
        public int Totaldiscountpayments { get; set; }
        public double? TotalAmount { get; set; }
        public decimal Paymentmony { get; set; }
        public double? RemainBalance { get; set; }
    }
}
