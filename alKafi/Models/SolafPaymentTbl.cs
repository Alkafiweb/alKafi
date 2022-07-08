using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class SolafPaymentTbl
    {
        public int Id { get; set; }
        public int SalId { get; set; }
        public int SolfaId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PayDate { get; set; }
    }
}
