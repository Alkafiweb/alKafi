using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class InternalMsgTbl
    {
        public int Id { get; set; }
        public int Fromuser { get; set; }
        public int Touser { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
        public DateTime? ReadDate { get; set; }
        public string MsgDetials { get; set; }
    }
}
