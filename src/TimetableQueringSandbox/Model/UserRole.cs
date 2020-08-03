using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class UserRole
    {
        public UserRole()
        {
            UserUsersUserRoleUserRoles = new HashSet<UserUsersUserRoleUserRoles>();
        }

        public Guid Oid { get; set; }

        public virtual SecuritySystemRole O { get; set; }
        public virtual ICollection<UserUsersUserRoleUserRoles> UserUsersUserRoleUserRoles { get; set; }
    }
}
