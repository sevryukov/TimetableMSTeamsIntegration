using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class AppointmentLabelColor
    {
        public Guid Oid { get; set; }
        public int? Color { get; set; }
        public int? LabelCode { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
