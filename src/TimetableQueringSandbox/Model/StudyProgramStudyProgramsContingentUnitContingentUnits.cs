using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyProgramStudyProgramsContingentUnitContingentUnits
    {
        public Guid? ContingentUnits { get; set; }
        public Guid? StudyPrograms { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual ContingentUnit ContingentUnitsNavigation { get; set; }
        public virtual StudyProgram StudyProgramsNavigation { get; set; }
    }
}
