using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Benefit
    {
        public Benefit()
        {
            EmpBenefits = new HashSet<EmpBenefit>();
        }

        public int BenefitId { get; set; }
        public string BenefitName { get; set; }

        public virtual ICollection<EmpBenefit> EmpBenefits { get; set; }
    }
}
