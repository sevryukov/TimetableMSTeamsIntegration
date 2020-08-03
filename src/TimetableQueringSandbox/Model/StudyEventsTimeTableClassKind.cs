using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyEventsTimeTableClassKind
    {
        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string NameEnglish { get; set; }
        public Guid? TimeTableClass { get; set; }
        public Guid? TimeTableKind { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual StudyEventsTimeTableClass TimeTableClassNavigation { get; set; }
        public virtual StudyEventsTimeTableKind TimeTableKindNavigation { get; set; }
    }
}
