using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class LocationFloor
    {
        public LocationFloor()
        {
            Location = new HashSet<Location>();
            SapRoom = new HashSet<SapRoom>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<SapRoom> SapRoom { get; set; }
    }
}
