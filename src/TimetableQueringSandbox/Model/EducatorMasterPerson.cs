using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EducatorMasterPerson
    {
        public EducatorMasterPerson()
        {
            EducatorEmployment = new HashSet<EducatorEmployment>();
            EducatorPerson = new HashSet<EducatorPerson>();
            LocationEducator = new HashSet<LocationEducator>();
        }

        public Guid Oid { get; set; }
        public string UniqueLabel { get; set; }
        public string DisplayName { get; set; }
        public string DisplayNameEnglish { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? Birthday { get; set; }
        public bool? IsImported { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }
        public Guid? ImportSession { get; set; }
        public int Id { get; set; }
        public bool? IsActive { get; set; }
        public string FirstNameEnglish { get; set; }
        public string LastNameEnglish { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual ICollection<EducatorEmployment> EducatorEmployment { get; set; }
        public virtual ICollection<EducatorPerson> EducatorPerson { get; set; }
        public virtual ICollection<LocationEducator> LocationEducator { get; set; }
    }
}
