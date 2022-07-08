using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class KafalaMoney
    {
        public int Id { get; set; }
        public int KId { get; set; }
        public decimal Amount { get; set; }
        public DateTime MDate { get; set; }
        public string Notes { get; set; }
        public string PayNotes { get; set; }
        public int AccountId { get; set; }
        public bool? PaymentType { get; set; }
        public bool? Withouttax { get; set; }
        public int? Taxval { get; set; }

        public virtual Account Account { get; set; }
        public virtual KafalaTbl KIdNavigation { get; set; }
    }
}
