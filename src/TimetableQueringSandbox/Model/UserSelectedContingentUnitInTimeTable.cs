using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class UserSelectedContingentUnitInTimeTable
    {
        public Guid Oid { get; set; }
        public Guid? User { get; set; }
        public Guid? ContingentUnit { get; set; }
        public Guid? TimeTable { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual ContingentUnit ContingentUnitNavigation { get; set; }
        public virtual BaseTimeTable TimeTableNavigation { get; set; }
        public virtual User UserNavigation { get; set; }
    }
}
