using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class SecuritySystemUserUsersSecuritySystemRoleRoles
    {
        public Guid? Roles { get; set; }
        public Guid? Users { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual SecuritySystemRole RolesNavigation { get; set; }
        public virtual SecuritySystemUser UsersNavigation { get; set; }
    }
}
