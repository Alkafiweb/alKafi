using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AqedNotesTajeerTbl
    {
        public int Id { get; set; }
        public string Notes { get; set; }
        public DateTime NoteDate { get; set; }
        public int AqedId { get; set; }
        public int UserId { get; set; }
        public bool? NoteChk { get; set; }

        public virtual AqedTa3jeerTbl Aqed { get; set; }
        public virtual UserTbl User { get; set; }
    }
}
