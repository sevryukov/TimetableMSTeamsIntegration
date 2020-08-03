using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class LocationEducator
    {
        public Guid Oid { get; set; }
        public Guid? StudyEventLocation { get; set; }
        public Guid? EducatorEmployment { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? EventLocation { get; set; }
        public Guid? Educator { get; set; }
        public Guid? EducatorAssignmentUnit { get; set; }

        public virtual EducatorAssignmentUnit EducatorAssignmentUnitNavigation { get; set; }
        public virtual EducatorEmployment EducatorEmploymentNavigation { get; set; }
        public virtual EducatorMasterPerson EducatorNavigation { get; set; }
        public virtual EventLocation EventLocationNavigation { get; set; }
        public virtual EventLocation StudyEventLocationNavigation { get; set; }
    }
}
