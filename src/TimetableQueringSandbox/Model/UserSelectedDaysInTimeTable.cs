using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class UserSelectedDaysInTimeTable
    {
        public Guid Oid { get; set; }
        public Guid? User { get; set; }
        public int? WeekDays { get; set; }
        public Guid? TimeTable { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual BaseTimeTable TimeTableNavigation { get; set; }
        public virtual User UserNavigation { get; set; }
    }
}
