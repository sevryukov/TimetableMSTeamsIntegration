using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class ContingentUnitStudentGroupsBaseTimeTableStudyEventsTimeTables
    {
        public Guid? StudyEventsTimeTables { get; set; }
        public Guid? StudentGroups { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual ContingentUnit StudentGroupsNavigation { get; set; }
        public virtual BaseTimeTable StudyEventsTimeTablesNavigation { get; set; }
    }
}
