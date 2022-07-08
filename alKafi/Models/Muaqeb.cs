using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Muaqeb
    {
        public Muaqeb()
        {
            MouqebMoneys = new HashSet<MouqebMoney>();
        }

        public int MuaqebId { get; set; }
        public string MuaqebName { get; set; }
        public string MuaqebPhone { get; set; }
        public int? MoaccId { get; set; }

        public virtual ICollection<MouqebMoney> MouqebMoneys { get; set; }
    }
}
