using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyEventAppointmentInfo
    {
        public Guid Oid { get; set; }
        public Guid? ContingentUnit { get; set; }
        public Guid? TimeTableKind { get; set; }
        public Guid? TermKind { get; set; }
        public int? AppointmentType { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? TimeEvent { get; set; }

        public virtual ContingentUnit ContingentUnitNavigation { get; set; }
        public virtual StudyPlanTermKind TermKindNavigation { get; set; }
        public virtual Event TimeEventNavigation { get; set; }
        public virtual StudyEventsTimeTableKind TimeTableKindNavigation { get; set; }
    }
}
