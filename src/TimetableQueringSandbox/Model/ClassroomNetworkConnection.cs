using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class ClassroomNetworkConnection
    {
        public Guid Oid { get; set; }
        public int? NetworkConnectionKind { get; set; }
        public int? QuantityOfPorts { get; set; }
        public Guid? Classroom { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual Location ClassroomNavigation { get; set; }
    }
}
