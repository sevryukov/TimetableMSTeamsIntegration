using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class ContingentUnit
    {
        public ContingentUnit()
        {
            ContingentUnitRelatedContingentUnitCombinationsBaseTimeTableStudyEventsTimeTables = new HashSet<ContingentUnitRelatedContingentUnitCombinationsBaseTimeTableStudyEventsTimeTables>();
            ContingentUnitStudentGroupsBaseTimeTableStudyEventsTimeTables = new HashSet<ContingentUnitStudentGroupsBaseTimeTableStudyEventsTimeTables>();
            ContingentUnitStudentGroupsContingentUnitContingentUnitCombinationsContingentUnitCombinationsNavigation = new HashSet<ContingentUnitStudentGroupsContingentUnitContingentUnitCombinations>();
            ContingentUnitStudentGroupsContingentUnitContingentUnitCombinationsStudentGroupsNavigation = new HashSet<ContingentUnitStudentGroupsContingentUnitContingentUnitCombinations>();
            DivisionDivisionsContingentUnitContingentUnitCombinations = new HashSet<DivisionDivisionsContingentUnitContingentUnitCombinations>();
            EducatorAssignment = new HashSet<EducatorAssignment>();
            EducatorStudyWorkEducatorStudyWorksContingentUnitContingentUnits = new HashSet<EducatorStudyWorkEducatorStudyWorksContingentUnitContingentUnits>();
            EducatorStudyWorkUnitEducatorStudyWorkUnitsContingentUnitContingentUnitCombinations = new HashSet<EducatorStudyWorkUnitEducatorStudyWorkUnitsContingentUnitContingentUnitCombinations>();
            Event = new HashSet<Event>();
            StudyEventAppointmentInfo = new HashSet<StudyEventAppointmentInfo>();
            StudyModuleAllowedStudyModulesContingentUnitContingentUnitCombinations = new HashSet<StudyModuleAllowedStudyModulesContingentUnitContingentUnitCombinations>();
            StudyProfileProfilesContingentUnitContingentUnits = new HashSet<StudyProfileProfilesContingentUnitContingentUnits>();
            StudyProgramStudyProgramsContingentUnitContingentUnits = new HashSet<StudyProgramStudyProgramsContingentUnitContingentUnits>();
            UserSelectedContingentUnitInTimeTable = new HashSet<UserSelectedContingentUnitInTimeTable>();
        }

        public Guid Oid { get; set; }
        public string Course { get; set; }
        public Guid? AdmissionYear { get; set; }
        public Guid? Division { get; set; }
        public Guid? CurrentStudyYear { get; set; }
        public Guid? StudyProgram { get; set; }
        public string Name { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }
        public Guid? StudyPlan { get; set; }
        public int? CourseNumber { get; set; }
        public Guid? CurrentTimeTable { get; set; }
        public bool? IsArchived { get; set; }
        public bool? HasEducatorAssignments { get; set; }
        public int Id { get; set; }
        public DateTime? TermStart { get; set; }
        public DateTime? TermEnd { get; set; }
        public bool? IsPrimaryAvailableOnWeb { get; set; }
        public bool? IsIntermediaryAttestationAvailableOnWeb { get; set; }
        public bool? IsFinalAttestationAvailableOnWeb { get; set; }
        public bool? IsImported { get; set; }
        public int? ImportId { get; set; }
        public Guid? ImportSession { get; set; }
        public string DivisionsString { get; set; }
        public string StudentGroupsString { get; set; }
        public int? Capacity { get; set; }

        public virtual StudyYear AdmissionYearNavigation { get; set; }
        public virtual StudyYear CurrentStudyYearNavigation { get; set; }
        public virtual Division DivisionNavigation { get; set; }
        public virtual ImportSession ImportSessionNavigation { get; set; }
        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual StudyPlan StudyPlanNavigation { get; set; }
        public virtual StudyProgram StudyProgramNavigation { get; set; }
        public virtual ICollection<ContingentUnitRelatedContingentUnitCombinationsBaseTimeTableStudyEventsTimeTables> ContingentUnitRelatedContingentUnitCombinationsBaseTimeTableStudyEventsTimeTables { get; set; }
        public virtual ICollection<ContingentUnitStudentGroupsBaseTimeTableStudyEventsTimeTables> ContingentUnitStudentGroupsBaseTimeTableStudyEventsTimeTables { get; set; }
        public virtual ICollection<ContingentUnitStudentGroupsContingentUnitContingentUnitCombinations> ContingentUnitStudentGroupsContingentUnitContingentUnitCombinationsContingentUnitCombinationsNavigation { get; set; }
        public virtual ICollection<ContingentUnitStudentGroupsContingentUnitContingentUnitCombinations> ContingentUnitStudentGroupsContingentUnitContingentUnitCombinationsStudentGroupsNavigation { get; set; }
        public virtual ICollection<DivisionDivisionsContingentUnitContingentUnitCombinations> DivisionDivisionsContingentUnitContingentUnitCombinations { get; set; }
        public virtual ICollection<EducatorAssignment> EducatorAssignment { get; set; }
        public virtual ICollection<EducatorStudyWorkEducatorStudyWorksContingentUnitContingentUnits> EducatorStudyWorkEducatorStudyWorksContingentUnitContingentUnits { get; set; }
        public virtual ICollection<EducatorStudyWorkUnitEducatorStudyWorkUnitsContingentUnitContingentUnitCombinations> EducatorStudyWorkUnitEducatorStudyWorkUnitsContingentUnitContingentUnitCombinations { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<StudyEventAppointmentInfo> StudyEventAppointmentInfo { get; set; }
        public virtual ICollection<StudyModuleAllowedStudyModulesContingentUnitContingentUnitCombinations> StudyModuleAllowedStudyModulesContingentUnitContingentUnitCombinations { get; set; }
        public virtual ICollection<StudyProfileProfilesContingentUnitContingentUnits> StudyProfileProfilesContingentUnitContingentUnits { get; set; }
        public virtual ICollection<StudyProgramStudyProgramsContingentUnitContingentUnits> StudyProgramStudyProgramsContingentUnitContingentUnits { get; set; }
        public virtual ICollection<UserSelectedContingentUnitInTimeTable> UserSelectedContingentUnitInTimeTable { get; set; }
    }
}
