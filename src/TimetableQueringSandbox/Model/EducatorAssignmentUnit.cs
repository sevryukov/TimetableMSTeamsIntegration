using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EducatorAssignmentUnit
    {
        public EducatorAssignmentUnit()
        {
            LocationEducator = new HashSet<LocationEducator>();
        }

        public Guid Oid { get; set; }
        public Guid? EducatorAssignment { get; set; }
        public Guid? EducatorEmployment { get; set; }
        public Guid? EducatorStudyWorkUnit { get; set; }
        public int? WorkHoursFact { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public bool? IsCommitted { get; set; }
        public int? WorkHoursPlan { get; set; }

        public virtual EducatorAssignment EducatorAssignmentNavigation { get; set; }
        public virtual EducatorEmployment EducatorEmploymentNavigation { get; set; }
        public virtual EducatorStudyWorkUnit EducatorStudyWorkUnitNavigation { get; set; }
        public virtual ICollection<LocationEducator> LocationEducator { get; set; }
    }
}
