using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class KafalaReportVw
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string IdNum { get; set; }
        public string Phone { get; set; }
        public string NewCust { get; set; }
        public string NewCustId { get; set; }
        public string NewCustMob { get; set; }
        public string RecName { get; set; }
        public string NationalName { get; set; }
        public string Passportno { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime HandDate { get; set; }
        public DateTime? Enddate { get; set; }
        public decimal? Remainamount { get; set; }
        public decimal? Payedamuont { get; set; }
    }
}
