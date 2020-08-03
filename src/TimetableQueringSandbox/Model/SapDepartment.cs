using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class SapDepartment
    {
        public SapDepartment()
        {
            Discipline = new HashSet<Discipline>();
            EducatorEmployment = new HashSet<EducatorEmployment>();
            EducatorStudyWorkUnit = new HashSet<EducatorStudyWorkUnit>();
        }

        public Guid Oid { get; set; }
        public string ShortName { get; set; }
        public bool? IsImported { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ImportId { get; set; }
        public string FullName { get; set; }
        public Guid? SapDivision { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual SapDivision SapDivisionNavigation { get; set; }
        public virtual ICollection<Discipline> Discipline { get; set; }
        public virtual ICollection<EducatorEmployment> EducatorEmployment { get; set; }
        public virtual ICollection<EducatorStudyWorkUnit> EducatorStudyWorkUnit { get; set; }
    }
}
