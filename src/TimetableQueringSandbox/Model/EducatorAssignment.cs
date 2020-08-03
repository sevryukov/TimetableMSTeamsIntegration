using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EducatorAssignment
    {
        public EducatorAssignment()
        {
            EducatorAssignmentUnit = new HashSet<EducatorAssignmentUnit>();
            Event = new HashSet<Event>();
            StudyModuleWorkUnitStudyModuleWorkUnitsEducatorAssignmentEducatorAssignments = new HashSet<StudyModuleWorkUnitStudyModuleWorkUnitsEducatorAssignmentEducatorAssignments>();
        }

        public Guid Oid { get; set; }
        public string EducatorEmployment1 { get; set; }
        public string EducatorEmployment2 { get; set; }
        public string EducatorEmployment3 { get; set; }
        public Guid? StudyModuleWorkUnit { get; set; }
        public Guid? ContingentUnit { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? Kind { get; set; }
        public string DisplayName { get; set; }
        public int? ObjectType { get; set; }
        public Guid? TermKind { get; set; }
        public bool? HasStudyEvents { get; set; }
        public string DisplayNameEnglish { get; set; }
        public Guid? TimeTableKind { get; set; }
        public Guid? WorkUnitKind { get; set; }
        public string EducatorEmploymentNames { get; set; }
        public bool? HasCommittedUnits { get; set; }
        public int? WorkHoursFact { get; set; }
        public Guid? Discipline { get; set; }
        public string DisciplineName { get; set; }
        public Guid? Trajectory { get; set; }
        public Guid? RealizationVariant { get; set; }
        public Guid? TermName { get; set; }

        public virtual ContingentUnit ContingentUnitNavigation { get; set; }
        public virtual Discipline DisciplineNavigation { get; set; }
        public virtual EducatorAssignmentKind KindNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual StudyModuleRealizationVariant RealizationVariantNavigation { get; set; }
        public virtual StudyModuleWorkUnit StudyModuleWorkUnitNavigation { get; set; }
        public virtual StudyPlanTermKind TermKindNavigation { get; set; }
        public virtual StudyPlanTermName TermNameNavigation { get; set; }
        public virtual StudyEventsTimeTableKind TimeTableKindNavigation { get; set; }
        public virtual StudyModuleTrajectory TrajectoryNavigation { get; set; }
        public virtual StudyModuleWorkUnitKind WorkUnitKindNavigation { get; set; }
        public virtual ICollection<EducatorAssignmentUnit> EducatorAssignmentUnit { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<StudyModuleWorkUnitStudyModuleWorkUnitsEducatorAssignmentEducatorAssignments> StudyModuleWorkUnitStudyModuleWorkUnitsEducatorAssignmentEducatorAssignments { get; set; }
    }
}
