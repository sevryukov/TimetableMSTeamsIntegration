using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class AddressWebCategory
    {
        public AddressWebCategory()
        {
            Address = new HashSet<Address>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<Address> Address { get; set; }
    }
}
