using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class UserStudyPlan
    {
        public Guid Oid { get; set; }

        public virtual StudyPlan O { get; set; }
    }
}
