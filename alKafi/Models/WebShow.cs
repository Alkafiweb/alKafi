using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class WebShow
    {
        public int? Id { get; set; }
        public int? AccountVl { get; set; }
        public DateTime? Closedate { get; set; }
        public int? CloseUser { get; set; }
        public bool? Tajeer { get; set; }
        public string Officeidentity { get; set; }
        public bool? Service { get; set; }
        public bool? SadadType { get; set; }
        public int Musaned { get; set; }
        public int Tafweed { get; set; }
        public int States { get; set; }
    }
}
