using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class OtherServicesTbl
    {
        public int Id { get; set; }
        public int CustName { get; set; }
        public string CCust { get; set; }
        public string CPhone { get; set; }
        public DateTime SDate { get; set; }
        public string SDisc { get; set; }
        public decimal TotalMoney { get; set; }
        public decimal PayedMoney { get; set; }
    }
}
