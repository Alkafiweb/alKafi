using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Permission
    {
        public Permission()
        {
            UserPermissions = new HashSet<UserPermission>();
        }

        public int Id { get; set; }
        public string PermissionType { get; set; }

        public virtual ICollection<UserPermission> UserPermissions { get; set; }
    }
}
