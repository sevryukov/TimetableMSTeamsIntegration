using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class Recurrence
    {
        public Guid? Event { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public short? Index { get; set; }
    }
}
