using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class DivisionDivisionsContingentUnitContingentUnitCombinations
    {
        public Guid? ContingentUnitCombinations { get; set; }
        public Guid? Divisions { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual ContingentUnit ContingentUnitCombinationsNavigation { get; set; }
        public virtual Division DivisionsNavigation { get; set; }
    }
}
