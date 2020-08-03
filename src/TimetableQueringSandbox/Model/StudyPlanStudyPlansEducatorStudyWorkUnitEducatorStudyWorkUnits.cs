using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyPlanStudyPlansEducatorStudyWorkUnitEducatorStudyWorkUnits
    {
        public Guid? EducatorStudyWorkUnits { get; set; }
        public Guid? StudyPlans { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual EducatorStudyWorkUnit EducatorStudyWorkUnitsNavigation { get; set; }
        public virtual StudyPlan StudyPlansNavigation { get; set; }
    }
}
