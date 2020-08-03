using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EducatorStudyWorkUnit
    {
        public EducatorStudyWorkUnit()
        {
            EducatorAssignmentUnit = new HashSet<EducatorAssignmentUnit>();
            EducatorStudyWorkUnitComment = new HashSet<EducatorStudyWorkUnitComment>();
            EducatorStudyWorkUnitEducatorStudyWorkUnitsContingentUnitContingentUnitCombinations = new HashSet<EducatorStudyWorkUnitEducatorStudyWorkUnitsContingentUnitContingentUnitCombinations>();
            StudyPlanStudyPlansEducatorStudyWorkUnitEducatorStudyWorkUnits = new HashSet<StudyPlanStudyPlansEducatorStudyWorkUnitEducatorStudyWorkUnits>();
            StudyProgramStudyProgramsEducatorStudyWorkUnitEducatorStudyWorkUnits = new HashSet<StudyProgramStudyProgramsEducatorStudyWorkUnitEducatorStudyWorkUnits>();
        }

        public Guid Oid { get; set; }
        public int? EmploymentId { get; set; }
        public Guid? SapDepartment { get; set; }
        public Guid? SapDivision { get; set; }
        public string ContingentString { get; set; }
        public Guid? StudyYear { get; set; }
        public Guid? EducatorStudyWork { get; set; }
        public Guid? EducatorEmployment { get; set; }
        public int? WorkHours { get; set; }
        public int? Order { get; set; }
        public bool? IsCommitted { get; set; }
        public Guid? LastChangeUser { get; set; }
        public DateTime? LastChangeDateTime { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int Id { get; set; }
        public Guid? Division { get; set; }
        public Guid? Discipline { get; set; }
        public Guid? RealizationVariant { get; set; }
        public Guid? Trajectory { get; set; }
        public Guid? TermName { get; set; }
        public Guid? StudyModuleWorkKind { get; set; }
        public string DivisionString { get; set; }
        public int? WorkHoursFact { get; set; }
        public string StudyPlansString { get; set; }
        public string StudyProgramsString { get; set; }

        public virtual Discipline DisciplineNavigation { get; set; }
        public virtual Division DivisionNavigation { get; set; }
        public virtual EducatorEmployment EducatorEmploymentNavigation { get; set; }
        public virtual EducatorStudyWork EducatorStudyWorkNavigation { get; set; }
        public virtual User LastChangeUserNavigation { get; set; }
        public virtual StudyModuleRealizationVariant RealizationVariantNavigation { get; set; }
        public virtual SapDepartment SapDepartmentNavigation { get; set; }
        public virtual SapDivision SapDivisionNavigation { get; set; }
        public virtual StudyModuleWorkKind StudyModuleWorkKindNavigation { get; set; }
        public virtual StudyYear StudyYearNavigation { get; set; }
        public virtual StudyPlanTermName TermNameNavigation { get; set; }
        public virtual StudyModuleTrajectory TrajectoryNavigation { get; set; }
        public virtual ICollection<EducatorAssignmentUnit> EducatorAssignmentUnit { get; set; }
        public virtual ICollection<EducatorStudyWorkUnitComment> EducatorStudyWorkUnitComment { get; set; }
        public virtual ICollection<EducatorStudyWorkUnitEducatorStudyWorkUnitsContingentUnitContingentUnitCombinations> EducatorStudyWorkUnitEducatorStudyWorkUnitsContingentUnitContingentUnitCombinations { get; set; }
        public virtual ICollection<StudyPlanStudyPlansEducatorStudyWorkUnitEducatorStudyWorkUnits> StudyPlanStudyPlansEducatorStudyWorkUnitEducatorStudyWorkUnits { get; set; }
        public virtual ICollection<StudyProgramStudyProgramsEducatorStudyWorkUnitEducatorStudyWorkUnits> StudyProgramStudyProgramsEducatorStudyWorkUnitEducatorStudyWorkUnits { get; set; }
    }
}
