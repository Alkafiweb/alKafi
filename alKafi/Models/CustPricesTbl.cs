using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class CustPricesTbl
    {
        public int Id { get; set; }
        public int NatId { get; set; }
        public int JobId { get; set; }
        public int RelejonId { get; set; }
        public decimal Price { get; set; }
        public decimal? Visaprice { get; set; }
    }
}
