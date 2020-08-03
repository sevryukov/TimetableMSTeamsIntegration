using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class LocationClassroomsClassroomAccessKindClassroomAccessKinds
    {
        public Guid? ClassroomAccessKinds { get; set; }
        public Guid? Classrooms { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual ClassroomAccessKind ClassroomAccessKindsNavigation { get; set; }
        public virtual Location ClassroomsNavigation { get; set; }
    }
}
