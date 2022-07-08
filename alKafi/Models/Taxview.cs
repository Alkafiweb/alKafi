using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Taxview
    {
        public int? Id { get; set; }
        public int AqedId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Taxamount { get; set; }
        public string Taxvalue { get; set; }
        public decimal Finalamount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Notce { get; set; }
        public string PayNotce { get; set; }
        public int? PaymentType { get; set; }
        public string CName { get; set; }
        public string AccountName { get; set; }
        public bool Withouttax { get; set; }
    }
}
