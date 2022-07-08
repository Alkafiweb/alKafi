using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class StatusNameTbl
    {
        public StatusNameTbl()
        {
            StatusTbls = new HashSet<StatusTbl>();
        }

        public int Id { get; set; }
        public string SName { get; set; }
        public string SNameEn { get; set; }
        public int CountryId { get; set; }
        public int TotalDays { get; set; }
        public string Color { get; set; }
        public bool? AfterSend { get; set; }
        public int? SOrder { get; set; }

        public virtual NationalityTbl Country { get; set; }
        public virtual ICollection<StatusTbl> StatusTbls { get; set; }
    }
}
