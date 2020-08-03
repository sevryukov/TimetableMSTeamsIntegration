using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EventKindAvailableEventKindsBaseTimeTableKindAvailableTimeTableKinds
    {
        public Guid? AvailableTimeTableKinds { get; set; }
        public Guid? AvailableEventKinds { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual EventKind AvailableEventKindsNavigation { get; set; }
        public virtual BaseTimeTableKind AvailableTimeTableKindsNavigation { get; set; }
    }
}
