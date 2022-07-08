using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Report
    {
        public int Id { get; set; }
        public string UniqeName { get; set; }
        public byte[] Reportfile { get; set; }
        public DateTime Lastupdate { get; set; }
        public int Userupdate { get; set; }
        public string RContent { get; set; }
    }
}
