using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class RecStatusMsgVw
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string Visano { get; set; }
        public string Job { get; set; }
        public string SName { get; set; }
        public DateTime StatusDate { get; set; }
        public DateTime? DoneDate { get; set; }
        public string RecName { get; set; }
        public int? Officeid { get; set; }
        public string OfficeName { get; set; }
        public bool IsDone { get; set; }
        public int StatusId { get; set; }
    }
}
