using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TblcusInformation
    {
        public int Id { get; set; }
        public string CusName { get; set; }
        public string CusMobile { get; set; }
        public string CusNumId { get; set; }
        public string CusTxt { get; set; }
        public int? RecId { get; set; }
        public DateTime? Dt { get; set; }
        public bool Gtactive { get; set; }
        public bool Gtok { get; set; }
    }
}
