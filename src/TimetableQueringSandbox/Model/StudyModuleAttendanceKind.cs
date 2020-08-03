using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyModuleAttendanceKind
    {
        public StudyModuleAttendanceKind()
        {
            Event = new HashSet<Event>();
            StudyModuleWorkUnit = new HashSet<StudyModuleWorkUnit>();
        }

        public Guid Oid { get; set; }
        public string DisplayName { get; set; }
        public string DisplayNameEnglish { get; set; }
        public int? Code { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public bool? IsDisplayed { get; set; }

        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<StudyModuleWorkUnit> StudyModuleWorkUnit { get; set; }
    }
}
