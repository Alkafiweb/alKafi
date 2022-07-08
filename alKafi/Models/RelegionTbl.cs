using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class RelegionTbl
    {
        public RelegionTbl()
        {
            OfficeMoneyTbls = new HashSet<OfficeMoneyTbl>();
            RecruitmenterTbls = new HashSet<RecruitmenterTbl>();
        }

        public int Id { get; set; }
        public string Relegion { get; set; }
        public string RelegionEn { get; set; }

        public virtual ICollection<OfficeMoneyTbl> OfficeMoneyTbls { get; set; }
        public virtual ICollection<RecruitmenterTbl> RecruitmenterTbls { get; set; }
    }
}
