using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class CustomerOrdersview
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public DateTime AqedDate { get; set; }
        public string Job { get; set; }
        public string NationalName { get; set; }
        public string Relegion { get; set; }
        public int? Reccount { get; set; }
        public string SevenCond { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public string CountryName { get; set; }
        public string IdNum { get; set; }
        public string Phone { get; set; }
        public string Visano { get; set; }
        public string EightCond { get; set; }
        public string OwnerAddressAr { get; set; }
    }
}
