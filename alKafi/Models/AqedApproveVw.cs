using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AqedApproveVw
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string NationalName { get; set; }
        public string Job { get; set; }
        public string Visano { get; set; }
        public string SevenCond { get; set; }
        public DateTime AqedDate { get; set; }
        public string Phone { get; set; }
        public string Relegion { get; set; }
    }
}
