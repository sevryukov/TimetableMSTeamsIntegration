using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class User
    {
        public User()
        {
            ApplicationEvent = new HashSet<ApplicationEvent>();
            EducatorStudyWorkUnit = new HashSet<EducatorStudyWorkUnit>();
            EducatorStudyWorkUnitComment = new HashSet<EducatorStudyWorkUnitComment>();
            Event = new HashSet<Event>();
            Location = new HashSet<Location>();
            UserApplicationApplicantUserNavigation = new HashSet<UserApplication>();
            UserApplicationAssigneeUserNavigation = new HashSet<UserApplication>();
            UserApplicationUpdateCommentAuthorUserNavigation = new HashSet<UserApplicationUpdate>();
            UserApplicationUpdateCurrentAssigneeUserNavigation = new HashSet<UserApplicationUpdate>();
            UserSelectedContingentUnitInTimeTable = new HashSet<UserSelectedContingentUnitInTimeTable>();
            UserSelectedDaysInTimeTable = new HashSet<UserSelectedDaysInTimeTable>();
            UserUsersSecuritySystemRoleUserRoles = new HashSet<UserUsersSecuritySystemRoleUserRoles>();
            UserUsersSelectedThisAddressAddressSelectedAddresses = new HashSet<UserUsersSelectedThisAddressAddressSelectedAddresses>();
            UserUsersUserRoleUserRoles = new HashSet<UserUsersUserRoleUserRoles>();
        }

        public Guid Oid { get; set; }
        public bool? IsActive { get; set; }
        public string UserName { get; set; }
        public bool? ChangePasswordOnFirstLogon { get; set; }
        public string StoredPassword { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string PositionDisplayName { get; set; }
        public string PersonFullName { get; set; }
        public string Email { get; set; }
        public string ContactPhone { get; set; }
        public bool? CanBeAssignedForUserApplications { get; set; }

        public virtual ICollection<ApplicationEvent> ApplicationEvent { get; set; }
        public virtual ICollection<EducatorStudyWorkUnit> EducatorStudyWorkUnit { get; set; }
        public virtual ICollection<EducatorStudyWorkUnitComment> EducatorStudyWorkUnitComment { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<UserApplication> UserApplicationApplicantUserNavigation { get; set; }
        public virtual ICollection<UserApplication> UserApplicationAssigneeUserNavigation { get; set; }
        public virtual ICollection<UserApplicationUpdate> UserApplicationUpdateCommentAuthorUserNavigation { get; set; }
        public virtual ICollection<UserApplicationUpdate> UserApplicationUpdateCurrentAssigneeUserNavigation { get; set; }
        public virtual ICollection<UserSelectedContingentUnitInTimeTable> UserSelectedContingentUnitInTimeTable { get; set; }
        public virtual ICollection<UserSelectedDaysInTimeTable> UserSelectedDaysInTimeTable { get; set; }
        public virtual ICollection<UserUsersSecuritySystemRoleUserRoles> UserUsersSecuritySystemRoleUserRoles { get; set; }
        public virtual ICollection<UserUsersSelectedThisAddressAddressSelectedAddresses> UserUsersSelectedThisAddressAddressSelectedAddresses { get; set; }
        public virtual ICollection<UserUsersUserRoleUserRoles> UserUsersUserRoleUserRoles { get; set; }
    }
}
