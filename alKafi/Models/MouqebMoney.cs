using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class MouqebMoney
    {
        public int Id { get; set; }
        public int MuaqeId { get; set; }
        public int AqedId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DDate { get; set; }
        public string Notes { get; set; }
        public string PayNotes { get; set; }
        public int AccountId { get; set; }
        public int? RecId { get; set; }

        public virtual Account Account { get; set; }
        public virtual AqedTbl Aqed { get; set; }
        public virtual Muaqeb Muaqe { get; set; }
    }
}
