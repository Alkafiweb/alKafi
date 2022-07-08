using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Tblgetprice
    {
        public int Gtid { get; set; }
        public string Gtcard { get; set; }
        public string Gtprice { get; set; }
        public int? GtdominCk { get; set; }
        public string GtdominName { get; set; }
        public string GtdominLast { get; set; }
        public string Gtname { get; set; }
        public string Gtemail { get; set; }
        public string Gtmobile { get; set; }
        public string GtuserIp { get; set; }
        public DateTime? Gtdt { get; set; }
        public bool Gtactive { get; set; }
        public bool Gtok { get; set; }
    }
}
