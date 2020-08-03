using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class Address
    {
        public Address()
        {
            Event = new HashSet<Event>();
            Location = new HashSet<Location>();
            UserUsersSelectedThisAddressAddressSelectedAddresses = new HashSet<UserUsersSelectedThisAddressAddressSelectedAddresses>();
        }

        public Guid Oid { get; set; }
        public string BuildingName { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Korpus { get; set; }
        public string House { get; set; }
        public string Letter { get; set; }
        public bool? HasGeographicCoordinates { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool? IsImported { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }
        public Guid? ImportSession { get; set; }
        public string DisplayName1 { get; set; }
        public string DisplayNameEnglish1 { get; set; }
        public string BuildingNameEnglish { get; set; }
        public bool? HasSpbuClassroomFundLocations { get; set; }
        public bool? HasExternalLocations { get; set; }
        public int Id { get; set; }
        public bool? HideFromReport { get; set; }
        public Guid? WebCategory { get; set; }
        public string DisplayName2 { get; set; }
        public string DisplayName3 { get; set; }
        public string DisplayNameEnglish2 { get; set; }
        public Guid? SapBuilding { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual SapBuilding SapBuildingNavigation { get; set; }
        public virtual AddressWebCategory WebCategoryNavigation { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<UserUsersSelectedThisAddressAddressSelectedAddresses> UserUsersSelectedThisAddressAddressSelectedAddresses { get; set; }
    }
}
