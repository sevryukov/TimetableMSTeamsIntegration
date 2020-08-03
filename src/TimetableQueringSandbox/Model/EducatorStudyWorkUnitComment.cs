using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EducatorStudyWorkUnitComment
    {
        public Guid Oid { get; set; }
        public Guid? EducatorStudyWorkUnit { get; set; }
        public string Comment { get; set; }
        public Guid? Author { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ObjectType { get; set; }

        public virtual User AuthorNavigation { get; set; }
        public virtual EducatorStudyWorkUnit EducatorStudyWorkUnitNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
    }
}
