using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class SecuritySystemUser
    {
        public SecuritySystemUser()
        {
            SecuritySystemUserUsersSecuritySystemRoleRoles = new HashSet<SecuritySystemUserUsersSecuritySystemRoleRoles>();
        }

        public Guid Oid { get; set; }
        public string StoredPassword { get; set; }
        public bool? ChangePasswordOnFirstLogon { get; set; }
        public string UserName { get; set; }
        public bool? IsActive { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }

        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual ICollection<SecuritySystemUserUsersSecuritySystemRoleRoles> SecuritySystemUserUsersSecuritySystemRoleRoles { get; set; }
    }
}
