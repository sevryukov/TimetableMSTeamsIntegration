using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class ContingentUnitStudentGroupsContingentUnitContingentUnitCombinations
    {
        public Guid? ContingentUnitCombinations { get; set; }
        public Guid? StudentGroups { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual ContingentUnit ContingentUnitCombinationsNavigation { get; set; }
        public virtual ContingentUnit StudentGroupsNavigation { get; set; }
    }
}
