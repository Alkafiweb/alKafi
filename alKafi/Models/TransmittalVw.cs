using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TransmittalVw
    {
        public int Id { get; set; }
        public string Recname { get; set; }
        public string Kafeelname { get; set; }
        public string Visano { get; set; }
        public string Passportno { get; set; }
        public int TransmitId { get; set; }
        public int Offid { get; set; }
        public string IdNum { get; set; }
        public string OwnernameEn { get; set; }
    }
}
