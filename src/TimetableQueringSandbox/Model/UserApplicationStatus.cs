using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class UserApplicationStatus
    {
        public UserApplicationStatus()
        {
            UserApplication = new HashSet<UserApplication>();
            UserApplicationUpdate = new HashSet<UserApplicationUpdate>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public int? Code { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<UserApplication> UserApplication { get; set; }
        public virtual ICollection<UserApplicationUpdate> UserApplicationUpdate { get; set; }
    }
}
