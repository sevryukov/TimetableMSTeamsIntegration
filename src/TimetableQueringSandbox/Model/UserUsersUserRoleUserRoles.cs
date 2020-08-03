using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class UserUsersUserRoleUserRoles
    {
        public Guid? UserRoles { get; set; }
        public Guid? Users { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual UserRole UserRolesNavigation { get; set; }
        public virtual User UsersNavigation { get; set; }
    }
}
