using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class OnlinePuuser
    {
        public OnlinePuuser()
        {
            UserInPedUnitCommentAuthorNavigation = new HashSet<UserInPedUnit>();
            UserInPedUnitPuuserNavigation = new HashSet<UserInPedUnit>();
        }

        public Guid Oid { get; set; }
        public string DisplayName { get; set; }
        public Guid? ImportId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool? IsAd { get; set; }
        public string Login { get; set; }
        public int? PersonId { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual ICollection<UserInPedUnit> UserInPedUnitCommentAuthorNavigation { get; set; }
        public virtual ICollection<UserInPedUnit> UserInPedUnitPuuserNavigation { get; set; }
    }
}
