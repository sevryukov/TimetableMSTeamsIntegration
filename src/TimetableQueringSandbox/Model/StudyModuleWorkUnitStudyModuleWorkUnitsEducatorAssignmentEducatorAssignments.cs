using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyModuleWorkUnitStudyModuleWorkUnitsEducatorAssignmentEducatorAssignments
    {
        public Guid? EducatorAssignments { get; set; }
        public Guid? StudyModuleWorkUnits { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual EducatorAssignment EducatorAssignmentsNavigation { get; set; }
        public virtual StudyModuleWorkUnit StudyModuleWorkUnitsNavigation { get; set; }
    }
}
