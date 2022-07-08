using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class FillipoReportSitting
    {
        public int Id { get; set; }
        public string FieldName { get; set; }
        public string FieldBind { get; set; }
        public bool? IsActive { get; set; }
    }
}
