using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Incometype
    {
        public Incometype()
        {
            IncomeTbls = new HashSet<IncomeTbl>();
        }

        public int Id { get; set; }
        public string IncomeName { get; set; }
        public bool IsHidden { get; set; }

        public virtual ICollection<IncomeTbl> IncomeTbls { get; set; }
    }
}
