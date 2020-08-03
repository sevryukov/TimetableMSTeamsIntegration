using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class Holiday
    {
        public Guid Oid { get; set; }
        public DateTime? Day { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
