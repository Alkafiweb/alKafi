using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class BeforeaqedTbl
    {
        public int Id { get; set; }
        public string KName { get; set; }
        public string KMob { get; set; }
        public string KAddress { get; set; }
        public string KSpec { get; set; }
        public bool IsAqed { get; set; }
        public int AqedNum { get; set; }
        public DateTime KDate { get; set; }
        public int Userid { get; set; }
        public int? JobId { get; set; }
        public int? NatId { get; set; }
    }
}
