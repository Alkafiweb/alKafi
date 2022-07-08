using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AqedExitTajeerTbl
    {
        public int Id { get; set; }
        public string Notes { get; set; }
        public DateTime NoteDate { get; set; }
        public int RecId { get; set; }
        public int UserId { get; set; }
        public bool? NoteChk { get; set; }
        public bool IsOut { get; set; }
        public string ArrType { get; set; }

        public virtual RecruitmenterTa3jeerTbl Rec { get; set; }
        public virtual UserTbl User { get; set; }
    }
}
