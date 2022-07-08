using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class KafalView
    {
        public int Id { get; set; }
        public string RecId { get; set; }
        public int AqedId { get; set; }
        public DateTime ReachDate { get; set; }
        public string NewCust { get; set; }
        public decimal TotalAmount { get; set; }
        public string NewCustId { get; set; }
        public string NewCustMob { get; set; }
        public string Notes { get; set; }
        public decimal? Remain { get; set; }
        public int? Cusid { get; set; }
        public string Cusname { get; set; }
        public int? NewCusId { get; set; }
        public string NewCusName { get; set; }
        public DateTime? KstartDt { get; set; }
        public DateTime? KendDt { get; set; }
        public string KdayTot { get; set; }
        public bool Kok { get; set; }
        public int CustId { get; set; }
        public DateTime? HandDate { get; set; }
        public string RecName { get; set; }
        public string IdNum { get; set; }
        public string Phone { get; set; }
        public string NewCusIdnum { get; set; }
        public string NewCusPhone { get; set; }
        public string NationalName { get; set; }
        public string Passportno { get; set; }
        public int? Rcid { get; set; }
    }
}
