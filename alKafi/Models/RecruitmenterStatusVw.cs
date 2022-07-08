using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class RecruitmenterStatusVw
    {
        public string Visano { get; set; }
        public string CName { get; set; }
        public string IdNum { get; set; }
        public string RecName { get; set; }
        public string Passportno { get; set; }
        public string SName { get; set; }
        public DateTime StatusDate { get; set; }
        public int StatusId { get; set; }
        public string Phone { get; set; }
        public int OfficeTbl { get; set; }
        public string UserName { get; set; }
        public int? UserId { get; set; }
        public DateTime? DoneDate { get; set; }
        public bool IsDone { get; set; }
        public string Airport { get; set; }
        public int MuaqpId { get; set; }
        public string RecNotes { get; set; }
    }
}
