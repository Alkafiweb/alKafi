using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class EmpAutoAttendance
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime DateT { get; set; }
        public TimeSpan? FromTime { get; set; }
        public TimeSpan? ToTime { get; set; }
    }
}
