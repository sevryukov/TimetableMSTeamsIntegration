using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class LocationLocationsBaseTimeTableLocationsTimeTables
    {
        public Guid? LocationsTimeTables { get; set; }
        public Guid? Locations { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual Location LocationsNavigation { get; set; }
        public virtual BaseTimeTable LocationsTimeTablesNavigation { get; set; }
    }
}
