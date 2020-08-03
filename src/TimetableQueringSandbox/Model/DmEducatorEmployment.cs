using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class DmEducatorEmployment
    {
        public Guid EducatorId { get; set; }
        public int? EmploymentId { get; set; }
        public string PositionName { get; set; }
        public int? PositionId { get; set; }
        public string DepartmentName { get; set; }
        public int? DepartmentId { get; set; }
        public string DivisionName { get; set; }
        public int? DivisionId { get; set; }
    }
}
