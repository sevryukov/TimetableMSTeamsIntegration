using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EventSequence
    {
        public EventSequence()
        {
            Event = new HashSet<Event>();
        }

        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<Event> Event { get; set; }
    }
}
