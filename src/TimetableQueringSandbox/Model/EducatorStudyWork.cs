using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EducatorStudyWork
    {
        public EducatorStudyWork()
        {
            EducatorStudyWorkEducatorStudyWorksContingentUnitContingentUnits = new HashSet<EducatorStudyWorkEducatorStudyWorksContingentUnitContingentUnits>();
            EducatorStudyWorkUnit = new HashSet<EducatorStudyWorkUnit>();
        }

        public Guid Oid { get; set; }
        public int? WorkHoursByContingent { get; set; }
        public int? WorkHoursByEducatorStudyWorkUnits { get; set; }
        public int? WorkHoursRemaining { get; set; }
        public Guid? Division { get; set; }
        public Guid? SapDivision { get; set; }
        public Guid? StudyYear { get; set; }
        public Guid? Discipline { get; set; }
        public Guid? RealizationVariant { get; set; }
        public Guid? Trajectory { get; set; }
        public Guid? TermName { get; set; }
        public Guid? StudyModuleWorkKind { get; set; }
        public Guid? ImportId { get; set; }
        public int? WorkHours { get; set; }
        public string Name { get; set; }
        public int? HeadCount { get; set; }
        public string Author { get; set; }
        public bool? IsImported { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string Comment { get; set; }
        public Guid? StudyForm { get; set; }
        public string BlackBoardCode { get; set; }
        public bool? IsArchived { get; set; }

        public virtual Discipline DisciplineNavigation { get; set; }
        public virtual Division DivisionNavigation { get; set; }
        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual StudyModuleRealizationVariant RealizationVariantNavigation { get; set; }
        public virtual SapDivision SapDivisionNavigation { get; set; }
        public virtual StudyForm StudyFormNavigation { get; set; }
        public virtual StudyModuleWorkKind StudyModuleWorkKindNavigation { get; set; }
        public virtual StudyYear StudyYearNavigation { get; set; }
        public virtual StudyPlanTermName TermNameNavigation { get; set; }
        public virtual StudyModuleTrajectory TrajectoryNavigation { get; set; }
        public virtual ICollection<EducatorStudyWorkEducatorStudyWorksContingentUnitContingentUnits> EducatorStudyWorkEducatorStudyWorksContingentUnitContingentUnits { get; set; }
        public virtual ICollection<EducatorStudyWorkUnit> EducatorStudyWorkUnit { get; set; }
    }
}
