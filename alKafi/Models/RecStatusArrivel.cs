using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class RecStatusArrivel
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string RecName { get; set; }
        public string SendDate { get; set; }
        public string MuaqpId { get; set; }
        public bool IsArrive { get; set; }
        public string Airport { get; set; }
        public DateTime? ArrivaleDate { get; set; }
        public string Relegion { get; set; }
        public string OfficeName { get; set; }
        public string IdNum { get; set; }
        public string Phone { get; set; }
        public string CountryName { get; set; }
        public string NationalName { get; set; }
        public DateTime? Insurancedate { get; set; }
        public int Insurance { get; set; }
        public int? DayTot { get; set; }
    }
}
