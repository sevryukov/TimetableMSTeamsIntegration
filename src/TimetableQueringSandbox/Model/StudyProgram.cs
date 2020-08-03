using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class StudyProgram
    {
        public StudyProgram()
        {
            ContingentUnit = new HashSet<ContingentUnit>();
            OnlinePedUnit = new HashSet<OnlinePedUnit>();
            StudyPlan = new HashSet<StudyPlan>();
            StudyProgramStudyProgramsBaseTimeTableTimeTables = new HashSet<StudyProgramStudyProgramsBaseTimeTableTimeTables>();
            StudyProgramStudyProgramsContingentUnitContingentUnits = new HashSet<StudyProgramStudyProgramsContingentUnitContingentUnits>();
            StudyProgramStudyProgramsDivisionDivisions = new HashSet<StudyProgramStudyProgramsDivisionDivisions>();
            StudyProgramStudyProgramsEducatorStudyWorkUnitEducatorStudyWorkUnits = new HashSet<StudyProgramStudyProgramsEducatorStudyWorkUnitEducatorStudyWorkUnits>();
            StudyProgramStudyProgramsStudyProfileProfiles = new HashSet<StudyProgramStudyProgramsStudyProfileProfiles>();
            UserInPedUnit = new HashSet<UserInPedUnit>();
        }

        public Guid Oid { get; set; }
        public string DisplayName { get; set; }
        public int? ImportId { get; set; }
        public string Number { get; set; }
        public string LicenseName { get; set; }
        public string LicenseNameEnglish { get; set; }
        public string LicenseCode { get; set; }
        public string NormativePeriod { get; set; }
        public string ProgramTypeName { get; set; }
        public Guid? AdmissionYear { get; set; }
        public bool? IsImported { get; set; }
        public Guid? ImportSession { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string DisplayNameEnglish { get; set; }
        public string Name { get; set; }
        public string NameEnglish { get; set; }
        public Guid? StudyLevel { get; set; }
        public int? ObjectType { get; set; }
        public Guid? PrimaryDivision { get; set; }
        public int Id { get; set; }
        public string XtracurDivisionAlias { get; set; }

        public virtual StudyYear AdmissionYearNavigation { get; set; }
        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual Division PrimaryDivisionNavigation { get; set; }
        public virtual StudyLevel StudyLevelNavigation { get; set; }
        public virtual ICollection<ContingentUnit> ContingentUnit { get; set; }
        public virtual ICollection<OnlinePedUnit> OnlinePedUnit { get; set; }
        public virtual ICollection<StudyPlan> StudyPlan { get; set; }
        public virtual ICollection<StudyProgramStudyProgramsBaseTimeTableTimeTables> StudyProgramStudyProgramsBaseTimeTableTimeTables { get; set; }
        public virtual ICollection<StudyProgramStudyProgramsContingentUnitContingentUnits> StudyProgramStudyProgramsContingentUnitContingentUnits { get; set; }
        public virtual ICollection<StudyProgramStudyProgramsDivisionDivisions> StudyProgramStudyProgramsDivisionDivisions { get; set; }
        public virtual ICollection<StudyProgramStudyProgramsEducatorStudyWorkUnitEducatorStudyWorkUnits> StudyProgramStudyProgramsEducatorStudyWorkUnitEducatorStudyWorkUnits { get; set; }
        public virtual ICollection<StudyProgramStudyProgramsStudyProfileProfiles> StudyProgramStudyProgramsStudyProfileProfiles { get; set; }
        public virtual ICollection<UserInPedUnit> UserInPedUnit { get; set; }
    }
}
