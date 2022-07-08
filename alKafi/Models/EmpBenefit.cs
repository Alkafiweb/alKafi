using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class EmpBenefit
    {
        public int Id { get; set; }
        public int BenefitId { get; set; }
        public int EmpId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PayedDate { get; set; }
        public string PNote { get; set; }
        public string Notes { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Benefit Benefit { get; set; }
    }
}
