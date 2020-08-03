using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class SapDivision
    {
        public SapDivision()
        {
            Discipline = new HashSet<Discipline>();
            EducatorEmployment = new HashSet<EducatorEmployment>();
            EducatorStudyWork = new HashSet<EducatorStudyWork>();
            EducatorStudyWorkUnit = new HashSet<EducatorStudyWorkUnit>();
            SapDepartment = new HashSet<SapDepartment>();
            SecuritySystemRole = new HashSet<SecuritySystemRole>();
        }

        public Guid Oid { get; set; }
        public string ShortName { get; set; }
        public bool? IsImported { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ImportId { get; set; }
        public string FullName { get; set; }
        public bool? IsStudy { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual ICollection<Discipline> Discipline { get; set; }
        public virtual ICollection<EducatorEmployment> EducatorEmployment { get; set; }
        public virtual ICollection<EducatorStudyWork> EducatorStudyWork { get; set; }
        public virtual ICollection<EducatorStudyWorkUnit> EducatorStudyWorkUnit { get; set; }
        public virtual ICollection<SapDepartment> SapDepartment { get; set; }
        public virtual ICollection<SecuritySystemRole> SecuritySystemRole { get; set; }
    }
}
