using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyPlan
    {
        public StudyPlan()
        {
            ContingentUnit = new HashSet<ContingentUnit>();
            OnlineCourse = new HashSet<OnlineCourse>();
            OnlinePedUnit = new HashSet<OnlinePedUnit>();
            StudyPlanStudyPlansEducatorStudyWorkUnitEducatorStudyWorkUnits = new HashSet<StudyPlanStudyPlansEducatorStudyWorkUnitEducatorStudyWorkUnits>();
            StudyPlanTerm = new HashSet<StudyPlanTerm>();
            StudyProfileProfilesStudyPlanStudyPlans = new HashSet<StudyProfileProfilesStudyPlanStudyPlans>();
            UserInPedUnit = new HashSet<UserInPedUnit>();
        }

        public Guid Oid { get; set; }
        public int? ImportId { get; set; }
        public Guid? StudyProgram { get; set; }
        public string EducationPeriodName { get; set; }
        public Guid? AdmissionYear { get; set; }
        public string RegistrationNumber { get; set; }
        public bool? IsImported { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string DisplayName { get; set; }
        public Guid? StudyForm { get; set; }
        public int? ObjectType { get; set; }
        public Guid? ImportOid { get; set; }

        public virtual StudyYear AdmissionYearNavigation { get; set; }
        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual StudyForm StudyFormNavigation { get; set; }
        public virtual StudyProgram StudyProgramNavigation { get; set; }
        public virtual UserStudyPlan UserStudyPlan { get; set; }
        public virtual ICollection<ContingentUnit> ContingentUnit { get; set; }
        public virtual ICollection<OnlineCourse> OnlineCourse { get; set; }
        public virtual ICollection<OnlinePedUnit> OnlinePedUnit { get; set; }
        public virtual ICollection<StudyPlanStudyPlansEducatorStudyWorkUnitEducatorStudyWorkUnits> StudyPlanStudyPlansEducatorStudyWorkUnitEducatorStudyWorkUnits { get; set; }
        public virtual ICollection<StudyPlanTerm> StudyPlanTerm { get; set; }
        public virtual ICollection<StudyProfileProfilesStudyPlanStudyPlans> StudyProfileProfilesStudyPlanStudyPlans { get; set; }
        public virtual ICollection<UserInPedUnit> UserInPedUnit { get; set; }
    }
}
