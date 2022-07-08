using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class KafalaTbl
    {
        public KafalaTbl()
        {
            KafalaMoneys = new HashSet<KafalaMoney>();
        }

        public int Id { get; set; }
        public int CustId { get; set; }
        public string RecId { get; set; }
        public int AqedId { get; set; }
        public DateTime ReachDate { get; set; }
        public DateTime? HandDate { get; set; }
        public string NewCust { get; set; }
        public decimal TotalAmount { get; set; }
        public string NewCustId { get; set; }
        public string NewCustMob { get; set; }
        public string Notes { get; set; }
        public decimal? Remain { get; set; }
        public int? NewCustId1 { get; set; }
        public int? KrecId { get; set; }
        public DateTime? KstartDt { get; set; }
        public DateTime? KendDt { get; set; }
        public string KdayTot { get; set; }
        public bool Kok { get; set; }

        public virtual CustomerTbl Cust { get; set; }
        public virtual ICollection<KafalaMoney> KafalaMoneys { get; set; }
    }
}
