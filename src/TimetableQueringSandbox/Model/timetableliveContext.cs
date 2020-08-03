using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TimetableQueringSandbox.Model
{
    public partial class timetableliveContext : DbContext
    {
        public timetableliveContext()
        {
        }

        public timetableliveContext(DbContextOptions<timetableliveContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressWebCategory> AddressWebCategory { get; set; }
        public virtual DbSet<ApplicationEvent> ApplicationEvent { get; set; }
        public virtual DbSet<AppointmentLabelColor> AppointmentLabelColor { get; set; }
        public virtual DbSet<BaseTimeTable> BaseTimeTable { get; set; }
        public virtual DbSet<BaseTimeTableKind> BaseTimeTableKind { get; set; }
        public virtual DbSet<ClassroomAccessKind> ClassroomAccessKind { get; set; }
        public virtual DbSet<ClassroomKind> ClassroomKind { get; set; }
        public virtual DbSet<ClassroomNetworkConnection> ClassroomNetworkConnection { get; set; }
        public virtual DbSet<ContingentUnit> ContingentUnit { get; set; }
        public virtual DbSet<ContingentUnitRelatedContingentUnitCombinationsBaseTimeTableStudyEventsTimeTables> ContingentUnitRelatedContingentUnitCombinationsBaseTimeTableStudyEventsTimeTables { get; set; }
        public virtual DbSet<ContingentUnitStudentGroupsBaseTimeTableStudyEventsTimeTables> ContingentUnitStudentGroupsBaseTimeTableStudyEventsTimeTables { get; set; }
        public virtual DbSet<ContingentUnitStudentGroupsContingentUnitContingentUnitCombinations> ContingentUnitStudentGroupsContingentUnitContingentUnitCombinations { get; set; }
        public virtual DbSet<Discipline> Discipline { get; set; }
        public virtual DbSet<Division> Division { get; set; }
        public virtual DbSet<DivisionDivisionsContingentUnitContingentUnitCombinations> DivisionDivisionsContingentUnitContingentUnitCombinations { get; set; }
        public virtual DbSet<DmBlackBoardCourse> DmBlackBoardCourse { get; set; }
        public virtual DbSet<DmEducator> DmEducator { get; set; }
        public virtual DbSet<DmEducatorEmployment> DmEducatorEmployment { get; set; }
        public virtual DbSet<DmEducatorsBlackBoardCourses> DmEducatorsBlackBoardCourses { get; set; }
        public virtual DbSet<DmGroupsBlackBoardCourses> DmGroupsBlackBoardCourses { get; set; }
        public virtual DbSet<EducatorAssignment> EducatorAssignment { get; set; }
        public virtual DbSet<EducatorAssignmentKind> EducatorAssignmentKind { get; set; }
        public virtual DbSet<EducatorAssignmentUnit> EducatorAssignmentUnit { get; set; }
        public virtual DbSet<EducatorEmployment> EducatorEmployment { get; set; }
        public virtual DbSet<EducatorEmploymentCategory> EducatorEmploymentCategory { get; set; }
        public virtual DbSet<EducatorEmploymentGroup> EducatorEmploymentGroup { get; set; }
        public virtual DbSet<EducatorEmploymentPosition> EducatorEmploymentPosition { get; set; }
        public virtual DbSet<EducatorMasterPerson> EducatorMasterPerson { get; set; }
        public virtual DbSet<EducatorPerson> EducatorPerson { get; set; }
        public virtual DbSet<EducatorPersonDegree> EducatorPersonDegree { get; set; }
        public virtual DbSet<EducatorPersonTitle> EducatorPersonTitle { get; set; }
        public virtual DbSet<EducatorStudyWork> EducatorStudyWork { get; set; }
        public virtual DbSet<EducatorStudyWorkEducatorStudyWorksContingentUnitContingentUnits> EducatorStudyWorkEducatorStudyWorksContingentUnitContingentUnits { get; set; }
        public virtual DbSet<EducatorStudyWorkUnit> EducatorStudyWorkUnit { get; set; }
        public virtual DbSet<EducatorStudyWorkUnitComment> EducatorStudyWorkUnitComment { get; set; }
        public virtual DbSet<EducatorStudyWorkUnitEducatorStudyWorkUnitsContingentUnitContingentUnitCombinations> EducatorStudyWorkUnitEducatorStudyWorkUnitsContingentUnitContingentUnitCombinations { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventFlatten> EventFlatten { get; set; }
        public virtual DbSet<EventKind> EventKind { get; set; }
        public virtual DbSet<EventKindAvailableEventKindsBaseTimeTableKindAvailableTimeTableKinds> EventKindAvailableEventKindsBaseTimeTableKindAvailableTimeTableKinds { get; set; }
        public virtual DbSet<EventLocation> EventLocation { get; set; }
        public virtual DbSet<EventSequence> EventSequence { get; set; }
        public virtual DbSet<EventSubkind> EventSubkind { get; set; }
        public virtual DbSet<ExtBbCourse> ExtBbCourse { get; set; }
        public virtual DbSet<ExtBbEducator> ExtBbEducator { get; set; }
        public virtual DbSet<ExtBbEducatorsCourses> ExtBbEducatorsCourses { get; set; }
        public virtual DbSet<ExtBbGroupsCourses> ExtBbGroupsCourses { get; set; }
        public virtual DbSet<Holiday> Holiday { get; set; }
        public virtual DbSet<ImportSession> ImportSession { get; set; }
        public virtual DbSet<ImportedAssignmentRegistry> ImportedAssignmentRegistry { get; set; }
        public virtual DbSet<ImportedLocationInfo> ImportedLocationInfo { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<LocationClassroomsClassroomAccessKindClassroomAccessKinds> LocationClassroomsClassroomAccessKindClassroomAccessKinds { get; set; }
        public virtual DbSet<LocationEducator> LocationEducator { get; set; }
        public virtual DbSet<LocationFloor> LocationFloor { get; set; }
        public virtual DbSet<LocationKind> LocationKind { get; set; }
        public virtual DbSet<LocationLocationsBaseTimeTableLocationsTimeTables> LocationLocationsBaseTimeTableLocationsTimeTables { get; set; }
        public virtual DbSet<ModuleInfo> ModuleInfo { get; set; }
        public virtual DbSet<Numbers> Numbers { get; set; }
        public virtual DbSet<OnlineCourse> OnlineCourse { get; set; }
        public virtual DbSet<OnlinePedUnit> OnlinePedUnit { get; set; }
        public virtual DbSet<OnlinePuuser> OnlinePuuser { get; set; }
        public virtual DbSet<PlannerAppTracingSettings> PlannerAppTracingSettings { get; set; }
        public virtual DbSet<PublicDivision> PublicDivision { get; set; }
        public virtual DbSet<PublicDivisionAccessKind> PublicDivisionAccessKind { get; set; }
        public virtual DbSet<PublicDivisionPublicDivisionsDivisionDivisions> PublicDivisionPublicDivisionsDivisionDivisions { get; set; }
        public virtual DbSet<Recurrence> Recurrence { get; set; }
        public virtual DbSet<RegistrySearchgroups> RegistrySearchgroups { get; set; }
        public virtual DbSet<SapBuilding> SapBuilding { get; set; }
        public virtual DbSet<SapDepartment> SapDepartment { get; set; }
        public virtual DbSet<SapDivision> SapDivision { get; set; }
        public virtual DbSet<SapRoom> SapRoom { get; set; }
        public virtual DbSet<SapRoomKind> SapRoomKind { get; set; }
        public virtual DbSet<SecuritySystemMemberPermissionsObject> SecuritySystemMemberPermissionsObject { get; set; }
        public virtual DbSet<SecuritySystemObjectPermissionsObject> SecuritySystemObjectPermissionsObject { get; set; }
        public virtual DbSet<SecuritySystemRole> SecuritySystemRole { get; set; }
        public virtual DbSet<SecuritySystemRoleParentRolesSecuritySystemRoleChildRoles> SecuritySystemRoleParentRolesSecuritySystemRoleChildRoles { get; set; }
        public virtual DbSet<SecuritySystemTypePermissionsObject> SecuritySystemTypePermissionsObject { get; set; }
        public virtual DbSet<SecuritySystemUser> SecuritySystemUser { get; set; }
        public virtual DbSet<SecuritySystemUserUsersSecuritySystemRoleRoles> SecuritySystemUserUsersSecuritySystemRoleRoles { get; set; }
        public virtual DbSet<SoftlineData> SoftlineData { get; set; }
        public virtual DbSet<SportObjectPassport> SportObjectPassport { get; set; }
        public virtual DbSet<StudyEventAppointmentInfo> StudyEventAppointmentInfo { get; set; }
        public virtual DbSet<StudyEventDurationKind> StudyEventDurationKind { get; set; }
        public virtual DbSet<StudyEventsTimeTableClass> StudyEventsTimeTableClass { get; set; }
        public virtual DbSet<StudyEventsTimeTableClassKind> StudyEventsTimeTableClassKind { get; set; }
        public virtual DbSet<StudyEventsTimeTableKind> StudyEventsTimeTableKind { get; set; }
        public virtual DbSet<StudyEventsTimeTableSpreadsheet> StudyEventsTimeTableSpreadsheet { get; set; }
        public virtual DbSet<StudyForm> StudyForm { get; set; }
        public virtual DbSet<StudyLevel> StudyLevel { get; set; }
        public virtual DbSet<StudyModule> StudyModule { get; set; }
        public virtual DbSet<StudyModuleAllowedStudyModulesContingentUnitContingentUnitCombinations> StudyModuleAllowedStudyModulesContingentUnitContingentUnitCombinations { get; set; }
        public virtual DbSet<StudyModuleAttendanceKind> StudyModuleAttendanceKind { get; set; }
        public virtual DbSet<StudyModuleControlFormKind> StudyModuleControlFormKind { get; set; }
        public virtual DbSet<StudyModuleControlFormName> StudyModuleControlFormName { get; set; }
        public virtual DbSet<StudyModuleControlFormPeriod> StudyModuleControlFormPeriod { get; set; }
        public virtual DbSet<StudyModuleRealizationVariant> StudyModuleRealizationVariant { get; set; }
        public virtual DbSet<StudyModuleTrajectory> StudyModuleTrajectory { get; set; }
        public virtual DbSet<StudyModuleWorkKind> StudyModuleWorkKind { get; set; }
        public virtual DbSet<StudyModuleWorkUnit> StudyModuleWorkUnit { get; set; }
        public virtual DbSet<StudyModuleWorkUnitKind> StudyModuleWorkUnitKind { get; set; }
        public virtual DbSet<StudyModuleWorkUnitKindContactLoadType> StudyModuleWorkUnitKindContactLoadType { get; set; }
        public virtual DbSet<StudyModuleWorkUnitStudyModuleWorkUnitsEducatorAssignmentEducatorAssignments> StudyModuleWorkUnitStudyModuleWorkUnitsEducatorAssignmentEducatorAssignments { get; set; }
        public virtual DbSet<StudyPlan> StudyPlan { get; set; }
        public virtual DbSet<StudyPlanStudyPlansEducatorStudyWorkUnitEducatorStudyWorkUnits> StudyPlanStudyPlansEducatorStudyWorkUnitEducatorStudyWorkUnits { get; set; }
        public virtual DbSet<StudyPlanTerm> StudyPlanTerm { get; set; }
        public virtual DbSet<StudyPlanTermKind> StudyPlanTermKind { get; set; }
        public virtual DbSet<StudyPlanTermName> StudyPlanTermName { get; set; }
        public virtual DbSet<StudyProfile> StudyProfile { get; set; }
        public virtual DbSet<StudyProfileProfilesContingentUnitContingentUnits> StudyProfileProfilesContingentUnitContingentUnits { get; set; }
        public virtual DbSet<StudyProfileProfilesStudyPlanStudyPlans> StudyProfileProfilesStudyPlanStudyPlans { get; set; }
        public virtual DbSet<StudyProgram> StudyProgram { get; set; }
        public virtual DbSet<StudyProgramStudyProgramsBaseTimeTableTimeTables> StudyProgramStudyProgramsBaseTimeTableTimeTables { get; set; }
        public virtual DbSet<StudyProgramStudyProgramsContingentUnitContingentUnits> StudyProgramStudyProgramsContingentUnitContingentUnits { get; set; }
        public virtual DbSet<StudyProgramStudyProgramsDivisionDivisions> StudyProgramStudyProgramsDivisionDivisions { get; set; }
        public virtual DbSet<StudyProgramStudyProgramsEducatorStudyWorkUnitEducatorStudyWorkUnits> StudyProgramStudyProgramsEducatorStudyWorkUnitEducatorStudyWorkUnits { get; set; }
        public virtual DbSet<StudyProgramStudyProgramsStudyProfileProfiles> StudyProgramStudyProgramsStudyProfileProfiles { get; set; }
        public virtual DbSet<StudyYear> StudyYear { get; set; }
        public virtual DbSet<TimeScaleStepKind> TimeScaleStepKind { get; set; }
        public virtual DbSet<TimetableLog> TimetableLog { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserApplication> UserApplication { get; set; }
        public virtual DbSet<UserApplicationStatus> UserApplicationStatus { get; set; }
        public virtual DbSet<UserApplicationUpdate> UserApplicationUpdate { get; set; }
        public virtual DbSet<UserInPedUnit> UserInPedUnit { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserRoleKind> UserRoleKind { get; set; }
        public virtual DbSet<UserSelectedContingentUnitInTimeTable> UserSelectedContingentUnitInTimeTable { get; set; }
        public virtual DbSet<UserSelectedDaysInTimeTable> UserSelectedDaysInTimeTable { get; set; }
        public virtual DbSet<UserStudyPlan> UserStudyPlan { get; set; }
        public virtual DbSet<UserUsersSecuritySystemRoleUserRoles> UserUsersSecuritySystemRoleUserRoles { get; set; }
        public virtual DbSet<UserUsersSelectedThisAddressAddressSelectedAddresses> UserUsersSelectedThisAddressAddressSelectedAddresses { get; set; }
        public virtual DbSet<UserUsersUserRoleUserRoles> UserUsersUserRoleUserRoles { get; set; }
        public virtual DbSet<VwAdcroomInfo> VwAdcroomInfo { get; set; }
        public virtual DbSet<VwEducatorStudyWorkSourceInfo> VwEducatorStudyWorkSourceInfo { get; set; }
        public virtual DbSet<VwStudyModulesLocations> VwStudyModulesLocations { get; set; }
        public virtual DbSet<VwTeacherContingentUnits> VwTeacherContingentUnits { get; set; }
        public virtual DbSet<VwTeachersWorkHours> VwTeachersWorkHours { get; set; }
        public virtual DbSet<WeeklyRecurGenerator> WeeklyRecurGenerator { get; set; }
        public virtual DbSet<XpobjectType> XpobjectType { get; set; }
        public virtual DbSet<XtracurDivision> XtracurDivision { get; set; }
        public virtual DbSet<XtracurImageAttachment> XtracurImageAttachment { get; set; }
        public virtual DbSet<Лист1> Лист1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=timetable-live;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Address");

                entity.HasIndex(e => e.Id)
                    .HasName("iId_Address")
                    .IsUnique();

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_Address");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_Address");

                entity.HasIndex(e => e.SapBuilding)
                    .HasName("iSapBuilding_Address");

                entity.HasIndex(e => e.WebCategory)
                    .HasName("iWebCategory_Address");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.BuildingName).HasMaxLength(100);

                entity.Property(e => e.BuildingNameEnglish).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.DisplayName1).HasMaxLength(250);

                entity.Property(e => e.DisplayName2).HasMaxLength(250);

                entity.Property(e => e.DisplayName3).HasMaxLength(250);

                entity.Property(e => e.DisplayNameEnglish1).HasMaxLength(250);

                entity.Property(e => e.DisplayNameEnglish2).HasMaxLength(250);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.House).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Korpus).HasMaxLength(100);

                entity.Property(e => e.Letter).HasMaxLength(100);

                entity.Property(e => e.PostalCode).HasMaxLength(100);

                entity.Property(e => e.Street).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_Address_ImportSession");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_Address_ObjectType");

                entity.HasOne(d => d.SapBuildingNavigation)
                    .WithMany(p => p.AddressNavigation)
                    .HasForeignKey(d => d.SapBuilding)
                    .HasConstraintName("FK_Address_SapBuilding");

                entity.HasOne(d => d.WebCategoryNavigation)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.WebCategory)
                    .HasConstraintName("FK_Address_WebCategory");
            });

            modelBuilder.Entity<AddressWebCategory>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Alias)
                    .HasName("iAlias_AddressWebCategory")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_AddressWebCategory");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Alias).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<ApplicationEvent>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_ApplicationEvent");

                entity.HasIndex(e => e.User)
                    .HasName("iUser_ApplicationEvent");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.ApplicationName).HasMaxLength(100);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.MachineName).HasMaxLength(100);

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.ApplicationEvent)
                    .HasForeignKey(d => d.User)
                    .HasConstraintName("FK_ApplicationEvent_User");
            });

            modelBuilder.Entity<AppointmentLabelColor>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_AppointmentLabelColor");

                entity.HasIndex(e => new { e.LabelCode, e.Gcrecord })
                    .HasName("iLabelCodeGCRecord_AppointmentLabelColor")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<BaseTimeTable>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Class)
                    .HasName("iClass_BaseTimeTable");

                entity.HasIndex(e => e.ContingentUnitAdmissionYear)
                    .HasName("iContingentUnitAdmissionYear_BaseTimeTable");

                entity.HasIndex(e => e.ContingentUnitDivision)
                    .HasName("iContingentUnitDivision_BaseTimeTable");

                entity.HasIndex(e => e.Division)
                    .HasName("iDivision_BaseTimeTable");

                entity.HasIndex(e => e.EventKind)
                    .HasName("iEventKind_BaseTimeTable");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyEventsTimeTable");

                entity.HasIndex(e => e.Kind)
                    .HasName("iKind_BaseTimeTable");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_BaseTimeTable");

                entity.HasIndex(e => e.StudyEventDefaultDurationKind)
                    .HasName("iStudyEventDefaultDurationKind_BaseTimeTable");

                entity.HasIndex(e => e.StudyEventsTimeTableKind)
                    .HasName("iStudyEventsTimeTableKind_BaseTimeTable");

                entity.HasIndex(e => e.StudyYear)
                    .HasName("iStudyYear_StudyEventsTimeTable");

                entity.HasIndex(e => e.TimeScaleStepKind)
                    .HasName("iTimeScaleStepKind_BaseTimeTable");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.ContingentUnitCourse).HasMaxLength(100);

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.StudyProgramsDisplayName).HasMaxLength(100);

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.BaseTimeTable)
                    .HasForeignKey(d => d.Class)
                    .HasConstraintName("FK_BaseTimeTable_Class");

                entity.HasOne(d => d.ContingentUnitAdmissionYearNavigation)
                    .WithMany(p => p.BaseTimeTableContingentUnitAdmissionYearNavigation)
                    .HasForeignKey(d => d.ContingentUnitAdmissionYear)
                    .HasConstraintName("FK_BaseTimeTable_ContingentUnitAdmissionYear");

                entity.HasOne(d => d.ContingentUnitDivisionNavigation)
                    .WithMany(p => p.BaseTimeTableContingentUnitDivisionNavigation)
                    .HasForeignKey(d => d.ContingentUnitDivision)
                    .HasConstraintName("FK_BaseTimeTable_ContingentUnitDivision");

                entity.HasOne(d => d.DivisionNavigation)
                    .WithMany(p => p.BaseTimeTableDivisionNavigation)
                    .HasForeignKey(d => d.Division)
                    .HasConstraintName("FK_BaseTimeTable_Division");

                entity.HasOne(d => d.EventKindNavigation)
                    .WithMany(p => p.BaseTimeTable)
                    .HasForeignKey(d => d.EventKind)
                    .HasConstraintName("FK_BaseTimeTable_EventKind");

                entity.HasOne(d => d.KindNavigation)
                    .WithMany(p => p.BaseTimeTable)
                    .HasForeignKey(d => d.Kind)
                    .HasConstraintName("FK_BaseTimeTable_Kind");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.BaseTimeTable)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_BaseTimeTable_ObjectType");

                entity.HasOne(d => d.StudyEventDefaultDurationKindNavigation)
                    .WithMany(p => p.BaseTimeTable)
                    .HasForeignKey(d => d.StudyEventDefaultDurationKind)
                    .HasConstraintName("FK_BaseTimeTable_StudyEventDefaultDurationKind");

                entity.HasOne(d => d.StudyEventsTimeTableKindNavigation)
                    .WithMany(p => p.BaseTimeTable)
                    .HasForeignKey(d => d.StudyEventsTimeTableKind)
                    .HasConstraintName("FK_BaseTimeTable_StudyEventsTimeTableKind");

                entity.HasOne(d => d.StudyYearNavigation)
                    .WithMany(p => p.BaseTimeTableStudyYearNavigation)
                    .HasForeignKey(d => d.StudyYear)
                    .HasConstraintName("FK_BaseTimeTable_StudyYear");

                entity.HasOne(d => d.TimeScaleStepKindNavigation)
                    .WithMany(p => p.BaseTimeTable)
                    .HasForeignKey(d => d.TimeScaleStepKind)
                    .HasConstraintName("FK_BaseTimeTable_TimeScaleStepKind");
            });

            modelBuilder.Entity<BaseTimeTableKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Code)
                    .HasName("iCode_BaseTimeTableKind")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_BaseTimeTableKind");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameEnglish).HasMaxLength(100);
            });

            modelBuilder.Entity<ClassroomAccessKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_ClassroomAccessKind");

                entity.HasIndex(e => e.Name)
                    .HasName("iName_ClassroomAccessKind")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<ClassroomKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_ClassroomKind");

                entity.HasIndex(e => e.Id)
                    .HasName("iId_ClassroomKind")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("iName_ClassroomKind")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<ClassroomNetworkConnection>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Classroom)
                    .HasName("iClassroom_ClassroomNetworkConnection");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_ClassroomNetworkConnection");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.ClassroomNavigation)
                    .WithMany(p => p.ClassroomNetworkConnection)
                    .HasForeignKey(d => d.Classroom)
                    .HasConstraintName("FK_ClassroomNetworkConnection_Classroom");
            });

            modelBuilder.Entity<ContingentUnit>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.AdmissionYear)
                    .HasName("iAdmissionYear_ContingentUnit");

                entity.HasIndex(e => e.CurrentStudyYear)
                    .HasName("iCurrentStudyYear_ContingentUnit");

                entity.HasIndex(e => e.CurrentTimeTable)
                    .HasName("iCurrentTimeTable_ContingentUnit");

                entity.HasIndex(e => e.Division)
                    .HasName("iDivision_ContingentUnit");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_ContingentUnit");

                entity.HasIndex(e => e.Id)
                    .HasName("iId_ContingentUnit")
                    .IsUnique();

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_ContingentUnit");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_ContingentUnit");

                entity.HasIndex(e => e.StudyPlan)
                    .HasName("iStudyPlan_ContingentUnit");

                entity.HasIndex(e => e.StudyProgram)
                    .HasName("iStudyProgram_ContingentUnit");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Course).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TermEnd).HasColumnType("datetime");

                entity.Property(e => e.TermStart).HasColumnType("datetime");

                entity.HasOne(d => d.AdmissionYearNavigation)
                    .WithMany(p => p.ContingentUnitAdmissionYearNavigation)
                    .HasForeignKey(d => d.AdmissionYear)
                    .HasConstraintName("FK_ContingentUnit_AdmissionYear");

                entity.HasOne(d => d.CurrentStudyYearNavigation)
                    .WithMany(p => p.ContingentUnitCurrentStudyYearNavigation)
                    .HasForeignKey(d => d.CurrentStudyYear)
                    .HasConstraintName("FK_ContingentUnit_CurrentStudyYear");

                entity.HasOne(d => d.DivisionNavigation)
                    .WithMany(p => p.ContingentUnit)
                    .HasForeignKey(d => d.Division)
                    .HasConstraintName("FK_ContingentUnit_Division");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.ContingentUnit)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_ContingentUnit_ImportSession");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.ContingentUnit)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_ContingentUnit_ObjectType");

                entity.HasOne(d => d.StudyPlanNavigation)
                    .WithMany(p => p.ContingentUnit)
                    .HasForeignKey(d => d.StudyPlan)
                    .HasConstraintName("FK_ContingentUnit_StudyPlan");

                entity.HasOne(d => d.StudyProgramNavigation)
                    .WithMany(p => p.ContingentUnit)
                    .HasForeignKey(d => d.StudyProgram)
                    .HasConstraintName("FK_ContingentUnit_StudyProgram");
            });

            modelBuilder.Entity<ContingentUnitRelatedContingentUnitCombinationsBaseTimeTableStudyEventsTimeTables>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("ContingentUnitRelatedContingentUnitCombinations_BaseTimeTableStudyEventsTimeTables");

                entity.HasIndex(e => e.RelatedContingentUnitCombinations)
                    .HasName("iRelatedContingentUnitCombinations_ContingentUnitRelatedContingentUnitCombinations_BaseTimeTableStudyEventsTimeTables");

                entity.HasIndex(e => e.StudyEventsTimeTables)
                    .HasName("ix_20180903_ContingentUnitRelatedContingentUnitCombinations_BaseTimeTableStudyEventsTimeTables");

                entity.HasIndex(e => new { e.StudyEventsTimeTables, e.RelatedContingentUnitCombinations })
                    .HasName("iStudyEventsTimeTablesRelatedContingentUnitCombinations_ContingentUnitRelatedContingentUnitCombinations_BaseTimeTableSt_37D266ED")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.RelatedContingentUnitCombinationsNavigation)
                    .WithMany(p => p.ContingentUnitRelatedContingentUnitCombinationsBaseTimeTableStudyEventsTimeTables)
                    .HasForeignKey(d => d.RelatedContingentUnitCombinations)
                    .HasConstraintName("FK_ContingentUnitRelatedContingentUnitCombinations_BaseTimeTableStudyEventsTimeTables_RelatedContingentUnitCombinations");

                entity.HasOne(d => d.StudyEventsTimeTablesNavigation)
                    .WithMany(p => p.ContingentUnitRelatedContingentUnitCombinationsBaseTimeTableStudyEventsTimeTables)
                    .HasForeignKey(d => d.StudyEventsTimeTables)
                    .HasConstraintName("FK_ContingentUnitRelatedContingentUnitCombinations_BaseTimeTableStudyEventsTimeTables_StudyEventsTimeTables");
            });

            modelBuilder.Entity<ContingentUnitStudentGroupsBaseTimeTableStudyEventsTimeTables>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("ContingentUnitStudentGroups_BaseTimeTableStudyEventsTimeTables");

                entity.HasIndex(e => e.StudentGroups)
                    .HasName("iStudentGroups_ContingentUnitStudentGroups_BaseTimeTableStudyEventsTimeTables");

                entity.HasIndex(e => e.StudyEventsTimeTables)
                    .HasName("iStudyEventsTimeTables_ContingentUnitStudentGroups_BaseTimeTableStudyEventsTimeTables");

                entity.HasIndex(e => new { e.StudyEventsTimeTables, e.StudentGroups })
                    .HasName("iStudyEventsTimeTablesStudentGroups_ContingentUnitStudentGroups_BaseTimeTableStudyEventsTimeTables")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.StudentGroupsNavigation)
                    .WithMany(p => p.ContingentUnitStudentGroupsBaseTimeTableStudyEventsTimeTables)
                    .HasForeignKey(d => d.StudentGroups)
                    .HasConstraintName("FK_ContingentUnitStudentGroups_BaseTimeTableStudyEventsTimeTables_StudentGroups");

                entity.HasOne(d => d.StudyEventsTimeTablesNavigation)
                    .WithMany(p => p.ContingentUnitStudentGroupsBaseTimeTableStudyEventsTimeTables)
                    .HasForeignKey(d => d.StudyEventsTimeTables)
                    .HasConstraintName("FK_ContingentUnitStudentGroups_BaseTimeTableStudyEventsTimeTables_StudyEventsTimeTables");
            });

            modelBuilder.Entity<ContingentUnitStudentGroupsContingentUnitContingentUnitCombinations>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("ContingentUnitStudentGroups_ContingentUnitContingentUnitCombinations");

                entity.HasIndex(e => e.ContingentUnitCombinations)
                    .HasName("iContingentUnitCombinations_ContingentUnitStudentGroups_ContingentUnitContingentUnitCombinations");

                entity.HasIndex(e => e.StudentGroups)
                    .HasName("ix_20180903_StudentGroups_ContingentUnitCombinations");

                entity.HasIndex(e => new { e.ContingentUnitCombinations, e.StudentGroups })
                    .HasName("iContingentUnitCombinationsStudentGroups_ContingentUnitStudentGroups_ContingentUnitContingentUnitCombinations")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ContingentUnitCombinationsNavigation)
                    .WithMany(p => p.ContingentUnitStudentGroupsContingentUnitContingentUnitCombinationsContingentUnitCombinationsNavigation)
                    .HasForeignKey(d => d.ContingentUnitCombinations)
                    .HasConstraintName("FK_ContingentUnitStudentGroups_ContingentUnitContingentUnitCombinations_ContingentUnitCombinations");

                entity.HasOne(d => d.StudentGroupsNavigation)
                    .WithMany(p => p.ContingentUnitStudentGroupsContingentUnitContingentUnitCombinationsStudentGroupsNavigation)
                    .HasForeignKey(d => d.StudentGroups)
                    .HasConstraintName("FK_ContingentUnitStudentGroups_ContingentUnitContingentUnitCombinations_StudentGroups");
            });

            modelBuilder.Entity<Discipline>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Discipline");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_Discipline");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_Discipline");

                entity.HasIndex(e => e.SapDepartment)
                    .HasName("iSapDepartment_Discipline");

                entity.HasIndex(e => e.SapDivision)
                    .HasName("iSapDivision_Discipline");

                entity.HasIndex(e => new { e.Oid, e.Name, e.ImportId, e.IsImported, e.Gcrecord, e.ObjectType })
                    .HasName("ix_20180903_Discipline");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Number).HasMaxLength(50);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.Discipline)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_Discipline_ImportSession");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.Discipline)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_Discipline_ObjectType");

                entity.HasOne(d => d.SapDepartmentNavigation)
                    .WithMany(p => p.Discipline)
                    .HasForeignKey(d => d.SapDepartment)
                    .HasConstraintName("FK_Discipline_SapDepartment");

                entity.HasOne(d => d.SapDivisionNavigation)
                    .WithMany(p => p.Discipline)
                    .HasForeignKey(d => d.SapDivision)
                    .HasConstraintName("FK_Discipline_SapDivision");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Division");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_Division");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameEnglish).HasMaxLength(100);

                entity.Property(e => e.ShortName).HasMaxLength(100);

                entity.Property(e => e.ShortNameEnglish).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.Division)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_Division_ImportSession");
            });

            modelBuilder.Entity<DivisionDivisionsContingentUnitContingentUnitCombinations>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("DivisionDivisions_ContingentUnitContingentUnitCombinations");

                entity.HasIndex(e => e.ContingentUnitCombinations)
                    .HasName("iContingentUnitCombinations_DivisionDivisions_ContingentUnitContingentUnitCombinations");

                entity.HasIndex(e => e.Divisions)
                    .HasName("iDivisions_DivisionDivisions_ContingentUnitContingentUnitCombinations");

                entity.HasIndex(e => new { e.ContingentUnitCombinations, e.Divisions })
                    .HasName("iContingentUnitCombinationsDivisions_DivisionDivisions_ContingentUnitContingentUnitCombinations")
                    .IsUnique();

                entity.HasIndex(e => new { e.ContingentUnitCombinations, e.Oid, e.OptimisticLockField, e.Divisions })
                    .HasName("ix_20180903_Divisions_ContingentUnitCombinations");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ContingentUnitCombinationsNavigation)
                    .WithMany(p => p.DivisionDivisionsContingentUnitContingentUnitCombinations)
                    .HasForeignKey(d => d.ContingentUnitCombinations)
                    .HasConstraintName("FK_DivisionDivisions_ContingentUnitContingentUnitCombinations_ContingentUnitCombinations");

                entity.HasOne(d => d.DivisionsNavigation)
                    .WithMany(p => p.DivisionDivisionsContingentUnitContingentUnitCombinations)
                    .HasForeignKey(d => d.Divisions)
                    .HasConstraintName("FK_DivisionDivisions_ContingentUnitContingentUnitCombinations_Divisions");
            });

            modelBuilder.Entity<DmBlackBoardCourse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("dm_BlackBoardCourse");
            });

            modelBuilder.Entity<DmEducator>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("dm_Educator");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.SecondName).HasMaxLength(100);

                entity.Property(e => e.UserCode).HasMaxLength(100);
            });

            modelBuilder.Entity<DmEducatorEmployment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("dm_EducatorEmployment");

                entity.Property(e => e.PositionName).HasMaxLength(255);
            });

            modelBuilder.Entity<DmEducatorsBlackBoardCourses>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("dm_EducatorsBlackBoardCourses");

                entity.Property(e => e.UserCode).HasMaxLength(100);
            });

            modelBuilder.Entity<DmGroupsBlackBoardCourses>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("dm_GroupsBlackBoardCourses");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<EducatorAssignment>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.ContingentUnit)
                    .HasName("iContingentUnit_EducatorAssignment");

                entity.HasIndex(e => e.Discipline)
                    .HasName("iDiscipline_EducatorAssignment");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EducatorAssignment");

                entity.HasIndex(e => e.Kind)
                    .HasName("iKind_EducatorAssignment");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_EducatorAssignment");

                entity.HasIndex(e => e.RealizationVariant)
                    .HasName("iRealizationVariant_EducatorAssignment");

                entity.HasIndex(e => e.StudyModuleWorkUnit)
                    .HasName("iStudyModuleWorkUnit_EducatorAssignment");

                entity.HasIndex(e => e.TermKind)
                    .HasName("iTermKind_EducatorAssignment");

                entity.HasIndex(e => e.TermName)
                    .HasName("iTermName_EducatorAssignment");

                entity.HasIndex(e => e.TimeTableKind)
                    .HasName("iTimeTableKind_EducatorAssignment");

                entity.HasIndex(e => e.Trajectory)
                    .HasName("iTrajectory_EducatorAssignment");

                entity.HasIndex(e => e.WorkUnitKind)
                    .HasName("iWorkUnitKind_EducatorAssignment");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.EducatorEmployment1).HasMaxLength(100);

                entity.Property(e => e.EducatorEmployment2).HasMaxLength(100);

                entity.Property(e => e.EducatorEmployment3).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.ContingentUnitNavigation)
                    .WithMany(p => p.EducatorAssignment)
                    .HasForeignKey(d => d.ContingentUnit)
                    .HasConstraintName("FK_EducatorAssignment_ContingentUnit");

                entity.HasOne(d => d.DisciplineNavigation)
                    .WithMany(p => p.EducatorAssignment)
                    .HasForeignKey(d => d.Discipline)
                    .HasConstraintName("FK_EducatorAssignment_Discipline");

                entity.HasOne(d => d.KindNavigation)
                    .WithMany(p => p.EducatorAssignment)
                    .HasForeignKey(d => d.Kind)
                    .HasConstraintName("FK_EducatorAssignment_Kind");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.EducatorAssignment)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_EducatorAssignment_ObjectType");

                entity.HasOne(d => d.RealizationVariantNavigation)
                    .WithMany(p => p.EducatorAssignment)
                    .HasForeignKey(d => d.RealizationVariant)
                    .HasConstraintName("FK_EducatorAssignment_RealizationVariant");

                entity.HasOne(d => d.StudyModuleWorkUnitNavigation)
                    .WithMany(p => p.EducatorAssignment)
                    .HasForeignKey(d => d.StudyModuleWorkUnit)
                    .HasConstraintName("FK_EducatorAssignment_StudyModuleWorkUnit");

                entity.HasOne(d => d.TermKindNavigation)
                    .WithMany(p => p.EducatorAssignment)
                    .HasForeignKey(d => d.TermKind)
                    .HasConstraintName("FK_EducatorAssignment_TermKind");

                entity.HasOne(d => d.TermNameNavigation)
                    .WithMany(p => p.EducatorAssignment)
                    .HasForeignKey(d => d.TermName)
                    .HasConstraintName("FK_EducatorAssignment_TermName");

                entity.HasOne(d => d.TimeTableKindNavigation)
                    .WithMany(p => p.EducatorAssignment)
                    .HasForeignKey(d => d.TimeTableKind)
                    .HasConstraintName("FK_EducatorAssignment_TimeTableKind");

                entity.HasOne(d => d.TrajectoryNavigation)
                    .WithMany(p => p.EducatorAssignment)
                    .HasForeignKey(d => d.Trajectory)
                    .HasConstraintName("FK_EducatorAssignment_Trajectory");

                entity.HasOne(d => d.WorkUnitKindNavigation)
                    .WithMany(p => p.EducatorAssignment)
                    .HasForeignKey(d => d.WorkUnitKind)
                    .HasConstraintName("FK_EducatorAssignment_WorkUnitKind");
            });

            modelBuilder.Entity<EducatorAssignmentKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Code)
                    .HasName("iCode_EducatorAssignmentKind")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EducatorAssignmentKind");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<EducatorAssignmentUnit>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.EducatorAssignment)
                    .HasName("iEducatorAssignment_EducatorAssignmentUnit");

                entity.HasIndex(e => e.EducatorEmployment)
                    .HasName("iEducatorEmployment_EducatorAssignmentUnit");

                entity.HasIndex(e => e.EducatorStudyWorkUnit)
                    .HasName("iEducatorStudyWorkUnit_EducatorAssignmentUnit");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EducatorAssignmentUnit");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.WorkHoursPlan).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.EducatorAssignmentNavigation)
                    .WithMany(p => p.EducatorAssignmentUnit)
                    .HasForeignKey(d => d.EducatorAssignment)
                    .HasConstraintName("FK_EducatorAssignmentUnit_EducatorAssignment");

                entity.HasOne(d => d.EducatorEmploymentNavigation)
                    .WithMany(p => p.EducatorAssignmentUnit)
                    .HasForeignKey(d => d.EducatorEmployment)
                    .HasConstraintName("FK_EducatorAssignmentUnit_EducatorEmployment");

                entity.HasOne(d => d.EducatorStudyWorkUnitNavigation)
                    .WithMany(p => p.EducatorAssignmentUnit)
                    .HasForeignKey(d => d.EducatorStudyWorkUnit)
                    .HasConstraintName("FK_EducatorAssignmentUnit_EducatorStudyWorkUnit");
            });

            modelBuilder.Entity<EducatorEmployment>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Category)
                    .HasName("iCategory_EducatorEmployment");

                entity.HasIndex(e => e.EducatorMasterPerson)
                    .HasName("iEducatorMasterPerson_EducatorEmployment");

                entity.HasIndex(e => e.EducatorPerson)
                    .HasName("iEducatorPerson_EducatorEmployment");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EducatorEmployment");

                entity.HasIndex(e => e.Group)
                    .HasName("iGroup_EducatorEmployment");

                entity.HasIndex(e => e.Id)
                    .HasName("iId_EducatorEmployment")
                    .IsUnique();

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_EducatorEmployment");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_EducatorEmployment");

                entity.HasIndex(e => e.Position)
                    .HasName("iPosition_EducatorEmployment");

                entity.HasIndex(e => e.SapDepartment)
                    .HasName("iSapDepartment_EducatorEmployment");

                entity.HasIndex(e => e.SapDivision)
                    .HasName("iSapDivision_EducatorEmployment");

                entity.HasIndex(e => new { e.Oid, e.DisplayName, e.SapDepartment, e.SapDivision, e.ToDate, e.IsActive, e.IsImported, e.Gcrecord, e.ObjectType, e.EmploymentId, e.FromDate })
                    .HasName("ix_20180903_EducatorEmployment");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.DisplayNameEnglish).HasMaxLength(100);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ShortDisplayName).HasMaxLength(100);

                entity.Property(e => e.ShortDisplayNameEnglish).HasMaxLength(100);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.EducatorEmployment)
                    .HasForeignKey(d => d.Category)
                    .HasConstraintName("FK_EducatorEmployment_Category");

                entity.HasOne(d => d.EducatorMasterPersonNavigation)
                    .WithMany(p => p.EducatorEmployment)
                    .HasForeignKey(d => d.EducatorMasterPerson)
                    .HasConstraintName("FK_EducatorEmployment_EducatorMasterPerson");

                entity.HasOne(d => d.EducatorPersonNavigation)
                    .WithMany(p => p.EducatorEmployment)
                    .HasForeignKey(d => d.EducatorPerson)
                    .HasConstraintName("FK_EducatorEmployment_EducatorPerson");

                entity.HasOne(d => d.GroupNavigation)
                    .WithMany(p => p.EducatorEmployment)
                    .HasForeignKey(d => d.Group)
                    .HasConstraintName("FK_EducatorEmployment_Group");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.EducatorEmployment)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_EducatorEmployment_ImportSession");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.EducatorEmployment)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_EducatorEmployment_ObjectType");

                entity.HasOne(d => d.PositionNavigation)
                    .WithMany(p => p.EducatorEmployment)
                    .HasForeignKey(d => d.Position)
                    .HasConstraintName("FK_EducatorEmployment_Position");

                entity.HasOne(d => d.SapDepartmentNavigation)
                    .WithMany(p => p.EducatorEmployment)
                    .HasForeignKey(d => d.SapDepartment)
                    .HasConstraintName("FK_EducatorEmployment_SapDepartment");

                entity.HasOne(d => d.SapDivisionNavigation)
                    .WithMany(p => p.EducatorEmployment)
                    .HasForeignKey(d => d.SapDivision)
                    .HasConstraintName("FK_EducatorEmployment_SapDivision");
            });

            modelBuilder.Entity<EducatorEmploymentCategory>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EducatorEmploymentCategory");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_EducatorEmploymentCategory");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.EducatorEmploymentCategory)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_EducatorEmploymentCategory_ImportSession");
            });

            modelBuilder.Entity<EducatorEmploymentGroup>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EducatorEmploymentGroup");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_EducatorEmploymentGroup");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.EducatorEmploymentGroup)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_EducatorEmploymentGroup_ImportSession");
            });

            modelBuilder.Entity<EducatorEmploymentPosition>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EducatorEmploymentPosition");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_EducatorEmploymentPosition");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.NameEnglish).HasMaxLength(100);

                entity.Property(e => e.ShortName).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.EducatorEmploymentPosition)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_EducatorEmploymentPosition_ImportSession");
            });

            modelBuilder.Entity<EducatorMasterPerson>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.DisplayName)
                    .HasName("iDisplayName_EducatorMasterPerson");

                entity.HasIndex(e => e.DisplayNameEnglish)
                    .HasName("iDisplayNameEnglish_EducatorMasterPerson");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EducatorMasterPerson");

                entity.HasIndex(e => e.Id)
                    .HasName("iId_EducatorMasterPerson")
                    .IsUnique();

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_EducatorMasterPerson");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_EducatorMasterPerson");

                entity.HasIndex(e => e.UniqueLabel)
                    .HasName("iUniqueLabel_EducatorMasterPerson")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.DisplayNameEnglish).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.UniqueLabel).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.EducatorMasterPerson)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_EducatorMasterPerson_ImportSession");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.EducatorMasterPerson)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_EducatorMasterPerson_ObjectType");
            });

            modelBuilder.Entity<EducatorPerson>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Degree)
                    .HasName("iDegree_EducatorPerson");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EducatorPerson");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_EducatorPerson");

                entity.HasIndex(e => e.MasterPerson)
                    .HasName("iMasterPerson_EducatorPerson");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_EducatorPerson");

                entity.HasIndex(e => e.Title)
                    .HasName("iTitle_EducatorPerson");

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.MiddleName, e.Gcrecord, e.ObjectType, e.PersonId, e.Title, e.Degree })
                    .HasName("ix_20180903_EducatorPerson");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Login).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(100);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.DegreeNavigation)
                    .WithMany(p => p.EducatorPerson)
                    .HasForeignKey(d => d.Degree)
                    .HasConstraintName("FK_EducatorPerson_Degree");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.EducatorPerson)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_EducatorPerson_ImportSession");

                entity.HasOne(d => d.MasterPersonNavigation)
                    .WithMany(p => p.EducatorPerson)
                    .HasForeignKey(d => d.MasterPerson)
                    .HasConstraintName("FK_EducatorPerson_MasterPerson");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.EducatorPerson)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_EducatorPerson_ObjectType");

                entity.HasOne(d => d.TitleNavigation)
                    .WithMany(p => p.EducatorPerson)
                    .HasForeignKey(d => d.Title)
                    .HasConstraintName("FK_EducatorPerson_Title");
            });

            modelBuilder.Entity<EducatorPersonDegree>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_EducatorEmploymentDegree");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EducatorEmploymentDegree");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_EducatorEmploymentDegree");

                entity.HasIndex(e => e.Name)
                    .HasName("iName_EducatorEmploymentDegree")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.EducatorPersonDegree)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_EducatorEmploymentDegree_ImportSession");
            });

            modelBuilder.Entity<EducatorPersonTitle>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_EducatorEmploymentTitle");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EducatorEmploymentTitle");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_EducatorEmploymentTitle");

                entity.HasIndex(e => e.Name)
                    .HasName("iName_EducatorEmploymentTitle")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.EducatorPersonTitle)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_EducatorEmploymentTitle_ImportSession");
            });

            modelBuilder.Entity<EducatorStudyWork>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Discipline)
                    .HasName("iDiscipline_EducatorStudyWork");

                entity.HasIndex(e => e.Division)
                    .HasName("iDivision_EducatorStudyWork");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EducatorStudyWork");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_EducatorStudyWork");

                entity.HasIndex(e => e.RealizationVariant)
                    .HasName("iRealizationVariant_EducatorStudyWork");

                entity.HasIndex(e => e.SapDivision)
                    .HasName("iSapDivision_EducatorStudyWork");

                entity.HasIndex(e => e.StudyForm)
                    .HasName("iStudyForm_EducatorStudyWork");

                entity.HasIndex(e => e.StudyModuleWorkKind)
                    .HasName("iStudyModuleWorkKind_EducatorStudyWork");

                entity.HasIndex(e => e.StudyYear)
                    .HasName("iStudyYear_EducatorStudyWork");

                entity.HasIndex(e => e.TermName)
                    .HasName("iTermName_EducatorStudyWork");

                entity.HasIndex(e => e.Trajectory)
                    .HasName("iTrajectory_EducatorStudyWork");

                entity.HasIndex(e => new { e.Oid, e.Division, e.StudyYear, e.Discipline, e.RealizationVariant, e.Trajectory, e.TermName, e.StudyModuleWorkKind, e.Name, e.Author, e.Comment, e.SapDivision, e.Gcrecord })
                    .HasName("ix_20180903_EducatorStudyWork");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Author).HasMaxLength(100);

                entity.Property(e => e.Comment).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.DisciplineNavigation)
                    .WithMany(p => p.EducatorStudyWork)
                    .HasForeignKey(d => d.Discipline)
                    .HasConstraintName("FK_EducatorStudyWork_Discipline");

                entity.HasOne(d => d.DivisionNavigation)
                    .WithMany(p => p.EducatorStudyWork)
                    .HasForeignKey(d => d.Division)
                    .HasConstraintName("FK_EducatorStudyWork_Division");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.EducatorStudyWork)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_EducatorStudyWork_ImportSession");

                entity.HasOne(d => d.RealizationVariantNavigation)
                    .WithMany(p => p.EducatorStudyWork)
                    .HasForeignKey(d => d.RealizationVariant)
                    .HasConstraintName("FK_EducatorStudyWork_RealizationVariant");

                entity.HasOne(d => d.SapDivisionNavigation)
                    .WithMany(p => p.EducatorStudyWork)
                    .HasForeignKey(d => d.SapDivision)
                    .HasConstraintName("FK_EducatorStudyWork_SapDivision");

                entity.HasOne(d => d.StudyFormNavigation)
                    .WithMany(p => p.EducatorStudyWork)
                    .HasForeignKey(d => d.StudyForm)
                    .HasConstraintName("FK_EducatorStudyWork_StudyForm");

                entity.HasOne(d => d.StudyModuleWorkKindNavigation)
                    .WithMany(p => p.EducatorStudyWork)
                    .HasForeignKey(d => d.StudyModuleWorkKind)
                    .HasConstraintName("FK_EducatorStudyWork_StudyModuleWorkKind");

                entity.HasOne(d => d.StudyYearNavigation)
                    .WithMany(p => p.EducatorStudyWork)
                    .HasForeignKey(d => d.StudyYear)
                    .HasConstraintName("FK_EducatorStudyWork_StudyYear");

                entity.HasOne(d => d.TermNameNavigation)
                    .WithMany(p => p.EducatorStudyWork)
                    .HasForeignKey(d => d.TermName)
                    .HasConstraintName("FK_EducatorStudyWork_TermName");

                entity.HasOne(d => d.TrajectoryNavigation)
                    .WithMany(p => p.EducatorStudyWork)
                    .HasForeignKey(d => d.Trajectory)
                    .HasConstraintName("FK_EducatorStudyWork_Trajectory");
            });

            modelBuilder.Entity<EducatorStudyWorkEducatorStudyWorksContingentUnitContingentUnits>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("EducatorStudyWorkEducatorStudyWorks_ContingentUnitContingentUnits");

                entity.HasIndex(e => e.ContingentUnits)
                    .HasName("iContingentUnits_EducatorStudyWorkEducatorStudyWorks_ContingentUnitContingentUnits");

                entity.HasIndex(e => e.EducatorStudyWorks)
                    .HasName("iEducatorStudyWorks_EducatorStudyWorkEducatorStudyWorks_ContingentUnitContingentUnits");

                entity.HasIndex(e => new { e.ContingentUnits, e.EducatorStudyWorks })
                    .HasName("iContingentUnitsEducatorStudyWorks_EducatorStudyWorkEducatorStudyWorks_ContingentUnitContingentUnits")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ContingentUnitsNavigation)
                    .WithMany(p => p.EducatorStudyWorkEducatorStudyWorksContingentUnitContingentUnits)
                    .HasForeignKey(d => d.ContingentUnits)
                    .HasConstraintName("FK_EducatorStudyWorkEducatorStudyWorks_ContingentUnitContingentUnits_ContingentUnits");

                entity.HasOne(d => d.EducatorStudyWorksNavigation)
                    .WithMany(p => p.EducatorStudyWorkEducatorStudyWorksContingentUnitContingentUnits)
                    .HasForeignKey(d => d.EducatorStudyWorks)
                    .HasConstraintName("FK_EducatorStudyWorkEducatorStudyWorks_ContingentUnitContingentUnits_EducatorStudyWorks");
            });

            modelBuilder.Entity<EducatorStudyWorkUnit>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Discipline)
                    .HasName("iDiscipline_EducatorStudyWorkUnit");

                entity.HasIndex(e => e.Division)
                    .HasName("iDivision_EducatorStudyWorkUnit");

                entity.HasIndex(e => e.EducatorEmployment)
                    .HasName("iEducatorEmployment_EducatorStudyWorkUnit");

                entity.HasIndex(e => e.EducatorStudyWork)
                    .HasName("iEducatorStudyWork_EducatorStudyWorkUnit");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EducatorStudyWorkUnit");

                entity.HasIndex(e => e.LastChangeUser)
                    .HasName("iLastChangeUser_EducatorStudyWorkUnit");

                entity.HasIndex(e => e.RealizationVariant)
                    .HasName("iRealizationVariant_EducatorStudyWorkUnit");

                entity.HasIndex(e => e.SapDepartment)
                    .HasName("iSapDepartment_EducatorStudyWorkUnit");

                entity.HasIndex(e => e.SapDivision)
                    .HasName("iSapDivision_EducatorStudyWorkUnit");

                entity.HasIndex(e => e.StudyModuleWorkKind)
                    .HasName("iStudyModuleWorkKind_EducatorStudyWorkUnit");

                entity.HasIndex(e => e.StudyYear)
                    .HasName("iStudyYear_EducatorStudyWorkUnit");

                entity.HasIndex(e => e.TermName)
                    .HasName("iTermName_EducatorStudyWorkUnit");

                entity.HasIndex(e => e.Trajectory)
                    .HasName("iTrajectory_EducatorStudyWorkUnit");

                entity.HasIndex(e => new { e.Oid, e.EmploymentId, e.SapDepartment, e.SapDivision, e.ContingentString, e.StudyYear, e.EducatorStudyWork, e.EducatorEmployment, e.WorkHours, e.Order, e.Discipline, e.RealizationVariant, e.Trajectory, e.TermName, e.StudyModuleWorkKind, e.DivisionString, e.WorkHoursFact, e.StudyPlansString, e.StudyProgramsString, e.Gcrecord })
                    .HasName("ix_20180903_EducatorStudyWorkUnit");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.ContingentString).HasColumnType("nvarchar(max)");

                entity.Property(e => e.DivisionString).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastChangeDateTime).HasColumnType("datetime");

                entity.Property(e => e.StudyPlansString).HasColumnType("nvarchar(max)");

                entity.Property(e => e.StudyProgramsString).HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.DisciplineNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnit)
                    .HasForeignKey(d => d.Discipline)
                    .HasConstraintName("FK_EducatorStudyWorkUnit_Discipline");

                entity.HasOne(d => d.DivisionNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnit)
                    .HasForeignKey(d => d.Division)
                    .HasConstraintName("FK_EducatorStudyWorkUnit_Division");

                entity.HasOne(d => d.EducatorEmploymentNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnit)
                    .HasForeignKey(d => d.EducatorEmployment)
                    .HasConstraintName("FK_EducatorStudyWorkUnit_EducatorEmployment");

                entity.HasOne(d => d.EducatorStudyWorkNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnit)
                    .HasForeignKey(d => d.EducatorStudyWork)
                    .HasConstraintName("FK_EducatorStudyWorkUnit_EducatorStudyWork");

                entity.HasOne(d => d.LastChangeUserNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnit)
                    .HasForeignKey(d => d.LastChangeUser)
                    .HasConstraintName("FK_EducatorStudyWorkUnit_LastChangeUser");

                entity.HasOne(d => d.RealizationVariantNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnit)
                    .HasForeignKey(d => d.RealizationVariant)
                    .HasConstraintName("FK_EducatorStudyWorkUnit_RealizationVariant");

                entity.HasOne(d => d.SapDepartmentNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnit)
                    .HasForeignKey(d => d.SapDepartment)
                    .HasConstraintName("FK_EducatorStudyWorkUnit_SapDepartment");

                entity.HasOne(d => d.SapDivisionNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnit)
                    .HasForeignKey(d => d.SapDivision)
                    .HasConstraintName("FK_EducatorStudyWorkUnit_SapDivision");

                entity.HasOne(d => d.StudyModuleWorkKindNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnit)
                    .HasForeignKey(d => d.StudyModuleWorkKind)
                    .HasConstraintName("FK_EducatorStudyWorkUnit_StudyModuleWorkKind");

                entity.HasOne(d => d.StudyYearNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnit)
                    .HasForeignKey(d => d.StudyYear)
                    .HasConstraintName("FK_EducatorStudyWorkUnit_StudyYear");

                entity.HasOne(d => d.TermNameNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnit)
                    .HasForeignKey(d => d.TermName)
                    .HasConstraintName("FK_EducatorStudyWorkUnit_TermName");

                entity.HasOne(d => d.TrajectoryNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnit)
                    .HasForeignKey(d => d.Trajectory)
                    .HasConstraintName("FK_EducatorStudyWorkUnit_Trajectory");
            });

            modelBuilder.Entity<EducatorStudyWorkUnitComment>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Author)
                    .HasName("iAuthor_EducatorStudyWorkUnitComment");

                entity.HasIndex(e => e.EducatorStudyWorkUnit)
                    .HasName("iEducatorStudyWorkUnit_EducatorStudyWorkUnitComment");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EducatorStudyWorkUnitComment");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_EducatorStudyWorkUnitComment");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.AuthorNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnitComment)
                    .HasForeignKey(d => d.Author)
                    .HasConstraintName("FK_EducatorStudyWorkUnitComment_Author");

                entity.HasOne(d => d.EducatorStudyWorkUnitNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnitComment)
                    .HasForeignKey(d => d.EducatorStudyWorkUnit)
                    .HasConstraintName("FK_EducatorStudyWorkUnitComment_EducatorStudyWorkUnit");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnitComment)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_EducatorStudyWorkUnitComment_ObjectType");
            });

            modelBuilder.Entity<EducatorStudyWorkUnitEducatorStudyWorkUnitsContingentUnitContingentUnitCombinations>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("EducatorStudyWorkUnitEducatorStudyWorkUnits_ContingentUnitContingentUnitCombinations");

                entity.HasIndex(e => e.ContingentUnitCombinations)
                    .HasName("iContingentUnitCombinations_EducatorStudyWorkUnitEducatorStudyWorkUnits_ContingentUnitContingentUnitCombinations");

                entity.HasIndex(e => e.EducatorStudyWorkUnits)
                    .HasName("iEducatorStudyWorkUnits_EducatorStudyWorkUnitEducatorStudyWorkUnits_ContingentUnitContingentUnitCombinations");

                entity.HasIndex(e => new { e.ContingentUnitCombinations, e.EducatorStudyWorkUnits })
                    .HasName("iContingentUnitCombinationsEducatorStudyWorkUnits_EducatorStudyWorkUnitEducatorStudyWorkUnits_ContingentUnitContingentU_19B208CF")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ContingentUnitCombinationsNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnitEducatorStudyWorkUnitsContingentUnitContingentUnitCombinations)
                    .HasForeignKey(d => d.ContingentUnitCombinations)
                    .HasConstraintName("FK_EducatorStudyWorkUnitEducatorStudyWorkUnits_ContingentUnitContingentUnitCombinations_ContingentUnitCombinations");

                entity.HasOne(d => d.EducatorStudyWorkUnitsNavigation)
                    .WithMany(p => p.EducatorStudyWorkUnitEducatorStudyWorkUnitsContingentUnitContingentUnitCombinations)
                    .HasForeignKey(d => d.EducatorStudyWorkUnits)
                    .HasConstraintName("FK_EducatorStudyWorkUnitEducatorStudyWorkUnits_ContingentUnitContingentUnitCombinations_EducatorStudyWorkUnits");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.AttendanceKind)
                    .HasName("iAttendanceKind_Event");

                entity.HasIndex(e => e.ContingentUnit)
                    .HasName("iContingentUnit_StudyEvent");

                entity.HasIndex(e => e.Division)
                    .HasName("iDivision_StudyEvent");

                entity.HasIndex(e => e.EducatorAssignment)
                    .HasName("iEducatorAssignment_StudyEvent");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyEvent");

                entity.HasIndex(e => e.Id)
                    .HasName("iId_Event")
                    .IsUnique();

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_Event");

                entity.HasIndex(e => e.Kind)
                    .HasName("iKind_Event");

                entity.HasIndex(e => e.LastChangeUser)
                    .HasName("iLastChangeUser_Event");

                entity.HasIndex(e => e.MasterEvent)
                    .HasName("iMasterEvent_Event");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_Event");

                entity.HasIndex(e => e.PatternEvent)
                    .HasName("iPatternEvent_Event");

                entity.HasIndex(e => e.Sequence)
                    .HasName("iSequence_Event");

                entity.HasIndex(e => e.StudyEventsTimeTableKind)
                    .HasName("iStudyEventsTimeTableKind_Event");

                entity.HasIndex(e => e.Subkind)
                    .HasName("iSubkind_Event");

                entity.HasIndex(e => e.TermKind)
                    .HasName("iTermKind_StudyEvent");

                entity.HasIndex(e => e.TimeTable)
                    .HasName("iTimeTable_Event");

                entity.HasIndex(e => e.Trajectory)
                    .HasName("iTrajectory_Event");

                entity.HasIndex(e => e.XtracurAddress)
                    .HasName("iXtracurAddress_Event");

                entity.HasIndex(e => e.XtracurImageAttachment)
                    .HasName("iXtracurImageAttachment_Event");

                entity.HasIndex(e => new { e.Gcrecord, e.Type, e.RecurId, e.RecurIndex })
                    .HasName("iEvent_ChangedAndDeleted");

                entity.HasIndex(e => new { e.Id, e.Properties, e.Subject, e.SubjectEnglish, e.EducatorsDisplayText, e.EducatorsDisplayTextEnglish, e.LocationsDisplayText, e.LocationsDisplayTextEnglish, e.RecurId, e.StudyEventsTimeTableKind, e.Cohort, e.Gcrecord, e.Type, e.ContingentUnit, e.EducatorAssignment, e.WebAvailability })
                    .HasName("iEvent_Pattern")
                    .HasFilter("([Type]=(1) AND [GCRecord] IS NULL)");

                entity.HasIndex(e => new { e.Id, e.Properties, e.Subject, e.SubjectEnglish, e.EducatorsDisplayText, e.EducatorsDisplayTextEnglish, e.LocationsDisplayText, e.LocationsDisplayTextEnglish, e.StudyEventsTimeTableKind, e.Cohort, e.Gcrecord, e.Type, e.Start, e.End, e.ContingentUnit, e.EducatorAssignment, e.WebAvailability })
                    .HasName("iEvent_Normal")
                    .HasFilter("([Type]=(0) AND [GCRecord] IS NULL)");

                entity.HasIndex(e => new { e.Id, e.End, e.Properties, e.Subject, e.SubjectEnglish, e.EducatorsDisplayText, e.EducatorsDisplayTextEnglish, e.LocationsDisplayText, e.LocationsDisplayTextEnglish, e.RecurIndex, e.StudyEventsTimeTableKind, e.Cohort, e.Gcrecord, e.Type, e.ContingentUnit, e.EducatorAssignment, e.Start, e.WebAvailability })
                    .HasName("iEvent_Changed")
                    .HasFilter("([Type]=(3) AND [GCRecord] IS NULL)");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.AssignedDateTime).HasColumnType("datetime");

                entity.Property(e => e.EducatorsDisplayText).HasColumnType("nvarchar(max)");

                entity.Property(e => e.EducatorsDisplayTextEnglish).HasColumnType("nvarchar(max)");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IssuedDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastChangeDateTime).HasColumnType("datetime");

                entity.Property(e => e.LocationsDisplayText).HasColumnType("nvarchar(max)");

                entity.Property(e => e.LocationsDisplayTextEnglish).HasColumnType("nvarchar(max)");

                entity.Property(e => e.RecurrenceInfo).HasColumnType("xml");

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasColumnType("nvarchar(max)");

                entity.Property(e => e.SubjectEnglish).HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.AttendanceKindNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.AttendanceKind)
                    .HasConstraintName("FK_Event_AttendanceKind");

                entity.HasOne(d => d.ContingentUnitNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.ContingentUnit)
                    .HasConstraintName("FK_Event_ContingentUnit");

                entity.HasOne(d => d.EducatorAssignmentNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.EducatorAssignment)
                    .HasConstraintName("FK_Event_EducatorAssignment");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_Event_ImportSession");

                entity.HasOne(d => d.KindNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.Kind)
                    .HasConstraintName("FK_Event_Kind");

                entity.HasOne(d => d.LastChangeUserNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.LastChangeUser)
                    .HasConstraintName("FK_Event_LastChangeUser");

                entity.HasOne(d => d.MasterEventNavigation)
                    .WithMany(p => p.InverseMasterEventNavigation)
                    .HasForeignKey(d => d.MasterEvent)
                    .HasConstraintName("FK_Event_MasterEvent");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_Event_ObjectType");

                entity.HasOne(d => d.PatternEventNavigation)
                    .WithMany(p => p.InversePatternEventNavigation)
                    .HasForeignKey(d => d.PatternEvent)
                    .HasConstraintName("FK_Event_PatternEvent");

                entity.HasOne(d => d.SequenceNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.Sequence)
                    .HasConstraintName("FK_Event_Sequence");

                entity.HasOne(d => d.StudyEventsTimeTableKindNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.StudyEventsTimeTableKind)
                    .HasConstraintName("FK_Event_StudyEventsTimeTableKind");

                entity.HasOne(d => d.SubkindNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.Subkind)
                    .HasConstraintName("FK_Event_Subkind");

                entity.HasOne(d => d.TermKindNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.TermKind)
                    .HasConstraintName("FK_Event_TermKind");

                entity.HasOne(d => d.TimeTableNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.TimeTable)
                    .HasConstraintName("FK_Event_TimeTable");

                entity.HasOne(d => d.TrajectoryNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.Trajectory)
                    .HasConstraintName("FK_Event_Trajectory");

                entity.HasOne(d => d.XtracurAddressNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.XtracurAddress)
                    .HasConstraintName("FK_Event_XtracurAddress");

                entity.HasOne(d => d.XtracurImageAttachmentNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.XtracurImageAttachment)
                    .HasConstraintName("FK_Event_XtracurImageAttachment");
            });

            modelBuilder.Entity<EventFlatten>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EventFlatten");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Start).HasColumnType("datetime");
            });

            modelBuilder.Entity<EventKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EventKind");

                entity.HasIndex(e => e.XtracurDivision)
                    .HasName("iXtracurDivision_EventKind");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.XtracurDivisionNavigation)
                    .WithMany(p => p.EventKind)
                    .HasForeignKey(d => d.XtracurDivision)
                    .HasConstraintName("FK_EventKind_XtracurDivision");
            });

            modelBuilder.Entity<EventKindAvailableEventKindsBaseTimeTableKindAvailableTimeTableKinds>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("EventKindAvailableEventKinds_BaseTimeTableKindAvailableTimeTableKinds");

                entity.HasIndex(e => e.AvailableEventKinds)
                    .HasName("iAvailableEventKinds_EventKindAvailableEventKinds_BaseTimeTableKindAvailableTimeTableKinds");

                entity.HasIndex(e => e.AvailableTimeTableKinds)
                    .HasName("iAvailableTimeTableKinds_EventKindAvailableEventKinds_BaseTimeTableKindAvailableTimeTableKinds");

                entity.HasIndex(e => new { e.AvailableTimeTableKinds, e.AvailableEventKinds })
                    .HasName("iAvailableTimeTableKindsAvailableEventKinds_EventKindAvailableEventKinds_BaseTimeTableKindAvailableTimeTableKinds")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.AvailableEventKindsNavigation)
                    .WithMany(p => p.EventKindAvailableEventKindsBaseTimeTableKindAvailableTimeTableKinds)
                    .HasForeignKey(d => d.AvailableEventKinds)
                    .HasConstraintName("FK_EventKindAvailableEventKinds_BaseTimeTableKindAvailableTimeTableKinds_AvailableEventKinds");

                entity.HasOne(d => d.AvailableTimeTableKindsNavigation)
                    .WithMany(p => p.EventKindAvailableEventKindsBaseTimeTableKindAvailableTimeTableKinds)
                    .HasForeignKey(d => d.AvailableTimeTableKinds)
                    .HasConstraintName("FK_EventKindAvailableEventKinds_BaseTimeTableKindAvailableTimeTableKinds_AvailableTimeTableKinds");
            });

            modelBuilder.Entity<EventLocation>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Event)
                    .HasName("iEvent_EventLocation");

                entity.HasIndex(e => e.EventLocation1)
                    .HasName("iEventLocation_StudyEventLocation");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyEventLocation");

                entity.HasIndex(e => e.Location)
                    .HasName("iLocation_EventLocation");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_EventLocation");

                entity.HasIndex(e => e.StudyEvent)
                    .HasName("iStudyEvent_StudyEventLocation");

                entity.HasIndex(e => new { e.Gcrecord, e.Location, e.Event })
                    .HasName("ix_20180903_EventLocation");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.EventLocation1).HasColumnName("EventLocation");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.EventNavigation)
                    .WithMany(p => p.EventLocation)
                    .HasForeignKey(d => d.Event)
                    .HasConstraintName("FK_EventLocation_Event");

                entity.HasOne(d => d.LocationNavigation)
                    .WithMany(p => p.EventLocation)
                    .HasForeignKey(d => d.Location)
                    .HasConstraintName("FK_EventLocation_Location");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.EventLocation)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_EventLocation_ObjectType");
            });

            modelBuilder.Entity<EventSequence>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EventSequence");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<EventSubkind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EventSubkind");

                entity.HasIndex(e => e.Kind)
                    .HasName("iKind_EventSubkind");

                entity.HasIndex(e => new { e.Name, e.Gcrecord, e.Kind })
                    .HasName("iNameGCRecordKind_EventSubkind")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.OrderIndex).HasColumnType("money");

                entity.HasOne(d => d.KindNavigation)
                    .WithMany(p => p.EventSubkind)
                    .HasForeignKey(d => d.Kind)
                    .HasConstraintName("FK_EventSubkind_Kind");
            });

            modelBuilder.Entity<ExtBbCourse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ext_BB_Course");
            });

            modelBuilder.Entity<ExtBbEducator>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ext_BB_Educator");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.SecondName).HasMaxLength(100);

                entity.Property(e => e.UserCode).HasMaxLength(100);
            });

            modelBuilder.Entity<ExtBbEducatorsCourses>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ext_BB_EducatorsCourses");

                entity.Property(e => e.UserCode).HasMaxLength(100);
            });

            modelBuilder.Entity<ExtBbGroupsCourses>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ext_BB_GroupsCourses");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Holiday");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Day).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<ImportSession>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_ImportSession");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.ExportDateTime).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.ImportDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ImportedAssignmentRegistry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Imported_AssignmentRegistry");

                entity.Property(e => e.Bb)
                    .HasColumnName("BB")
                    .HasMaxLength(255);

                entity.Property(e => e.EMail)
                    .HasColumnName("eMail")
                    .HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(255);

                entity.Property(e => e.ВидУчебнойРаботы)
                    .HasColumnName("Вид учебной работы")
                    .HasMaxLength(255);

                entity.Property(e => e.ГлПодр)
                    .HasColumnName("Гл# подр#")
                    .HasMaxLength(255);

                entity.Property(e => e.ГодПланирования)
                    .HasColumnName("Год планирования")
                    .HasMaxLength(255);

                entity.Property(e => e.ДР)
                    .HasColumnName("Д#р#")
                    .HasMaxLength(255);

                entity.Property(e => e.Дата).HasMaxLength(255);

                entity.Property(e => e.Должность).HasMaxLength(255);

                entity.Property(e => e.Должность1).HasMaxLength(255);

                entity.Property(e => e.ДоляСтавки)
                    .HasColumnName("Доля ставки")
                    .HasMaxLength(255);

                entity.Property(e => e.Имя).HasMaxLength(255);

                entity.Property(e => e.Кафедра).HasMaxLength(255);

                entity.Property(e => e.КафедраНазначения)
                    .HasColumnName("Кафедра назначения")
                    .HasMaxLength(255);

                entity.Property(e => e.Код).HasMaxLength(255);

                entity.Property(e => e.Комментарии).HasMaxLength(255);

                entity.Property(e => e.КонецТрДог)
                    .HasColumnName("конец тр#дог#")
                    .HasMaxLength(255);

                entity.Property(e => e.НаименованиеДисц)
                    .HasColumnName("Наименование дисц")
                    .HasMaxLength(255);

                entity.Property(e => e.НаименованиеПедзадания)
                    .HasColumnName("Наименование педзадания")
                    .HasMaxLength(255);

                entity.Property(e => e.НаименованиеПрограммы).HasColumnName("Наименование программы");

                entity.Property(e => e.Направление).HasMaxLength(255);

                entity.Property(e => e.НеобходимостьДгпх)
                    .HasColumnName("Необходимость ДГПХ")
                    .HasMaxLength(255);

                entity.Property(e => e.НомерГруппы)
                    .HasColumnName("Номер группы")
                    .HasMaxLength(255);

                entity.Property(e => e.НомерДисц)
                    .HasColumnName("Номер дисц")
                    .HasMaxLength(255);

                entity.Property(e => e.Отчество).HasMaxLength(255);

                entity.Property(e => e.ПериодОбучения)
                    .HasColumnName("Период обучения")
                    .HasMaxLength(255);

                entity.Property(e => e.ПерсИд)
                    .HasColumnName("Перс#ид#")
                    .HasMaxLength(255);

                entity.Property(e => e.Персонал).HasMaxLength(255);

                entity.Property(e => e.План).HasMaxLength(255);

                entity.Property(e => e.Подр2Ур)
                    .HasColumnName("Подр# 2 ур#")
                    .HasMaxLength(255);

                entity.Property(e => e.Подразделение).HasMaxLength(255);

                entity.Property(e => e.Подразделение1Уровня)
                    .HasColumnName("Подразделение 1 уровня")
                    .HasMaxLength(255);

                entity.Property(e => e.Примечание).HasMaxLength(255);

                entity.Property(e => e.Профиль).HasMaxLength(255);

                entity.Property(e => e.Таб)
                    .HasColumnName("Таб#№")
                    .HasMaxLength(255);

                entity.Property(e => e.Фамилия).HasMaxLength(255);

                entity.Property(e => e.Фио)
                    .HasColumnName("ФИО")
                    .HasMaxLength(255);

                entity.Property(e => e.ФиоПотенциальногоКандидата)
                    .HasColumnName("ФИО потенциального кандидата")
                    .HasMaxLength(255);

                entity.Property(e => e.ЧасовКонтактнойРаботы)
                    .HasColumnName("Часов контактной работы")
                    .HasMaxLength(255);

                entity.Property(e => e.ЧислоОбучающихся)
                    .HasColumnName("Число обучающихся")
                    .HasMaxLength(255);

                entity.Property(e => e.Шифр).HasMaxLength(255);

                entity.Property(e => e.ШифрПрограммы)
                    .HasColumnName("Шифр программы")
                    .HasMaxLength(255);

                entity.Property(e => e.Штат).HasMaxLength(255);
            });

            modelBuilder.Entity<ImportedLocationInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Addinfo)
                    .HasColumnName("addinfo")
                    .HasMaxLength(255);

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(255);

                entity.Property(e => e.Вместимость).HasMaxLength(255);

                entity.Property(e => e.Оборудование).HasMaxLength(255);

                entity.Property(e => e.Площадь).HasMaxLength(255);

                entity.Property(e => e.ТипАудитории)
                    .HasColumnName("Тип аудитории")
                    .HasMaxLength(255);

                entity.Property(e => e.Этаж).HasMaxLength(255);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Address)
                    .HasName("iAddress_EventLocation");

                entity.HasIndex(e => e.ClassroomKind)
                    .HasName("iClassroomKind_EventLocation");

                entity.HasIndex(e => e.Floor)
                    .HasName("iFloor_EventLocation");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EventLocation");

                entity.HasIndex(e => e.Id)
                    .HasName("iId_Location")
                    .IsUnique();

                entity.HasIndex(e => e.LastChangeUser)
                    .HasName("iLastChangeUser_Location");

                entity.HasIndex(e => e.LocationKind)
                    .HasName("iLocationKind_EventLocation");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_EventLocation");

                entity.HasIndex(e => e.SapRoom)
                    .HasName("iSapRoom_Location");

                entity.HasIndex(e => e.SapRoomKind)
                    .HasName("iSapRoomKind_Location");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.AdditionalInfo).HasMaxLength(100);

                entity.Property(e => e.DisplayName1).HasMaxLength(100);

                entity.Property(e => e.DisplayName2).HasMaxLength(250);

                entity.Property(e => e.DisplayName3).HasMaxLength(300);

                entity.Property(e => e.DisplayNameEnglish1).HasMaxLength(150);

                entity.Property(e => e.DisplayNameEnglish2).HasMaxLength(300);

                entity.Property(e => e.DisplayNameEnglish3).HasMaxLength(400);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.JurfakClassroomName).HasMaxLength(100);

                entity.Property(e => e.LastChangeDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameEnglish).HasMaxLength(100);

                entity.Property(e => e.NumberActual).HasMaxLength(100);

                entity.Property(e => e.NumberActualOld).HasMaxLength(100);

                entity.Property(e => e.NumberProjected).HasMaxLength(100);

                entity.Property(e => e.SetUnavailableOnDay).HasColumnType("datetime");

                entity.HasOne(d => d.AddressNavigation)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.Address)
                    .HasConstraintName("FK_Location_Address");

                entity.HasOne(d => d.ClassroomKindNavigation)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.ClassroomKind)
                    .HasConstraintName("FK_Location_ClassroomKind");

                entity.HasOne(d => d.FloorNavigation)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.Floor)
                    .HasConstraintName("FK_Location_Floor");

                entity.HasOne(d => d.LastChangeUserNavigation)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.LastChangeUser)
                    .HasConstraintName("FK_Location_LastChangeUser");

                entity.HasOne(d => d.LocationKindNavigation)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.LocationKind)
                    .HasConstraintName("FK_Location_LocationKind");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_Location_ObjectType");

                entity.HasOne(d => d.SapRoomNavigation)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.SapRoom)
                    .HasConstraintName("FK_Location_SapRoom");

                entity.HasOne(d => d.SapRoomKindNavigation)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.SapRoomKind)
                    .HasConstraintName("FK_Location_SapRoomKind");
            });

            modelBuilder.Entity<LocationClassroomsClassroomAccessKindClassroomAccessKinds>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("LocationClassrooms_ClassroomAccessKindClassroomAccessKinds");

                entity.HasIndex(e => e.ClassroomAccessKinds)
                    .HasName("iClassroomAccessKinds_LocationClassrooms_ClassroomAccessKindClassroomAccessKinds");

                entity.HasIndex(e => e.Classrooms)
                    .HasName("iClassrooms_LocationClassrooms_ClassroomAccessKindClassroomAccessKinds");

                entity.HasIndex(e => new { e.ClassroomAccessKinds, e.Classrooms })
                    .HasName("iClassroomAccessKindsClassrooms_LocationClassrooms_ClassroomAccessKindClassroomAccessKinds")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ClassroomAccessKindsNavigation)
                    .WithMany(p => p.LocationClassroomsClassroomAccessKindClassroomAccessKinds)
                    .HasForeignKey(d => d.ClassroomAccessKinds)
                    .HasConstraintName("FK_LocationClassrooms_ClassroomAccessKindClassroomAccessKinds_ClassroomAccessKinds");

                entity.HasOne(d => d.ClassroomsNavigation)
                    .WithMany(p => p.LocationClassroomsClassroomAccessKindClassroomAccessKinds)
                    .HasForeignKey(d => d.Classrooms)
                    .HasConstraintName("FK_LocationClassrooms_ClassroomAccessKindClassroomAccessKinds_Classrooms");
            });

            modelBuilder.Entity<LocationEducator>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_StudyEventLocationEmployment");

                entity.HasIndex(e => e.Educator)
                    .HasName("iEducator_LocationEducator");

                entity.HasIndex(e => e.EducatorAssignmentUnit)
                    .HasName("iEducatorAssignmentUnit_LocationEducator");

                entity.HasIndex(e => e.EducatorEmployment)
                    .HasName("iEducatorEmployment_StudyEventLocationEmployment");

                entity.HasIndex(e => e.EventLocation)
                    .HasName("iEventLocation_LocationEducator");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyEventLocationEmployment");

                entity.HasIndex(e => e.StudyEventLocation)
                    .HasName("iStudyEventLocation_StudyEventLocationEmployment");

                entity.HasIndex(e => new { e.EducatorEmployment, e.Gcrecord })
                    .HasName("ix_20180903_LocationEducator");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.EducatorNavigation)
                    .WithMany(p => p.LocationEducator)
                    .HasForeignKey(d => d.Educator)
                    .HasConstraintName("FK_LocationEducator_Educator");

                entity.HasOne(d => d.EducatorAssignmentUnitNavigation)
                    .WithMany(p => p.LocationEducator)
                    .HasForeignKey(d => d.EducatorAssignmentUnit)
                    .HasConstraintName("FK_LocationEducator_EducatorAssignmentUnit");

                entity.HasOne(d => d.EducatorEmploymentNavigation)
                    .WithMany(p => p.LocationEducator)
                    .HasForeignKey(d => d.EducatorEmployment)
                    .HasConstraintName("FK_StudyEventLocationEmployment_EducatorEmployment");

                entity.HasOne(d => d.EventLocationNavigation)
                    .WithMany(p => p.LocationEducatorEventLocationNavigation)
                    .HasForeignKey(d => d.EventLocation)
                    .HasConstraintName("FK_LocationEducator_EventLocation");

                entity.HasOne(d => d.StudyEventLocationNavigation)
                    .WithMany(p => p.LocationEducatorStudyEventLocationNavigation)
                    .HasForeignKey(d => d.StudyEventLocation)
                    .HasConstraintName("FK_StudyEventLocationEmployment_StudyEventLocation");
            });

            modelBuilder.Entity<LocationFloor>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_LocationFloor");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<LocationKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Code)
                    .HasName("iCode_EventLocationKind")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_EventLocationKind");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<LocationLocationsBaseTimeTableLocationsTimeTables>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("LocationLocations_BaseTimeTableLocationsTimeTables");

                entity.HasIndex(e => e.Locations)
                    .HasName("iLocations_LocationLocations_BaseTimeTableLocationsTimeTables");

                entity.HasIndex(e => e.LocationsTimeTables)
                    .HasName("iLocationsTimeTables_LocationLocations_BaseTimeTableLocationsTimeTables");

                entity.HasIndex(e => new { e.LocationsTimeTables, e.Locations })
                    .HasName("iLocationsTimeTablesLocations_LocationLocations_BaseTimeTableLocationsTimeTables")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.LocationsNavigation)
                    .WithMany(p => p.LocationLocationsBaseTimeTableLocationsTimeTables)
                    .HasForeignKey(d => d.Locations)
                    .HasConstraintName("FK_LocationLocations_BaseTimeTableLocationsTimeTables_Locations");

                entity.HasOne(d => d.LocationsTimeTablesNavigation)
                    .WithMany(p => p.LocationLocationsBaseTimeTableLocationsTimeTables)
                    .HasForeignKey(d => d.LocationsTimeTables)
                    .HasConstraintName("FK_LocationLocations_BaseTimeTableLocationsTimeTables_LocationsTimeTables");
            });

            modelBuilder.Entity<ModuleInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssemblyFileName).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Version).HasMaxLength(100);
            });

            modelBuilder.Entity<Numbers>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.N)
                    .HasName("n")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.N).HasColumnName("n");
            });

            modelBuilder.Entity<OnlineCourse>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_OnlineCourse");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_OnlineCourse");

                entity.HasIndex(e => e.RealizationVariant)
                    .HasName("iRealizationVariant_OnlineCourse");

                entity.HasIndex(e => e.StudyModule)
                    .HasName("iStudyModule_OnlineCourse");

                entity.HasIndex(e => e.StudyPlan)
                    .HasName("iStudyPlan_OnlineCourse");

                entity.HasIndex(e => e.StudyPlanTerm)
                    .HasName("iStudyPlanTerm_OnlineCourse");

                entity.HasIndex(e => e.StudyProfile)
                    .HasName("iStudyProfile_OnlineCourse");

                entity.HasIndex(e => e.StudyYear)
                    .HasName("iStudyYear_OnlineCourse");

                entity.HasIndex(e => e.Trajectory)
                    .HasName("iTrajectory_OnlineCourse");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.OnlineCourseUrl).HasColumnName("OnlineCourseURL");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.OnlineCourse)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_OnlineCourse_ImportSession");

                entity.HasOne(d => d.RealizationVariantNavigation)
                    .WithMany(p => p.OnlineCourse)
                    .HasForeignKey(d => d.RealizationVariant)
                    .HasConstraintName("FK_OnlineCourse_RealizationVariant");

                entity.HasOne(d => d.StudyModuleNavigation)
                    .WithMany(p => p.OnlineCourseNavigation)
                    .HasForeignKey(d => d.StudyModule)
                    .HasConstraintName("FK_OnlineCourse_StudyModule");

                entity.HasOne(d => d.StudyPlanNavigation)
                    .WithMany(p => p.OnlineCourse)
                    .HasForeignKey(d => d.StudyPlan)
                    .HasConstraintName("FK_OnlineCourse_StudyPlan");

                entity.HasOne(d => d.StudyPlanTermNavigation)
                    .WithMany(p => p.OnlineCourse)
                    .HasForeignKey(d => d.StudyPlanTerm)
                    .HasConstraintName("FK_OnlineCourse_StudyPlanTerm");

                entity.HasOne(d => d.StudyProfileNavigation)
                    .WithMany(p => p.OnlineCourse)
                    .HasForeignKey(d => d.StudyProfile)
                    .HasConstraintName("FK_OnlineCourse_StudyProfile");

                entity.HasOne(d => d.StudyYearNavigation)
                    .WithMany(p => p.OnlineCourse)
                    .HasForeignKey(d => d.StudyYear)
                    .HasConstraintName("FK_OnlineCourse_StudyYear");

                entity.HasOne(d => d.TrajectoryNavigation)
                    .WithMany(p => p.OnlineCourse)
                    .HasForeignKey(d => d.Trajectory)
                    .HasConstraintName("FK_OnlineCourse_Trajectory");
            });

            modelBuilder.Entity<OnlinePedUnit>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.ContactLoadType)
                    .HasName("iContactLoadType_OnlinePedUnit");

                entity.HasIndex(e => e.Discipline)
                    .HasName("iDiscipline_OnlinePedUnit");

                entity.HasIndex(e => e.Division)
                    .HasName("iDivision_OnlinePedUnit");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_OnlinePedUnit");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_OnlinePedUnit");

                entity.HasIndex(e => e.RealizationVariant)
                    .HasName("iRealizationVariant_OnlinePedUnit");

                entity.HasIndex(e => e.StudyForm)
                    .HasName("iStudyForm_OnlinePedUnit");

                entity.HasIndex(e => e.StudyLevel)
                    .HasName("iStudyLevel_OnlinePedUnit");

                entity.HasIndex(e => e.StudyPlan)
                    .HasName("iStudyPlan_OnlinePedUnit");

                entity.HasIndex(e => e.StudyProgram)
                    .HasName("iStudyProgram_OnlinePedUnit");

                entity.HasIndex(e => e.StudyYear)
                    .HasName("iStudyYear_OnlinePedUnit");

                entity.HasIndex(e => e.TermName)
                    .HasName("iTermName_OnlinePedUnit");

                entity.HasIndex(e => e.Trajectory)
                    .HasName("iTrajectory_OnlinePedUnit");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.ContactLoadTypeNavigation)
                    .WithMany(p => p.OnlinePedUnit)
                    .HasForeignKey(d => d.ContactLoadType)
                    .HasConstraintName("FK_OnlinePedUnit_ContactLoadType");

                entity.HasOne(d => d.DisciplineNavigation)
                    .WithMany(p => p.OnlinePedUnit)
                    .HasForeignKey(d => d.Discipline)
                    .HasConstraintName("FK_OnlinePedUnit_Discipline");

                entity.HasOne(d => d.DivisionNavigation)
                    .WithMany(p => p.OnlinePedUnit)
                    .HasForeignKey(d => d.Division)
                    .HasConstraintName("FK_OnlinePedUnit_Division");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.OnlinePedUnit)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_OnlinePedUnit_ImportSession");

                entity.HasOne(d => d.RealizationVariantNavigation)
                    .WithMany(p => p.OnlinePedUnit)
                    .HasForeignKey(d => d.RealizationVariant)
                    .HasConstraintName("FK_OnlinePedUnit_RealizationVariant");

                entity.HasOne(d => d.StudyFormNavigation)
                    .WithMany(p => p.OnlinePedUnit)
                    .HasForeignKey(d => d.StudyForm)
                    .HasConstraintName("FK_OnlinePedUnit_StudyForm");

                entity.HasOne(d => d.StudyLevelNavigation)
                    .WithMany(p => p.OnlinePedUnit)
                    .HasForeignKey(d => d.StudyLevel)
                    .HasConstraintName("FK_OnlinePedUnit_StudyLevel");

                entity.HasOne(d => d.StudyPlanNavigation)
                    .WithMany(p => p.OnlinePedUnit)
                    .HasForeignKey(d => d.StudyPlan)
                    .HasConstraintName("FK_OnlinePedUnit_StudyPlan");

                entity.HasOne(d => d.StudyProgramNavigation)
                    .WithMany(p => p.OnlinePedUnit)
                    .HasForeignKey(d => d.StudyProgram)
                    .HasConstraintName("FK_OnlinePedUnit_StudyProgram");

                entity.HasOne(d => d.StudyYearNavigation)
                    .WithMany(p => p.OnlinePedUnit)
                    .HasForeignKey(d => d.StudyYear)
                    .HasConstraintName("FK_OnlinePedUnit_StudyYear");

                entity.HasOne(d => d.TermNameNavigation)
                    .WithMany(p => p.OnlinePedUnit)
                    .HasForeignKey(d => d.TermName)
                    .HasConstraintName("FK_OnlinePedUnit_TermName");

                entity.HasOne(d => d.TrajectoryNavigation)
                    .WithMany(p => p.OnlinePedUnit)
                    .HasForeignKey(d => d.Trajectory)
                    .HasConstraintName("FK_OnlinePedUnit_Trajectory");
            });

            modelBuilder.Entity<OnlinePuuser>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("OnlinePUUser");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_OnlinePUUser");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_OnlinePUUser");

                entity.HasIndex(e => e.Login)
                    .HasName("iLogin_OnlinePUUser")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Login).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.OnlinePuuser)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_OnlinePUUser_ImportSession");
            });

            modelBuilder.Entity<PlannerAppTracingSettings>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PlannerAppTracingSettings");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<PublicDivision>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Alias)
                    .HasName("iAlias_PublicDivision")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PublicDivision");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Alias).HasMaxLength(100);

                entity.Property(e => e.ExternalWebSiteReference).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameEnglish).HasMaxLength(100);
            });

            modelBuilder.Entity<PublicDivisionAccessKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Code)
                    .HasName("iCode_PublicDivisionAccessKind")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PublicDivisionAccessKind");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<PublicDivisionPublicDivisionsDivisionDivisions>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PublicDivisionPublicDivisions_DivisionDivisions");

                entity.HasIndex(e => e.Divisions)
                    .HasName("iDivisions_PublicDivisionPublicDivisions_DivisionDivisions");

                entity.HasIndex(e => e.PublicDivisions)
                    .HasName("iPublicDivisions_PublicDivisionPublicDivisions_DivisionDivisions");

                entity.HasIndex(e => new { e.Divisions, e.PublicDivisions })
                    .HasName("iDivisionsPublicDivisions_PublicDivisionPublicDivisions_DivisionDivisions")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DivisionsNavigation)
                    .WithMany(p => p.PublicDivisionPublicDivisionsDivisionDivisions)
                    .HasForeignKey(d => d.Divisions)
                    .HasConstraintName("FK_PublicDivisionPublicDivisions_DivisionDivisions_Divisions");

                entity.HasOne(d => d.PublicDivisionsNavigation)
                    .WithMany(p => p.PublicDivisionPublicDivisionsDivisionDivisions)
                    .HasForeignKey(d => d.PublicDivisions)
                    .HasConstraintName("FK_PublicDivisionPublicDivisions_DivisionDivisions_PublicDivisions");
            });

            modelBuilder.Entity<Recurrence>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.End, e.Index, e.Event, e.Start })
                    .HasName("iRecurrence_EventStart");

                entity.HasIndex(e => new { e.Event, e.Index, e.Start, e.End })
                    .HasName("iRecurrence_StartEnd");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Start).HasColumnType("datetime");
            });

            modelBuilder.Entity<RegistrySearchgroups>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("registry_searchgroups$");

                entity.Property(e => e.Key).HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(255);
            });

            modelBuilder.Entity<SapBuilding>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Code)
                    .HasName("iCode_SapBuilding")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SapBuilding");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_SapBuilding");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(206);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.House).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.PostalCode).HasMaxLength(6);

                entity.Property(e => e.Street).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.SapBuilding)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_SapBuilding_ImportSession");
            });

            modelBuilder.Entity<SapDepartment>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SapDepartment");

                entity.HasIndex(e => e.ImportId)
                    .HasName("iImportId_SapDepartment")
                    .IsUnique();

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_SapDepartment");

                entity.HasIndex(e => e.SapDivision)
                    .HasName("iSapDivision_SapDepartment");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.SapDepartment)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_SapDepartment_ImportSession");

                entity.HasOne(d => d.SapDivisionNavigation)
                    .WithMany(p => p.SapDepartment)
                    .HasForeignKey(d => d.SapDivision)
                    .HasConstraintName("FK_SapDepartment_SapDivision");
            });

            modelBuilder.Entity<SapDivision>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SapDivision");

                entity.HasIndex(e => e.ImportId)
                    .HasName("iImportId_SapDivision")
                    .IsUnique();

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_SapDivision");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.SapDivision)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_SapDivision_ImportSession");
            });

            modelBuilder.Entity<SapRoom>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Building)
                    .HasName("iBuilding_SapRoom");

                entity.HasIndex(e => e.Classroom)
                    .HasName("iClassroom_SapRoom");

                entity.HasIndex(e => e.Code)
                    .HasName("iCode_SapRoom")
                    .IsUnique();

                entity.HasIndex(e => e.Floor)
                    .HasName("iFloor_SapRoom");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SapRoom");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_SapRoom");

                entity.HasIndex(e => e.Kind)
                    .HasName("iKind_SapRoom");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.NumberActual).HasMaxLength(200);

                entity.Property(e => e.NumberProjected).HasMaxLength(200);

                entity.HasOne(d => d.BuildingNavigation)
                    .WithMany(p => p.SapRoom)
                    .HasForeignKey(d => d.Building)
                    .HasConstraintName("FK_SapRoom_Building");

                entity.HasOne(d => d.ClassroomNavigation)
                    .WithMany(p => p.SapRoom1)
                    .HasForeignKey(d => d.Classroom)
                    .HasConstraintName("FK_SapRoom_Classroom");

                entity.HasOne(d => d.FloorNavigation)
                    .WithMany(p => p.SapRoom)
                    .HasForeignKey(d => d.Floor)
                    .HasConstraintName("FK_SapRoom_Floor");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.SapRoom)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_SapRoom_ImportSession");

                entity.HasOne(d => d.KindNavigation)
                    .WithMany(p => p.SapRoom)
                    .HasForeignKey(d => d.Kind)
                    .HasConstraintName("FK_SapRoom_Kind");
            });

            modelBuilder.Entity<SapRoomKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Code)
                    .HasName("iCode_SapRoomKind")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SapRoomKind");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_SapRoomKind");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DisplayName).HasMaxLength(250);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.SapRoomKind)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_SapRoomKind_ImportSession");
            });

            modelBuilder.Entity<SecuritySystemMemberPermissionsObject>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SecuritySystemMemberPermissionsObject");

                entity.HasIndex(e => e.Owner)
                    .HasName("iOwner_SecuritySystemMemberPermissionsObject");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.SecuritySystemMemberPermissionsObject)
                    .HasForeignKey(d => d.Owner)
                    .HasConstraintName("FK_SecuritySystemMemberPermissionsObject_Owner");
            });

            modelBuilder.Entity<SecuritySystemObjectPermissionsObject>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SecuritySystemObjectPermissionsObject");

                entity.HasIndex(e => e.Owner)
                    .HasName("iOwner_SecuritySystemObjectPermissionsObject");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.SecuritySystemObjectPermissionsObject)
                    .HasForeignKey(d => d.Owner)
                    .HasConstraintName("FK_SecuritySystemObjectPermissionsObject_Owner");
            });

            modelBuilder.Entity<SecuritySystemRole>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Division)
                    .HasName("iDivision_SecuritySystemRole");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SecuritySystemRole");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_SecuritySystemRole");

                entity.HasIndex(e => e.SapDivision)
                    .HasName("iSapDivision_SecuritySystemRole");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.HasOne(d => d.DivisionNavigation)
                    .WithMany(p => p.SecuritySystemRole)
                    .HasForeignKey(d => d.Division)
                    .HasConstraintName("FK_SecuritySystemRole_Division");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.SecuritySystemRole)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_SecuritySystemRole_ObjectType");

                entity.HasOne(d => d.SapDivisionNavigation)
                    .WithMany(p => p.SecuritySystemRole)
                    .HasForeignKey(d => d.SapDivision)
                    .HasConstraintName("FK_SecuritySystemRole_SapDivision");
            });

            modelBuilder.Entity<SecuritySystemRoleParentRolesSecuritySystemRoleChildRoles>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles");

                entity.HasIndex(e => e.ChildRoles)
                    .HasName("iChildRoles_SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles");

                entity.HasIndex(e => e.ParentRoles)
                    .HasName("iParentRoles_SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles");

                entity.HasIndex(e => new { e.ChildRoles, e.ParentRoles })
                    .HasName("iChildRolesParentRoles_SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ChildRolesNavigation)
                    .WithMany(p => p.SecuritySystemRoleParentRolesSecuritySystemRoleChildRolesChildRolesNavigation)
                    .HasForeignKey(d => d.ChildRoles)
                    .HasConstraintName("FK_SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles_ChildRoles");

                entity.HasOne(d => d.ParentRolesNavigation)
                    .WithMany(p => p.SecuritySystemRoleParentRolesSecuritySystemRoleChildRolesParentRolesNavigation)
                    .HasForeignKey(d => d.ParentRoles)
                    .HasConstraintName("FK_SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles_ParentRoles");
            });

            modelBuilder.Entity<SecuritySystemTypePermissionsObject>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SecuritySystemTypePermissionsObject");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_SecuritySystemTypePermissionsObject");

                entity.HasIndex(e => e.Owner)
                    .HasName("iOwner_SecuritySystemTypePermissionsObject");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.SecuritySystemTypePermissionsObject)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_SecuritySystemTypePermissionsObject_ObjectType");

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.SecuritySystemTypePermissionsObject)
                    .HasForeignKey(d => d.Owner)
                    .HasConstraintName("FK_SecuritySystemTypePermissionsObject_Owner");
            });

            modelBuilder.Entity<SecuritySystemUser>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SecuritySystemUser");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_SecuritySystemUser");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.SecuritySystemUser)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_SecuritySystemUser_ObjectType");
            });

            modelBuilder.Entity<SecuritySystemUserUsersSecuritySystemRoleRoles>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("SecuritySystemUserUsers_SecuritySystemRoleRoles");

                entity.HasIndex(e => e.Roles)
                    .HasName("iRoles_SecuritySystemUserUsers_SecuritySystemRoleRoles");

                entity.HasIndex(e => e.Users)
                    .HasName("iUsers_SecuritySystemUserUsers_SecuritySystemRoleRoles");

                entity.HasIndex(e => new { e.Roles, e.Users })
                    .HasName("iRolesUsers_SecuritySystemUserUsers_SecuritySystemRoleRoles")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.RolesNavigation)
                    .WithMany(p => p.SecuritySystemUserUsersSecuritySystemRoleRoles)
                    .HasForeignKey(d => d.Roles)
                    .HasConstraintName("FK_SecuritySystemUserUsers_SecuritySystemRoleRoles_Roles");

                entity.HasOne(d => d.UsersNavigation)
                    .WithMany(p => p.SecuritySystemUserUsersSecuritySystemRoleRoles)
                    .HasForeignKey(d => d.Users)
                    .HasConstraintName("FK_SecuritySystemUserUsers_SecuritySystemRoleRoles_Users");
            });

            modelBuilder.Entity<SoftlineData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.F10).HasMaxLength(255);

                entity.Property(e => e.F11).HasMaxLength(255);

                entity.Property(e => e.F12).HasMaxLength(255);

                entity.Property(e => e.F13).HasMaxLength(255);

                entity.Property(e => e.F14).HasMaxLength(255);

                entity.Property(e => e.Адрес).HasMaxLength(255);

                entity.Property(e => e.ДопольнительнаяИнформация)
                    .HasColumnName("Допольнительная информация")
                    .HasMaxLength(255);

                entity.Property(e => e.МультимедийноеОборудование)
                    .HasColumnName("Мультимедийное оборудование")
                    .HasMaxLength(255);

                entity.Property(e => e.Название).HasMaxLength(255);

                entity.Property(e => e.Рассадка).HasMaxLength(255);

                entity.Property(e => e.ТипПомещения)
                    .HasColumnName("Тип помещения")
                    .HasMaxLength(255);

                entity.Property(e => e.Этаж).HasMaxLength(255);
            });

            modelBuilder.Entity<SportObjectPassport>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SportObjectPassport");

                entity.HasIndex(e => e.Location)
                    .HasName("iLocation_SportObjectPassport");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Equipment).HasMaxLength(2047);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Inventory).HasMaxLength(2047);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.SportKinds).HasMaxLength(1023);

                entity.HasOne(d => d.LocationNavigation)
                    .WithMany(p => p.SportObjectPassport)
                    .HasForeignKey(d => d.Location)
                    .HasConstraintName("FK_SportObjectPassport_Location");
            });

            modelBuilder.Entity<StudyEventAppointmentInfo>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.ContingentUnit)
                    .HasName("iContingentUnit_StudyEventAppointmentInfo");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyEventAppointmentInfo");

                entity.HasIndex(e => e.TermKind)
                    .HasName("iTermKind_StudyEventAppointmentInfo");

                entity.HasIndex(e => e.TimeEvent)
                    .HasName("iTimeEvent_StudyEventAppointmentInfo");

                entity.HasIndex(e => e.TimeTableKind)
                    .HasName("iTimeTableKind_StudyEventAppointmentInfo");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.HasOne(d => d.ContingentUnitNavigation)
                    .WithMany(p => p.StudyEventAppointmentInfo)
                    .HasForeignKey(d => d.ContingentUnit)
                    .HasConstraintName("FK_StudyEventAppointmentInfo_ContingentUnit");

                entity.HasOne(d => d.TermKindNavigation)
                    .WithMany(p => p.StudyEventAppointmentInfo)
                    .HasForeignKey(d => d.TermKind)
                    .HasConstraintName("FK_StudyEventAppointmentInfo_TermKind");

                entity.HasOne(d => d.TimeEventNavigation)
                    .WithMany(p => p.StudyEventAppointmentInfo)
                    .HasForeignKey(d => d.TimeEvent)
                    .HasConstraintName("FK_StudyEventAppointmentInfo_TimeEvent");

                entity.HasOne(d => d.TimeTableKindNavigation)
                    .WithMany(p => p.StudyEventAppointmentInfo)
                    .HasForeignKey(d => d.TimeTableKind)
                    .HasConstraintName("FK_StudyEventAppointmentInfo_TimeTableKind");
            });

            modelBuilder.Entity<StudyEventDurationKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Code)
                    .HasName("iCode_StudyEventDurationKind")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyEventDurationKind");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<StudyEventsTimeTableClass>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyEventsTimeTableClass");

                entity.HasIndex(e => e.StudyYear)
                    .HasName("iStudyYear_StudyEventsTimeTableClass");

                entity.HasIndex(e => e.TermKind)
                    .HasName("iTermKind_StudyEventsTimeTableClass");

                entity.HasIndex(e => new { e.StudyYear, e.TermKind })
                    .HasName("iStudyYearTermKind_StudyEventsTimeTableClass")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DefaultTermEnd).HasColumnType("datetime");

                entity.Property(e => e.DefaultTermStart).HasColumnType("datetime");

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.DisplayNameEnglish).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.StudyYearNavigation)
                    .WithMany(p => p.StudyEventsTimeTableClass)
                    .HasForeignKey(d => d.StudyYear)
                    .HasConstraintName("FK_StudyEventsTimeTableClass_StudyYear");

                entity.HasOne(d => d.TermKindNavigation)
                    .WithMany(p => p.StudyEventsTimeTableClass)
                    .HasForeignKey(d => d.TermKind)
                    .HasConstraintName("FK_StudyEventsTimeTableClass_TermKind");
            });

            modelBuilder.Entity<StudyEventsTimeTableClassKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyEventsTimeTableClassKind");

                entity.HasIndex(e => e.TimeTableClass)
                    .HasName("iTimeTableClass_StudyEventsTimeTableClassKind");

                entity.HasIndex(e => e.TimeTableKind)
                    .HasName("iTimeTableKind_StudyEventsTimeTableClassKind");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameEnglish).HasMaxLength(100);

                entity.HasOne(d => d.TimeTableClassNavigation)
                    .WithMany(p => p.StudyEventsTimeTableClassKind)
                    .HasForeignKey(d => d.TimeTableClass)
                    .HasConstraintName("FK_StudyEventsTimeTableClassKind_TimeTableClass");

                entity.HasOne(d => d.TimeTableKindNavigation)
                    .WithMany(p => p.StudyEventsTimeTableClassKind)
                    .HasForeignKey(d => d.TimeTableKind)
                    .HasConstraintName("FK_StudyEventsTimeTableClassKind_TimeTableKind");
            });

            modelBuilder.Entity<StudyEventsTimeTableKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Code)
                    .HasName("iCode_StudyEventsTimeTableKind")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyEventsTimeTableKind");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameEnglish).HasMaxLength(100);
            });

            modelBuilder.Entity<StudyEventsTimeTableSpreadsheet>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyEventsTimeTableSpreadsheet");

                entity.HasIndex(e => e.StreamId)
                    .HasName("UQ__StudyEve__07C87A937ABC33CD")
                    .IsUnique();

                entity.HasIndex(e => e.StudyEventsTimeTable)
                    .HasName("iStudyEventsTimeTable_StudyEventsTimeTableSpreadsheet");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.StudyEventsTimeTableNavigation)
                    .WithMany(p => p.StudyEventsTimeTableSpreadsheet)
                    .HasForeignKey(d => d.StudyEventsTimeTable)
                    .HasConstraintName("FK_StudyEventsTimeTableSpreadsheet_StudyEventsTimeTable");
            });

            modelBuilder.Entity<StudyForm>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyForm");

                entity.HasIndex(e => e.ImportId)
                    .HasName("iImportId_StudyForm")
                    .IsUnique();

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyForm");

                entity.HasIndex(e => e.Name)
                    .HasName("iName_StudyForm")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameEnglish).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyForm)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyForm_ImportSession");
            });

            modelBuilder.Entity<StudyLevel>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyLevel");

                entity.HasIndex(e => e.ImportId)
                    .HasName("iImportId_StudyLevel")
                    .IsUnique();

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyLevel");

                entity.HasIndex(e => e.Name)
                    .HasName("iName_StudyLevel")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameEnglish).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyLevel)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyLevel_ImportSession");
            });

            modelBuilder.Entity<StudyModule>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Discipline)
                    .HasName("iDiscipline_StudyModule");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyModule");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyModule");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_StudyModule");

                entity.HasIndex(e => e.OnlineCourse)
                    .HasName("iOnlineCourse_StudyModule");

                entity.HasIndex(e => e.Profile)
                    .HasName("iProfile_StudyModule");

                entity.HasIndex(e => e.RealizationVariant)
                    .HasName("iRealizationVariant_StudyModule");

                entity.HasIndex(e => e.StudyPlanTerm)
                    .HasName("iStudyPlanTerm_StudyModule");

                entity.HasIndex(e => e.Trajectory)
                    .HasName("iTrajectory_StudyModule");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.ActualStatusComment).HasMaxLength(250);

                entity.Property(e => e.BlackBoardCode).HasMaxLength(500);

                entity.Property(e => e.DisciplineName).HasMaxLength(500);

                entity.Property(e => e.DisciplineNameEnglish).HasMaxLength(500);

                entity.Property(e => e.DisciplineNumber).HasMaxLength(50);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.ImportedOn).HasColumnType("datetime");

                entity.Property(e => e.ReImportedOn).HasColumnType("datetime");

                entity.HasOne(d => d.DisciplineNavigation)
                    .WithMany(p => p.StudyModule)
                    .HasForeignKey(d => d.Discipline)
                    .HasConstraintName("FK_StudyModule_Discipline");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyModule)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyModule_ImportSession");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.StudyModule)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_StudyModule_ObjectType");

                entity.HasOne(d => d.OnlineCourse1)
                    .WithMany(p => p.StudyModule1)
                    .HasForeignKey(d => d.OnlineCourse)
                    .HasConstraintName("FK_StudyModule_OnlineCourse");

                entity.HasOne(d => d.ProfileNavigation)
                    .WithMany(p => p.StudyModule)
                    .HasForeignKey(d => d.Profile)
                    .HasConstraintName("FK_StudyModule_Profile");

                entity.HasOne(d => d.RealizationVariantNavigation)
                    .WithMany(p => p.StudyModule)
                    .HasForeignKey(d => d.RealizationVariant)
                    .HasConstraintName("FK_StudyModule_RealizationVariant");

                entity.HasOne(d => d.StudyPlanTermNavigation)
                    .WithMany(p => p.StudyModule)
                    .HasForeignKey(d => d.StudyPlanTerm)
                    .HasConstraintName("FK_StudyModule_StudyPlanTerm");

                entity.HasOne(d => d.TrajectoryNavigation)
                    .WithMany(p => p.StudyModule)
                    .HasForeignKey(d => d.Trajectory)
                    .HasConstraintName("FK_StudyModule_Trajectory");
            });

            modelBuilder.Entity<StudyModuleAllowedStudyModulesContingentUnitContingentUnitCombinations>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("StudyModuleAllowedStudyModules_ContingentUnitContingentUnitCombinations");

                entity.HasIndex(e => e.AllowedStudyModules)
                    .HasName("iAllowedStudyModules_StudyModuleAllowedStudyModules_ContingentUnitContingentUnitCombinations");

                entity.HasIndex(e => e.ContingentUnitCombinations)
                    .HasName("iContingentUnitCombinations_StudyModuleAllowedStudyModules_ContingentUnitContingentUnitCombinations");

                entity.HasIndex(e => new { e.ContingentUnitCombinations, e.AllowedStudyModules })
                    .HasName("iContingentUnitCombinationsAllowedStudyModules_StudyModuleAllowedStudyModules_ContingentUnitContingentUnitCombinations")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.AllowedStudyModulesNavigation)
                    .WithMany(p => p.StudyModuleAllowedStudyModulesContingentUnitContingentUnitCombinations)
                    .HasForeignKey(d => d.AllowedStudyModules)
                    .HasConstraintName("FK_StudyModuleAllowedStudyModules_ContingentUnitContingentUnitCombinations_AllowedStudyModules");

                entity.HasOne(d => d.ContingentUnitCombinationsNavigation)
                    .WithMany(p => p.StudyModuleAllowedStudyModulesContingentUnitContingentUnitCombinations)
                    .HasForeignKey(d => d.ContingentUnitCombinations)
                    .HasConstraintName("FK_StudyModuleAllowedStudyModules_ContingentUnitContingentUnitCombinations_ContingentUnitCombinations");
            });

            modelBuilder.Entity<StudyModuleAttendanceKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Code)
                    .HasName("iCode_StudyModuleAttendanceKind")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyModuleAttendanceKind");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DisplayName).HasMaxLength(500);

                entity.Property(e => e.DisplayNameEnglish).HasMaxLength(500);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<StudyModuleControlFormKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyModuleControlFormKind");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyModuleControlFormKind");

                entity.HasIndex(e => e.Name)
                    .HasName("iName_StudyModuleControlFormKind")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyModuleControlFormKind)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyModuleControlFormKind_ImportSession");
            });

            modelBuilder.Entity<StudyModuleControlFormName>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyModuleControlFormName");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyModuleControlFormName");

                entity.HasIndex(e => e.Name)
                    .HasName("iName_StudyModuleControlFormName")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyModuleControlFormName)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyModuleControlFormName_ImportSession");
            });

            modelBuilder.Entity<StudyModuleControlFormPeriod>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyModuleControlFormPeriod");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyModuleControlFormPeriod");

                entity.HasIndex(e => e.Name)
                    .HasName("iName_StudyModuleControlFormPeriod")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyModuleControlFormPeriod)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyModuleControlFormPeriod_ImportSession");
            });

            modelBuilder.Entity<StudyModuleRealizationVariant>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyModuleRealizationVariant");

                entity.HasIndex(e => e.Id)
                    .HasName("iId_StudyModuleRealizationVariant")
                    .IsUnique();

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyModuleRealizationVariant");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasMaxLength(1023)
                    .IsUnicode(false);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyModuleRealizationVariant)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyModuleRealizationVariant_ImportSession");
            });

            modelBuilder.Entity<StudyModuleTrajectory>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyModuleTrajectory");

                entity.HasIndex(e => e.Id)
                    .HasName("iId_StudyModuleTrajectory")
                    .IsUnique();

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyModuleTrajectory");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyModuleTrajectory)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyModuleTrajectory_ImportSession");
            });

            modelBuilder.Entity<StudyModuleWorkKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.ContactLoadType)
                    .HasName("iContactLoadType_StudyModuleWorkKind");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyModuleWorkKind");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyModuleWorkKind");

                entity.HasIndex(e => e.TimeTableKind)
                    .HasName("iTimeTableKind_StudyModuleWorkKind");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.HasOne(d => d.ContactLoadTypeNavigation)
                    .WithMany(p => p.StudyModuleWorkKind)
                    .HasForeignKey(d => d.ContactLoadType)
                    .HasConstraintName("FK_StudyModuleWorkKind_ContactLoadType");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyModuleWorkKind)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyModuleWorkKind_ImportSession");

                entity.HasOne(d => d.TimeTableKindNavigation)
                    .WithMany(p => p.StudyModuleWorkKind)
                    .HasForeignKey(d => d.TimeTableKind)
                    .HasConstraintName("FK_StudyModuleWorkKind_TimeTableKind");
            });

            modelBuilder.Entity<StudyModuleWorkUnit>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.AttendanceKind)
                    .HasName("iAttendanceKind_StudyModuleWorkUnit");

                entity.HasIndex(e => e.ControlFormKind)
                    .HasName("iControlFormKind_StudyModuleWorkUnit");

                entity.HasIndex(e => e.ControlFormName)
                    .HasName("iControlFormName_StudyModuleWorkUnit");

                entity.HasIndex(e => e.ControlFormPeriod)
                    .HasName("iControlFormPeriod_StudyModuleWorkUnit");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyModuleWorkUnit");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyModuleWorkUnit");

                entity.HasIndex(e => e.Kind)
                    .HasName("iKind_StudyModuleWorkUnit");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_StudyModuleWorkUnit");

                entity.HasIndex(e => e.StudyModule)
                    .HasName("iStudyModule_StudyModuleWorkUnit");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DisplayName).HasMaxLength(500);

                entity.Property(e => e.DisplayNameEnglish).HasMaxLength(500);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.ImportedOn).HasColumnType("datetime");

                entity.Property(e => e.ReImportedOn).HasColumnType("datetime");

                entity.HasOne(d => d.AttendanceKindNavigation)
                    .WithMany(p => p.StudyModuleWorkUnit)
                    .HasForeignKey(d => d.AttendanceKind)
                    .HasConstraintName("FK_StudyModuleWorkUnit_AttendanceKind");

                entity.HasOne(d => d.ControlFormKindNavigation)
                    .WithMany(p => p.StudyModuleWorkUnit)
                    .HasForeignKey(d => d.ControlFormKind)
                    .HasConstraintName("FK_StudyModuleWorkUnit_ControlFormKind");

                entity.HasOne(d => d.ControlFormNameNavigation)
                    .WithMany(p => p.StudyModuleWorkUnit)
                    .HasForeignKey(d => d.ControlFormName)
                    .HasConstraintName("FK_StudyModuleWorkUnit_ControlFormName");

                entity.HasOne(d => d.ControlFormPeriodNavigation)
                    .WithMany(p => p.StudyModuleWorkUnit)
                    .HasForeignKey(d => d.ControlFormPeriod)
                    .HasConstraintName("FK_StudyModuleWorkUnit_ControlFormPeriod");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyModuleWorkUnit)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyModuleWorkUnit_ImportSession");

                entity.HasOne(d => d.KindNavigation)
                    .WithMany(p => p.StudyModuleWorkUnit)
                    .HasForeignKey(d => d.Kind)
                    .HasConstraintName("FK_StudyModuleWorkUnit_Kind");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.StudyModuleWorkUnit)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_StudyModuleWorkUnit_ObjectType");

                entity.HasOne(d => d.StudyModuleNavigation)
                    .WithMany(p => p.StudyModuleWorkUnit)
                    .HasForeignKey(d => d.StudyModule)
                    .HasConstraintName("FK_StudyModuleWorkUnit_StudyModule");
            });

            modelBuilder.Entity<StudyModuleWorkUnitKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.ContactLoadType)
                    .HasName("iContactLoadType_StudyModuleWorkUnitKind");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyModuleWorkUnitKind");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyModuleWorkUnitKind");

                entity.HasIndex(e => e.StudyModuleWorkKind)
                    .HasName("iStudyModuleWorkKind_StudyModuleWorkUnitKind");

                entity.HasIndex(e => e.TimeTableKind)
                    .HasName("iTimeTableKind_StudyModuleWorkUnitKind");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.NameEnglish).HasMaxLength(150);

                entity.Property(e => e.ShortName).HasMaxLength(150);

                entity.Property(e => e.ShortNameEnglish).HasMaxLength(150);

                entity.Property(e => e.WorkHoursFactor).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ContactLoadTypeNavigation)
                    .WithMany(p => p.StudyModuleWorkUnitKind)
                    .HasForeignKey(d => d.ContactLoadType)
                    .HasConstraintName("FK_StudyModuleWorkUnitKind_ContactLoadType");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyModuleWorkUnitKind)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyModuleWorkUnitKind_ImportSession");

                entity.HasOne(d => d.StudyModuleWorkKindNavigation)
                    .WithMany(p => p.StudyModuleWorkUnitKind)
                    .HasForeignKey(d => d.StudyModuleWorkKind)
                    .HasConstraintName("FK_StudyModuleWorkUnitKind_StudyModuleWorkKind");

                entity.HasOne(d => d.TimeTableKindNavigation)
                    .WithMany(p => p.StudyModuleWorkUnitKind)
                    .HasForeignKey(d => d.TimeTableKind)
                    .HasConstraintName("FK_StudyModuleWorkUnitKind_TimeTableKind");
            });

            modelBuilder.Entity<StudyModuleWorkUnitKindContactLoadType>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyModuleWorkUnitKindContactLoadType");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyModuleWorkUnitKindContactLoadType");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_StudyModuleWorkUnitKindContactLoadType");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyModuleWorkUnitKindContactLoadType)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyModuleWorkUnitKindContactLoadType_ImportSession");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.StudyModuleWorkUnitKindContactLoadType)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_StudyModuleWorkUnitKindContactLoadType_ObjectType");
            });

            modelBuilder.Entity<StudyModuleWorkUnitStudyModuleWorkUnitsEducatorAssignmentEducatorAssignments>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("StudyModuleWorkUnitStudyModuleWorkUnits_EducatorAssignmentEducatorAssignments");

                entity.HasIndex(e => e.EducatorAssignments)
                    .HasName("iEducatorAssignments_StudyModuleWorkUnitStudyModuleWorkUnits_EducatorAssignmentEducatorAssignments");

                entity.HasIndex(e => e.StudyModuleWorkUnits)
                    .HasName("iStudyModuleWorkUnits_StudyModuleWorkUnitStudyModuleWorkUnits_EducatorAssignmentEducatorAssignments");

                entity.HasIndex(e => new { e.EducatorAssignments, e.StudyModuleWorkUnits })
                    .HasName("iEducatorAssignmentsStudyModuleWorkUnits_StudyModuleWorkUnitStudyModuleWorkUnits_EducatorAssignmentEducatorAssignments")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EducatorAssignmentsNavigation)
                    .WithMany(p => p.StudyModuleWorkUnitStudyModuleWorkUnitsEducatorAssignmentEducatorAssignments)
                    .HasForeignKey(d => d.EducatorAssignments)
                    .HasConstraintName("FK_StudyModuleWorkUnitStudyModuleWorkUnits_EducatorAssignmentEducatorAssignments_EducatorAssignments");

                entity.HasOne(d => d.StudyModuleWorkUnitsNavigation)
                    .WithMany(p => p.StudyModuleWorkUnitStudyModuleWorkUnitsEducatorAssignmentEducatorAssignments)
                    .HasForeignKey(d => d.StudyModuleWorkUnits)
                    .HasConstraintName("FK_StudyModuleWorkUnitStudyModuleWorkUnits_EducatorAssignmentEducatorAssignments_StudyModuleWorkUnits");
            });

            modelBuilder.Entity<StudyPlan>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.AdmissionYear)
                    .HasName("iAdmissionYear_StudyPlan");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyPlan");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyPlan");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_StudyPlan");

                entity.HasIndex(e => e.StudyForm)
                    .HasName("iStudyForm_StudyPlan");

                entity.HasIndex(e => e.StudyProgram)
                    .HasName("iStudyProgram_StudyPlan");

                entity.HasIndex(e => new { e.ImportId, e.Gcrecord, e.ObjectType, e.ImportOid })
                    .HasName("ix_20180903_StudyPlan");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DisplayName).HasMaxLength(500);

                entity.Property(e => e.EducationPeriodName).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.RegistrationNumber).HasMaxLength(50);

                entity.HasOne(d => d.AdmissionYearNavigation)
                    .WithMany(p => p.StudyPlan)
                    .HasForeignKey(d => d.AdmissionYear)
                    .HasConstraintName("FK_StudyPlan_AdmissionYear");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyPlan)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyPlan_ImportSession");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.StudyPlan)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_StudyPlan_ObjectType");

                entity.HasOne(d => d.StudyFormNavigation)
                    .WithMany(p => p.StudyPlan)
                    .HasForeignKey(d => d.StudyForm)
                    .HasConstraintName("FK_StudyPlan_StudyForm");

                entity.HasOne(d => d.StudyProgramNavigation)
                    .WithMany(p => p.StudyPlan)
                    .HasForeignKey(d => d.StudyProgram)
                    .HasConstraintName("FK_StudyPlan_StudyProgram");
            });

            modelBuilder.Entity<StudyPlanStudyPlansEducatorStudyWorkUnitEducatorStudyWorkUnits>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("StudyPlanStudyPlans_EducatorStudyWorkUnitEducatorStudyWorkUnits");

                entity.HasIndex(e => e.EducatorStudyWorkUnits)
                    .HasName("iEducatorStudyWorkUnits_StudyPlanStudyPlans_EducatorStudyWorkUnitEducatorStudyWorkUnits");

                entity.HasIndex(e => e.StudyPlans)
                    .HasName("iStudyPlans_StudyPlanStudyPlans_EducatorStudyWorkUnitEducatorStudyWorkUnits");

                entity.HasIndex(e => new { e.EducatorStudyWorkUnits, e.StudyPlans })
                    .HasName("iEducatorStudyWorkUnitsStudyPlans_StudyPlanStudyPlans_EducatorStudyWorkUnitEducatorStudyWorkUnits")
                    .IsUnique();

                entity.HasIndex(e => new { e.EducatorStudyWorkUnits, e.Oid, e.OptimisticLockField, e.StudyPlans })
                    .HasName("ix_20180903_StudyPlanStudyPlans_EducatorStudyWorkUnitEducatorStudyWorkUnits");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EducatorStudyWorkUnitsNavigation)
                    .WithMany(p => p.StudyPlanStudyPlansEducatorStudyWorkUnitEducatorStudyWorkUnits)
                    .HasForeignKey(d => d.EducatorStudyWorkUnits)
                    .HasConstraintName("FK_StudyPlanStudyPlans_EducatorStudyWorkUnitEducatorStudyWorkUnits_EducatorStudyWorkUnits");

                entity.HasOne(d => d.StudyPlansNavigation)
                    .WithMany(p => p.StudyPlanStudyPlansEducatorStudyWorkUnitEducatorStudyWorkUnits)
                    .HasForeignKey(d => d.StudyPlans)
                    .HasConstraintName("FK_StudyPlanStudyPlans_EducatorStudyWorkUnitEducatorStudyWorkUnits_StudyPlans");
            });

            modelBuilder.Entity<StudyPlanTerm>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyPlanTerm");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyPlanTerm");

                entity.HasIndex(e => e.Kind)
                    .HasName("iKind_StudyPlanTerm");

                entity.HasIndex(e => e.Name)
                    .HasName("iName_StudyPlanTerm");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_StudyPlanTerm");

                entity.HasIndex(e => e.StudyPlan)
                    .HasName("iStudyPlan_StudyPlanTerm");

                entity.HasIndex(e => e.StudyYear)
                    .HasName("iStudyYear_StudyPlanTerm");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyPlanTerm)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyPlanTerm_ImportSession");

                entity.HasOne(d => d.KindNavigation)
                    .WithMany(p => p.StudyPlanTerm)
                    .HasForeignKey(d => d.Kind)
                    .HasConstraintName("FK_StudyPlanTerm_Kind");

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.StudyPlanTerm)
                    .HasForeignKey(d => d.Name)
                    .HasConstraintName("FK_StudyPlanTerm_Name");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.StudyPlanTerm)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_StudyPlanTerm_ObjectType");

                entity.HasOne(d => d.StudyPlanNavigation)
                    .WithMany(p => p.StudyPlanTerm)
                    .HasForeignKey(d => d.StudyPlan)
                    .HasConstraintName("FK_StudyPlanTerm_StudyPlan");

                entity.HasOne(d => d.StudyYearNavigation)
                    .WithMany(p => p.StudyPlanTerm)
                    .HasForeignKey(d => d.StudyYear)
                    .HasConstraintName("FK_StudyPlanTerm_StudyYear");
            });

            modelBuilder.Entity<StudyPlanTermKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyPlanTermKind");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyPlanTermKind");

                entity.HasIndex(e => e.Name)
                    .HasName("iName_StudyPlanTermKind")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameEnglish).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyPlanTermKind)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyPlanTermKind_ImportSession");
            });

            modelBuilder.Entity<StudyPlanTermName>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyPlanTermName");

                entity.HasIndex(e => e.Id)
                    .HasName("iId_StudyPlanTermName")
                    .IsUnique();

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyPlanTermName");

                entity.HasIndex(e => e.Name)
                    .HasName("iName_StudyPlanTermName")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyPlanTermName)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyPlanTermName_ImportSession");
            });

            modelBuilder.Entity<StudyProfile>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyProfile");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyProfile");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_StudyProfile");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(1023)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayNameEnglish)
                    .HasMaxLength(1023)
                    .IsUnicode(false);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name)
                    .HasMaxLength(1023)
                    .IsUnicode(false);

                entity.Property(e => e.NameEnglish)
                    .HasMaxLength(1023)
                    .IsUnicode(false);

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyProfile)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyProfile_ImportSession");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.StudyProfile)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_StudyProfile_ObjectType");
            });

            modelBuilder.Entity<StudyProfileProfilesContingentUnitContingentUnits>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("StudyProfileProfiles_ContingentUnitContingentUnits");

                entity.HasIndex(e => e.ContingentUnits)
                    .HasName("iContingentUnits_StudyProfileProfiles_ContingentUnitContingentUnits");

                entity.HasIndex(e => e.Profiles)
                    .HasName("iProfiles_StudyProfileProfiles_ContingentUnitContingentUnits");

                entity.HasIndex(e => new { e.ContingentUnits, e.Profiles })
                    .HasName("iContingentUnitsProfiles_StudyProfileProfiles_ContingentUnitContingentUnits")
                    .IsUnique();

                entity.HasIndex(e => new { e.ContingentUnits, e.Oid, e.OptimisticLockField, e.Profiles })
                    .HasName("ix_20180903_StudyProfileProfiles_ContingentUnitContingentUnits");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ContingentUnitsNavigation)
                    .WithMany(p => p.StudyProfileProfilesContingentUnitContingentUnits)
                    .HasForeignKey(d => d.ContingentUnits)
                    .HasConstraintName("FK_StudyProfileProfiles_ContingentUnitContingentUnits_ContingentUnits");

                entity.HasOne(d => d.ProfilesNavigation)
                    .WithMany(p => p.StudyProfileProfilesContingentUnitContingentUnits)
                    .HasForeignKey(d => d.Profiles)
                    .HasConstraintName("FK_StudyProfileProfiles_ContingentUnitContingentUnits_Profiles");
            });

            modelBuilder.Entity<StudyProfileProfilesStudyPlanStudyPlans>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("StudyProfileProfiles_StudyPlanStudyPlans");

                entity.HasIndex(e => e.Profiles)
                    .HasName("iProfiles_StudyProfileProfiles_StudyPlanStudyPlans");

                entity.HasIndex(e => e.StudyPlans)
                    .HasName("iStudyPlans_StudyProfileProfiles_StudyPlanStudyPlans");

                entity.HasIndex(e => new { e.StudyPlans, e.Profiles })
                    .HasName("iStudyPlansProfiles_StudyProfileProfiles_StudyPlanStudyPlans")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ProfilesNavigation)
                    .WithMany(p => p.StudyProfileProfilesStudyPlanStudyPlans)
                    .HasForeignKey(d => d.Profiles)
                    .HasConstraintName("FK_StudyProfileProfiles_StudyPlanStudyPlans_Profiles");

                entity.HasOne(d => d.StudyPlansNavigation)
                    .WithMany(p => p.StudyProfileProfilesStudyPlanStudyPlans)
                    .HasForeignKey(d => d.StudyPlans)
                    .HasConstraintName("FK_StudyProfileProfiles_StudyPlanStudyPlans_StudyPlans");
            });

            modelBuilder.Entity<StudyProgram>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.AdmissionYear)
                    .HasName("iAdmissionYear_StudyProgram");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyProgram");

                entity.HasIndex(e => e.Id)
                    .HasName("iId_StudyProgram")
                    .IsUnique();

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyProgram");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("iObjectType_StudyProgram");

                entity.HasIndex(e => e.PrimaryDivision)
                    .HasName("iPrimaryDivision_StudyProgram");

                entity.HasIndex(e => e.StudyLevel)
                    .HasName("iStudyLevel_StudyProgram");

                entity.HasIndex(e => new { e.Oid, e.DisplayName, e.Number, e.LicenseName, e.LicenseNameEnglish, e.LicenseCode, e.NormativePeriod, e.ProgramTypeName, e.IsImported, e.ImportSession, e.OptimisticLockField, e.DisplayNameEnglish, e.Name, e.NameEnglish, e.StudyLevel, e.PrimaryDivision, e.Id, e.XtracurDivisionAlias, e.ImportId, e.AdmissionYear, e.Gcrecord, e.ObjectType })
                    .HasName("ix_20180903_StudyProgram");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DisplayName).HasMaxLength(1000);

                entity.Property(e => e.DisplayNameEnglish).HasMaxLength(1000);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LicenseCode).HasColumnType("nvarchar(max)");

                entity.Property(e => e.LicenseName).HasMaxLength(1000);

                entity.Property(e => e.LicenseNameEnglish).HasMaxLength(1000);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.NameEnglish).HasMaxLength(1000);

                entity.Property(e => e.NormativePeriod).HasMaxLength(50);

                entity.Property(e => e.Number).HasMaxLength(100);

                entity.Property(e => e.ProgramTypeName).HasMaxLength(100);

                entity.Property(e => e.XtracurDivisionAlias).HasMaxLength(50);

                entity.HasOne(d => d.AdmissionYearNavigation)
                    .WithMany(p => p.StudyProgram)
                    .HasForeignKey(d => d.AdmissionYear)
                    .HasConstraintName("FK_StudyProgram_AdmissionYear");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyProgram)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyProgram_ImportSession");

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.StudyProgram)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_StudyProgram_ObjectType");

                entity.HasOne(d => d.PrimaryDivisionNavigation)
                    .WithMany(p => p.StudyProgram)
                    .HasForeignKey(d => d.PrimaryDivision)
                    .HasConstraintName("FK_StudyProgram_PrimaryDivision");

                entity.HasOne(d => d.StudyLevelNavigation)
                    .WithMany(p => p.StudyProgram)
                    .HasForeignKey(d => d.StudyLevel)
                    .HasConstraintName("FK_StudyProgram_StudyLevel");
            });

            modelBuilder.Entity<StudyProgramStudyProgramsBaseTimeTableTimeTables>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("StudyProgramStudyPrograms_BaseTimeTableTimeTables");

                entity.HasIndex(e => e.StudyPrograms)
                    .HasName("iStudyPrograms_StudyProgramStudyPrograms_BaseTimeTableTimeTables");

                entity.HasIndex(e => e.TimeTables)
                    .HasName("iTimeTables_StudyProgramStudyPrograms_BaseTimeTableTimeTables");

                entity.HasIndex(e => new { e.TimeTables, e.StudyPrograms })
                    .HasName("iTimeTablesStudyPrograms_StudyProgramStudyPrograms_BaseTimeTableTimeTables")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.StudyProgramsNavigation)
                    .WithMany(p => p.StudyProgramStudyProgramsBaseTimeTableTimeTables)
                    .HasForeignKey(d => d.StudyPrograms)
                    .HasConstraintName("FK_StudyProgramStudyPrograms_BaseTimeTableTimeTables_StudyPrograms");

                entity.HasOne(d => d.TimeTablesNavigation)
                    .WithMany(p => p.StudyProgramStudyProgramsBaseTimeTableTimeTables)
                    .HasForeignKey(d => d.TimeTables)
                    .HasConstraintName("FK_StudyProgramStudyPrograms_BaseTimeTableTimeTables_TimeTables");
            });

            modelBuilder.Entity<StudyProgramStudyProgramsContingentUnitContingentUnits>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("StudyProgramStudyPrograms_ContingentUnitContingentUnits");

                entity.HasIndex(e => e.ContingentUnits)
                    .HasName("iContingentUnits_StudyProgramStudyPrograms_ContingentUnitContingentUnits");

                entity.HasIndex(e => e.StudyPrograms)
                    .HasName("ix_20180903_StudyProgramStudyPrograms_ContingentUnitContingentUnits");

                entity.HasIndex(e => new { e.ContingentUnits, e.StudyPrograms })
                    .HasName("iContingentUnitsStudyPrograms_StudyProgramStudyPrograms_ContingentUnitContingentUnits")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ContingentUnitsNavigation)
                    .WithMany(p => p.StudyProgramStudyProgramsContingentUnitContingentUnits)
                    .HasForeignKey(d => d.ContingentUnits)
                    .HasConstraintName("FK_StudyProgramStudyPrograms_ContingentUnitContingentUnits_ContingentUnits");

                entity.HasOne(d => d.StudyProgramsNavigation)
                    .WithMany(p => p.StudyProgramStudyProgramsContingentUnitContingentUnits)
                    .HasForeignKey(d => d.StudyPrograms)
                    .HasConstraintName("FK_StudyProgramStudyPrograms_ContingentUnitContingentUnits_StudyPrograms");
            });

            modelBuilder.Entity<StudyProgramStudyProgramsDivisionDivisions>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("StudyProgramStudyPrograms_DivisionDivisions");

                entity.HasIndex(e => e.Divisions)
                    .HasName("iDivisions_StudyProgramStudyPrograms_DivisionDivisions");

                entity.HasIndex(e => e.StudyPrograms)
                    .HasName("iStudyPrograms_StudyProgramStudyPrograms_DivisionDivisions");

                entity.HasIndex(e => new { e.Divisions, e.StudyPrograms })
                    .HasName("iDivisionsStudyPrograms_StudyProgramStudyPrograms_DivisionDivisions")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DivisionsNavigation)
                    .WithMany(p => p.StudyProgramStudyProgramsDivisionDivisions)
                    .HasForeignKey(d => d.Divisions)
                    .HasConstraintName("FK_StudyProgramStudyPrograms_DivisionDivisions_Divisions");

                entity.HasOne(d => d.StudyProgramsNavigation)
                    .WithMany(p => p.StudyProgramStudyProgramsDivisionDivisions)
                    .HasForeignKey(d => d.StudyPrograms)
                    .HasConstraintName("FK_StudyProgramStudyPrograms_DivisionDivisions_StudyPrograms");
            });

            modelBuilder.Entity<StudyProgramStudyProgramsEducatorStudyWorkUnitEducatorStudyWorkUnits>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("StudyProgramStudyPrograms_EducatorStudyWorkUnitEducatorStudyWorkUnits");

                entity.HasIndex(e => e.EducatorStudyWorkUnits)
                    .HasName("iEducatorStudyWorkUnits_StudyProgramStudyPrograms_EducatorStudyWorkUnitEducatorStudyWorkUnits");

                entity.HasIndex(e => e.StudyPrograms)
                    .HasName("iStudyPrograms_StudyProgramStudyPrograms_EducatorStudyWorkUnitEducatorStudyWorkUnits");

                entity.HasIndex(e => new { e.EducatorStudyWorkUnits, e.StudyPrograms })
                    .HasName("iEducatorStudyWorkUnitsStudyPrograms_StudyProgramStudyPrograms_EducatorStudyWorkUnitEducatorStudyWorkUnits")
                    .IsUnique();

                entity.HasIndex(e => new { e.EducatorStudyWorkUnits, e.Oid, e.OptimisticLockField, e.StudyPrograms })
                    .HasName("ix_20180903_StudyProgramStudyPrograms_EducatorStudyWorkUnitEducatorStudyWorkUnits");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EducatorStudyWorkUnitsNavigation)
                    .WithMany(p => p.StudyProgramStudyProgramsEducatorStudyWorkUnitEducatorStudyWorkUnits)
                    .HasForeignKey(d => d.EducatorStudyWorkUnits)
                    .HasConstraintName("FK_StudyProgramStudyPrograms_EducatorStudyWorkUnitEducatorStudyWorkUnits_EducatorStudyWorkUnits");

                entity.HasOne(d => d.StudyProgramsNavigation)
                    .WithMany(p => p.StudyProgramStudyProgramsEducatorStudyWorkUnitEducatorStudyWorkUnits)
                    .HasForeignKey(d => d.StudyPrograms)
                    .HasConstraintName("FK_StudyProgramStudyPrograms_EducatorStudyWorkUnitEducatorStudyWorkUnits_StudyPrograms");
            });

            modelBuilder.Entity<StudyProgramStudyProgramsStudyProfileProfiles>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("StudyProgramStudyPrograms_StudyProfileProfiles");

                entity.HasIndex(e => e.Profiles)
                    .HasName("iProfiles_StudyProgramStudyPrograms_StudyProfileProfiles");

                entity.HasIndex(e => e.StudyPrograms)
                    .HasName("iStudyPrograms_StudyProgramStudyPrograms_StudyProfileProfiles");

                entity.HasIndex(e => new { e.Profiles, e.StudyPrograms })
                    .HasName("iProfilesStudyPrograms_StudyProgramStudyPrograms_StudyProfileProfiles")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ProfilesNavigation)
                    .WithMany(p => p.StudyProgramStudyProgramsStudyProfileProfiles)
                    .HasForeignKey(d => d.Profiles)
                    .HasConstraintName("FK_StudyProgramStudyPrograms_StudyProfileProfiles_Profiles");

                entity.HasOne(d => d.StudyProgramsNavigation)
                    .WithMany(p => p.StudyProgramStudyProgramsStudyProfileProfiles)
                    .HasForeignKey(d => d.StudyPrograms)
                    .HasConstraintName("FK_StudyProgramStudyPrograms_StudyProfileProfiles_StudyPrograms");
            });

            modelBuilder.Entity<StudyYear>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_StudyYear");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_StudyYear");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.DisplayNameEnglish).HasMaxLength(100);

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.StudyYear)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_StudyYear_ImportSession");
            });

            modelBuilder.Entity<TimeScaleStepKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Code)
                    .HasName("iCode_TimeScaleStepKind")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_TimeScaleStepKind");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<TimetableLog>(entity =>
            {
                entity.Property(e => e.TimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_User");

                entity.HasIndex(e => e.UserName)
                    .HasName("iUserName_User")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.ContactPhone).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.PersonFullName).HasMaxLength(100);

                entity.Property(e => e.PositionDisplayName).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<UserApplication>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.ApplicantUser)
                    .HasName("iApplicantUser_UserApplication");

                entity.HasIndex(e => e.AssigneeUser)
                    .HasName("iAssigneeUser_UserApplication");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_UserApplication");

                entity.HasIndex(e => e.Status)
                    .HasName("iStatus_UserApplication");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.ApplicantActualResult).HasMaxLength(200);

                entity.Property(e => e.ApplicantExpectedResult).HasMaxLength(200);

                entity.Property(e => e.ApplicantStepsToReproduce).HasMaxLength(1000);

                entity.Property(e => e.AssigneeActualResult).HasMaxLength(200);

                entity.Property(e => e.AssigneeExpectedResult).HasMaxLength(200);

                entity.Property(e => e.AssigneeStepsToReproduce).HasMaxLength(1000);

                entity.Property(e => e.ContactPhone).HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.MessageBody).HasMaxLength(1000);

                entity.Property(e => e.Reply).HasMaxLength(1000);

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.HasOne(d => d.ApplicantUserNavigation)
                    .WithMany(p => p.UserApplicationApplicantUserNavigation)
                    .HasForeignKey(d => d.ApplicantUser)
                    .HasConstraintName("FK_UserApplication_ApplicantUser");

                entity.HasOne(d => d.AssigneeUserNavigation)
                    .WithMany(p => p.UserApplicationAssigneeUserNavigation)
                    .HasForeignKey(d => d.AssigneeUser)
                    .HasConstraintName("FK_UserApplication_AssigneeUser");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.UserApplication)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK_UserApplication_Status");
            });

            modelBuilder.Entity<UserApplicationStatus>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Code)
                    .HasName("iCode_UserApplicationStatus")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_UserApplicationStatus");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<UserApplicationUpdate>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.CommentAuthorUser)
                    .HasName("iCommentAuthorUser_UserApplicationUpdate");

                entity.HasIndex(e => e.CurrentAssigneeUser)
                    .HasName("iCurrentAssigneeUser_UserApplicationUpdate");

                entity.HasIndex(e => e.CurrentStatus)
                    .HasName("iCurrentStatus_UserApplicationUpdate");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_UserApplicationUpdate");

                entity.HasIndex(e => e.UserApplication)
                    .HasName("iUserApplication_UserApplicationUpdate");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.CommentAuthorUserNavigation)
                    .WithMany(p => p.UserApplicationUpdateCommentAuthorUserNavigation)
                    .HasForeignKey(d => d.CommentAuthorUser)
                    .HasConstraintName("FK_UserApplicationUpdate_CommentAuthorUser");

                entity.HasOne(d => d.CurrentAssigneeUserNavigation)
                    .WithMany(p => p.UserApplicationUpdateCurrentAssigneeUserNavigation)
                    .HasForeignKey(d => d.CurrentAssigneeUser)
                    .HasConstraintName("FK_UserApplicationUpdate_CurrentAssigneeUser");

                entity.HasOne(d => d.CurrentStatusNavigation)
                    .WithMany(p => p.UserApplicationUpdate)
                    .HasForeignKey(d => d.CurrentStatus)
                    .HasConstraintName("FK_UserApplicationUpdate_CurrentStatus");

                entity.HasOne(d => d.UserApplicationNavigation)
                    .WithMany(p => p.UserApplicationUpdate)
                    .HasForeignKey(d => d.UserApplication)
                    .HasConstraintName("FK_UserApplicationUpdate_UserApplication");
            });

            modelBuilder.Entity<UserInPedUnit>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.CommentAuthor)
                    .HasName("iCommentAuthor_UserInPedUnit");

                entity.HasIndex(e => e.Discipline)
                    .HasName("iDiscipline_UserInPedUnit");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_UserInPedUnit");

                entity.HasIndex(e => e.ImportSession)
                    .HasName("iImportSession_UserInPedUnit");

                entity.HasIndex(e => e.PedUnit)
                    .HasName("iPedUnit_UserInPedUnit");

                entity.HasIndex(e => e.Puuser)
                    .HasName("iPUUser_UserInPedUnit");

                entity.HasIndex(e => e.RealizationVariant)
                    .HasName("iRealizationVariant_UserInPedUnit");

                entity.HasIndex(e => e.StudyPlan)
                    .HasName("iStudyPlan_UserInPedUnit");

                entity.HasIndex(e => e.StudyProgram)
                    .HasName("iStudyProgram_UserInPedUnit");

                entity.HasIndex(e => e.TermName)
                    .HasName("iTermName_UserInPedUnit");

                entity.HasIndex(e => e.Trajectory)
                    .HasName("iTrajectory_UserInPedUnit");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Puuser).HasColumnName("PUUser");

                entity.HasOne(d => d.CommentAuthorNavigation)
                    .WithMany(p => p.UserInPedUnitCommentAuthorNavigation)
                    .HasForeignKey(d => d.CommentAuthor)
                    .HasConstraintName("FK_UserInPedUnit_CommentAuthor");

                entity.HasOne(d => d.DisciplineNavigation)
                    .WithMany(p => p.UserInPedUnit)
                    .HasForeignKey(d => d.Discipline)
                    .HasConstraintName("FK_UserInPedUnit_Discipline");

                entity.HasOne(d => d.ImportSessionNavigation)
                    .WithMany(p => p.UserInPedUnit)
                    .HasForeignKey(d => d.ImportSession)
                    .HasConstraintName("FK_UserInPedUnit_ImportSession");

                entity.HasOne(d => d.PedUnitNavigation)
                    .WithMany(p => p.UserInPedUnit)
                    .HasForeignKey(d => d.PedUnit)
                    .HasConstraintName("FK_UserInPedUnit_PedUnit");

                entity.HasOne(d => d.PuuserNavigation)
                    .WithMany(p => p.UserInPedUnitPuuserNavigation)
                    .HasForeignKey(d => d.Puuser)
                    .HasConstraintName("FK_UserInPedUnit_PUUser");

                entity.HasOne(d => d.RealizationVariantNavigation)
                    .WithMany(p => p.UserInPedUnit)
                    .HasForeignKey(d => d.RealizationVariant)
                    .HasConstraintName("FK_UserInPedUnit_RealizationVariant");

                entity.HasOne(d => d.StudyPlanNavigation)
                    .WithMany(p => p.UserInPedUnit)
                    .HasForeignKey(d => d.StudyPlan)
                    .HasConstraintName("FK_UserInPedUnit_StudyPlan");

                entity.HasOne(d => d.StudyProgramNavigation)
                    .WithMany(p => p.UserInPedUnit)
                    .HasForeignKey(d => d.StudyProgram)
                    .HasConstraintName("FK_UserInPedUnit_StudyProgram");

                entity.HasOne(d => d.TermNameNavigation)
                    .WithMany(p => p.UserInPedUnit)
                    .HasForeignKey(d => d.TermName)
                    .HasConstraintName("FK_UserInPedUnit_TermName");

                entity.HasOne(d => d.TrajectoryNavigation)
                    .WithMany(p => p.UserInPedUnit)
                    .HasForeignKey(d => d.Trajectory)
                    .HasConstraintName("FK_UserInPedUnit_Trajectory");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.HasOne(d => d.O)
                    .WithOne(p => p.UserRole)
                    .HasForeignKey<UserRole>(d => d.Oid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_Oid");
            });

            modelBuilder.Entity<UserRoleKind>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Code)
                    .HasName("iCode_UserRoleKind")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_UserRoleKind");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<UserSelectedContingentUnitInTimeTable>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.ContingentUnit)
                    .HasName("iContingentUnit_UserSelectedContingentUnitInTimeTable");

                entity.HasIndex(e => e.TimeTable)
                    .HasName("iTimeTable_UserSelectedContingentUnitInTimeTable");

                entity.HasIndex(e => e.User)
                    .HasName("iUser_UserSelectedContingentUnitInTimeTable");

                entity.HasIndex(e => new { e.User, e.ContingentUnit, e.TimeTable })
                    .HasName("iUserContingentUnitTimeTable_UserSelectedContingentUnitInTimeTable")
                    .IsUnique();

                entity.HasIndex(e => new { e.Oid, e.ContingentUnit, e.TimeTable, e.OptimisticLockField, e.User })
                    .HasName("ix_20180903_UserSelectedContingentUnitInTimeTable");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.HasOne(d => d.ContingentUnitNavigation)
                    .WithMany(p => p.UserSelectedContingentUnitInTimeTable)
                    .HasForeignKey(d => d.ContingentUnit)
                    .HasConstraintName("FK_UserSelectedContingentUnitInTimeTable_ContingentUnit");

                entity.HasOne(d => d.TimeTableNavigation)
                    .WithMany(p => p.UserSelectedContingentUnitInTimeTable)
                    .HasForeignKey(d => d.TimeTable)
                    .HasConstraintName("FK_UserSelectedContingentUnitInTimeTable_TimeTable");

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.UserSelectedContingentUnitInTimeTable)
                    .HasForeignKey(d => d.User)
                    .HasConstraintName("FK_UserSelectedContingentUnitInTimeTable_User");
            });

            modelBuilder.Entity<UserSelectedDaysInTimeTable>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.TimeTable)
                    .HasName("iTimeTable_UserSelectedDaysInTimeTable");

                entity.HasIndex(e => e.User)
                    .HasName("iUser_UserSelectedDaysInTimeTable");

                entity.HasIndex(e => new { e.User, e.TimeTable })
                    .HasName("iUserTimeTable_UserSelectedDaysInTimeTable")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.HasOne(d => d.TimeTableNavigation)
                    .WithMany(p => p.UserSelectedDaysInTimeTable)
                    .HasForeignKey(d => d.TimeTable)
                    .HasConstraintName("FK_UserSelectedDaysInTimeTable_TimeTable");

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.UserSelectedDaysInTimeTable)
                    .HasForeignKey(d => d.User)
                    .HasConstraintName("FK_UserSelectedDaysInTimeTable_User");
            });

            modelBuilder.Entity<UserStudyPlan>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.HasOne(d => d.O)
                    .WithOne(p => p.UserStudyPlan)
                    .HasForeignKey<UserStudyPlan>(d => d.Oid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserStudyPlan_Oid");
            });

            modelBuilder.Entity<UserUsersSecuritySystemRoleUserRoles>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("UserUsers_SecuritySystemRoleUserRoles");

                entity.HasIndex(e => e.UserRoles)
                    .HasName("iUserRoles_UserUsers_SecuritySystemRoleUserRoles");

                entity.HasIndex(e => e.Users)
                    .HasName("iUsers_UserUsers_SecuritySystemRoleUserRoles");

                entity.HasIndex(e => new { e.UserRoles, e.Users })
                    .HasName("iUserRolesUsers_UserUsers_SecuritySystemRoleUserRoles")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.UserRolesNavigation)
                    .WithMany(p => p.UserUsersSecuritySystemRoleUserRoles)
                    .HasForeignKey(d => d.UserRoles)
                    .HasConstraintName("FK_UserUsers_SecuritySystemRoleUserRoles_UserRoles");

                entity.HasOne(d => d.UsersNavigation)
                    .WithMany(p => p.UserUsersSecuritySystemRoleUserRoles)
                    .HasForeignKey(d => d.Users)
                    .HasConstraintName("FK_UserUsers_SecuritySystemRoleUserRoles_Users");
            });

            modelBuilder.Entity<UserUsersSelectedThisAddressAddressSelectedAddresses>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("UserUsersSelectedThisAddress_AddressSelectedAddresses");

                entity.HasIndex(e => e.SelectedAddresses)
                    .HasName("iSelectedAddresses_UserUsersSelectedThisAddress_AddressSelectedAddresses");

                entity.HasIndex(e => e.UsersSelectedThisAddress)
                    .HasName("iUsersSelectedThisAddress_UserUsersSelectedThisAddress_AddressSelectedAddresses");

                entity.HasIndex(e => new { e.SelectedAddresses, e.UsersSelectedThisAddress })
                    .HasName("iSelectedAddressesUsersSelectedThisAddress_UserUsersSelectedThisAddress_AddressSelectedAddresses")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.SelectedAddressesNavigation)
                    .WithMany(p => p.UserUsersSelectedThisAddressAddressSelectedAddresses)
                    .HasForeignKey(d => d.SelectedAddresses)
                    .HasConstraintName("FK_UserUsersSelectedThisAddress_AddressSelectedAddresses_SelectedAddresses");

                entity.HasOne(d => d.UsersSelectedThisAddressNavigation)
                    .WithMany(p => p.UserUsersSelectedThisAddressAddressSelectedAddresses)
                    .HasForeignKey(d => d.UsersSelectedThisAddress)
                    .HasConstraintName("FK_UserUsersSelectedThisAddress_AddressSelectedAddresses_UsersSelectedThisAddress");
            });

            modelBuilder.Entity<UserUsersUserRoleUserRoles>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("UserUsers_UserRoleUserRoles");

                entity.HasIndex(e => e.UserRoles)
                    .HasName("iUserRoles_UserUsers_UserRoleUserRoles");

                entity.HasIndex(e => e.Users)
                    .HasName("iUsers_UserUsers_UserRoleUserRoles");

                entity.HasIndex(e => new { e.UserRoles, e.Users })
                    .HasName("iUserRolesUsers_UserUsers_UserRoleUserRoles")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.UserRolesNavigation)
                    .WithMany(p => p.UserUsersUserRoleUserRoles)
                    .HasForeignKey(d => d.UserRoles)
                    .HasConstraintName("FK_UserUsers_UserRoleUserRoles_UserRoles");

                entity.HasOne(d => d.UsersNavigation)
                    .WithMany(p => p.UserUsersUserRoleUserRoles)
                    .HasForeignKey(d => d.Users)
                    .HasConstraintName("FK_UserUsers_UserRoleUserRoles_Users");
            });

            modelBuilder.Entity<VwAdcroomInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ADCRoomInfo");

                entity.Property(e => e.OidЗдания).HasColumnName("OID Здания");

                entity.Property(e => e.OidПомещения).HasColumnName("OID помещения");

                entity.Property(e => e.Адрес).HasMaxLength(250);

                entity.Property(e => e.ВидАудитории).HasColumnName("Вид аудитории");

                entity.Property(e => e.ВидПомещения)
                    .HasColumnName("Вид помещения")
                    .HasMaxLength(100);

                entity.Property(e => e.ВидПомещенияSap).HasColumnName("Вид помещения SAP");

                entity.Property(e => e.Город).HasMaxLength(100);

                entity.Property(e => e.КодУнимЗдания)
                    .HasColumnName("КодУНИМ Здания")
                    .HasMaxLength(50);

                entity.Property(e => e.КодУнимПомещения)
                    .HasColumnName("КодУНИМ Помещения")
                    .HasMaxLength(50);

                entity.Property(e => e.КолВоКомпьютеров).HasColumnName("Кол-во компьютеров");

                entity.Property(e => e.ЛабораторноеОборудование).HasColumnName("Лабораторное оборудование");

                entity.Property(e => e.МультимедиаОборудование).HasColumnName("Мультимедиа оборудование");

                entity.Property(e => e.НаименованиеЗдания)
                    .HasColumnName("Наименование здания")
                    .HasMaxLength(100);

                entity.Property(e => e.НаименованиеПомещения)
                    .HasColumnName("Наименование помещения")
                    .HasMaxLength(100);

                entity.Property(e => e.НомерДома)
                    .HasColumnName("Номер дома")
                    .HasMaxLength(103);

                entity.Property(e => e.НомерДомаДоп)
                    .HasColumnName("Номер дома (доп)")
                    .HasMaxLength(105);

                entity.Property(e => e.Помещения)
                    .HasColumnName("№ помещения")
                    .HasMaxLength(100);

                entity.Property(e => e.Примечание).HasMaxLength(100);

                entity.Property(e => e.СОграниченнымДоступом).HasColumnName("С ограниченным доступом");

                entity.Property(e => e.Улица).HasMaxLength(100);
            });

            modelBuilder.Entity<VwEducatorStudyWorkSourceInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_EducatorStudyWorkSourceInfo");

                entity.Property(e => e.Author).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<VwStudyModulesLocations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_StudyModulesLocations");

                entity.Property(e => e.DisciplineName).HasMaxLength(500);

                entity.Property(e => e.RealizationVariantName)
                    .HasMaxLength(1023)
                    .IsUnicode(false);

                entity.Property(e => e.StudyPlanNumber).HasMaxLength(50);

                entity.Property(e => e.StudyProgramName).HasMaxLength(1000);

                entity.Property(e => e.StudyProgramNumber).HasMaxLength(100);

                entity.Property(e => e.StudyWorkName).HasMaxLength(150);

                entity.Property(e => e.TermName).HasMaxLength(100);

                entity.Property(e => e.TrajectoryName).HasMaxLength(100);

                entity.Property(e => e.YearName).HasMaxLength(100);
            });

            modelBuilder.Entity<VwTeacherContingentUnits>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_TeacherContingentUnits");

                entity.Property(e => e.ВиртуальныйКонтингентId).HasColumnName("Виртуальный Контингент: Id");

                entity.Property(e => e.ВиртуальныйКонтингентНаименование).HasColumnName("Виртуальный Контингент: Наименование");

                entity.Property(e => e.ДисциплинаId).HasColumnName("Дисциплина: Id");

                entity.Property(e => e.ДисциплинаВидЗанятий)
                    .HasColumnName("Дисциплина:Вид занятий")
                    .HasMaxLength(150);

                entity.Property(e => e.ДисциплинаНаименование)
                    .HasColumnName("Дисциплина:Наименование")
                    .HasMaxLength(500);

                entity.Property(e => e.ДисциплинаНомер)
                    .HasColumnName("Дисциплина:Номер")
                    .HasMaxLength(50);

                entity.Property(e => e.ПпсPersNumSapId).HasColumnName("ППС:PersNum (SAP ID)");

                entity.Property(e => e.ПпсИмя)
                    .HasColumnName("ППС:Имя")
                    .HasMaxLength(100);

                entity.Property(e => e.ПпсЛогин)
                    .HasColumnName("ППС:Логин")
                    .HasMaxLength(100);

                entity.Property(e => e.ПпсОтчество)
                    .HasColumnName("ППС:Отчество")
                    .HasMaxLength(100);

                entity.Property(e => e.ПпсТабельныйНомер).HasColumnName("ППС:Табельный номер");

                entity.Property(e => e.ПпсФамилия)
                    .HasColumnName("ППС:Фамилия")
                    .HasMaxLength(100);

                entity.Property(e => e.УчебныйГодНаименование)
                    .HasColumnName("Учебный год: наименование")
                    .HasMaxLength(100);

                entity.Property(e => e.УчебныйГодНомер).HasColumnName("Учебный год: номер");
            });

            modelBuilder.Entity<VwTeachersWorkHours>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_TeachersWorkHours");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.DisciplineName).HasMaxLength(500);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.RealizationVariantName)
                    .HasMaxLength(1023)
                    .IsUnicode(false);

                entity.Property(e => e.StudyPlanNumber).HasMaxLength(50);

                entity.Property(e => e.StudyProgramName).HasMaxLength(1000);

                entity.Property(e => e.StudyProgramNumber).HasMaxLength(100);

                entity.Property(e => e.StudyWorkName).HasMaxLength(150);

                entity.Property(e => e.TeacherSapid).HasColumnName("Teacher_SAPID");

                entity.Property(e => e.TermName).HasMaxLength(100);

                entity.Property(e => e.TrajectoryName).HasMaxLength(100);

                entity.Property(e => e.YearName).HasMaxLength(100);
            });

            modelBuilder.Entity<WeeklyRecurGenerator>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.WeekNumber, e.RecurIndexOffset })
                    .HasName("ciWeeklyRecurGenrator")
                    .IsClustered();

                entity.HasIndex(e => new { e.RecurStartOffset, e.RecurIndexOffset, e.WeekNumber, e.RecurWeekDays, e.RecurStartDayNumber })
                    .HasName("iWeeklyRecurGenrator");
            });

            modelBuilder.Entity<XpobjectType>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XPObjectType");

                entity.HasIndex(e => e.TypeName)
                    .HasName("iTypeName_XPObjectType")
                    .IsUnique();

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.AssemblyName).HasMaxLength(254);

                entity.Property(e => e.TypeName).HasMaxLength(254);
            });

            modelBuilder.Entity<XtracurDivision>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Alias)
                    .HasName("iAlias_XtracurDivision")
                    .IsUnique();

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XtracurDivision");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Alias).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameEnglish).HasMaxLength(100);
            });

            modelBuilder.Entity<XtracurImageAttachment>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_XtracurImageAttachment");

                entity.HasIndex(e => e.Oid)
                    .HasName("UQ__XtracurI__CB3E4F302712E4B3")
                    .IsUnique();

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<Лист1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Лист1$");

                entity.Property(e => e.АкадемЧасы).HasColumnName("Академ# часы");

                entity.Property(e => e.АстрономическиеЧасы).HasColumnName("Астрономические часы");

                entity.Property(e => e.ВидЗанятий)
                    .HasColumnName("Вид занятий")
                    .HasMaxLength(255);

                entity.Property(e => e.Дисциплина).HasMaxLength(255);

                entity.Property(e => e.Контингент).HasMaxLength(1024);

                entity.Property(e => e.Направление).HasMaxLength(255);

                entity.Property(e => e.НомерДисциплины).HasColumnName("Номер дисциплины");

                entity.Property(e => e.НомерУчебногоПлана)
                    .HasColumnName("Номер учебного плана")
                    .HasMaxLength(255);

                entity.Property(e => e.ОбразовательнаяПрограмма)
                    .HasColumnName("Образовательная программа")
                    .HasMaxLength(255);

                entity.Property(e => e.ПпсДатаРождения)
                    .HasColumnName("ППС:Дата рождения")
                    .HasColumnType("datetime");

                entity.Property(e => e.ПпсИмя)
                    .HasColumnName("ППС:Имя")
                    .HasMaxLength(255);

                entity.Property(e => e.ПпсОтчество)
                    .HasColumnName("ППС:Отчество")
                    .HasMaxLength(255);

                entity.Property(e => e.ПпсФамилия)
                    .HasColumnName("ППС:Фамилия")
                    .HasMaxLength(255);

                entity.Property(e => e.Профиль).HasMaxLength(255);

                entity.Property(e => e.Семестр).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
