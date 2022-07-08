using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TfweedTbl
    {
        public TfweedTbl()
        {
            TfweedMasareefTbls = new HashSet<TfweedMasareefTbl>();
            TfweedMoneys = new HashSet<TfweedMoney>();
        }

        public int Id { get; set; }
        public string PName { get; set; }
        public string Visano { get; set; }
        public string Visadate { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public DateTime TDate { get; set; }
        public int TNo { get; set; }
        public string CustNo { get; set; }
        public decimal? PayedM { get; set; }
        public decimal? Masroof { get; set; }
        public decimal? RemainM { get; set; }
        public decimal? Rebh { get; set; }

        public virtual ICollection<TfweedMasareefTbl> TfweedMasareefTbls { get; set; }
        public virtual ICollection<TfweedMoney> TfweedMoneys { get; set; }
    }
}
