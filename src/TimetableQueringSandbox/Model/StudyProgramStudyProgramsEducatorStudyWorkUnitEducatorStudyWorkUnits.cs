using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyProgramStudyProgramsEducatorStudyWorkUnitEducatorStudyWorkUnits
    {
        public Guid? EducatorStudyWorkUnits { get; set; }
        public Guid? StudyPrograms { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual EducatorStudyWorkUnit EducatorStudyWorkUnitsNavigation { get; set; }
        public virtual StudyProgram StudyProgramsNavigation { get; set; }
    }
}
