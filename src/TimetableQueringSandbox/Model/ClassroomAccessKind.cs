using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class ClassroomAccessKind
    {
        public ClassroomAccessKind()
        {
            LocationClassroomsClassroomAccessKindClassroomAccessKinds = new HashSet<LocationClassroomsClassroomAccessKindClassroomAccessKinds>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<LocationClassroomsClassroomAccessKindClassroomAccessKinds> LocationClassroomsClassroomAccessKindClassroomAccessKinds { get; set; }
    }
}
