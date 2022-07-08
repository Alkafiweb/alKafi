using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Year
    {
        public int Id { get; set; }
        public int YearName { get; set; }
        public bool IsActive { get; set; }
        public DateTime YearFrom { get; set; }
        public DateTime YearTo { get; set; }
    }
}
