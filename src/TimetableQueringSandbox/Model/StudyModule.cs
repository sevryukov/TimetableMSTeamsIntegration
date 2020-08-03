using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyModule
    {
        public StudyModule()
        {
            OnlineCourseNavigation = new HashSet<OnlineCourse>();
            StudyModuleAllowedStudyModulesContingentUnitContingentUnitCombinations = new HashSet<StudyModuleAllowedStudyModulesContingentUnitContingentUnitCombinations>();
            StudyModuleWorkUnit = new HashSet<StudyModuleWorkUnit>();
        }

        public Guid Oid { get; set; }
        public Guid? Profile { get; set; }
        public Guid? StudyPlanTerm { get; set; }
        public string DisciplineName { get; set; }
        public string DisciplineNumber { get; set; }
        public Guid? Trajectory { get; set; }
        public Guid? RealizationVariant { get; set; }
        public bool? IsFacultative { get; set; }
        public bool? IsVariativePart { get; set; }
        public bool? IsImported { get; set; }
        public int? ActualStatus { get; set; }
        public string ActualStatusComment { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }
        public Guid? ImportId { get; set; }
        public Guid? ImportSession { get; set; }
        public int? StudyModuleWorkId { get; set; }
        public int? DisciplineId { get; set; }
        public DateTime? ImportedOn { get; set; }
        public DateTime? ReImportedOn { get; set; }
        public string DisciplineNameEnglish { get; set; }
        public bool? HasStudyEvents { get; set; }
        public string BlackBoardCode { get; set; }
        public int? ElectiveDisciplinesCount { get; set; }
        public Guid? Discipline { get; set; }
        public Guid? OnlineCourse { get; set; }

        public virtual Discipline DisciplineNavigation { get; set; }
        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual OnlineCourse OnlineCourse1 { get; set; }
        public virtual StudyProfile ProfileNavigation { get; set; }
        public virtual StudyModuleRealizationVariant RealizationVariantNavigation { get; set; }
        public virtual StudyPlanTerm StudyPlanTermNavigation { get; set; }
        public virtual StudyModuleTrajectory TrajectoryNavigation { get; set; }
        public virtual ICollection<OnlineCourse> OnlineCourseNavigation { get; set; }
        public virtual ICollection<StudyModuleAllowedStudyModulesContingentUnitContingentUnitCombinations> StudyModuleAllowedStudyModulesContingentUnitContingentUnitCombinations { get; set; }
        public virtual ICollection<StudyModuleWorkUnit> StudyModuleWorkUnit { get; set; }
    }
}
