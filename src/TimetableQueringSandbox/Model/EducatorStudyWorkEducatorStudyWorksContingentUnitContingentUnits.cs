using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EducatorStudyWorkEducatorStudyWorksContingentUnitContingentUnits
    {
        public Guid? ContingentUnits { get; set; }
        public Guid? EducatorStudyWorks { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual ContingentUnit ContingentUnitsNavigation { get; set; }
        public virtual EducatorStudyWork EducatorStudyWorksNavigation { get; set; }
    }
}
