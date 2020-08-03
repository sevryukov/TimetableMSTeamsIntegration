using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class BaseTimeTableKind
    {
        public BaseTimeTableKind()
        {
            BaseTimeTable = new HashSet<BaseTimeTable>();
            EventKindAvailableEventKindsBaseTimeTableKindAvailableTimeTableKinds = new HashSet<EventKindAvailableEventKindsBaseTimeTableKindAvailableTimeTableKinds>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string NameEnglish { get; set; }
        public int? Code { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<BaseTimeTable> BaseTimeTable { get; set; }
        public virtual ICollection<EventKindAvailableEventKindsBaseTimeTableKindAvailableTimeTableKinds> EventKindAvailableEventKindsBaseTimeTableKindAvailableTimeTableKinds { get; set; }
    }
}
