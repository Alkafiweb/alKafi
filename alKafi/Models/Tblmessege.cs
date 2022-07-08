using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Tblmessege
    {
        public int Id { get; set; }
        public string Emname { get; set; }
        public string Ememail { get; set; }
        public string Emsubject { get; set; }
        public string Emmsg { get; set; }
        public bool? Emread { get; set; }
        public DateTime? Emdt { get; set; }
        public DateTime? EmreadDt { get; set; }
    }
}
