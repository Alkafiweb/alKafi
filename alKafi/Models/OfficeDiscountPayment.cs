using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class OfficeDiscountPayment
    {
        public int Id { get; set; }
        public int OfficeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Paydate { get; set; }
        public string Details { get; set; }
        public int AccountId { get; set; }
        public bool PaymentType { get; set; }
        public string ReturnType { get; set; }
        public string CustName { get; set; }
        public int AmountUs { get; set; }
        public int? AqedId { get; set; }

        public virtual Account Account { get; set; }
        public virtual OfficeTbl Office { get; set; }
    }
}
