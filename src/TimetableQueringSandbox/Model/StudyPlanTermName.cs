using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyPlanTermName
    {
        public StudyPlanTermName()
        {
            EducatorAssignment = new HashSet<EducatorAssignment>();
            EducatorStudyWork = new HashSet<EducatorStudyWork>();
            EducatorStudyWorkUnit = new HashSet<EducatorStudyWorkUnit>();
            OnlinePedUnit = new HashSet<OnlinePedUnit>();
            StudyPlanTerm = new HashSet<StudyPlanTerm>();
            UserInPedUnit = new HashSet<UserInPedUnit>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsFinalAssessment { get; set; }
        public int? Id { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual ICollection<EducatorAssignment> EducatorAssignment { get; set; }
        public virtual ICollection<EducatorStudyWork> EducatorStudyWork { get; set; }
        public virtual ICollection<EducatorStudyWorkUnit> EducatorStudyWorkUnit { get; set; }
        public virtual ICollection<OnlinePedUnit> OnlinePedUnit { get; set; }
        public virtual ICollection<StudyPlanTerm> StudyPlanTerm { get; set; }
        public virtual ICollection<UserInPedUnit> UserInPedUnit { get; set; }
    }
}
