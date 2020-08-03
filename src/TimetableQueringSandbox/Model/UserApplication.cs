using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class UserApplication
    {
        public UserApplication()
        {
            UserApplicationUpdate = new HashSet<UserApplicationUpdate>();
        }

        public int Oid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Guid? Status { get; set; }
        public Guid? ApplicantUser { get; set; }
        public bool? RequestCallback { get; set; }
        public string ContactPhone { get; set; }
        public Guid? AssigneeUser { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
        public string Reply { get; set; }
        public string ApplicantStepsToReproduce { get; set; }
        public string ApplicantExpectedResult { get; set; }
        public string ApplicantActualResult { get; set; }
        public string AssigneeStepsToReproduce { get; set; }
        public string AssigneeExpectedResult { get; set; }
        public string AssigneeActualResult { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual User ApplicantUserNavigation { get; set; }
        public virtual User AssigneeUserNavigation { get; set; }
        public virtual UserApplicationStatus StatusNavigation { get; set; }
        public virtual ICollection<UserApplicationUpdate> UserApplicationUpdate { get; set; }
    }
}
