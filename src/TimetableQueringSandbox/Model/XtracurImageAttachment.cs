using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class XtracurImageAttachment
    {
        public XtracurImageAttachment()
        {
            Event = new HashSet<Event>();
        }

        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public byte[] ImageData { get; set; }

        public virtual ICollection<Event> Event { get; set; }
    }
}
