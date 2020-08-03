using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class Division
    {
        public Division()
        {
            BaseTimeTableContingentUnitDivisionNavigation = new HashSet<BaseTimeTable>();
            BaseTimeTableDivisionNavigation = new HashSet<BaseTimeTable>();
            ContingentUnit = new HashSet<ContingentUnit>();
            DivisionDivisionsContingentUnitContingentUnitCombinations = new HashSet<DivisionDivisionsContingentUnitContingentUnitCombinations>();
            EducatorStudyWork = new HashSet<EducatorStudyWork>();
            EducatorStudyWorkUnit = new HashSet<EducatorStudyWorkUnit>();
            OnlinePedUnit = new HashSet<OnlinePedUnit>();
            PublicDivisionPublicDivisionsDivisionDivisions = new HashSet<PublicDivisionPublicDivisionsDivisionDivisions>();
            SecuritySystemRole = new HashSet<SecuritySystemRole>();
            StudyProgram = new HashSet<StudyProgram>();
            StudyProgramStudyProgramsDivisionDivisions = new HashSet<StudyProgramStudyProgramsDivisionDivisions>();
        }

        public Guid Oid { get; set; }
        public int? ImportId { get; set; }
        public string Name { get; set; }
        public string NameEnglish { get; set; }
        public string ShortName { get; set; }
        public string ShortNameEnglish { get; set; }
        public bool? IsImported { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual ICollection<BaseTimeTable> BaseTimeTableContingentUnitDivisionNavigation { get; set; }
        public virtual ICollection<BaseTimeTable> BaseTimeTableDivisionNavigation { get; set; }
        public virtual ICollection<ContingentUnit> ContingentUnit { get; set; }
        public virtual ICollection<DivisionDivisionsContingentUnitContingentUnitCombinations> DivisionDivisionsContingentUnitContingentUnitCombinations { get; set; }
        public virtual ICollection<EducatorStudyWork> EducatorStudyWork { get; set; }
        public virtual ICollection<EducatorStudyWorkUnit> EducatorStudyWorkUnit { get; set; }
        public virtual ICollection<OnlinePedUnit> OnlinePedUnit { get; set; }
        public virtual ICollection<PublicDivisionPublicDivisionsDivisionDivisions> PublicDivisionPublicDivisionsDivisionDivisions { get; set; }
        public virtual ICollection<SecuritySystemRole> SecuritySystemRole { get; set; }
        public virtual ICollection<StudyProgram> StudyProgram { get; set; }
        public virtual ICollection<StudyProgramStudyProgramsDivisionDivisions> StudyProgramStudyProgramsDivisionDivisions { get; set; }
    }
}
