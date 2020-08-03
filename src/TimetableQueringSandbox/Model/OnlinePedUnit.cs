using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class OnlinePedUnit
    {
        public OnlinePedUnit()
        {
            UserInPedUnit = new HashSet<UserInPedUnit>();
        }

        public Guid Oid { get; set; }
        public Guid? ImportId { get; set; }
        public Guid? StudyYear { get; set; }
        public Guid? StudyForm { get; set; }
        public Guid? StudyLevel { get; set; }
        public Guid? Division { get; set; }
        public bool? IsCommonStudyLevelProgram { get; set; }
        public bool? IsCommonFacultyProgram { get; set; }
        public bool? IsOnlineCourse { get; set; }
        public bool? IsAllSemester { get; set; }
        public Guid? TermName { get; set; }
        public Guid? Discipline { get; set; }
        public Guid? RealizationVariant { get; set; }
        public Guid? Trajectory { get; set; }
        public Guid? ContactLoadType { get; set; }
        public Guid? StudyProgram { get; set; }
        public Guid? StudyPlan { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual StudyModuleWorkUnitKindContactLoadType ContactLoadTypeNavigation { get; set; }
        public virtual Discipline DisciplineNavigation { get; set; }
        public virtual Division DivisionNavigation { get; set; }
        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual StudyModuleRealizationVariant RealizationVariantNavigation { get; set; }
        public virtual StudyForm StudyFormNavigation { get; set; }
        public virtual StudyLevel StudyLevelNavigation { get; set; }
        public virtual StudyPlan StudyPlanNavigation { get; set; }
        public virtual StudyProgram StudyProgramNavigation { get; set; }
        public virtual StudyYear StudyYearNavigation { get; set; }
        public virtual StudyPlanTermName TermNameNavigation { get; set; }
        public virtual StudyModuleTrajectory TrajectoryNavigation { get; set; }
        public virtual ICollection<UserInPedUnit> UserInPedUnit { get; set; }
    }
}
