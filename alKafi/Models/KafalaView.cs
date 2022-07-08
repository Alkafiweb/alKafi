using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class KafalaView
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public int CustId { get; set; }
        public DateTime? ArrivaleDate { get; set; }
        public string RecId { get; set; }
        public int Rcid { get; set; }
    }
}
