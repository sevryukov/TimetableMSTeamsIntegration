using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class ExtBbGroupsCourses
    {
        public Guid CourseId { get; set; }
        public string CourseCode { get; set; }
        public int? GroupId { get; set; }
        public string GroupName { get; set; }
        public int? Year { get; set; }
        public int? YearId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
