using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class JobTbl
    {
        public JobTbl()
        {
            OfficeMoneyTbls = new HashSet<OfficeMoneyTbl>();
            RecruitmenterTbls = new HashSet<RecruitmenterTbl>();
        }

        public int Id { get; set; }
        public string Job { get; set; }
        public string JobEn { get; set; }

        public virtual ICollection<OfficeMoneyTbl> OfficeMoneyTbls { get; set; }
        public virtual ICollection<RecruitmenterTbl> RecruitmenterTbls { get; set; }
    }
}
