using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class SearchStView
    {
        public string RecName { get; set; }
        public string SName { get; set; }
        public DateTime StatusDate { get; set; }
        public DateTime? DoneDate { get; set; }
        public bool IsDone { get; set; }
        public int? AqedId { get; set; }
        public string Cvno { get; set; }
    }
}
