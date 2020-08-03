using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class ImportSession
    {
        public ImportSession()
        {
            Address = new HashSet<Address>();
            ContingentUnit = new HashSet<ContingentUnit>();
            Discipline = new HashSet<Discipline>();
            Division = new HashSet<Division>();
            EducatorEmployment = new HashSet<EducatorEmployment>();
            EducatorEmploymentCategory = new HashSet<EducatorEmploymentCategory>();
            EducatorEmploymentGroup = new HashSet<EducatorEmploymentGroup>();
            EducatorEmploymentPosition = new HashSet<EducatorEmploymentPosition>();
            EducatorMasterPerson = new HashSet<EducatorMasterPerson>();
            EducatorPerson = new HashSet<EducatorPerson>();
            EducatorPersonDegree = new HashSet<EducatorPersonDegree>();
            EducatorPersonTitle = new HashSet<EducatorPersonTitle>();
            EducatorStudyWork = new HashSet<EducatorStudyWork>();
            Event = new HashSet<Event>();
            OnlineCourse = new HashSet<OnlineCourse>();
            OnlinePedUnit = new HashSet<OnlinePedUnit>();
            OnlinePuuser = new HashSet<OnlinePuuser>();
            SapBuilding = new HashSet<SapBuilding>();
            SapDepartment = new HashSet<SapDepartment>();
            SapDivision = new HashSet<SapDivision>();
            SapRoom = new HashSet<SapRoom>();
            SapRoomKind = new HashSet<SapRoomKind>();
            StudyForm = new HashSet<StudyForm>();
            StudyLevel = new HashSet<StudyLevel>();
            StudyModule = new HashSet<StudyModule>();
            StudyModuleControlFormKind = new HashSet<StudyModuleControlFormKind>();
            StudyModuleControlFormName = new HashSet<StudyModuleControlFormName>();
            StudyModuleControlFormPeriod = new HashSet<StudyModuleControlFormPeriod>();
            StudyModuleRealizationVariant = new HashSet<StudyModuleRealizationVariant>();
            StudyModuleTrajectory = new HashSet<StudyModuleTrajectory>();
            StudyModuleWorkKind = new HashSet<StudyModuleWorkKind>();
            StudyModuleWorkUnit = new HashSet<StudyModuleWorkUnit>();
            StudyModuleWorkUnitKind = new HashSet<StudyModuleWorkUnitKind>();
            StudyModuleWorkUnitKindContactLoadType = new HashSet<StudyModuleWorkUnitKindContactLoadType>();
            StudyPlan = new HashSet<StudyPlan>();
            StudyPlanTerm = new HashSet<StudyPlanTerm>();
            StudyPlanTermKind = new HashSet<StudyPlanTermKind>();
            StudyPlanTermName = new HashSet<StudyPlanTermName>();
            StudyProfile = new HashSet<StudyProfile>();
            StudyProgram = new HashSet<StudyProgram>();
            StudyYear = new HashSet<StudyYear>();
            UserInPedUnit = new HashSet<UserInPedUnit>();
        }

        public Guid Oid { get; set; }
        public DateTime? ImportDateTime { get; set; }
        public DateTime? ExportDateTime { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<ContingentUnit> ContingentUnit { get; set; }
        public virtual ICollection<Discipline> Discipline { get; set; }
        public virtual ICollection<Division> Division { get; set; }
        public virtual ICollection<EducatorEmployment> EducatorEmployment { get; set; }
        public virtual ICollection<EducatorEmploymentCategory> EducatorEmploymentCategory { get; set; }
        public virtual ICollection<EducatorEmploymentGroup> EducatorEmploymentGroup { get; set; }
        public virtual ICollection<EducatorEmploymentPosition> EducatorEmploymentPosition { get; set; }
        public virtual ICollection<EducatorMasterPerson> EducatorMasterPerson { get; set; }
        public virtual ICollection<EducatorPerson> EducatorPerson { get; set; }
        public virtual ICollection<EducatorPersonDegree> EducatorPersonDegree { get; set; }
        public virtual ICollection<EducatorPersonTitle> EducatorPersonTitle { get; set; }
        public virtual ICollection<EducatorStudyWork> EducatorStudyWork { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<OnlineCourse> OnlineCourse { get; set; }
        public virtual ICollection<OnlinePedUnit> OnlinePedUnit { get; set; }
        public virtual ICollection<OnlinePuuser> OnlinePuuser { get; set; }
        public virtual ICollection<SapBuilding> SapBuilding { get; set; }
        public virtual ICollection<SapDepartment> SapDepartment { get; set; }
        public virtual ICollection<SapDivision> SapDivision { get; set; }
        public virtual ICollection<SapRoom> SapRoom { get; set; }
        public virtual ICollection<SapRoomKind> SapRoomKind { get; set; }
        public virtual ICollection<StudyForm> StudyForm { get; set; }
        public virtual ICollection<StudyLevel> StudyLevel { get; set; }
        public virtual ICollection<StudyModule> StudyModule { get; set; }
        public virtual ICollection<StudyModuleControlFormKind> StudyModuleControlFormKind { get; set; }
        public virtual ICollection<StudyModuleControlFormName> StudyModuleControlFormName { get; set; }
        public virtual ICollection<StudyModuleControlFormPeriod> StudyModuleControlFormPeriod { get; set; }
        public virtual ICollection<StudyModuleRealizationVariant> StudyModuleRealizationVariant { get; set; }
        public virtual ICollection<StudyModuleTrajectory> StudyModuleTrajectory { get; set; }
        public virtual ICollection<StudyModuleWorkKind> StudyModuleWorkKind { get; set; }
        public virtual ICollection<StudyModuleWorkUnit> StudyModuleWorkUnit { get; set; }
        public virtual ICollection<StudyModuleWorkUnitKind> StudyModuleWorkUnitKind { get; set; }
        public virtual ICollection<StudyModuleWorkUnitKindContactLoadType> StudyModuleWorkUnitKindContactLoadType { get; set; }
        public virtual ICollection<StudyPlan> StudyPlan { get; set; }
        public virtual ICollection<StudyPlanTerm> StudyPlanTerm { get; set; }
        public virtual ICollection<StudyPlanTermKind> StudyPlanTermKind { get; set; }
        public virtual ICollection<StudyPlanTermName> StudyPlanTermName { get; set; }
        public virtual ICollection<StudyProfile> StudyProfile { get; set; }
        public virtual ICollection<StudyProgram> StudyProgram { get; set; }
        public virtual ICollection<StudyYear> StudyYear { get; set; }
        public virtual ICollection<UserInPedUnit> UserInPedUnit { get; set; }
    }
}
