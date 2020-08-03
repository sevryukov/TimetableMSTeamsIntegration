using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class ExtBbEducatorsCourses
    {
        public Guid CourseId { get; set; }
        public string CourseCode { get; set; }
        public Guid UserId { get; set; }
        public string UserCode { get; set; }
    }
}
