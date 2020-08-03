using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class UserApplicationUpdate
    {
        public int Oid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UserApplication { get; set; }
        public Guid? CommentAuthorUser { get; set; }
        public Guid? CurrentAssigneeUser { get; set; }
        public Guid? CurrentStatus { get; set; }
        public string Comment { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual User CommentAuthorUserNavigation { get; set; }
        public virtual User CurrentAssigneeUserNavigation { get; set; }
        public virtual UserApplicationStatus CurrentStatusNavigation { get; set; }
        public virtual UserApplication UserApplicationNavigation { get; set; }
    }
}
