using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AqedNotesVw
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }
        public DateTime NoteDate { get; set; }
        public int UserId { get; set; }
        public bool? NoteChk { get; set; }
        public int NotceId { get; set; }
    }
}
