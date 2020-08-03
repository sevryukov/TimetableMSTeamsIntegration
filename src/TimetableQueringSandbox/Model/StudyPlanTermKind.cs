using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyPlanTermKind
    {
        public StudyPlanTermKind()
        {
            EducatorAssignment = new HashSet<EducatorAssignment>();
            Event = new HashSet<Event>();
            StudyEventAppointmentInfo = new HashSet<StudyEventAppointmentInfo>();
            StudyEventsTimeTableClass = new HashSet<StudyEventsTimeTableClass>();
            StudyPlanTerm = new HashSet<StudyPlanTerm>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string NameEnglish { get; set; }
        public bool? IsDefault { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual ICollection<EducatorAssignment> EducatorAssignment { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<StudyEventAppointmentInfo> StudyEventAppointmentInfo { get; set; }
        public virtual ICollection<StudyEventsTimeTableClass> StudyEventsTimeTableClass { get; set; }
        public virtual ICollection<StudyPlanTerm> StudyPlanTerm { get; set; }
    }
}
