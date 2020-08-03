using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class OnlineCourse
    {
        public OnlineCourse()
        {
            StudyModule1 = new HashSet<StudyModule>();
        }

        public Guid Oid { get; set; }
        public Guid? StudyYear { get; set; }
        public Guid? StudyPlan { get; set; }
        public Guid? StudyPlanTerm { get; set; }
        public Guid? StudyProfile { get; set; }
        public Guid? Trajectory { get; set; }
        public Guid? RealizationVariant { get; set; }
        public Guid? StudyModule { get; set; }
        public string OnlineCourseUrl { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual StudyModuleRealizationVariant RealizationVariantNavigation { get; set; }
        public virtual StudyModule StudyModuleNavigation { get; set; }
        public virtual StudyPlan StudyPlanNavigation { get; set; }
        public virtual StudyPlanTerm StudyPlanTermNavigation { get; set; }
        public virtual StudyProfile StudyProfileNavigation { get; set; }
        public virtual StudyYear StudyYearNavigation { get; set; }
        public virtual StudyModuleTrajectory TrajectoryNavigation { get; set; }
        public virtual ICollection<StudyModule> StudyModule1 { get; set; }
    }
}
