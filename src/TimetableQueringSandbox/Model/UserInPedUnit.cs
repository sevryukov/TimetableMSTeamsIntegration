using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class UserInPedUnit
    {
        public Guid Oid { get; set; }
        public Guid? StudyProgram { get; set; }
        public Guid? StudyPlan { get; set; }
        public Guid? TermName { get; set; }
        public Guid? Discipline { get; set; }
        public Guid? Trajectory { get; set; }
        public Guid? RealizationVariant { get; set; }
        public int? Kind { get; set; }
        public Guid? Puuser { get; set; }
        public string CommentText { get; set; }
        public bool? IsAutoAccepted { get; set; }
        public bool? IsAutoDisAccepted { get; set; }
        public Guid? CommentAuthor { get; set; }
        public Guid? PedUnit { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual OnlinePuuser CommentAuthorNavigation { get; set; }
        public virtual Discipline DisciplineNavigation { get; set; }
        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual OnlinePedUnit PedUnitNavigation { get; set; }
        public virtual OnlinePuuser PuuserNavigation { get; set; }
        public virtual StudyModuleRealizationVariant RealizationVariantNavigation { get; set; }
        public virtual StudyPlan StudyPlanNavigation { get; set; }
        public virtual StudyProgram StudyProgramNavigation { get; set; }
        public virtual StudyPlanTermName TermNameNavigation { get; set; }
        public virtual StudyModuleTrajectory TrajectoryNavigation { get; set; }
    }
}
