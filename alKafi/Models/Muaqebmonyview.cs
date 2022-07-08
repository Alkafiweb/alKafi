using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Muaqebmonyview
    {
        public string MuaqebName { get; set; }
        public int Id { get; set; }
        public string CName { get; set; }
        public double MuaqpMoney { get; set; }
        public DateTime AqedDate { get; set; }
        public decimal Total { get; set; }
        public double? Res { get; set; }
        public int MuaqebId { get; set; }
        public int? AqedSource { get; set; }
        public string Visano { get; set; }
        public DateTime Visadate { get; set; }
    }
}
