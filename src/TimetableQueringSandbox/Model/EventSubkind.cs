using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EventSubkind
    {
        public EventSubkind()
        {
            Event = new HashSet<Event>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public decimal? OrderIndex { get; set; }
        public bool? IsDefault { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? Kind { get; set; }

        public virtual EventKind KindNavigation { get; set; }
        public virtual ICollection<Event> Event { get; set; }
    }
}
