using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class RecruitmenterTa3jeerTbl
    {
        public RecruitmenterTa3jeerTbl()
        {
            AqedExitTajeerTbls = new HashSet<AqedExitTajeerTbl>();
        }

        public int RecId { get; set; }
        public string Gender { get; set; }
        public string IqamaNum { get; set; }
        public string Mo3hlatkhbrat { get; set; }
        public string RecStatus { get; set; }
        public bool IsKafala { get; set; }
        public string Notes { get; set; }
        public DateTime? KafalaDate { get; set; }
        public decimal? RecCost { get; set; }
        public string CostDiscrp { get; set; }
        public DateTime? IqamaEndDate { get; set; }
        public DateTime? InsuranceEndDate { get; set; }
        public DateTime? PassportEndDate { get; set; }
        public bool? IsExit { get; set; }

        public virtual RecruitmenterTbl Rec { get; set; }
        public virtual ICollection<AqedExitTajeerTbl> AqedExitTajeerTbls { get; set; }
    }
}
