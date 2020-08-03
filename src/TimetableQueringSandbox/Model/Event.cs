using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class Event
    {
        public Event()
        {
            EventLocation = new HashSet<EventLocation>();
            InverseMasterEventNavigation = new HashSet<Event>();
            InversePatternEventNavigation = new HashSet<Event>();
            StudyEventAppointmentInfo = new HashSet<StudyEventAppointmentInfo>();
        }

        public Guid Oid { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? EducatorAssignment { get; set; }
        public int? LabelId { get; set; }
        public Guid? ContingentUnit { get; set; }
        public string Subject { get; set; }
        public string LocationsDisplayText { get; set; }
        public string EducatorsDisplayText { get; set; }
        public string InternalDescription { get; set; }
        public Guid? Division { get; set; }
        public Guid? TermKind { get; set; }
        public Guid? Kind { get; set; }
        public int? ObjectType { get; set; }
        public Guid? StudyEventsTimeTableKind { get; set; }
        public int? Type { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ResourceIds { get; set; }
        public string SubjectEnglish { get; set; }
        public string LocationsDisplayTextEnglish { get; set; }
        public string EducatorsDisplayTextEnglish { get; set; }
        public string EducatorsShortDisplayText { get; set; }
        public string EducatorsShortDisplayTextEnglish { get; set; }
        public Guid? PatternEvent { get; set; }
        public Guid? Subkind { get; set; }
        public Guid? TimeTable { get; set; }
        public Guid? MasterEvent { get; set; }
        public string ResponsiblePersonContacts { get; set; }
        public string DescriptionShort { get; set; }
        public string DescriptionLong { get; set; }
        public Guid? XtracurImageAttachment { get; set; }
        public Guid? XtracurAddress { get; set; }
        public int Id { get; set; }
        public int? WebAvailability { get; set; }
        public bool? IsImported { get; set; }
        public Guid? ImportOid { get; set; }
        public Guid? ImportSession { get; set; }
        public Guid? LastChangeUser { get; set; }
        public DateTime? LastChangeDateTime { get; set; }
        public int? Status { get; set; }
        public DateTime? AssignedDateTime { get; set; }
        public bool? ShowEndTimeOnWeb { get; set; }
        public Guid? Sequence { get; set; }
        public bool? Locked { get; set; }
        public Guid? AttendanceKind { get; set; }
        public Guid? Trajectory { get; set; }
        public long? Cohort { get; set; }
        public int Properties { get; set; }
        public Guid? RecurId { get; set; }
        public short? RecurIndex { get; set; }
        public DateTime? IssuedDateTime { get; set; }

        public virtual StudyModuleAttendanceKind AttendanceKindNavigation { get; set; }
        public virtual ContingentUnit ContingentUnitNavigation { get; set; }
        public virtual EducatorAssignment EducatorAssignmentNavigation { get; set; }
        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual EventKind KindNavigation { get; set; }
        public virtual User LastChangeUserNavigation { get; set; }
        public virtual Event MasterEventNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual Event PatternEventNavigation { get; set; }
        public virtual EventSequence SequenceNavigation { get; set; }
        public virtual StudyEventsTimeTableKind StudyEventsTimeTableKindNavigation { get; set; }
        public virtual EventSubkind SubkindNavigation { get; set; }
        public virtual StudyPlanTermKind TermKindNavigation { get; set; }
        public virtual BaseTimeTable TimeTableNavigation { get; set; }
        public virtual StudyModuleTrajectory TrajectoryNavigation { get; set; }
        public virtual Address XtracurAddressNavigation { get; set; }
        public virtual XtracurImageAttachment XtracurImageAttachmentNavigation { get; set; }
        public virtual ICollection<EventLocation> EventLocation { get; set; }
        public virtual ICollection<Event> InverseMasterEventNavigation { get; set; }
        public virtual ICollection<Event> InversePatternEventNavigation { get; set; }
        public virtual ICollection<StudyEventAppointmentInfo> StudyEventAppointmentInfo { get; set; }
    }
}
