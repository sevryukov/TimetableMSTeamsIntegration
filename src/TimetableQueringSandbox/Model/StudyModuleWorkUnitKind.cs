using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyModuleWorkUnitKind
    {
        public StudyModuleWorkUnitKind()
        {
            EducatorAssignment = new HashSet<EducatorAssignment>();
            StudyModuleWorkUnit = new HashSet<StudyModuleWorkUnit>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public bool? IsImported { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string NameEnglish { get; set; }
        public Guid? TimeTableKind { get; set; }
        public string ShortName { get; set; }
        public string ShortNameEnglish { get; set; }
        public Guid? ContactLoadType { get; set; }
        public bool? IsNameVisible { get; set; }
        public bool? IsNameOverrideDisciplineName { get; set; }
        public Guid? StudyModuleWorkKind { get; set; }
        public double? WorkHoursFactor { get; set; }
        public int Properties { get; set; }

        public virtual StudyModuleWorkUnitKindContactLoadType ContactLoadTypeNavigation { get; set; }
        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual StudyModuleWorkKind StudyModuleWorkKindNavigation { get; set; }
        public virtual StudyEventsTimeTableKind TimeTableKindNavigation { get; set; }
        public virtual ICollection<EducatorAssignment> EducatorAssignment { get; set; }
        public virtual ICollection<StudyModuleWorkUnit> StudyModuleWorkUnit { get; set; }
    }
}
