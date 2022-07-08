using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TransationTbl
    {
        public int Id { get; set; }
        public decimal TranAmount { get; set; }
        public DateTime TranDate { get; set; }
        public int TranType { get; set; }
        public int? SourceId { get; set; }
        public int UserId { get; set; }
        public string Notes { get; set; }
        public int AccountId { get; set; }
        public bool? IsValidated { get; set; }
        public int? UserValid { get; set; }
        public DateTime? DateValid { get; set; }
    }
}
