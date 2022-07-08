using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Tblinvoice
    {
        public int Inid { get; set; }
        public string Inname { get; set; }
        public string Intype { get; set; }
        public DateTime? Indate { get; set; }
        public string Inkind { get; set; }
        public double? Inprice { get; set; }
        public double? Indis { get; set; }
        public double? Inleft { get; set; }
        public double? Intotal { get; set; }
        public string Innotice { get; set; }
        public bool Inactive { get; set; }
    }
}
