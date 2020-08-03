using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class BaseTimeTable
    {
        public BaseTimeTable()
        {
            ContingentUnitRelatedContingentUnitCombinationsBaseTimeTableStudyEventsTimeTables = new HashSet<ContingentUnitRelatedContingentUnitCombinationsBaseTimeTableStudyEventsTimeTables>();
            ContingentUnitStudentGroupsBaseTimeTableStudyEventsTimeTables = new HashSet<ContingentUnitStudentGroupsBaseTimeTableStudyEventsTimeTables>();
            Event = new HashSet<Event>();
            LocationLocationsBaseTimeTableLocationsTimeTables = new HashSet<LocationLocationsBaseTimeTableLocationsTimeTables>();
            StudyEventsTimeTableSpreadsheet = new HashSet<StudyEventsTimeTableSpreadsheet>();
            StudyProgramStudyProgramsBaseTimeTableTimeTables = new HashSet<StudyProgramStudyProgramsBaseTimeTableTimeTables>();
            UserSelectedContingentUnitInTimeTable = new HashSet<UserSelectedContingentUnitInTimeTable>();
            UserSelectedDaysInTimeTable = new HashSet<UserSelectedDaysInTimeTable>();
        }

        public Guid Oid { get; set; }
        public string DisplayName { get; set; }
        public Guid? StudyYear { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string StudyProgramsDisplayName { get; set; }
        public bool? IsArchived { get; set; }
        public bool? HasEvents { get; set; }
        public int? ObjectType { get; set; }
        public string ContingentUnitCourse { get; set; }
        public Guid? StudyEventsTimeTableKind { get; set; }
        public Guid? ContingentUnitAdmissionYear { get; set; }
        public Guid? ContingentUnitDivision { get; set; }
        public Guid? TimeScaleStepKind { get; set; }
        public double? TimeScaleStart { get; set; }
        public double? TimeScaleEnd { get; set; }
        public bool? HasContingentUnits { get; set; }
        public Guid? Class { get; set; }
        public Guid? StudyEventDefaultDurationKind { get; set; }
        public Guid? Division { get; set; }
        public Guid? Kind { get; set; }
        public Guid? EventKind { get; set; }

        public virtual StudyEventsTimeTableClass ClassNavigation { get; set; }
        public virtual StudyYear ContingentUnitAdmissionYearNavigation { get; set; }
        public virtual Division ContingentUnitDivisionNavigation { get; set; }
        public virtual Division DivisionNavigation { get; set; }
        public virtual EventKind EventKindNavigation { get; set; }
        public virtual BaseTimeTableKind KindNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual StudyEventDurationKind StudyEventDefaultDurationKindNavigation { get; set; }
        public virtual StudyEventsTimeTableKind StudyEventsTimeTableKindNavigation { get; set; }
        public virtual StudyYear StudyYearNavigation { get; set; }
        public virtual TimeScaleStepKind TimeScaleStepKindNavigation { get; set; }
        public virtual ICollection<ContingentUnitRelatedContingentUnitCombinationsBaseTimeTableStudyEventsTimeTables> ContingentUnitRelatedContingentUnitCombinationsBaseTimeTableStudyEventsTimeTables { get; set; }
        public virtual ICollection<ContingentUnitStudentGroupsBaseTimeTableStudyEventsTimeTables> ContingentUnitStudentGroupsBaseTimeTableStudyEventsTimeTables { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<LocationLocationsBaseTimeTableLocationsTimeTables> LocationLocationsBaseTimeTableLocationsTimeTables { get; set; }
        public virtual ICollection<StudyEventsTimeTableSpreadsheet> StudyEventsTimeTableSpreadsheet { get; set; }
        public virtual ICollection<StudyProgramStudyProgramsBaseTimeTableTimeTables> StudyProgramStudyProgramsBaseTimeTableTimeTables { get; set; }
        public virtual ICollection<UserSelectedContingentUnitInTimeTable> UserSelectedContingentUnitInTimeTable { get; set; }
        public virtual ICollection<UserSelectedDaysInTimeTable> UserSelectedDaysInTimeTable { get; set; }
    }
}
