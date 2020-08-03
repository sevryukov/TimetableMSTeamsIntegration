using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class Location
    {
        public Location()
        {
            ClassroomNetworkConnection = new HashSet<ClassroomNetworkConnection>();
            EventLocation = new HashSet<EventLocation>();
            LocationClassroomsClassroomAccessKindClassroomAccessKinds = new HashSet<LocationClassroomsClassroomAccessKindClassroomAccessKinds>();
            LocationLocationsBaseTimeTableLocationsTimeTables = new HashSet<LocationLocationsBaseTimeTableLocationsTimeTables>();
            SapRoom1 = new HashSet<SapRoom>();
            SportObjectPassport = new HashSet<SportObjectPassport>();
        }

        public Guid Oid { get; set; }
        public int? LocationKindCode { get; set; }
        public Guid? LocationKind { get; set; }
        public Guid? Address { get; set; }
        public Guid? Floor { get; set; }
        public string AdditionalInfo { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }
        public string NumberActual { get; set; }
        public string NumberProjected { get; set; }
        public Guid? ClassroomKind { get; set; }
        public DateTime? SetUnavailableOnDay { get; set; }
        public int? UsageState { get; set; }
        public int? MultimediaEquipment { get; set; }
        public int? LabwareEquipment { get; set; }
        public int? Capacity { get; set; }
        public double? Square { get; set; }
        public string Name { get; set; }
        public string DisplayName1 { get; set; }
        public string DisplayName2 { get; set; }
        public string DisplayNameEnglish1 { get; set; }
        public string DisplayNameEnglish2 { get; set; }
        public string NameEnglish { get; set; }
        public int Id { get; set; }
        public string DisplayName1Old { get; set; }
        public string DisplayName2Old { get; set; }
        public string DisplayNameEnglish1Old { get; set; }
        public string DisplayNameEnglish2Old { get; set; }
        public string NumberActualOld { get; set; }
        public string DisplayName3 { get; set; }
        public string DisplayNameEnglish3 { get; set; }
        public string DisplayName3Old { get; set; }
        public string DisplayNameEnglish3Old { get; set; }
        public string JurfakClassroomName { get; set; }
        public int? ComputersCount { get; set; }
        public int? SeatingType { get; set; }
        public bool? HideFromReport { get; set; }
        public Guid? SapRoom { get; set; }
        public Guid? SapRoomKind { get; set; }
        public Guid? LastChangeUser { get; set; }
        public DateTime? LastChangeDateTime { get; set; }
        public bool? WithLimitedAccess { get; set; }
        public bool? IsImported { get; set; }

        public virtual Address AddressNavigation { get; set; }
        public virtual ClassroomKind ClassroomKindNavigation { get; set; }
        public virtual LocationFloor FloorNavigation { get; set; }
        public virtual User LastChangeUserNavigation { get; set; }
        public virtual LocationKind LocationKindNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual SapRoomKind SapRoomKindNavigation { get; set; }
        public virtual SapRoom SapRoomNavigation { get; set; }
        public virtual ICollection<ClassroomNetworkConnection> ClassroomNetworkConnection { get; set; }
        public virtual ICollection<EventLocation> EventLocation { get; set; }
        public virtual ICollection<LocationClassroomsClassroomAccessKindClassroomAccessKinds> LocationClassroomsClassroomAccessKindClassroomAccessKinds { get; set; }
        public virtual ICollection<LocationLocationsBaseTimeTableLocationsTimeTables> LocationLocationsBaseTimeTableLocationsTimeTables { get; set; }
        public virtual ICollection<SapRoom> SapRoom1 { get; set; }
        public virtual ICollection<SportObjectPassport> SportObjectPassport { get; set; }
    }
}
