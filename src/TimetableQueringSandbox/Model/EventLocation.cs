using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class EventLocation
    {
        public EventLocation()
        {
            LocationEducatorEventLocationNavigation = new HashSet<LocationEducator>();
            LocationEducatorStudyEventLocationNavigation = new HashSet<LocationEducator>();
        }

        public Guid Oid { get; set; }
        public Guid? EventLocation1 { get; set; }
        public Guid? StudyEvent { get; set; }
        public bool? ShowAddressInDisplayName { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? Location { get; set; }
        public Guid? Event { get; set; }
        public int? ObjectType { get; set; }

        public virtual Event EventNavigation { get; set; }
        public virtual Location LocationNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual ICollection<LocationEducator> LocationEducatorEventLocationNavigation { get; set; }
        public virtual ICollection<LocationEducator> LocationEducatorStudyEventLocationNavigation { get; set; }
    }
}
