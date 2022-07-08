using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class OfficeMoneyTbl
    {
        public int Id { get; set; }
        public int OfficeId { get; set; }
        public int JobId { get; set; }
        public int ReleginId { get; set; }
        public decimal Price { get; set; }
        public int PriceUs { get; set; }

        public virtual JobTbl Job { get; set; }
        public virtual OfficeTbl Office { get; set; }
        public virtual RelegionTbl Relegin { get; set; }
    }
}
