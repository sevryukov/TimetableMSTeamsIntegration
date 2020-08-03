using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class SapBuilding
    {
        public SapBuilding()
        {
            AddressNavigation = new HashSet<Address>();
            SapRoom = new HashSet<SapRoom>();
        }

        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual ICollection<Address> AddressNavigation { get; set; }
        public virtual ICollection<SapRoom> SapRoom { get; set; }
    }
}
