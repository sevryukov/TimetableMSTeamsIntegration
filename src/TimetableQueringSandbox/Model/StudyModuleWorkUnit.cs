using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyModuleWorkUnit
    {
        public StudyModuleWorkUnit()
        {
            EducatorAssignment = new HashSet<EducatorAssignment>();
            StudyModuleWorkUnitStudyModuleWorkUnitsEducatorAssignmentEducatorAssignments = new HashSet<StudyModuleWorkUnitStudyModuleWorkUnitsEducatorAssignmentEducatorAssignments>();
        }

        public Guid Oid { get; set; }
        public string DisplayName { get; set; }
        public Guid? StudyModule { get; set; }
        public bool? IsImported { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }
        public Guid? ControlFormName { get; set; }
        public Guid? ControlFormKind { get; set; }
        public Guid? ControlFormPeriod { get; set; }
        public Guid? ControlFormModuleId { get; set; }
        public Guid? ImportSession { get; set; }
        public Guid? Kind { get; set; }
        public int? WorkHours { get; set; }
        public int? StudCapacityMin { get; set; }
        public int? StudCapacityMax { get; set; }
        public DateTime? ImportedOn { get; set; }
        public DateTime? ReImportedOn { get; set; }
        public string DisplayNameEnglish { get; set; }
        public bool? HasStudyEvents { get; set; }
        public Guid? AttendanceKind { get; set; }

        public virtual StudyModuleAttendanceKind AttendanceKindNavigation { get; set; }
        public virtual StudyModuleControlFormKind ControlFormKindNavigation { get; set; }
        public virtual StudyModuleControlFormName ControlFormNameNavigation { get; set; }
        public virtual StudyModuleControlFormPeriod ControlFormPeriodNavigation { get; set; }
        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual StudyModuleWorkUnitKind KindNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual StudyModule StudyModuleNavigation { get; set; }
        public virtual ICollection<EducatorAssignment> EducatorAssignment { get; set; }
        public virtual ICollection<StudyModuleWorkUnitStudyModuleWorkUnitsEducatorAssignmentEducatorAssignments> StudyModuleWorkUnitStudyModuleWorkUnitsEducatorAssignmentEducatorAssignments { get; set; }
    }
}
