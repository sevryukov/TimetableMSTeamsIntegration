using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class SecuritySystemTypePermissionsObject
    {
        public SecuritySystemTypePermissionsObject()
        {
            SecuritySystemMemberPermissionsObject = new HashSet<SecuritySystemMemberPermissionsObject>();
            SecuritySystemObjectPermissionsObject = new HashSet<SecuritySystemObjectPermissionsObject>();
        }

        public Guid Oid { get; set; }
        public string TargetType { get; set; }
        public bool? AllowRead { get; set; }
        public bool? AllowWrite { get; set; }
        public bool? AllowCreate { get; set; }
        public bool? AllowDelete { get; set; }
        public bool? AllowNavigate { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }
        public Guid? Owner { get; set; }

        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual SecuritySystemRole OwnerNavigation { get; set; }
        public virtual ICollection<SecuritySystemMemberPermissionsObject> SecuritySystemMemberPermissionsObject { get; set; }
        public virtual ICollection<SecuritySystemObjectPermissionsObject> SecuritySystemObjectPermissionsObject { get; set; }
    }
}
