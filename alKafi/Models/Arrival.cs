using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Arrival
    {
        public int Id { get; set; }
        public int AriportId { get; set; }
        public DateTime? ArrivaleDate { get; set; }
        public TimeSpan? ArrivaleTime { get; set; }
        public string Airplane { get; set; }
        public int RecId { get; set; }
        public int AqedId { get; set; }
        public string Flyno { get; set; }
        public string ArrType { get; set; }
        public bool? IsArrive { get; set; }
        public int Insurance { get; set; }
        public string Notes { get; set; }
        public int? YearId { get; set; }
        public bool? YearClose { get; set; }

        public virtual AqedTbl Aqed { get; set; }
        public virtual AirportTbl Ariport { get; set; }
        public virtual RecruitmenterTbl Rec { get; set; }
    }
}
