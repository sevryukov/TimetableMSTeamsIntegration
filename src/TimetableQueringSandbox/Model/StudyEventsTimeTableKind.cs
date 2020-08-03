using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyEventsTimeTableKind
    {
        public StudyEventsTimeTableKind()
        {
            BaseTimeTable = new HashSet<BaseTimeTable>();
            EducatorAssignment = new HashSet<EducatorAssignment>();
            Event = new HashSet<Event>();
            StudyEventAppointmentInfo = new HashSet<StudyEventAppointmentInfo>();
            StudyEventsTimeTableClassKind = new HashSet<StudyEventsTimeTableClassKind>();
            StudyModuleWorkKind = new HashSet<StudyModuleWorkKind>();
            StudyModuleWorkUnitKind = new HashSet<StudyModuleWorkUnitKind>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public int? Code { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string NameEnglish { get; set; }

        public virtual ICollection<BaseTimeTable> BaseTimeTable { get; set; }
        public virtual ICollection<EducatorAssignment> EducatorAssignment { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<StudyEventAppointmentInfo> StudyEventAppointmentInfo { get; set; }
        public virtual ICollection<StudyEventsTimeTableClassKind> StudyEventsTimeTableClassKind { get; set; }
        public virtual ICollection<StudyModuleWorkKind> StudyModuleWorkKind { get; set; }
        public virtual ICollection<StudyModuleWorkUnitKind> StudyModuleWorkUnitKind { get; set; }
    }
}
