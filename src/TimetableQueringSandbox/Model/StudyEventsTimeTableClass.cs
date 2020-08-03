using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyEventsTimeTableClass
    {
        public StudyEventsTimeTableClass()
        {
            BaseTimeTable = new HashSet<BaseTimeTable>();
            StudyEventsTimeTableClassKind = new HashSet<StudyEventsTimeTableClassKind>();
        }

        public Guid Oid { get; set; }
        public string DisplayName { get; set; }
        public Guid? StudyYear { get; set; }
        public Guid? TermKind { get; set; }
        public DateTime? DefaultTermStart { get; set; }
        public DateTime? DefaultTermEnd { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string DisplayNameEnglish { get; set; }

        public virtual StudyYear StudyYearNavigation { get; set; }
        public virtual StudyPlanTermKind TermKindNavigation { get; set; }
        public virtual ICollection<BaseTimeTable> BaseTimeTable { get; set; }
        public virtual ICollection<StudyEventsTimeTableClassKind> StudyEventsTimeTableClassKind { get; set; }
    }
}
