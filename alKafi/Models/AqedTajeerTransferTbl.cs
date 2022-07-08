using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AqedTajeerTransferTbl
    {
        public int Id { get; set; }
        public int AqedTajeerId { get; set; }
        public int FromRecId { get; set; }
        public int ToRecId { get; set; }
        public DateTime TransDate { get; set; }
        public string TransNote { get; set; }
        public int TransUser { get; set; }
        public DateTime UserDate { get; set; }
        public string TransTime { get; set; }
    }
}
