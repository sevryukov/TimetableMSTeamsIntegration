using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class SapRoom
    {
        public SapRoom()
        {
            Location = new HashSet<Location>();
        }

        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string NumberActual { get; set; }
        public string NumberProjected { get; set; }
        public int? StudyCapacity { get; set; }
        public int? WorkCapacity { get; set; }
        public double? Square { get; set; }
        public Guid? Floor { get; set; }
        public Guid? Building { get; set; }
        public Guid? Classroom { get; set; }
        public Guid? Kind { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual SapBuilding BuildingNavigation { get; set; }
        public virtual Location ClassroomNavigation { get; set; }
        public virtual LocationFloor FloorNavigation { get; set; }
        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual SapRoomKind KindNavigation { get; set; }
        public virtual ICollection<Location> Location { get; set; }
    }
}
