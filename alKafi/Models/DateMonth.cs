using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class DateMonth
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public bool Active { get; set; }
    }
}
