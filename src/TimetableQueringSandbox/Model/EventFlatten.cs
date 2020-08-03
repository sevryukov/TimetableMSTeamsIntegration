using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EventFlatten
    {
        public Guid Oid { get; set; }
        public int Id { get; set; }
        public short? Index { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public Guid? ContingentUnit { get; set; }
        public Guid? EducatorAssignment { get; set; }
        public string EducatorsDisplayText { get; set; }
        public string EducatorsDisplayTextEnglish { get; set; }
        public string LocationsDisplayText { get; set; }
        public string LocationsDisplayTextEnglish { get; set; }
        public string Subject { get; set; }
        public string SubjectEnglish { get; set; }
        public Guid? StudyEventsTimeTableKind { get; set; }
        public int Properties { get; set; }
        public int? WebAvailability { get; set; }
        public long? Cohort { get; set; }
    }
}
