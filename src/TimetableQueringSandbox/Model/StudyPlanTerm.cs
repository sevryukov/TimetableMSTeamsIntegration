using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyPlanTerm
    {
        public StudyPlanTerm()
        {
            OnlineCourse = new HashSet<OnlineCourse>();
            StudyModule = new HashSet<StudyModule>();
        }

        public Guid Oid { get; set; }
        public int? ImportId { get; set; }
        public Guid? StudyPlan { get; set; }
        public Guid? StudyYear { get; set; }
        public int? StudyYearOrdinalNumber { get; set; }
        public bool? IsImported { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? Name { get; set; }
        public Guid? Kind { get; set; }
        public int? ObjectType { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual StudyPlanTermKind KindNavigation { get; set; }
        public virtual StudyPlanTermName NameNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual StudyPlan StudyPlanNavigation { get; set; }
        public virtual StudyYear StudyYearNavigation { get; set; }
        public virtual ICollection<OnlineCourse> OnlineCourse { get; set; }
        public virtual ICollection<StudyModule> StudyModule { get; set; }
    }
}
