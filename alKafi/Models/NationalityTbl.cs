using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class NationalityTbl
    {
        public NationalityTbl()
        {
            RecruitmenterTbls = new HashSet<RecruitmenterTbl>();
            StatusNameTbls = new HashSet<StatusNameTbl>();
        }

        public int Id { get; set; }
        public string NationalName { get; set; }
        public string CountryName { get; set; }
        public string NationalNameEn { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<RecruitmenterTbl> RecruitmenterTbls { get; set; }
        public virtual ICollection<StatusNameTbl> StatusNameTbls { get; set; }
    }
}
