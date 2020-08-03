using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class SecuritySystemMemberPermissionsObject
    {
        public Guid Oid { get; set; }
        public string Members { get; set; }
        public bool? AllowRead { get; set; }
        public bool? AllowWrite { get; set; }
        public string Criteria { get; set; }
        public Guid? Owner { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual SecuritySystemTypePermissionsObject OwnerNavigation { get; set; }
    }
}
