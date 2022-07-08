using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AqedServiceView
    {
        public int Id { get; set; }
        public string RecStatus { get; set; }
        public DateTime? RecStatusDate { get; set; }
        public string Firstmoqeb { get; set; }
        public string Secondmoqeb { get; set; }
        public string CName { get; set; }
        public string IdNum { get; set; }
        public string Phone { get; set; }
        public DateTime SrvDate { get; set; }
        public int SrvDuration { get; set; }
        public string SvrDiscription { get; set; }
        public int? Remaindays { get; set; }
        public int SrvMouqeb1 { get; set; }
        public decimal SrvMouqebPrice { get; set; }
        public int SrvMouqeb2 { get; set; }
        public decimal SrvMouqebPrice2 { get; set; }
        public decimal SrvAmount { get; set; }
        public bool IsNew { get; set; }
        public DateTime? IsNewDate { get; set; }
        public bool IsSendToMouqeb { get; set; }
        public DateTime? IsSendDate { get; set; }
        public bool IsUnderProcess { get; set; }
        public DateTime? IsUnderProcessDate { get; set; }
        public bool IsEnd { get; set; }
        public DateTime? IsEndDate { get; set; }
        public int? BillCurnceyId { get; set; }
        public int? BillCostId { get; set; }
        public int? Usrname { get; set; }
        public bool? IsReturned { get; set; }
        public int? BillMainId { get; set; }
        public decimal? Mad { get; set; }
    }
}
