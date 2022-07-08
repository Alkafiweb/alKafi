using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class GeneralSalesTbl
    {
        public int Id { get; set; }
        public int PName { get; set; }
        public decimal TotalAmout { get; set; }
        public DateTime DateIn { get; set; }
        public string InNo { get; set; }
        public string Notes { get; set; }
        public string CName { get; set; }
        public int AccountId { get; set; }
        public int? ServiceId { get; set; }

        public virtual Account Account { get; set; }
        public virtual PayedName PNameNavigation { get; set; }
    }
}
