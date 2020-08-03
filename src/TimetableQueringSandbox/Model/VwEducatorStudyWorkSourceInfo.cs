using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class VwEducatorStudyWorkSourceInfo
    {
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
        public int? StudyYearImportId { get; set; }
        public int? DisciplineImportId { get; set; }
        public int? RealizationVariantId { get; set; }
        public int? TrajectoryId { get; set; }
        public int StudyFormImportId { get; set; }
        public int? StudyPlanTermNameId { get; set; }
        public int? StudyModuleWorkKindId { get; set; }
    }
}
