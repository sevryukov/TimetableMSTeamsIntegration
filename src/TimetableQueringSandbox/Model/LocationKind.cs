using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class LocationKind
    {
        public LocationKind()
        {
            Location = new HashSet<Location>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public int? Code { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<Location> Location { get; set; }
    }
}
