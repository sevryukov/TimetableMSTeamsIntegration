using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyModuleWorkUnitKindContactLoadType
    {
        public StudyModuleWorkUnitKindContactLoadType()
        {
            OnlinePedUnit = new HashSet<OnlinePedUnit>();
            StudyModuleWorkKind = new HashSet<StudyModuleWorkKind>();
            StudyModuleWorkUnitKind = new HashSet<StudyModuleWorkUnitKind>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string NameEnglish { get; set; }
        public string Acronym { get; set; }
        public string AcronymEnglish { get; set; }
        public bool? IsImported { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }
        public int? ImportId { get; set; }
        public Guid? ImportSession { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual ICollection<OnlinePedUnit> OnlinePedUnit { get; set; }
        public virtual ICollection<StudyModuleWorkKind> StudyModuleWorkKind { get; set; }
        public virtual ICollection<StudyModuleWorkUnitKind> StudyModuleWorkUnitKind { get; set; }
    }
}
