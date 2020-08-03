using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class UserUsersSelectedThisAddressAddressSelectedAddresses
    {
        public Guid? SelectedAddresses { get; set; }
        public Guid? UsersSelectedThisAddress { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual Address SelectedAddressesNavigation { get; set; }
        public virtual User UsersSelectedThisAddressNavigation { get; set; }
    }
}
