using System;
using System.Collections.Generic;

namespace TimetableQueringSandbox.Model
{
    public partial class XpobjectType
    {
        public XpobjectType()
        {
            Address = new HashSet<Address>();
            BaseTimeTable = new HashSet<BaseTimeTable>();
            ContingentUnit = new HashSet<ContingentUnit>();
            Discipline = new HashSet<Discipline>();
            EducatorAssignment = new HashSet<EducatorAssignment>();
            EducatorEmployment = new HashSet<EducatorEmployment>();
            EducatorMasterPerson = new HashSet<EducatorMasterPerson>();
            EducatorPerson = new HashSet<EducatorPerson>();
            EducatorStudyWorkUnitComment = new HashSet<EducatorStudyWorkUnitComment>();
            Event = new HashSet<Event>();
            EventLocation = new HashSet<EventLocation>();
            Location = new HashSet<Location>();
            SecuritySystemRole = new HashSet<SecuritySystemRole>();
            SecuritySystemTypePermissionsObject = new HashSet<SecuritySystemTypePermissionsObject>();
            SecuritySystemUser = new HashSet<SecuritySystemUser>();
            StudyModule = new HashSet<StudyModule>();
            StudyModuleWorkUnit = new HashSet<StudyModuleWorkUnit>();
            StudyModuleWorkUnitKindContactLoadType = new HashSet<StudyModuleWorkUnitKindContactLoadType>();
            StudyPlan = new HashSet<StudyPlan>();
            StudyPlanTerm = new HashSet<StudyPlanTerm>();
            StudyProfile = new HashSet<StudyProfile>();
            StudyProgram = new HashSet<StudyProgram>();
        }

        public int Oid { get; set; }
        public string TypeName { get; set; }
        public string AssemblyName { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<BaseTimeTable> BaseTimeTable { get; set; }
        public virtual ICollection<ContingentUnit> ContingentUnit { get; set; }
        public virtual ICollection<Discipline> Discipline { get; set; }
        public virtual ICollection<EducatorAssignment> EducatorAssignment { get; set; }
        public virtual ICollection<EducatorEmployment> EducatorEmployment { get; set; }
        public virtual ICollection<EducatorMasterPerson> EducatorMasterPerson { get; set; }
        public virtual ICollection<EducatorPerson> EducatorPerson { get; set; }
        public virtual ICollection<EducatorStudyWorkUnitComment> EducatorStudyWorkUnitComment { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<EventLocation> EventLocation { get; set; }
        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<SecuritySystemRole> SecuritySystemRole { get; set; }
        public virtual ICollection<SecuritySystemTypePermissionsObject> SecuritySystemTypePermissionsObject { get; set; }
        public virtual ICollection<SecuritySystemUser> SecuritySystemUser { get; set; }
        public virtual ICollection<StudyModule> StudyModule { get; set; }
        public virtual ICollection<StudyModuleWorkUnit> StudyModuleWorkUnit { get; set; }
        public virtual ICollection<StudyModuleWorkUnitKindContactLoadType> StudyModuleWorkUnitKindContactLoadType { get; set; }
        public virtual ICollection<StudyPlan> StudyPlan { get; set; }
        public virtual ICollection<StudyPlanTerm> StudyPlanTerm { get; set; }
        public virtual ICollection<StudyProfile> StudyProfile { get; set; }
        public virtual ICollection<StudyProgram> StudyProgram { get; set; }
    }
}
