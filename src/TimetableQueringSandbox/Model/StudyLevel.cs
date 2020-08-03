using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyLevel
    {
        public StudyLevel()
        {
            OnlinePedUnit = new HashSet<OnlinePedUnit>();
            StudyProgram = new HashSet<StudyProgram>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string NameEnglish { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ImportId { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual ICollection<OnlinePedUnit> OnlinePedUnit { get; set; }
        public virtual ICollection<StudyProgram> StudyProgram { get; set; }
    }
}
