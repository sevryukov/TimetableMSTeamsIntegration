using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EducatorEmploymentGroup
    {
        public EducatorEmploymentGroup()
        {
            EducatorEmployment = new HashSet<EducatorEmployment>();
        }

        public Guid Oid { get; set; }
        public int? ImportId { get; set; }
        public string Name { get; set; }
        public bool? IsImported { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual ICollection<EducatorEmployment> EducatorEmployment { get; set; }
    }
}
