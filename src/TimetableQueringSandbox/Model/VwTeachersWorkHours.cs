using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class VwTeachersWorkHours
    {
        public int? TeacherSapid { get; set; }
        public int? EmploymentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? Birthday { get; set; }
        public Guid? StudyPlanId { get; set; }
        public string StudyPlanNumber { get; set; }
        public int? StudyProgramId { get; set; }
        public string StudyProgramNumber { get; set; }
        public string StudyProgramName { get; set; }
        public int? DisciplineId { get; set; }
        public string DisciplineName { get; set; }
        public int? RealizationVariantId { get; set; }
        public string RealizationVariantName { get; set; }
        public int? TrajectoryId { get; set; }
        public string TrajectoryName { get; set; }
        public int? TermId { get; set; }
        public string TermName { get; set; }
        public int? YearId { get; set; }
        public string YearName { get; set; }
        public int? StudyWorkId { get; set; }
        public string StudyWorkName { get; set; }
        public int? WorkHours { get; set; }
        public int? WorkHoursFact { get; set; }
    }
}
