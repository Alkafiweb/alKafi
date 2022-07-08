using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TrialBalanceView
    {
        public int AcountId { get; set; }
        public string AcountName { get; set; }
        public string AccountCode { get; set; }
        public int AccountLevel { get; set; }
        public int AcountEnd { get; set; }
        public bool Acctyp { get; set; }
        public bool Accdlt { get; set; }
        public double? FirstInvl { get; set; }
        public double? FirstOutVl { get; set; }
        public double? EndInvl { get; set; }
        public double? EndOutVl { get; set; }
        public double? Totinvl { get; set; }
        public double? Totoutvl { get; set; }
        public double? Tottvl { get; set; }
    }
}
