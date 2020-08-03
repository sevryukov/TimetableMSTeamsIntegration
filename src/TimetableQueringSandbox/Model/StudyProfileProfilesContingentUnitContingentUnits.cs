using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyProfileProfilesContingentUnitContingentUnits
    {
        public Guid? ContingentUnits { get; set; }
        public Guid? Profiles { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual ContingentUnit ContingentUnitsNavigation { get; set; }
        public virtual StudyProfile ProfilesNavigation { get; set; }
    }
}
