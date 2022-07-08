using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AqedHasemTbl
    {
        public int Id { get; set; }
        public int AqedId { get; set; }
        public DateTime HDate { get; set; }
        public int HUser { get; set; }
        public string HType { get; set; }
        public int HAmount { get; set; }
        public string HNotes { get; set; }

        public virtual AqedTbl Aqed { get; set; }
        public virtual UserTbl HUserNavigation { get; set; }
    }
}
