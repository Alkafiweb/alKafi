using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class PayedName
    {
        public PayedName()
        {
            GeneralSalesTbls = new HashSet<GeneralSalesTbl>();
        }

        public int Id { get; set; }
        public string MName { get; set; }
        public bool IsHidden { get; set; }

        public virtual ICollection<GeneralSalesTbl> GeneralSalesTbls { get; set; }
    }
}
