using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TransmittTbl
    {
        public int Id { get; set; }
        public DateTime TransDate { get; set; }
        public string TransName { get; set; }
        public int OfficeId { get; set; }
        public string Notes { get; set; }
    }
}
