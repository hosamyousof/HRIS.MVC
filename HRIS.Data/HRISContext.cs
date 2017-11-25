using HRIS.Data.Entity;
using HRIS.Data.Mapping;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HRIS.Data
{
    public partial class HRISContext : Repository.Providers.EntityFramework.DataContext
    {
        #region Tables
        public DbSet<mf_Agency> mf_Agencies { get; set; }
        public DbSet<mf_Allowance> mf_Allowances { get; set; }
        public DbSet<mf_ApplicationRequestType> mf_ApplicationRequestTypes { get; set; }
        public DbSet<mf_Country> mf_Countries { get; set; }
        public DbSet<mf_Deduction> mf_Deductions { get; set; }
        public DbSet<mf_Department> mf_Departments { get; set; }
        public DbSet<mf_DepartmentSection> mf_DepartmentSections { get; set; }
        public DbSet<mf_DepartmentSectionRequestApprover> mf_DepartmentSectionRequestApprovers { get; set; }
        public DbSet<mf_Employee> mf_Employees { get; set; }
        public DbSet<mf_Employee201> mf_Employee201 { get; set; }
        public DbSet<mf_EmployeeAddress> mf_EmployeeAddresses { get; set; }
        public DbSet<mf_EmployeeAllowance> mf_EmployeeAllowances { get; set; }
        public DbSet<mf_EmployeeBalanceLeave> mf_EmployeeBalanceLeaves { get; set; }
        public DbSet<mf_EmployeeBasicPay> mf_EmployeeBasicPays { get; set; }
        public DbSet<mf_EmployeeDeduction> mf_EmployeeDeductions { get; set; }
        public DbSet<mf_EmployeeEducation> mf_EmployeeEducations { get; set; }
        public DbSet<mf_EmployeeIdentificationDocument> mf_EmployeeIdentificationDocuments { get; set; }
        public DbSet<mf_EmployeeOffense> mf_EmployeeOffenses { get; set; }
        public DbSet<mf_EmployeeSkill> mf_EmployeeSkills { get; set; }
        public DbSet<mf_EmployeeTraining> mf_EmployeeTrainings { get; set; }
        public DbSet<mf_EmployeeWorkDay> mf_EmployeeWorkDays { get; set; }
        public DbSet<mf_EmployeeWorkHistory> mf_EmployeeWorkHistories { get; set; }
        public DbSet<mf_EmploymentStatu> mf_EmploymentStatus { get; set; }
        public DbSet<mf_EmploymentType> mf_EmploymentTypes { get; set; }
        public DbSet<mf_Holiday> mf_Holidays { get; set; }
        public DbSet<mf_HolidayType> mf_HolidayTypes { get; set; }
        public DbSet<mf_Offense> mf_Offenses { get; set; }
        public DbSet<mf_PayrollGroup> mf_PayrollGroups { get; set; }
        public DbSet<mf_PenaltyType> mf_PenaltyTypes { get; set; }
        public DbSet<mf_Position> mf_Positions { get; set; }
        public DbSet<mf_WorkDay> mf_WorkDays { get; set; }
        public DbSet<pr_Payroll> pr_Payrolls { get; set; }
        public DbSet<pr_PayrollEmployee> pr_PayrollEmployees { get; set; }
        public DbSet<pr_PayrollEmployeeDeduction> pr_PayrollEmployeeDeductions { get; set; }
        public DbSet<pr_PayrollEmployeeEarning> pr_PayrollEmployeeEarnings { get; set; }
        public DbSet<sys_Company> sys_Companies { get; set; }
        public DbSet<sys_CompanySetting> sys_CompanySettings { get; set; }
        public DbSet<sys_EnumReference> sys_EnumReferences { get; set; }
        public DbSet<sys_ErrorLog> sys_ErrorLogs { get; set; }
        public DbSet<sys_IdentificationDocument> sys_IdentificationDocuments { get; set; }
        public DbSet<sys_Location> sys_Locations { get; set; }
        public DbSet<sys_Menu> sys_Menus { get; set; }
        public DbSet<sys_Permission> sys_Permissions { get; set; }
        public DbSet<sys_Role> sys_Roles { get; set; }
        public DbSet<sys_RoleMenu> sys_RoleMenus { get; set; }
        public DbSet<sys_RolePermission> sys_RolePermissions { get; set; }
        public DbSet<sys_Setting> sys_Settings { get; set; }
        public DbSet<sys_User> sys_Users { get; set; }
        public DbSet<sys_UserRole> sys_UserRoles { get; set; }
        public DbSet<sys_UserSession> sys_UserSessions { get; set; }
        public DbSet<ta_ApplicationRequest> ta_ApplicationRequests { get; set; }
        public DbSet<ta_ApplicationRequestApprover> ta_ApplicationRequestApprovers { get; set; }
        public DbSet<ta_ApplicationRequestGatePass> ta_ApplicationRequestGatePasses { get; set; }
        public DbSet<ta_ApplicationRequestLeave> ta_ApplicationRequestLeaves { get; set; }
        public DbSet<ta_CutOffAttendance> ta_CutOffAttendances { get; set; }
        public DbSet<ta_CutOffAttendanceSummary> ta_CutOffAttendanceSummaries { get; set; }
        public DbSet<ta_CutOffAttendanceSummaryDetail> ta_CutOffAttendanceSummaryDetails { get; set; }
        public DbSet<ta_EmployeeAttendance> ta_EmployeeAttendances { get; set; }
        #endregion

        public HRISContext()
            : base("Name=HRIS")
        {
            InitializePartial();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new mf_AgencyConfiguration());
            modelBuilder.Configurations.Add(new mf_AllowanceConfiguration());
            modelBuilder.Configurations.Add(new mf_ApplicationRequestTypeConfiguration());
            modelBuilder.Configurations.Add(new mf_CountryConfiguration());
            modelBuilder.Configurations.Add(new mf_DeductionConfiguration());
            modelBuilder.Configurations.Add(new mf_DepartmentConfiguration());
            modelBuilder.Configurations.Add(new mf_DepartmentSectionConfiguration());
            modelBuilder.Configurations.Add(new mf_DepartmentSectionRequestApproverConfiguration());
            modelBuilder.Configurations.Add(new mf_EmployeeConfiguration());
            modelBuilder.Configurations.Add(new mf_Employee201Configuration());
            modelBuilder.Configurations.Add(new mf_EmployeeAddressConfiguration());
            modelBuilder.Configurations.Add(new mf_EmployeeAllowanceConfiguration());
            modelBuilder.Configurations.Add(new mf_EmployeeBalanceLeaveConfiguration());
            modelBuilder.Configurations.Add(new mf_EmployeeBasicPayConfiguration());
            modelBuilder.Configurations.Add(new mf_EmployeeDeductionConfiguration());
            modelBuilder.Configurations.Add(new mf_EmployeeEducationConfiguration());
            modelBuilder.Configurations.Add(new mf_EmployeeIdentificationDocumentConfiguration());
            modelBuilder.Configurations.Add(new mf_EmployeeOffenseConfiguration());
            modelBuilder.Configurations.Add(new mf_EmployeeSkillConfiguration());
            modelBuilder.Configurations.Add(new mf_EmployeeTrainingConfiguration());
            modelBuilder.Configurations.Add(new mf_EmployeeWorkDayConfiguration());
            modelBuilder.Configurations.Add(new mf_EmployeeWorkHistoryConfiguration());
            modelBuilder.Configurations.Add(new mf_EmploymentStatuConfiguration());
            modelBuilder.Configurations.Add(new mf_EmploymentTypeConfiguration());
            modelBuilder.Configurations.Add(new mf_HolidayConfiguration());
            modelBuilder.Configurations.Add(new mf_HolidayTypeConfiguration());
            modelBuilder.Configurations.Add(new mf_OffenseConfiguration());
            modelBuilder.Configurations.Add(new mf_PayrollGroupConfiguration());
            modelBuilder.Configurations.Add(new mf_PenaltyTypeConfiguration());
            modelBuilder.Configurations.Add(new mf_PositionConfiguration());
            modelBuilder.Configurations.Add(new mf_WorkDayConfiguration());
            modelBuilder.Configurations.Add(new pr_PayrollConfiguration());
            modelBuilder.Configurations.Add(new pr_PayrollEmployeeConfiguration());
            modelBuilder.Configurations.Add(new pr_PayrollEmployeeDeductionConfiguration());
            modelBuilder.Configurations.Add(new pr_PayrollEmployeeEarningConfiguration());
            modelBuilder.Configurations.Add(new sys_CompanyConfiguration());
            modelBuilder.Configurations.Add(new sys_CompanySettingConfiguration());
            modelBuilder.Configurations.Add(new sys_EnumReferenceConfiguration());
            modelBuilder.Configurations.Add(new sys_ErrorLogConfiguration());
            modelBuilder.Configurations.Add(new sys_IdentificationDocumentConfiguration());
            modelBuilder.Configurations.Add(new sys_LocationConfiguration());
            modelBuilder.Configurations.Add(new sys_MenuConfiguration());
            modelBuilder.Configurations.Add(new sys_PermissionConfiguration());
            modelBuilder.Configurations.Add(new sys_RoleConfiguration());
            modelBuilder.Configurations.Add(new sys_RoleMenuConfiguration());
            modelBuilder.Configurations.Add(new sys_RolePermissionConfiguration());
            modelBuilder.Configurations.Add(new sys_SettingConfiguration());
            modelBuilder.Configurations.Add(new sys_UserConfiguration());
            modelBuilder.Configurations.Add(new sys_UserRoleConfiguration());
            modelBuilder.Configurations.Add(new sys_UserSessionConfiguration());
            modelBuilder.Configurations.Add(new ta_ApplicationRequestConfiguration());
            modelBuilder.Configurations.Add(new ta_ApplicationRequestApproverConfiguration());
            modelBuilder.Configurations.Add(new ta_ApplicationRequestGatePassConfiguration());
            modelBuilder.Configurations.Add(new ta_ApplicationRequestLeaveConfiguration());
            modelBuilder.Configurations.Add(new ta_CutOffAttendanceConfiguration());
            modelBuilder.Configurations.Add(new ta_CutOffAttendanceSummaryConfiguration());
            modelBuilder.Configurations.Add(new ta_CutOffAttendanceSummaryDetailConfiguration());
            modelBuilder.Configurations.Add(new ta_EmployeeAttendanceConfiguration());

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void InitializePartial();

        partial void OnModelCreatingPartial(DbModelBuilder modelBuilder);

        // Stored Procedures
    }
}