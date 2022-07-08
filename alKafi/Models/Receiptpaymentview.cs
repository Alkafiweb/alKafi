using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Receiptpaymentview
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public int AqedId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Notce { get; set; }
        public string PayNotce { get; set; }
    }
}
