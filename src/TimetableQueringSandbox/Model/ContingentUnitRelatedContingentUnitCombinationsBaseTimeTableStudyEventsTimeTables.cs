using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class ContingentUnitRelatedContingentUnitCombinationsBaseTimeTableStudyEventsTimeTables
    {
        public Guid? StudyEventsTimeTables { get; set; }
        public Guid? RelatedContingentUnitCombinations { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual ContingentUnit RelatedContingentUnitCombinationsNavigation { get; set; }
        public virtual BaseTimeTable StudyEventsTimeTablesNavigation { get; set; }
    }
}
