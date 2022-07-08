using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TblbillAccHd
    {
        public int BillHeaderId { get; set; }
        public DateTime? BillHeaderDate { get; set; }
        public string BillHeaderNotice { get; set; }
        public int? BillHeaderTybe { get; set; }
        public double? BillHeaderTotal { get; set; }
        public int? BillHeaderTybeId { get; set; }
        public int? BillHeaderCostId { get; set; }
        public int? BillHeaderCurnceyId { get; set; }
        public string BillHeaderInfo { get; set; }
        public bool? BillHeaderDelet { get; set; }
        public int? YearId { get; set; }
        public bool? YearClose { get; set; }
    }
}
