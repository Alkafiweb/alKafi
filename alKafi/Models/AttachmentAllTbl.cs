using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AttachmentAllTbl
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public string CvFileName { get; set; }
        public byte[] AttachFile { get; set; }
        public int? UserName { get; set; }
        public DateTime? UpDate { get; set; }
        public int SourcType { get; set; }
        public int? YearId { get; set; }
    }
}
