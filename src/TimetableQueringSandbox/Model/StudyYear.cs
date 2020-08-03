using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyYear
    {
        public StudyYear()
        {
            BaseTimeTableContingentUnitAdmissionYearNavigation = new HashSet<BaseTimeTable>();
            BaseTimeTableStudyYearNavigation = new HashSet<BaseTimeTable>();
            ContingentUnitAdmissionYearNavigation = new HashSet<ContingentUnit>();
            ContingentUnitCurrentStudyYearNavigation = new HashSet<ContingentUnit>();
            EducatorStudyWork = new HashSet<EducatorStudyWork>();
            EducatorStudyWorkUnit = new HashSet<EducatorStudyWorkUnit>();
            OnlineCourse = new HashSet<OnlineCourse>();
            OnlinePedUnit = new HashSet<OnlinePedUnit>();
            StudyEventsTimeTableClass = new HashSet<StudyEventsTimeTableClass>();
            StudyPlan = new HashSet<StudyPlan>();
            StudyPlanTerm = new HashSet<StudyPlanTerm>();
            StudyProgram = new HashSet<StudyProgram>();
        }

        public Guid Oid { get; set; }
        public string DisplayName { get; set; }
        public int? ImportId { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
        public bool? IsIntercalary { get; set; }
        public bool? IsCurrent { get; set; }
        public bool? IsImported { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string DisplayNameEnglish { get; set; }
        public bool? IsWebAvailable { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual ICollection<BaseTimeTable> BaseTimeTableContingentUnitAdmissionYearNavigation { get; set; }
        public virtual ICollection<BaseTimeTable> BaseTimeTableStudyYearNavigation { get; set; }
        public virtual ICollection<ContingentUnit> ContingentUnitAdmissionYearNavigation { get; set; }
        public virtual ICollection<ContingentUnit> ContingentUnitCurrentStudyYearNavigation { get; set; }
        public virtual ICollection<EducatorStudyWork> EducatorStudyWork { get; set; }
        public virtual ICollection<EducatorStudyWorkUnit> EducatorStudyWorkUnit { get; set; }
        public virtual ICollection<OnlineCourse> OnlineCourse { get; set; }
        public virtual ICollection<OnlinePedUnit> OnlinePedUnit { get; set; }
        public virtual ICollection<StudyEventsTimeTableClass> StudyEventsTimeTableClass { get; set; }
        public virtual ICollection<StudyPlan> StudyPlan { get; set; }
        public virtual ICollection<StudyPlanTerm> StudyPlanTerm { get; set; }
        public virtual ICollection<StudyProgram> StudyProgram { get; set; }
    }
}
