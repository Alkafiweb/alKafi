using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AttachmentTbl
    {
        public int Id { get; set; }
        public int AqedId { get; set; }
        public string Note { get; set; }
        public byte[] FileImage { get; set; }
        public DateTime AttachDate { get; set; }
        public int? AttachtypeId { get; set; }
        public int UserId { get; set; }

        public virtual AqedTbl Aqed { get; set; }
        public virtual AttachmentType Attachtype { get; set; }
    }
}
