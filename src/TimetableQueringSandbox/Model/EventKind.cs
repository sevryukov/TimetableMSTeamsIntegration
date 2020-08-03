using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EventKind
    {
        public EventKind()
        {
            BaseTimeTable = new HashSet<BaseTimeTable>();
            Event = new HashSet<Event>();
            EventKindAvailableEventKindsBaseTimeTableKindAvailableTimeTableKinds = new HashSet<EventKindAvailableEventKindsBaseTimeTableKindAvailableTimeTableKinds>();
            EventSubkind = new HashSet<EventSubkind>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public bool? IsStudy { get; set; }
        public bool? IsXtracur { get; set; }
        public Guid? XtracurDivision { get; set; }

        public virtual XtracurDivision XtracurDivisionNavigation { get; set; }
        public virtual ICollection<BaseTimeTable> BaseTimeTable { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<EventKindAvailableEventKindsBaseTimeTableKindAvailableTimeTableKinds> EventKindAvailableEventKindsBaseTimeTableKindAvailableTimeTableKinds { get; set; }
        public virtual ICollection<EventSubkind> EventSubkind { get; set; }
    }
}
