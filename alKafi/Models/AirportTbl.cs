using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AirportTbl
    {
        public AirportTbl()
        {
            Arrivals = new HashSet<Arrival>();
        }

        public int Id { get; set; }
        public string Airport { get; set; }
        public string AirportEn { get; set; }

        public virtual ICollection<Arrival> Arrivals { get; set; }
    }
}
