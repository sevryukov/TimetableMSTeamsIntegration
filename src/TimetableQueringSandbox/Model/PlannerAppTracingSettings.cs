using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class PlannerAppTracingSettings
    {
        public Guid Oid { get; set; }
        public bool? TakeImageOnError { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
