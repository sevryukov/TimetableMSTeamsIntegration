using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyEventDurationKind
    {
        public StudyEventDurationKind()
        {
            BaseTimeTable = new HashSet<BaseTimeTable>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public int? Duration { get; set; }
        public int? Code { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public bool? IsDefault { get; set; }

        public virtual ICollection<BaseTimeTable> BaseTimeTable { get; set; }
    }
}
