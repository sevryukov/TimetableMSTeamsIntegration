using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class SportObjectPassport
    {
        public Guid Oid { get; set; }
        public Guid? Location { get; set; }
        public string Name { get; set; }
        public double? Square { get; set; }
        public string SportKinds { get; set; }
        public int? OutputCapacity { get; set; }
        public string Inventory { get; set; }
        public string Equipment { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual Location LocationNavigation { get; set; }
    }
}
