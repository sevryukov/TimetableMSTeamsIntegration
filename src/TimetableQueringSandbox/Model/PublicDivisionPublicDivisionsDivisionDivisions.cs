using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class PublicDivisionPublicDivisionsDivisionDivisions
    {
        public Guid? Divisions { get; set; }
        public Guid? PublicDivisions { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual Division DivisionsNavigation { get; set; }
        public virtual PublicDivision PublicDivisionsNavigation { get; set; }
    }
}
