using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class OfficerequirmentTbl
    {
        public int Id { get; set; }
        public int Officeid { get; set; }
        public DateTime ReqDate { get; set; }
        public int ReqUser { get; set; }
        public string Notes { get; set; }
        public int CountryId { get; set; }
    }
}
