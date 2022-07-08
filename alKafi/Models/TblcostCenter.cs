using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TblcostCenter
    {
        public int Id { get; set; }
        public string CostCenterName { get; set; }
        public string CostCenterNameEn { get; set; }
        public string CostCenterNotice { get; set; }
    }
}
