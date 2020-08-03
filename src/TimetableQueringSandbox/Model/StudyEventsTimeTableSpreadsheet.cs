using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyEventsTimeTableSpreadsheet
    {
        public int Oid { get; set; }
        public Guid? StudyEventsTimeTable { get; set; }
        public byte[] StreamData { get; set; }
        public Guid StreamId { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual BaseTimeTable StudyEventsTimeTableNavigation { get; set; }
    }
}
