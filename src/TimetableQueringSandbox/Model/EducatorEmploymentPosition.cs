using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EducatorEmploymentPosition
    {
        public EducatorEmploymentPosition()
        {
            EducatorEmployment = new HashSet<EducatorEmployment>();
        }

        public Guid Oid { get; set; }
        public string ShortName { get; set; }
        public bool? IsImported { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string NameEnglish { get; set; }
        public string FullName { get; set; }
        public int? ImportId { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual ICollection<EducatorEmployment> EducatorEmployment { get; set; }
    }
}
