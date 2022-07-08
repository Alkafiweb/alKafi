using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AttachmentType
    {
        public AttachmentType()
        {
            AttachmentTbls = new HashSet<AttachmentTbl>();
        }

        public int Id { get; set; }
        public string AttcahName { get; set; }

        public virtual ICollection<AttachmentTbl> AttachmentTbls { get; set; }
    }
}
