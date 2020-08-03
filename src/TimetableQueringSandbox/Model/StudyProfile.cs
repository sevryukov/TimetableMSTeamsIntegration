using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyProfile
    {
        public StudyProfile()
        {
            OnlineCourse = new HashSet<OnlineCourse>();
            StudyModule = new HashSet<StudyModule>();
            StudyProfileProfilesContingentUnitContingentUnits = new HashSet<StudyProfileProfilesContingentUnitContingentUnits>();
            StudyProfileProfilesStudyPlanStudyPlans = new HashSet<StudyProfileProfilesStudyPlanStudyPlans>();
            StudyProgramStudyProgramsStudyProfileProfiles = new HashSet<StudyProgramStudyProgramsStudyProfileProfiles>();
        }

        public Guid Oid { get; set; }
        public string DisplayName { get; set; }
        public int? ImportId { get; set; }
        public string Name { get; set; }
        public bool? IsUniversumProfile { get; set; }
        public bool? IsImported { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }
        public Guid? ImportSession { get; set; }
        public string DisplayNameEnglish { get; set; }
        public string NameEnglish { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual ICollection<OnlineCourse> OnlineCourse { get; set; }
        public virtual ICollection<StudyModule> StudyModule { get; set; }
        public virtual ICollection<StudyProfileProfilesContingentUnitContingentUnits> StudyProfileProfilesContingentUnitContingentUnits { get; set; }
        public virtual ICollection<StudyProfileProfilesStudyPlanStudyPlans> StudyProfileProfilesStudyPlanStudyPlans { get; set; }
        public virtual ICollection<StudyProgramStudyProgramsStudyProfileProfiles> StudyProgramStudyProgramsStudyProfileProfiles { get; set; }
    }
}
