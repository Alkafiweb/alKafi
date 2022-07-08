using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public int AqedId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Notce { get; set; }
        public string PayNotce { get; set; }
        public int AccountId { get; set; }
        public bool? PaymentType { get; set; }
        public bool? Withouttax { get; set; }
        public int? Taxval { get; set; }

        public virtual Account Account { get; set; }
        public virtual AqedTbl Aqed { get; set; }
    }
}
