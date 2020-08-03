using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyForm
    {
        public StudyForm()
        {
            EducatorStudyWork = new HashSet<EducatorStudyWork>();
            OnlinePedUnit = new HashSet<OnlinePedUnit>();
            StudyPlan = new HashSet<StudyPlan>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string NameEnglish { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int ImportId { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual ICollection<EducatorStudyWork> EducatorStudyWork { get; set; }
        public virtual ICollection<OnlinePedUnit> OnlinePedUnit { get; set; }
        public virtual ICollection<StudyPlan> StudyPlan { get; set; }
    }
}
