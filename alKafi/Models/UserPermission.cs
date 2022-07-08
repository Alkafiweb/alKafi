using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class UserPermission
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PermId { get; set; }
        public bool IsRead { get; set; }
        public bool IsAdd { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsDelete { get; set; }

        public virtual Permission Perm { get; set; }
        public virtual UserTbl User { get; set; }
    }
}
