using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EducatorEmployment
    {
        public EducatorEmployment()
        {
            EducatorAssignmentUnit = new HashSet<EducatorAssignmentUnit>();
            EducatorStudyWorkUnit = new HashSet<EducatorStudyWorkUnit>();
            LocationEducator = new HashSet<LocationEducator>();
        }

        public Guid Oid { get; set; }
        public string DisplayName { get; set; }
        public string ShortDisplayName { get; set; }
        public Guid? Position { get; set; }
        public Guid? EducatorPerson { get; set; }
        public Guid? SapDepartment { get; set; }
        public Guid? SapDivision { get; set; }
        public bool? IsImported { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }
        public int? EmploymentId { get; set; }
        public Guid? Category { get; set; }
        public Guid? ImportSession { get; set; }
        public string ShortDisplayNameEnglish { get; set; }
        public string DisplayNameEnglish { get; set; }
        public int Id { get; set; }
        public Guid? EducatorMasterPerson { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? IsActive { get; set; }
        public Guid? Group { get; set; }
        public double? Percent { get; set; }

        public virtual EducatorEmploymentCategory CategoryNavigation { get; set; }
        public virtual EducatorMasterPerson EducatorMasterPersonNavigation { get; set; }
        public virtual EducatorPerson EducatorPersonNavigation { get; set; }
        public virtual EducatorEmploymentGroup GroupNavigation { get; set; }
        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual EducatorEmploymentPosition PositionNavigation { get; set; }
        public virtual SapDepartment SapDepartmentNavigation { get; set; }
        public virtual SapDivision SapDivisionNavigation { get; set; }
        public virtual ICollection<EducatorAssignmentUnit> EducatorAssignmentUnit { get; set; }
        public virtual ICollection<EducatorStudyWorkUnit> EducatorStudyWorkUnit { get; set; }
        public virtual ICollection<LocationEducator> LocationEducator { get; set; }
    }
}
