using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EducatorStudyWorkUnitEducatorStudyWorkUnitsContingentUnitContingentUnitCombinations
    {
        public Guid? ContingentUnitCombinations { get; set; }
        public Guid? EducatorStudyWorkUnits { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual ContingentUnit ContingentUnitCombinationsNavigation { get; set; }
        public virtual EducatorStudyWorkUnit EducatorStudyWorkUnitsNavigation { get; set; }
    }
}
