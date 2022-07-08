using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TfweedMasareefTbl
    {
        public int Id { get; set; }
        public string Custname { get; set; }
        public decimal Amount { get; set; }
        public DateTime MDate { get; set; }
        public int AccountId { get; set; }
        public string PayNotes { get; set; }
        public string Notes { get; set; }
        public int TId { get; set; }

        public virtual Account Account { get; set; }
        public virtual TfweedTbl TIdNavigation { get; set; }
    }
}
