using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyProfileProfilesStudyPlanStudyPlans
    {
        public Guid? StudyPlans { get; set; }
        public Guid? Profiles { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual StudyProfile ProfilesNavigation { get; set; }
        public virtual StudyPlan StudyPlansNavigation { get; set; }
    }
}
