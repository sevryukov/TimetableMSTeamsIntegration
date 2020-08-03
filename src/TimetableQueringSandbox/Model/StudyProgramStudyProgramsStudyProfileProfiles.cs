using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyProgramStudyProgramsStudyProfileProfiles
    {
        public Guid? Profiles { get; set; }
        public Guid? StudyPrograms { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual StudyProfile ProfilesNavigation { get; set; }
        public virtual StudyProgram StudyProgramsNavigation { get; set; }
    }
}
