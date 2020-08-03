using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyModuleControlFormPeriod
    {
        public StudyModuleControlFormPeriod()
        {
            StudyModuleWorkUnit = new HashSet<StudyModuleWorkUnit>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual ICollection<StudyModuleWorkUnit> StudyModuleWorkUnit { get; set; }
    }
}
