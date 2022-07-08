using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class LogTbl
    {
        public int Id { get; set; }
        public string TransLog { get; set; }
        public DateTime TranDate { get; set; }
        public string TransType { get; set; }
        public string TranTable { get; set; }
        public int UserId { get; set; }
    }
}
