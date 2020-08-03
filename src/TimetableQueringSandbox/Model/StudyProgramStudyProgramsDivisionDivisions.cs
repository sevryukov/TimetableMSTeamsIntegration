using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyProgramStudyProgramsDivisionDivisions
    {
        public Guid? Divisions { get; set; }
        public Guid? StudyPrograms { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual Division DivisionsNavigation { get; set; }
        public virtual StudyProgram StudyProgramsNavigation { get; set; }
    }
}
