using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyProgramStudyProgramsBaseTimeTableTimeTables
    {
        public Guid? TimeTables { get; set; }
        public Guid? StudyPrograms { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual StudyProgram StudyProgramsNavigation { get; set; }
        public virtual BaseTimeTable TimeTablesNavigation { get; set; }
    }
}
