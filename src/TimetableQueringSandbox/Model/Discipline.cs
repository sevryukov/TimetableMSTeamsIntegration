using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class Discipline
    {
        public Discipline()
        {
            EducatorAssignment = new HashSet<EducatorAssignment>();
            EducatorStudyWork = new HashSet<EducatorStudyWork>();
            EducatorStudyWorkUnit = new HashSet<EducatorStudyWorkUnit>();
            OnlinePedUnit = new HashSet<OnlinePedUnit>();
            StudyModule = new HashSet<StudyModule>();
            UserInPedUnit = new HashSet<UserInPedUnit>();
        }

        public Guid Oid { get; set; }
        public int? ImportId { get; set; }
        public int? NameImportId { get; set; }
        public string Name { get; set; }
        public string NameEnglish { get; set; }
        public string Number { get; set; }
        public bool? IsImported { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }
        public Guid? SapDepartment { get; set; }
        public Guid? SapDivision { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual SapDepartment SapDepartmentNavigation { get; set; }
        public virtual SapDivision SapDivisionNavigation { get; set; }
        public virtual ICollection<EducatorAssignment> EducatorAssignment { get; set; }
        public virtual ICollection<EducatorStudyWork> EducatorStudyWork { get; set; }
        public virtual ICollection<EducatorStudyWorkUnit> EducatorStudyWorkUnit { get; set; }
        public virtual ICollection<OnlinePedUnit> OnlinePedUnit { get; set; }
        public virtual ICollection<StudyModule> StudyModule { get; set; }
        public virtual ICollection<UserInPedUnit> UserInPedUnit { get; set; }
    }
}
