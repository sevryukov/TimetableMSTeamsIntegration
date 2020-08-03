using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class TimeScaleStepKind
    {
        public TimeScaleStepKind()
        {
            BaseTimeTable = new HashSet<BaseTimeTable>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public double? Step { get; set; }
        public int? Code { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<BaseTimeTable> BaseTimeTable { get; set; }
    }
}
