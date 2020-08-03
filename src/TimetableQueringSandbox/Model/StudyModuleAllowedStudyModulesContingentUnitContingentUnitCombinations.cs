using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyModuleAllowedStudyModulesContingentUnitContingentUnitCombinations
    {
        public Guid? ContingentUnitCombinations { get; set; }
        public Guid? AllowedStudyModules { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual StudyModule AllowedStudyModulesNavigation { get; set; }
        public virtual ContingentUnit ContingentUnitCombinationsNavigation { get; set; }
    }
}
