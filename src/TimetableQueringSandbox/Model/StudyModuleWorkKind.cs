using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyModuleWorkKind
    {
        public StudyModuleWorkKind()
        {
            EducatorStudyWork = new HashSet<EducatorStudyWork>();
            EducatorStudyWorkUnit = new HashSet<EducatorStudyWorkUnit>();
            StudyModuleWorkUnitKind = new HashSet<StudyModuleWorkUnitKind>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public int? ImportId { get; set; }
        public Guid? TimeTableKind { get; set; }
        public Guid? ContactLoadType { get; set; }
        public bool? IsImported { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public bool IsArchived { get; set; }

        public virtual StudyModuleWorkUnitKindContactLoadType ContactLoadTypeNavigation { get; set; }
        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual StudyEventsTimeTableKind TimeTableKindNavigation { get; set; }
        public virtual ICollection<EducatorStudyWork> EducatorStudyWork { get; set; }
        public virtual ICollection<EducatorStudyWorkUnit> EducatorStudyWorkUnit { get; set; }
        public virtual ICollection<StudyModuleWorkUnitKind> StudyModuleWorkUnitKind { get; set; }
    }
}
