using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class IncomeTbl
    {
        public int Id { get; set; }
        public int IncomeType { get; set; }
        public decimal Amount { get; set; }
        public DateTime IncomeDate { get; set; }
        public int ToAcc { get; set; }
        public string Notice { get; set; }
        public string FromHand { get; set; }
        public string PNotice { get; set; }
        public string CustNo { get; set; }
        public int? AqedId { get; set; }
        public string Visano { get; set; }
        public bool? Withouttax { get; set; }
        public int? ServiceId { get; set; }
        public int? Taxval { get; set; }

        public virtual Incometype IncomeTypeNavigation { get; set; }
        public virtual Account ToAccNavigation { get; set; }
    }
}
