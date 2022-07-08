using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class UserTbl
    {
        public UserTbl()
        {
            AqedExitTajeerTbls = new HashSet<AqedExitTajeerTbl>();
            AqedHasemTbls = new HashSet<AqedHasemTbl>();
            AqedNotesTajeerTbls = new HashSet<AqedNotesTajeerTbl>();
            AqedNotesTbls = new HashSet<AqedNotesTbl>();
            UserPermissions = new HashSet<UserPermission>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Passwd { get; set; }
        public bool UType { get; set; }
        public bool Active { get; set; }
        public int? Officeid { get; set; }
        public int BranchId { get; set; }
        public int? CountryId { get; set; }

        public virtual ICollection<AqedExitTajeerTbl> AqedExitTajeerTbls { get; set; }
        public virtual ICollection<AqedHasemTbl> AqedHasemTbls { get; set; }
        public virtual ICollection<AqedNotesTajeerTbl> AqedNotesTajeerTbls { get; set; }
        public virtual ICollection<AqedNotesTbl> AqedNotesTbls { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
    }
}
