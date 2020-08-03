using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EducatorPerson
    {
        public EducatorPerson()
        {
            EducatorEmployment = new HashSet<EducatorEmployment>();
        }

        public Guid Oid { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? IsImported { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }
        public int? PersonId { get; set; }
        public Guid? Title { get; set; }
        public Guid? ImportSession { get; set; }
        public Guid? MasterPerson { get; set; }
        public string Login { get; set; }
        public Guid? Degree { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? IsActive { get; set; }
        public string LastNameEnglish { get; set; }
        public string FirstNameEnglish { get; set; }

        public virtual EducatorPersonDegree DegreeNavigation { get; set; }
        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual EducatorMasterPerson MasterPersonNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual EducatorPersonTitle TitleNavigation { get; set; }
        public virtual ICollection<EducatorEmployment> EducatorEmployment { get; set; }
    }
}
