using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AqedMoney
    {
        public int Id { get; set; }
        public string MName { get; set; }
        public decimal Amount { get; set; }
        public DateTime MDate { get; set; }
        public string Notes { get; set; }
        public int AqedId { get; set; }
        public string PayNotes { get; set; }
        public bool IsSafara { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual AqedTbl Aqed { get; set; }
    }
}
