using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class WeeklyRecurGenerator
    {
        public byte RecurWeekDays { get; set; }
        public byte RecurStartDayNumber { get; set; }
        public byte RecurStartOffset { get; set; }
        public byte RecurIndexOffset { get; set; }
        public byte WeekNumber { get; set; }
    }
}
