using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class HasamView
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public DateTime AqedDate { get; set; }
        public DateTime HDate { get; set; }
        public int HUser { get; set; }
        public string HType { get; set; }
        public int HAmount { get; set; }
        public string HNotes { get; set; }
    }
}
