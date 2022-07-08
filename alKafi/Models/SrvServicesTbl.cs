using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class SrvServicesTbl
    {
        public int Id { get; set; }
        public int CustId { get; set; }
        public DateTime SrvDate { get; set; }
        public int SrvDuration { get; set; }
        public string SvrDiscription { get; set; }
        public int SrvMouqeb1 { get; set; }
        public decimal SrvMouqebPrice { get; set; }
        public int SrvMouqeb2 { get; set; }
        public decimal SrvMouqebPrice2 { get; set; }
        public decimal SrvAmount { get; set; }
        public bool? SrvTax { get; set; }
        public bool IsNew { get; set; }
        public DateTime? IsNewDate { get; set; }
        public bool IsSendToMouqeb { get; set; }
        public DateTime? IsSendDate { get; set; }
        public bool IsUnderProcess { get; set; }
        public DateTime? IsUnderProcessDate { get; set; }
        public bool IsEnd { get; set; }
        public DateTime? IsEndDate { get; set; }
        public string Attachment1 { get; set; }
        public string Attachment2 { get; set; }
        public int? BillCurnceyId { get; set; }
        public int? BillCostId { get; set; }
        public int? Usrname { get; set; }
        public bool? IsReturned { get; set; }
        public int? BillMainId { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? BillDeleteId { get; set; }
        public int? YearId { get; set; }
        public bool? YearClose { get; set; }
        public int? YearIdRet { get; set; }
    }
}
