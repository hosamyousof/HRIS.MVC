

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "HRIS.Data\App.config"
//     Connection String Name: "HRIS"
//     Connection String:      "Data Source=.;Initial Catalog=HRIS;User Id=sa;password=**zapped**;"

// Database Edition: Standard Edition (64-bit)
// Database Engine Edition: Standard

// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using Repository;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data
{
    // ************************************************************************
    // Database context
    public partial class HRISContext : Repository.Providers.EntityFramework.DataContext
    {
        public DbSet<mf_Agency> mf_Agencies { get; set; }        public DbSet<mf_Allowance> mf_Allowances { get; set; }        public DbSet<mf_ApplicationRequestType> mf_ApplicationRequestTypes { get; set; }        public DbSet<mf_Country> mf_Countries { get; set; }        public DbSet<mf_Deduction> mf_Deductions { get; set; }        public DbSet<mf_Department> mf_Departments { get; set; }        public DbSet<mf_DepartmentSection> mf_DepartmentSections { get; set; }        public DbSet<mf_DepartmentSectionRequestApprover> mf_DepartmentSectionRequestApprovers { get; set; }        public DbSet<mf_Employee> mf_Employees { get; set; }        public DbSet<mf_Employee201> mf_Employee201 { get; set; }        public DbSet<mf_EmployeeAddress> mf_EmployeeAddresses { get; set; }        public DbSet<mf_EmployeeAllowance> mf_EmployeeAllowances { get; set; }        public DbSet<mf_EmployeeBalanceLeave> mf_EmployeeBalanceLeaves { get; set; }        public DbSet<mf_EmployeeBasicPay> mf_EmployeeBasicPays { get; set; }        public DbSet<mf_EmployeeDeduction> mf_EmployeeDeductions { get; set; }        public DbSet<mf_EmployeeEducation> mf_EmployeeEducations { get; set; }        public DbSet<mf_EmployeeIdentificationDocument> mf_EmployeeIdentificationDocuments { get; set; }        public DbSet<mf_EmployeeOffense> mf_EmployeeOffenses { get; set; }        public DbSet<mf_EmployeeSkill> mf_EmployeeSkills { get; set; }        public DbSet<mf_EmployeeTraining> mf_EmployeeTrainings { get; set; }        public DbSet<mf_EmployeeWorkDay> mf_EmployeeWorkDays { get; set; }        public DbSet<mf_EmployeeWorkHistory> mf_EmployeeWorkHistories { get; set; }        public DbSet<mf_EmploymentStatu> mf_EmploymentStatus { get; set; }        public DbSet<mf_EmploymentType> mf_EmploymentTypes { get; set; }        public DbSet<mf_Holiday> mf_Holidays { get; set; }        public DbSet<mf_HolidayType> mf_HolidayTypes { get; set; }        public DbSet<mf_Offense> mf_Offenses { get; set; }        public DbSet<mf_PayrollGroup> mf_PayrollGroups { get; set; }        public DbSet<mf_PenaltyType> mf_PenaltyTypes { get; set; }        public DbSet<mf_Position> mf_Positions { get; set; }        public DbSet<mf_WorkDay> mf_WorkDays { get; set; }        public DbSet<pr_Payroll> pr_Payrolls { get; set; }        public DbSet<pr_PayrollEmployee> pr_PayrollEmployees { get; set; }        public DbSet<pr_PayrollEmployeeDeduction> pr_PayrollEmployeeDeductions { get; set; }        public DbSet<pr_PayrollEmployeeEarning> pr_PayrollEmployeeEarnings { get; set; }        public DbSet<sys_Company> sys_Companies { get; set; }        public DbSet<sys_CompanySetting> sys_CompanySettings { get; set; }        public DbSet<sys_EnumReference> sys_EnumReferences { get; set; }        public DbSet<sys_ErrorLog> sys_ErrorLogs { get; set; }        public DbSet<sys_IdentificationDocument> sys_IdentificationDocuments { get; set; }        public DbSet<sys_Location> sys_Locations { get; set; }        public DbSet<sys_Menu> sys_Menus { get; set; }        public DbSet<sys_Permission> sys_Permissions { get; set; }        public DbSet<sys_Role> sys_Roles { get; set; }        public DbSet<sys_RoleMenu> sys_RoleMenus { get; set; }        public DbSet<sys_RolePermission> sys_RolePermissions { get; set; }        public DbSet<sys_Setting> sys_Settings { get; set; }        public DbSet<sys_User> sys_Users { get; set; }        public DbSet<sys_UserRole> sys_UserRoles { get; set; }        public DbSet<sys_UserSession> sys_UserSessions { get; set; }        public DbSet<sysdiagram> sysdiagrams { get; set; }        public DbSet<ta_ApplicationRequest> ta_ApplicationRequests { get; set; }        public DbSet<ta_ApplicationRequestApprover> ta_ApplicationRequestApprovers { get; set; }        public DbSet<ta_ApplicationRequestGatePass> ta_ApplicationRequestGatePasses { get; set; }        public DbSet<ta_ApplicationRequestLeave> ta_ApplicationRequestLeaves { get; set; }        public DbSet<ta_CutOffAttendance> ta_CutOffAttendances { get; set; }        public DbSet<ta_CutOffAttendanceSummary> ta_CutOffAttendanceSummaries { get; set; }        public DbSet<ta_CutOffAttendanceSummaryDetail> ta_CutOffAttendanceSummaryDetails { get; set; }        public DbSet<ta_EmployeeAttendance> ta_EmployeeAttendances { get; set; }
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
            modelBuilder.Configurations.Add(new sysdiagramConfiguration());
            modelBuilder.Configurations.Add(new ta_ApplicationRequestConfiguration());
            modelBuilder.Configurations.Add(new ta_ApplicationRequestApproverConfiguration());
            modelBuilder.Configurations.Add(new ta_ApplicationRequestGatePassConfiguration());
            modelBuilder.Configurations.Add(new ta_ApplicationRequestLeaveConfiguration());
            modelBuilder.Configurations.Add(new ta_CutOffAttendanceConfiguration());
            modelBuilder.Configurations.Add(new ta_CutOffAttendanceSummaryConfiguration());
            modelBuilder.Configurations.Add(new ta_CutOffAttendanceSummaryDetailConfiguration());
            modelBuilder.Configurations.Add(new ta_EmployeeAttendanceConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new mf_AgencyConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_AllowanceConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_ApplicationRequestTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_CountryConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_DeductionConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_DepartmentConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_DepartmentSectionConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_DepartmentSectionRequestApproverConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_EmployeeConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_Employee201Configuration(schema));
            modelBuilder.Configurations.Add(new mf_EmployeeAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_EmployeeAllowanceConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_EmployeeBalanceLeaveConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_EmployeeBasicPayConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_EmployeeDeductionConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_EmployeeEducationConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_EmployeeIdentificationDocumentConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_EmployeeOffenseConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_EmployeeSkillConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_EmployeeTrainingConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_EmployeeWorkDayConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_EmployeeWorkHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_EmploymentStatuConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_EmploymentTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_HolidayConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_HolidayTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_OffenseConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_PayrollGroupConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_PenaltyTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_PositionConfiguration(schema));
            modelBuilder.Configurations.Add(new mf_WorkDayConfiguration(schema));
            modelBuilder.Configurations.Add(new pr_PayrollConfiguration(schema));
            modelBuilder.Configurations.Add(new pr_PayrollEmployeeConfiguration(schema));
            modelBuilder.Configurations.Add(new pr_PayrollEmployeeDeductionConfiguration(schema));
            modelBuilder.Configurations.Add(new pr_PayrollEmployeeEarningConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_CompanyConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_CompanySettingConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_EnumReferenceConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_ErrorLogConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_IdentificationDocumentConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_LocationConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_MenuConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_PermissionConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_RoleConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_RoleMenuConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_RolePermissionConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_SettingConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_UserConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_UserRoleConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_UserSessionConfiguration(schema));
            modelBuilder.Configurations.Add(new sysdiagramConfiguration(schema));
            modelBuilder.Configurations.Add(new ta_ApplicationRequestConfiguration(schema));
            modelBuilder.Configurations.Add(new ta_ApplicationRequestApproverConfiguration(schema));
            modelBuilder.Configurations.Add(new ta_ApplicationRequestGatePassConfiguration(schema));
            modelBuilder.Configurations.Add(new ta_ApplicationRequestLeaveConfiguration(schema));
            modelBuilder.Configurations.Add(new ta_CutOffAttendanceConfiguration(schema));
            modelBuilder.Configurations.Add(new ta_CutOffAttendanceSummaryConfiguration(schema));
            modelBuilder.Configurations.Add(new ta_CutOffAttendanceSummaryDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new ta_EmployeeAttendanceConfiguration(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(DbModelBuilder modelBuilder);
        
        // Stored Procedures
    }

    // ************************************************************************
    // POCO classes

    public partial class mf_Agency: EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_Employee201> mf_Employee201 { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_Agency()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_Employee201 = new List<mf_Employee201>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_Allowance: EntityBaseCompany
    {
        public string code { get; set; }
        public bool isTaxable { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_EmployeeAllowance> mf_EmployeeAllowances { get; set; }
        public virtual ICollection<pr_PayrollEmployeeEarning> pr_PayrollEmployeeEarnings { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_Allowance()
        {
            isTaxable = false;
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_EmployeeAllowances = new List<mf_EmployeeAllowance>();
            pr_PayrollEmployeeEarnings = new List<pr_PayrollEmployeeEarning>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_ApplicationRequestType: EntityBase
    {
        public string code { get; set; }
        public string description { get; set; }
        public bool requiredLeavePoints { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_DepartmentSectionRequestApprover> mf_DepartmentSectionRequestApprovers { get; set; }
        public virtual ICollection<mf_EmployeeBalanceLeave> mf_EmployeeBalanceLeaves { get; set; }
        public virtual ICollection<ta_ApplicationRequest> ta_ApplicationRequests { get; set; }

        public virtual sys_User sys_User { get; set; }
        
        public mf_ApplicationRequestType()
        {
            requiredLeavePoints = false;
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_DepartmentSectionRequestApprovers = new List<mf_DepartmentSectionRequestApprover>();
            mf_EmployeeBalanceLeaves = new List<mf_EmployeeBalanceLeave>();
            ta_ApplicationRequests = new List<ta_ApplicationRequest>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_Country: EntityBase
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_EmployeeAddress> mf_EmployeeAddresses { get; set; }
        public virtual ICollection<sys_Company> sys_Companies { get; set; }

        public virtual sys_User sys_User { get; set; }
        
        public mf_Country()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_EmployeeAddresses = new List<mf_EmployeeAddress>();
            sys_Companies = new List<sys_Company>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_Deduction: EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_EmployeeDeduction> mf_EmployeeDeductions { get; set; }
        public virtual ICollection<pr_PayrollEmployeeDeduction> pr_PayrollEmployeeDeductions { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_Deduction()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_EmployeeDeductions = new List<mf_EmployeeDeduction>();
            pr_PayrollEmployeeDeductions = new List<pr_PayrollEmployeeDeduction>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_Department: EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_DepartmentSection> mf_DepartmentSections { get; set; }
        public virtual ICollection<mf_Employee201> mf_Employee201 { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_Department()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_DepartmentSections = new List<mf_DepartmentSection>();
            mf_Employee201 = new List<mf_Employee201>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_DepartmentSection: EntityBase
    {
        public int departmentId { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_DepartmentSectionRequestApprover> mf_DepartmentSectionRequestApprovers { get; set; }
        public virtual ICollection<mf_Employee201> mf_Employee201 { get; set; }

        public virtual mf_Department mf_Department { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_DepartmentSection()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_DepartmentSectionRequestApprovers = new List<mf_DepartmentSectionRequestApprover>();
            mf_Employee201 = new List<mf_Employee201>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_DepartmentSectionRequestApprover: EntityBase
    {
        public int approverId { get; set; }
        public int departmentSectionId { get; set; }
        public int applicationRequestTypeId { get; set; }
        public int orderNo { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_ApplicationRequestType mf_ApplicationRequestType { get; set; }
        public virtual mf_DepartmentSection mf_DepartmentSection { get; set; }
        public virtual sys_User sys_User_approverId { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }
        
        public mf_DepartmentSectionRequestApprover()
        {
            orderNo = 0;
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_Employee: EntityBaseCompany
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public DateTime? birthDate { get; set; }
        public string email { get; set; }
        public int? gender { get; set; }
        public int? maritalStatus { get; set; }
        public string contact1 { get; set; }
        public string contact2 { get; set; }
        public string contact3 { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }
        public int? employeeAddressId { get; set; }
        public int? employee201Id { get; set; }
        public string pictureExtension { get; set; }

        public virtual ICollection<mf_EmployeeAllowance> mf_EmployeeAllowances { get; set; }
        public virtual ICollection<mf_EmployeeBalanceLeave> mf_EmployeeBalanceLeaves { get; set; }
        public virtual ICollection<mf_EmployeeBasicPay> mf_EmployeeBasicPays { get; set; }
        public virtual ICollection<mf_EmployeeDeduction> mf_EmployeeDeductions { get; set; }
        public virtual ICollection<mf_EmployeeEducation> mf_EmployeeEducations { get; set; }
        public virtual ICollection<mf_EmployeeIdentificationDocument> mf_EmployeeIdentificationDocuments { get; set; }
        public virtual ICollection<mf_EmployeeOffense> mf_EmployeeOffenses { get; set; }
        public virtual ICollection<mf_EmployeeSkill> mf_EmployeeSkills { get; set; }
        public virtual ICollection<mf_EmployeeTraining> mf_EmployeeTrainings { get; set; }
        public virtual ICollection<mf_EmployeeWorkDay> mf_EmployeeWorkDays { get; set; }
        public virtual ICollection<mf_EmployeeWorkHistory> mf_EmployeeWorkHistories { get; set; }
        public virtual ICollection<pr_PayrollEmployee> pr_PayrollEmployees { get; set; }
        public virtual ICollection<sys_User> sys_Users { get; set; }
        public virtual ICollection<ta_CutOffAttendanceSummary> ta_CutOffAttendanceSummaries { get; set; }
        public virtual ICollection<ta_EmployeeAttendance> ta_EmployeeAttendances { get; set; }

        public virtual mf_Employee201 mf_Employee201 { get; set; }
        public virtual mf_EmployeeAddress mf_EmployeeAddress { get; set; }
        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_Employee()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_EmployeeAllowances = new List<mf_EmployeeAllowance>();
            mf_EmployeeBalanceLeaves = new List<mf_EmployeeBalanceLeave>();
            mf_EmployeeBasicPays = new List<mf_EmployeeBasicPay>();
            mf_EmployeeDeductions = new List<mf_EmployeeDeduction>();
            mf_EmployeeEducations = new List<mf_EmployeeEducation>();
            mf_EmployeeIdentificationDocuments = new List<mf_EmployeeIdentificationDocument>();
            mf_EmployeeOffenses = new List<mf_EmployeeOffense>();
            mf_EmployeeSkills = new List<mf_EmployeeSkill>();
            mf_EmployeeTrainings = new List<mf_EmployeeTraining>();
            mf_EmployeeWorkDays = new List<mf_EmployeeWorkDay>();
            mf_EmployeeWorkHistories = new List<mf_EmployeeWorkHistory>();
            pr_PayrollEmployees = new List<pr_PayrollEmployee>();
            sys_Users = new List<sys_User>();
            ta_CutOffAttendanceSummaries = new List<ta_CutOffAttendanceSummary>();
            ta_EmployeeAttendances = new List<ta_EmployeeAttendance>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_Employee201: EntityBase
    {
        public string employeeCode { get; set; }
        public int? departmentId { get; set; }
        public int? departmentSectionId { get; set; }
        public int? positionId { get; set; }
        public string email { get; set; }
        public int? employmentTypeId { get; set; }
        public int? employmentStatusId { get; set; }
        public int? positionLevel { get; set; }
        public DateTime? dateHired { get; set; }
        public DateTime? resignedDate { get; set; }
        public int? taxStatus { get; set; }
        public bool? timeSheetRequired { get; set; }
        public bool? entitledUnworkRegularHoliday { get; set; }
        public bool? entitledUnworkSpecialHoliday { get; set; }
        public bool? entitledOvertime { get; set; }
        public bool? entitledHolidayPay { get; set; }
        public int? payrollGroupId { get; set; }
        public int? agencyId { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }
        public bool confidential { get; set; }

        public virtual ICollection<mf_Employee> mf_Employees { get; set; }

        public virtual mf_Agency mf_Agency { get; set; }
        public virtual mf_Department mf_Department { get; set; }
        public virtual mf_DepartmentSection mf_DepartmentSection { get; set; }
        public virtual mf_EmploymentStatu mf_EmploymentStatu { get; set; }
        public virtual mf_EmploymentType mf_EmploymentType { get; set; }
        public virtual mf_PayrollGroup mf_PayrollGroup { get; set; }
        public virtual mf_Position mf_Position { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_Employee201()
        {
            timeSheetRequired = true;
            entitledUnworkRegularHoliday = true;
            entitledUnworkSpecialHoliday = true;
            updatedDate = System.DateTime.Now;
            deleted = false;
            confidential = false;
            mf_Employees = new List<mf_Employee>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_EmployeeAddress: EntityBase
    {
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public int countryId { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_Employee> mf_Employees { get; set; }

        public virtual mf_Country mf_Country { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_EmployeeAddress()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_Employees = new List<mf_Employee>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_EmployeeAllowance: EntityBase
    {
        public int employeeId { get; set; }
        public int allowanceId { get; set; }
        public double? amount { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Allowance mf_Allowance { get; set; }
        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_EmployeeAllowance()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_EmployeeBalanceLeave: EntityBase
    {
        public int employeeId { get; set; }
        public double balance { get; set; }
        public int applicationRequestTypeId { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_ApplicationRequestType mf_ApplicationRequestType { get; set; }
        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_EmployeeBalanceLeave()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_EmployeeBasicPay: EntityBase
    {
        public int employeeId { get; set; }
        public double basicPay { get; set; }
        public int rateType { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_EmployeeBasicPay()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_EmployeeDeduction: EntityBase
    {
        public int employeeId { get; set; }
        public int deductionId { get; set; }
        public double? amount { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Deduction mf_Deduction { get; set; }
        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_EmployeeDeduction()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_EmployeeEducation: EntityBase
    {
        public int employeeId { get; set; }
        public string schoolName { get; set; }
        public int? fromYear { get; set; }
        public int? toYear { get; set; }
        public bool? isGraduated { get; set; }
        public string course { get; set; }
        public int createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_EmployeeEducation()
        {
            createdDate = System.DateTime.Now;
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_EmployeeIdentificationDocument: EntityBase
    {
        public int employeeId { get; set; }
        public int identificationDocumentId { get; set; }
        public string idNumber { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_IdentificationDocument sys_IdentificationDocument { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_EmployeeIdentificationDocument()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_EmployeeOffense: EntityBase
    {
        public int employeeId { get; set; }
        public int offenseId { get; set; }
        public DateTime offenseDate { get; set; }
        public DateTime? memoDate { get; set; }
        public int penaltyTypeId { get; set; }
        public int frequency { get; set; }
        public int degree { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public string remarks { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual mf_Offense mf_Offense { get; set; }
        public virtual mf_PenaltyType mf_PenaltyType { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_EmployeeOffense()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_EmployeeSkill: EntityBase
    {
        public int employeeId { get; set; }
        public string skillName { get; set; }
        public int? skillProficiencyLevel { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_EmployeeSkill()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_EmployeeTraining: EntityBase
    {
        public int employeeId { get; set; }
        public DateTime trainingDate { get; set; }
        public string trainingName { get; set; }
        public string description { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_EmployeeTraining()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_EmployeeWorkDay: EntityBase
    {
        public int employeeId { get; set; }
        public int workDayId { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual mf_WorkDay mf_WorkDay { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_EmployeeWorkDay()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_EmployeeWorkHistory: EntityBase
    {
        public int employeeId { get; set; }
        public string companyName { get; set; }
        public string position { get; set; }
        public int joinedMonth { get; set; }
        public int joinedYear { get; set; }
        public int? resignedMonth { get; set; }
        public int? resignedYear { get; set; }
        public bool? isPresent { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_EmployeeWorkHistory()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_EmploymentStatu: EntityBase
    {
        public string code { get; set; }
        public string description { get; set; }
        public bool allowProcessPayroll { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_Employee201> mf_Employee201 { get; set; }

        public virtual sys_User sys_User { get; set; }
        
        public mf_EmploymentStatu()
        {
            allowProcessPayroll = false;
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_Employee201 = new List<mf_Employee201>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_EmploymentType: EntityBase
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_Employee201> mf_Employee201 { get; set; }

        public virtual sys_User sys_User { get; set; }
        
        public mf_EmploymentType()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_Employee201 = new List<mf_Employee201>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_Holiday: EntityBase
    {
        public DateTime holidayDate { get; set; }
        public string description { get; set; }
        public int holidayTypeId { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_HolidayType mf_HolidayType { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_Holiday()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_HolidayType: EntityBase
    {
        public string code { get; set; }
        public string description { get; set; }
        public double rateNotWork { get; set; }
        public double rateWork { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_Holiday> mf_Holidays { get; set; }
        public virtual ICollection<ta_CutOffAttendanceSummaryDetail> ta_CutOffAttendanceSummaryDetails { get; set; }

        public virtual sys_User sys_User { get; set; }
        
        public mf_HolidayType()
        {
            rateNotWork = 0;
            rateWork = 0;
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_Holidays = new List<mf_Holiday>();
            ta_CutOffAttendanceSummaryDetails = new List<ta_CutOffAttendanceSummaryDetail>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_Offense: EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_EmployeeOffense> mf_EmployeeOffenses { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_Offense()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_EmployeeOffenses = new List<mf_EmployeeOffense>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_PayrollGroup: EntityBase
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_Employee201> mf_Employee201 { get; set; }
        public virtual ICollection<ta_CutOffAttendance> ta_CutOffAttendances { get; set; }

        public virtual sys_User sys_User { get; set; }
        
        public mf_PayrollGroup()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_Employee201 = new List<mf_Employee201>();
            ta_CutOffAttendances = new List<ta_CutOffAttendance>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_PenaltyType: EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_EmployeeOffense> mf_EmployeeOffenses { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_PenaltyType()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_EmployeeOffenses = new List<mf_EmployeeOffense>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_Position: EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_Employee201> mf_Employee201 { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_Position()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_Employee201 = new List<mf_Employee201>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class mf_WorkDay: EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public bool monday { get; set; }
        public bool tuesday { get; set; }
        public bool wednesday { get; set; }
        public bool thursday { get; set; }
        public bool friday { get; set; }
        public bool saturday { get; set; }
        public bool sunday { get; set; }
        public int fromTimeHour { get; set; }
        public int fromTimeMinute { get; set; }
        public int toTimeHour { get; set; }
        public int toTimeMinute { get; set; }
        public double breakHours { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_EmployeeWorkDay> mf_EmployeeWorkDays { get; set; }
        public virtual ICollection<ta_EmployeeAttendance> ta_EmployeeAttendances { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public mf_WorkDay()
        {
            monday = false;
            tuesday = false;
            wednesday = false;
            thursday = false;
            friday = false;
            saturday = false;
            sunday = false;
            fromTimeHour = 0;
            fromTimeMinute = 0;
            toTimeHour = 0;
            toTimeMinute = 0;
            breakHours = 0;
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_EmployeeWorkDays = new List<mf_EmployeeWorkDay>();
            ta_EmployeeAttendances = new List<ta_EmployeeAttendance>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class pr_Payroll: EntityBaseCompany
    {
        public int cutOffAttendanceId { get; set; }
        public int status { get; set; }
        public bool includeLegalDeduction { get; set; }
        public int generatedBy { get; set; }
        public DateTime generatedDate { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<pr_PayrollEmployee> pr_PayrollEmployees { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User_generatedBy { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }
        public virtual ta_CutOffAttendance ta_CutOffAttendance { get; set; }
        
        public pr_Payroll()
        {
            generatedDate = System.DateTime.Now;
            updatedDate = System.DateTime.Now;
            deleted = false;
            pr_PayrollEmployees = new List<pr_PayrollEmployee>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class pr_PayrollEmployee: EntityBase
    {
        public int payrollId { get; set; }
        public int employeeId { get; set; }
        public double noOfDays { get; set; }
        public double totalHours { get; set; }
        public double hourlyRates { get; set; }
        public int payRateType { get; set; }
        public double basicRate { get; set; }
        public double totalDeduction { get; set; }
        public double totalIncome { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<pr_PayrollEmployeeDeduction> pr_PayrollEmployeeDeductions { get; set; }
        public virtual ICollection<pr_PayrollEmployeeEarning> pr_PayrollEmployeeEarnings { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual pr_Payroll pr_Payroll { get; set; }
        
        public pr_PayrollEmployee()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            pr_PayrollEmployeeDeductions = new List<pr_PayrollEmployeeDeduction>();
            pr_PayrollEmployeeEarnings = new List<pr_PayrollEmployeeEarning>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class pr_PayrollEmployeeDeduction: EntityBase
    {
        public int payrollEmployeeId { get; set; }
        public int? deductionId { get; set; }
        public int? paySlipDetail { get; set; }
        public double value { get; set; }

        public virtual mf_Deduction mf_Deduction { get; set; }
        public virtual pr_PayrollEmployee pr_PayrollEmployee { get; set; }
        
        public pr_PayrollEmployeeDeduction()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class pr_PayrollEmployeeEarning: EntityBase
    {
        public int payrollEmployeeId { get; set; }
        public int? allowanceId { get; set; }
        public int? paySlipDetail { get; set; }
        public double value { get; set; }

        public virtual mf_Allowance mf_Allowance { get; set; }
        public virtual pr_PayrollEmployee pr_PayrollEmployee { get; set; }
        
        public pr_PayrollEmployeeEarning()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sys_Company: EntityBase
    {
        public string code { get; set; }
        public string businessName { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public int countryId { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public string mobile { get; set; }
        public string fax { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_Agency> mf_Agencies { get; set; }
        public virtual ICollection<mf_Allowance> mf_Allowances { get; set; }
        public virtual ICollection<mf_Deduction> mf_Deductions { get; set; }
        public virtual ICollection<mf_Department> mf_Departments { get; set; }
        public virtual ICollection<mf_Employee> mf_Employees { get; set; }
        public virtual ICollection<mf_Offense> mf_Offenses { get; set; }
        public virtual ICollection<mf_PenaltyType> mf_PenaltyTypes { get; set; }
        public virtual ICollection<mf_Position> mf_Positions { get; set; }
        public virtual ICollection<mf_WorkDay> mf_WorkDays { get; set; }
        public virtual ICollection<pr_Payroll> pr_Payrolls { get; set; }
        public virtual ICollection<sys_CompanySetting> sys_CompanySettings { get; set; }
        public virtual ICollection<sys_EnumReference> sys_EnumReferences { get; set; }
        public virtual ICollection<sys_Location> sys_Locations { get; set; }
        public virtual ICollection<sys_Permission> sys_Permissions { get; set; }
        public virtual ICollection<sys_Role> sys_Roles { get; set; }
        public virtual ICollection<sys_User> sys_Users { get; set; }
        public virtual ICollection<sys_UserSession> sys_UserSessions { get; set; }
        public virtual ICollection<ta_CutOffAttendance> ta_CutOffAttendances { get; set; }

        public virtual mf_Country mf_Country { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public sys_Company()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_Agencies = new List<mf_Agency>();
            mf_Allowances = new List<mf_Allowance>();
            mf_Deductions = new List<mf_Deduction>();
            mf_Departments = new List<mf_Department>();
            mf_Employees = new List<mf_Employee>();
            mf_Offenses = new List<mf_Offense>();
            mf_PenaltyTypes = new List<mf_PenaltyType>();
            mf_Positions = new List<mf_Position>();
            mf_WorkDays = new List<mf_WorkDay>();
            pr_Payrolls = new List<pr_Payroll>();
            sys_CompanySettings = new List<sys_CompanySetting>();
            sys_EnumReferences = new List<sys_EnumReference>();
            sys_Locations = new List<sys_Location>();
            sys_Permissions = new List<sys_Permission>();
            sys_Roles = new List<sys_Role>();
            sys_Users = new List<sys_User>();
            sys_UserSessions = new List<sys_UserSession>();
            ta_CutOffAttendances = new List<ta_CutOffAttendance>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sys_CompanySetting: EntityBase
    {
        public int settingId { get; set; }
        public int? companyId { get; set; }
        public string value { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_Setting sys_Setting { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public sys_CompanySetting()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sys_EnumReference: EntityBaseCompany
    {
        public string name { get; set; }
        public int value { get; set; }
        public string description { get; set; }
        public int displayOrder { get; set; }
        public bool hidden { get; set; }
        public string field1 { get; set; }
        public string field2 { get; set; }
        public string field3 { get; set; }
        public string field4 { get; set; }
        public string field5 { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        
        public sys_EnumReference()
        {
            displayOrder = 0;
            hidden = false;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sys_ErrorLog: EntityBase
    {
        public string message { get; set; }
        public string innerException { get; set; }
        public int loggedType { get; set; }
        public string controllerName { get; set; }
        public string actionName { get; set; }
        public string areaName { get; set; }
        public int? createdBy { get; set; }
        public DateTime createdDate { get; set; }

        public virtual sys_User sys_User { get; set; }
        
        public sys_ErrorLog()
        {
            createdDate = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sys_IdentificationDocument: EntityBase
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_EmployeeIdentificationDocument> mf_EmployeeIdentificationDocuments { get; set; }

        public virtual sys_User sys_User { get; set; }
        
        public sys_IdentificationDocument()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_EmployeeIdentificationDocuments = new List<mf_EmployeeIdentificationDocument>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sys_Location: EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public sys_Location()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sys_Menu: EntityBase
    {
        public string description { get; set; }
        public string controllerName { get; set; }
        public string actionName { get; set; }
        public string areaName { get; set; }
        public string parameter { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<sys_RoleMenu> sys_RoleMenus { get; set; }

        public virtual sys_User sys_User { get; set; }
        
        public sys_Menu()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            sys_RoleMenus = new List<sys_RoleMenu>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sys_Permission: EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<sys_RolePermission> sys_RolePermissions { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public sys_Permission()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            sys_RolePermissions = new List<sys_RolePermission>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sys_Role: EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<sys_RoleMenu> sys_RoleMenus { get; set; }
        public virtual ICollection<sys_RolePermission> sys_RolePermissions { get; set; }
        public virtual ICollection<sys_UserRole> sys_UserRoles { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public sys_Role()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            sys_RoleMenus = new List<sys_RoleMenu>();
            sys_RolePermissions = new List<sys_RolePermission>();
            sys_UserRoles = new List<sys_UserRole>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sys_RoleMenu: EntityBase
    {
        public int roleId { get; set; }
        public int sourceMenuId { get; set; }
        public string description { get; set; }
        public int? parentRoleMenuId { get; set; }
        public int displayOrder { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<sys_RoleMenu> sys_RoleMenus { get; set; }

        public virtual sys_Menu sys_Menu { get; set; }
        public virtual sys_Role sys_Role { get; set; }
        public virtual sys_RoleMenu sys_RoleMenu_parentRoleMenuId { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public sys_RoleMenu()
        {
            displayOrder = 0;
            updatedDate = System.DateTime.Now;
            deleted = false;
            sys_RoleMenus = new List<sys_RoleMenu>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sys_RolePermission: EntityBase
    {
        public int roleId { get; set; }
        public int permissionId { get; set; }
        public bool viewAccess { get; set; }
        public bool createAccess { get; set; }
        public bool updateAccess { get; set; }
        public bool deleteAccess { get; set; }
        public bool printAccess { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual sys_Permission sys_Permission { get; set; }
        public virtual sys_Role sys_Role { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public sys_RolePermission()
        {
            viewAccess = false;
            createAccess = false;
            updateAccess = false;
            deleteAccess = false;
            printAccess = false;
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sys_Setting: EntityBase
    {
        public string name { get; set; }
        public string description { get; set; }

        public virtual ICollection<sys_CompanySetting> sys_CompanySettings { get; set; }
        
        public sys_Setting()
        {
            deleted = false;
            sys_CompanySettings = new List<sys_CompanySetting>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sys_User: EntityBaseCompany
    {
        public string username { get; set; }
        public string password { get; set; }
        public string hashKey { get; set; }
        public string vector { get; set; }
        public string email { get; set; }
        public int? employeeId { get; set; }
        public int status { get; set; }
        public int? updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_Agency> mf_Agencies { get; set; }
        public virtual ICollection<mf_Allowance> mf_Allowances { get; set; }
        public virtual ICollection<mf_ApplicationRequestType> mf_ApplicationRequestTypes { get; set; }
        public virtual ICollection<mf_Country> mf_Countries { get; set; }
        public virtual ICollection<mf_Deduction> mf_Deductions { get; set; }
        public virtual ICollection<mf_Department> mf_Departments { get; set; }
        public virtual ICollection<mf_DepartmentSection> mf_DepartmentSections { get; set; }
        public virtual ICollection<mf_DepartmentSectionRequestApprover> mf_DepartmentSectionRequestApprovers_approverId { get; set; }
        public virtual ICollection<mf_DepartmentSectionRequestApprover> mf_DepartmentSectionRequestApprovers_updatedBy { get; set; }
        public virtual ICollection<mf_Employee> mf_Employees { get; set; }
        public virtual ICollection<mf_Employee201> mf_Employee201 { get; set; }
        public virtual ICollection<mf_EmployeeAddress> mf_EmployeeAddresses { get; set; }
        public virtual ICollection<mf_EmployeeAllowance> mf_EmployeeAllowances { get; set; }
        public virtual ICollection<mf_EmployeeBalanceLeave> mf_EmployeeBalanceLeaves { get; set; }
        public virtual ICollection<mf_EmployeeBasicPay> mf_EmployeeBasicPays { get; set; }
        public virtual ICollection<mf_EmployeeDeduction> mf_EmployeeDeductions { get; set; }
        public virtual ICollection<mf_EmployeeEducation> mf_EmployeeEducations { get; set; }
        public virtual ICollection<mf_EmployeeIdentificationDocument> mf_EmployeeIdentificationDocuments { get; set; }
        public virtual ICollection<mf_EmployeeOffense> mf_EmployeeOffenses { get; set; }
        public virtual ICollection<mf_EmployeeSkill> mf_EmployeeSkills { get; set; }
        public virtual ICollection<mf_EmployeeTraining> mf_EmployeeTrainings { get; set; }
        public virtual ICollection<mf_EmployeeWorkDay> mf_EmployeeWorkDays { get; set; }
        public virtual ICollection<mf_EmployeeWorkHistory> mf_EmployeeWorkHistories { get; set; }
        public virtual ICollection<mf_EmploymentStatu> mf_EmploymentStatus { get; set; }
        public virtual ICollection<mf_EmploymentType> mf_EmploymentTypes { get; set; }
        public virtual ICollection<mf_Holiday> mf_Holidays { get; set; }
        public virtual ICollection<mf_HolidayType> mf_HolidayTypes { get; set; }
        public virtual ICollection<mf_Offense> mf_Offenses { get; set; }
        public virtual ICollection<mf_PayrollGroup> mf_PayrollGroups { get; set; }
        public virtual ICollection<mf_PenaltyType> mf_PenaltyTypes { get; set; }
        public virtual ICollection<mf_Position> mf_Positions { get; set; }
        public virtual ICollection<mf_WorkDay> mf_WorkDays { get; set; }
        public virtual ICollection<pr_Payroll> pr_Payrolls_generatedBy { get; set; }
        public virtual ICollection<pr_Payroll> pr_Payrolls_updatedBy { get; set; }
        public virtual ICollection<sys_Company> sys_Companies { get; set; }
        public virtual ICollection<sys_CompanySetting> sys_CompanySettings { get; set; }
        public virtual ICollection<sys_ErrorLog> sys_ErrorLogs { get; set; }
        public virtual ICollection<sys_IdentificationDocument> sys_IdentificationDocuments { get; set; }
        public virtual ICollection<sys_Location> sys_Locations { get; set; }
        public virtual ICollection<sys_Menu> sys_Menus { get; set; }
        public virtual ICollection<sys_Permission> sys_Permissions { get; set; }
        public virtual ICollection<sys_Role> sys_Roles { get; set; }
        public virtual ICollection<sys_RoleMenu> sys_RoleMenus { get; set; }
        public virtual ICollection<sys_RolePermission> sys_RolePermissions { get; set; }
        public virtual ICollection<sys_User> sys_Users { get; set; }
        public virtual ICollection<sys_UserRole> sys_UserRoles_updatedBy { get; set; }
        public virtual ICollection<sys_UserRole> sys_UserRoles_userId { get; set; }
        public virtual ICollection<sys_UserSession> sys_UserSessions { get; set; }
        public virtual ICollection<ta_ApplicationRequest> ta_ApplicationRequests_assignTo { get; set; }
        public virtual ICollection<ta_ApplicationRequest> ta_ApplicationRequests_requestedBy { get; set; }
        public virtual ICollection<ta_ApplicationRequest> ta_ApplicationRequests_updatedBy { get; set; }
        public virtual ICollection<ta_ApplicationRequestApprover> ta_ApplicationRequestApprovers_approverId { get; set; }
        public virtual ICollection<ta_ApplicationRequestApprover> ta_ApplicationRequestApprovers_updatedBy { get; set; }
        public virtual ICollection<ta_CutOffAttendance> ta_CutOffAttendances_changeStatusBy { get; set; }
        public virtual ICollection<ta_CutOffAttendance> ta_CutOffAttendances_updatedBy { get; set; }
        public virtual ICollection<ta_CutOffAttendanceSummary> ta_CutOffAttendanceSummaries { get; set; }
        public virtual ICollection<ta_CutOffAttendanceSummaryDetail> ta_CutOffAttendanceSummaryDetails { get; set; }
        public virtual ICollection<ta_EmployeeAttendance> ta_EmployeeAttendances { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }
        
        public sys_User()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_Agencies = new List<mf_Agency>();
            mf_Allowances = new List<mf_Allowance>();
            mf_ApplicationRequestTypes = new List<mf_ApplicationRequestType>();
            mf_Countries = new List<mf_Country>();
            mf_Deductions = new List<mf_Deduction>();
            mf_Departments = new List<mf_Department>();
            mf_DepartmentSections = new List<mf_DepartmentSection>();
            mf_DepartmentSectionRequestApprovers_approverId = new List<mf_DepartmentSectionRequestApprover>();
            mf_DepartmentSectionRequestApprovers_updatedBy = new List<mf_DepartmentSectionRequestApprover>();
            mf_Employees = new List<mf_Employee>();
            mf_Employee201 = new List<mf_Employee201>();
            mf_EmployeeAddresses = new List<mf_EmployeeAddress>();
            mf_EmployeeAllowances = new List<mf_EmployeeAllowance>();
            mf_EmployeeBalanceLeaves = new List<mf_EmployeeBalanceLeave>();
            mf_EmployeeBasicPays = new List<mf_EmployeeBasicPay>();
            mf_EmployeeDeductions = new List<mf_EmployeeDeduction>();
            mf_EmployeeEducations = new List<mf_EmployeeEducation>();
            mf_EmployeeIdentificationDocuments = new List<mf_EmployeeIdentificationDocument>();
            mf_EmployeeOffenses = new List<mf_EmployeeOffense>();
            mf_EmployeeSkills = new List<mf_EmployeeSkill>();
            mf_EmployeeTrainings = new List<mf_EmployeeTraining>();
            mf_EmployeeWorkDays = new List<mf_EmployeeWorkDay>();
            mf_EmployeeWorkHistories = new List<mf_EmployeeWorkHistory>();
            mf_EmploymentStatus = new List<mf_EmploymentStatu>();
            mf_EmploymentTypes = new List<mf_EmploymentType>();
            mf_Holidays = new List<mf_Holiday>();
            mf_HolidayTypes = new List<mf_HolidayType>();
            mf_Offenses = new List<mf_Offense>();
            mf_PayrollGroups = new List<mf_PayrollGroup>();
            mf_PenaltyTypes = new List<mf_PenaltyType>();
            mf_Positions = new List<mf_Position>();
            mf_WorkDays = new List<mf_WorkDay>();
            pr_Payrolls_generatedBy = new List<pr_Payroll>();
            pr_Payrolls_updatedBy = new List<pr_Payroll>();
            sys_Companies = new List<sys_Company>();
            sys_CompanySettings = new List<sys_CompanySetting>();
            sys_ErrorLogs = new List<sys_ErrorLog>();
            sys_IdentificationDocuments = new List<sys_IdentificationDocument>();
            sys_Locations = new List<sys_Location>();
            sys_Menus = new List<sys_Menu>();
            sys_Permissions = new List<sys_Permission>();
            sys_Roles = new List<sys_Role>();
            sys_RoleMenus = new List<sys_RoleMenu>();
            sys_RolePermissions = new List<sys_RolePermission>();
            sys_Users = new List<sys_User>();
            sys_UserRoles_updatedBy = new List<sys_UserRole>();
            sys_UserRoles_userId = new List<sys_UserRole>();
            sys_UserSessions = new List<sys_UserSession>();
            ta_ApplicationRequests_assignTo = new List<ta_ApplicationRequest>();
            ta_ApplicationRequests_requestedBy = new List<ta_ApplicationRequest>();
            ta_ApplicationRequests_updatedBy = new List<ta_ApplicationRequest>();
            ta_ApplicationRequestApprovers_approverId = new List<ta_ApplicationRequestApprover>();
            ta_ApplicationRequestApprovers_updatedBy = new List<ta_ApplicationRequestApprover>();
            ta_CutOffAttendances_changeStatusBy = new List<ta_CutOffAttendance>();
            ta_CutOffAttendances_updatedBy = new List<ta_CutOffAttendance>();
            ta_CutOffAttendanceSummaries = new List<ta_CutOffAttendanceSummary>();
            ta_CutOffAttendanceSummaryDetails = new List<ta_CutOffAttendanceSummaryDetail>();
            ta_EmployeeAttendances = new List<ta_EmployeeAttendance>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sys_UserRole: EntityBase
    {
        public int roleId { get; set; }
        public int userId { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual sys_Role sys_Role { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }
        public virtual sys_User sys_User_userId { get; set; }
        
        public sys_UserRole()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sys_UserSession: EntityBaseCompany
    {
        public int userId { get; set; }
        public DateTime loggedDate { get; set; }
        public string ipAddress { get; set; }
        public DateTime expiredDate { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public sys_UserSession()
        {
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class sysdiagram: EntityBase
    {
        public string name { get; set; }
        public int principal_id { get; set; }
        public int diagram_id { get; set; }
        public int? version { get; set; }
        public byte[] definition { get; set; }
        
        public sysdiagram()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class ta_ApplicationRequest: EntityBase
    {
        public int applicationRequestTypeId { get; set; }
        public string note { get; set; }
        public int status { get; set; }
        public int assignTo { get; set; }
        public int requestedBy { get; set; }
        public DateTime requestedDate { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<ta_ApplicationRequestApprover> ta_ApplicationRequestApprovers { get; set; }
        public virtual ICollection<ta_ApplicationRequestGatePass> ta_ApplicationRequestGatePasses { get; set; }
        public virtual ICollection<ta_ApplicationRequestLeave> ta_ApplicationRequestLeaves { get; set; }

        public virtual mf_ApplicationRequestType mf_ApplicationRequestType { get; set; }
        public virtual sys_User sys_User_assignTo { get; set; }
        public virtual sys_User sys_User_requestedBy { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }
        
        public ta_ApplicationRequest()
        {
            requestedDate = System.DateTime.Now;
            updatedDate = System.DateTime.Now;
            deleted = false;
            ta_ApplicationRequestApprovers = new List<ta_ApplicationRequestApprover>();
            ta_ApplicationRequestGatePasses = new List<ta_ApplicationRequestGatePass>();
            ta_ApplicationRequestLeaves = new List<ta_ApplicationRequestLeave>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class ta_ApplicationRequestApprover: EntityBase
    {
        public int applicationRequestId { get; set; }
        public int approverId { get; set; }
        public int status { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual sys_User sys_User_approverId { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }
        public virtual ta_ApplicationRequest ta_ApplicationRequest { get; set; }
        
        public ta_ApplicationRequestApprover()
        {
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class ta_ApplicationRequestGatePass: EntityBase
    {
        public int applicationRequestId { get; set; }
        public DateTime startDateTime { get; set; }
        public DateTime endDateTime { get; set; }

        public virtual ta_ApplicationRequest ta_ApplicationRequest { get; set; }
        
        public ta_ApplicationRequestGatePass()
        {
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class ta_ApplicationRequestLeave: EntityBase
    {
        public int applicationRequestId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public virtual ta_ApplicationRequest ta_ApplicationRequest { get; set; }
        
        public ta_ApplicationRequestLeave()
        {
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class ta_CutOffAttendance: EntityBaseCompany
    {
        public int payrollGroupId { get; set; }
        public DateTime generatedDate { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int status { get; set; }
        public string remarks { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }
        public int changeStatusBy { get; set; }
        public DateTime changeStatusDate { get; set; }

        public virtual ICollection<pr_Payroll> pr_Payrolls { get; set; }
        public virtual ICollection<ta_CutOffAttendanceSummary> ta_CutOffAttendanceSummaries { get; set; }

        public virtual mf_PayrollGroup mf_PayrollGroup { get; set; }
        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User_changeStatusBy { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }
        
        public ta_CutOffAttendance()
        {
            generatedDate = System.DateTime.Now;
            updatedDate = System.DateTime.Now;
            changeStatusDate = System.DateTime.Now;
            deleted = false;
            pr_Payrolls = new List<pr_Payroll>();
            ta_CutOffAttendanceSummaries = new List<ta_CutOffAttendanceSummary>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class ta_CutOffAttendanceSummary: EntityBase
    {
        public int cutOffAttendanceId { get; set; }
        public int employeeId { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<ta_CutOffAttendanceSummaryDetail> ta_CutOffAttendanceSummaryDetails { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User { get; set; }
        public virtual ta_CutOffAttendance ta_CutOffAttendance { get; set; }
        
        public ta_CutOffAttendanceSummary()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            ta_CutOffAttendanceSummaryDetails = new List<ta_CutOffAttendanceSummaryDetail>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class ta_CutOffAttendanceSummaryDetail: EntityBase
    {
        public int cutOffAttendanceSummaryId { get; set; }
        public DateTime workDate { get; set; }
        public double workHours { get; set; }
        public double undertimeHours { get; set; }
        public double lateHours { get; set; }
        public double overtimeHours { get; set; }
        public double? workHolidayHours { get; set; }
        public int? holidayTypeId { get; set; }
        public bool absent { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_HolidayType mf_HolidayType { get; set; }
        public virtual sys_User sys_User { get; set; }
        public virtual ta_CutOffAttendanceSummary ta_CutOffAttendanceSummary { get; set; }
        
        public ta_CutOffAttendanceSummaryDetail()
        {
            absent = false;
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

    public partial class ta_EmployeeAttendance: EntityBase
    {
        public int employeeId { get; set; }
        public int timeLogType { get; set; }
        public DateTime workDate { get; set; }
        public DateTime timeLog { get; set; }
        public int? workDayId { get; set; }
        public string remarks { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual mf_WorkDay mf_WorkDay { get; set; }
        public virtual sys_User sys_User { get; set; }
        
        public ta_EmployeeAttendance()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }


    // ************************************************************************
    // POCO Configuration

    internal partial class mf_AgencyConfiguration : EntityTypeConfiguration<mf_Agency>
    {
        public mf_AgencyConfiguration()
            : this("dbo")
        {
        }
 
        public mf_AgencyConfiguration(string schema)
        {
            ToTable(schema + ".mf_Agency");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Company).WithMany(b => b.mf_Agencies).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_Agencies).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_AllowanceConfiguration : EntityTypeConfiguration<mf_Allowance>
    {
        public mf_AllowanceConfiguration()
            : this("dbo")
        {
        }
 
        public mf_AllowanceConfiguration(string schema)
        {
            ToTable(schema + ".mf_Allowance");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.isTaxable).HasColumnName("isTaxable").IsRequired().HasColumnType("bit");
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Company).WithMany(b => b.mf_Allowances).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_Allowances).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_ApplicationRequestTypeConfiguration : EntityTypeConfiguration<mf_ApplicationRequestType>
    {
        public mf_ApplicationRequestTypeConfiguration()
            : this("dbo")
        {
        }
 
        public mf_ApplicationRequestTypeConfiguration(string schema)
        {
            ToTable(schema + ".mf_ApplicationRequestType");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.requiredLeavePoints).HasColumnName("requiredLeavePoints").IsRequired().HasColumnType("bit");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_User).WithMany(b => b.mf_ApplicationRequestTypes).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_CountryConfiguration : EntityTypeConfiguration<mf_Country>
    {
        public mf_CountryConfiguration()
            : this("dbo")
        {
        }
 
        public mf_CountryConfiguration(string schema)
        {
            ToTable(schema + ".mf_Country");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_User).WithMany(b => b.mf_Countries).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_DeductionConfiguration : EntityTypeConfiguration<mf_Deduction>
    {
        public mf_DeductionConfiguration()
            : this("dbo")
        {
        }
 
        public mf_DeductionConfiguration(string schema)
        {
            ToTable(schema + ".mf_Deduction");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Company).WithMany(b => b.mf_Deductions).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_Deductions).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_DepartmentConfiguration : EntityTypeConfiguration<mf_Department>
    {
        public mf_DepartmentConfiguration()
            : this("dbo")
        {
        }
 
        public mf_DepartmentConfiguration(string schema)
        {
            ToTable(schema + ".mf_Department");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Company).WithMany(b => b.mf_Departments).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_Departments).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_DepartmentSectionConfiguration : EntityTypeConfiguration<mf_DepartmentSection>
    {
        public mf_DepartmentSectionConfiguration()
            : this("dbo")
        {
        }
 
        public mf_DepartmentSectionConfiguration(string schema)
        {
            ToTable(schema + ".mf_DepartmentSection");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.departmentId).HasColumnName("departmentId").IsRequired().HasColumnType("int");
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Department).WithMany(b => b.mf_DepartmentSections).HasForeignKey(c => c.departmentId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_DepartmentSections).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_DepartmentSectionRequestApproverConfiguration : EntityTypeConfiguration<mf_DepartmentSectionRequestApprover>
    {
        public mf_DepartmentSectionRequestApproverConfiguration()
            : this("dbo")
        {
        }
 
        public mf_DepartmentSectionRequestApproverConfiguration(string schema)
        {
            ToTable(schema + ".mf_DepartmentSectionRequestApprover");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.approverId).HasColumnName("approverId").IsRequired().HasColumnType("int");
            Property(x => x.departmentSectionId).HasColumnName("departmentSectionId").IsRequired().HasColumnType("int");
            Property(x => x.applicationRequestTypeId).HasColumnName("applicationRequestTypeId").IsRequired().HasColumnType("int");
            Property(x => x.orderNo).HasColumnName("orderNo").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_ApplicationRequestType).WithMany(b => b.mf_DepartmentSectionRequestApprovers).HasForeignKey(c => c.applicationRequestTypeId);
            HasRequired(a => a.mf_DepartmentSection).WithMany(b => b.mf_DepartmentSectionRequestApprovers).HasForeignKey(c => c.departmentSectionId);
            HasRequired(a => a.sys_User_approverId).WithMany(b => b.mf_DepartmentSectionRequestApprovers_approverId).HasForeignKey(c => c.approverId);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.mf_DepartmentSectionRequestApprovers_updatedBy).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_EmployeeConfiguration : EntityTypeConfiguration<mf_Employee>
    {
        public mf_EmployeeConfiguration()
            : this("dbo")
        {
        }
 
        public mf_EmployeeConfiguration(string schema)
        {
            ToTable(schema + ".mf_Employee");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.firstName).HasColumnName("firstName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.lastName).HasColumnName("lastName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.middleName).HasColumnName("middleName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.birthDate).HasColumnName("birthDate").IsOptional().HasColumnType("datetime");
            Property(x => x.email).HasColumnName("email").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.gender).HasColumnName("gender").IsOptional().HasColumnType("int");
            Property(x => x.maritalStatus).HasColumnName("maritalStatus").IsOptional().HasColumnType("int");
            Property(x => x.contact1).HasColumnName("contact1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.contact2).HasColumnName("contact2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.contact3).HasColumnName("contact3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");
            Property(x => x.employeeAddressId).HasColumnName("employeeAddressId").IsOptional().HasColumnType("int");
            Property(x => x.employee201Id).HasColumnName("employee201Id").IsOptional().HasColumnType("int");
            Property(x => x.pictureExtension).HasColumnName("pictureExtension").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);

            HasOptional(a => a.mf_Employee201).WithMany(b => b.mf_Employees).HasForeignKey(c => c.employee201Id);
            HasOptional(a => a.mf_EmployeeAddress).WithMany(b => b.mf_Employees).HasForeignKey(c => c.employeeAddressId);
            HasRequired(a => a.sys_Company).WithMany(b => b.mf_Employees).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_Employees).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_Employee201Configuration : EntityTypeConfiguration<mf_Employee201>
    {
        public mf_Employee201Configuration()
            : this("dbo")
        {
        }
 
        public mf_Employee201Configuration(string schema)
        {
            ToTable(schema + ".mf_Employee201");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeCode).HasColumnName("employeeCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.departmentId).HasColumnName("departmentId").IsOptional().HasColumnType("int");
            Property(x => x.departmentSectionId).HasColumnName("departmentSectionId").IsOptional().HasColumnType("int");
            Property(x => x.positionId).HasColumnName("positionId").IsOptional().HasColumnType("int");
            Property(x => x.email).HasColumnName("email").IsOptional().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.employmentTypeId).HasColumnName("employmentTypeId").IsOptional().HasColumnType("int");
            Property(x => x.employmentStatusId).HasColumnName("employmentStatusId").IsOptional().HasColumnType("int");
            Property(x => x.positionLevel).HasColumnName("positionLevel").IsOptional().HasColumnType("int");
            Property(x => x.dateHired).HasColumnName("dateHired").IsOptional().HasColumnType("datetime");
            Property(x => x.resignedDate).HasColumnName("resignedDate").IsOptional().HasColumnType("datetime");
            Property(x => x.taxStatus).HasColumnName("taxStatus").IsOptional().HasColumnType("int");
            Property(x => x.timeSheetRequired).HasColumnName("timeSheetRequired").IsOptional().HasColumnType("bit");
            Property(x => x.entitledUnworkRegularHoliday).HasColumnName("entitledUnworkRegularHoliday").IsOptional().HasColumnType("bit");
            Property(x => x.entitledUnworkSpecialHoliday).HasColumnName("entitledUnworkSpecialHoliday").IsOptional().HasColumnType("bit");
            Property(x => x.entitledOvertime).HasColumnName("entitledOvertime").IsOptional().HasColumnType("bit");
            Property(x => x.entitledHolidayPay).HasColumnName("entitledHolidayPay").IsOptional().HasColumnType("bit");
            Property(x => x.payrollGroupId).HasColumnName("payrollGroupId").IsOptional().HasColumnType("int");
            Property(x => x.agencyId).HasColumnName("agencyId").IsOptional().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");
            Property(x => x.confidential).HasColumnName("confidential").IsRequired().HasColumnType("bit");

            HasOptional(a => a.mf_Agency).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.agencyId);
            HasOptional(a => a.mf_Department).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.departmentId);
            HasOptional(a => a.mf_DepartmentSection).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.departmentSectionId);
            HasOptional(a => a.mf_EmploymentStatu).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.employmentStatusId);
            HasOptional(a => a.mf_EmploymentType).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.employmentTypeId);
            HasOptional(a => a.mf_PayrollGroup).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.payrollGroupId);
            HasOptional(a => a.mf_Position).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.positionId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_EmployeeAddressConfiguration : EntityTypeConfiguration<mf_EmployeeAddress>
    {
        public mf_EmployeeAddressConfiguration()
            : this("dbo")
        {
        }
 
        public mf_EmployeeAddressConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeAddress");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.address1).HasColumnName("address1").IsOptional().HasColumnType("nvarchar");
            Property(x => x.address2).HasColumnName("address2").IsOptional().HasColumnType("nvarchar");
            Property(x => x.address3).HasColumnName("address3").IsOptional().HasColumnType("nvarchar");
            Property(x => x.countryId).HasColumnName("countryId").IsRequired().HasColumnType("int");
            Property(x => x.city).HasColumnName("city").IsOptional().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.postalCode).HasColumnName("postalCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Country).WithMany(b => b.mf_EmployeeAddresses).HasForeignKey(c => c.countryId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeAddresses).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_EmployeeAllowanceConfiguration : EntityTypeConfiguration<mf_EmployeeAllowance>
    {
        public mf_EmployeeAllowanceConfiguration()
            : this("dbo")
        {
        }
 
        public mf_EmployeeAllowanceConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeAllowance");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.allowanceId).HasColumnName("allowanceId").IsRequired().HasColumnType("int");
            Property(x => x.amount).HasColumnName("amount").IsOptional().HasColumnType("float");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Allowance).WithMany(b => b.mf_EmployeeAllowances).HasForeignKey(c => c.allowanceId);
            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeAllowances).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeAllowances).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_EmployeeBalanceLeaveConfiguration : EntityTypeConfiguration<mf_EmployeeBalanceLeave>
    {
        public mf_EmployeeBalanceLeaveConfiguration()
            : this("dbo")
        {
        }
 
        public mf_EmployeeBalanceLeaveConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeBalanceLeave");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.balance).HasColumnName("balance").IsRequired().HasColumnType("float");
            Property(x => x.applicationRequestTypeId).HasColumnName("applicationRequestTypeId").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_ApplicationRequestType).WithMany(b => b.mf_EmployeeBalanceLeaves).HasForeignKey(c => c.applicationRequestTypeId);
            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeBalanceLeaves).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeBalanceLeaves).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_EmployeeBasicPayConfiguration : EntityTypeConfiguration<mf_EmployeeBasicPay>
    {
        public mf_EmployeeBasicPayConfiguration()
            : this("dbo")
        {
        }
 
        public mf_EmployeeBasicPayConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeBasicPay");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.basicPay).HasColumnName("basicPay").IsRequired().HasColumnType("float");
            Property(x => x.rateType).HasColumnName("rateType").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeBasicPays).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeBasicPays).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_EmployeeDeductionConfiguration : EntityTypeConfiguration<mf_EmployeeDeduction>
    {
        public mf_EmployeeDeductionConfiguration()
            : this("dbo")
        {
        }
 
        public mf_EmployeeDeductionConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeDeduction");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.deductionId).HasColumnName("deductionId").IsRequired().HasColumnType("int");
            Property(x => x.amount).HasColumnName("amount").IsOptional().HasColumnType("float");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Deduction).WithMany(b => b.mf_EmployeeDeductions).HasForeignKey(c => c.deductionId);
            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeDeductions).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeDeductions).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_EmployeeEducationConfiguration : EntityTypeConfiguration<mf_EmployeeEducation>
    {
        public mf_EmployeeEducationConfiguration()
            : this("dbo")
        {
        }
 
        public mf_EmployeeEducationConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeEducation");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.schoolName).HasColumnName("schoolName").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.fromYear).HasColumnName("fromYear").IsOptional().HasColumnType("int");
            Property(x => x.toYear).HasColumnName("toYear").IsOptional().HasColumnType("int");
            Property(x => x.isGraduated).HasColumnName("isGraduated").IsOptional().HasColumnType("bit");
            Property(x => x.course).HasColumnName("course").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.createdBy).HasColumnName("createdBy").IsRequired().HasColumnType("int");
            Property(x => x.createdDate).HasColumnName("createdDate").IsRequired().HasColumnType("datetime");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeEducations).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeEducations).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_EmployeeIdentificationDocumentConfiguration : EntityTypeConfiguration<mf_EmployeeIdentificationDocument>
    {
        public mf_EmployeeIdentificationDocumentConfiguration()
            : this("dbo")
        {
        }
 
        public mf_EmployeeIdentificationDocumentConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeIdentificationDocument");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.identificationDocumentId).HasColumnName("identificationDocumentId").IsRequired().HasColumnType("int");
            Property(x => x.idNumber).HasColumnName("idNumber").IsRequired().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeIdentificationDocuments).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_IdentificationDocument).WithMany(b => b.mf_EmployeeIdentificationDocuments).HasForeignKey(c => c.identificationDocumentId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeIdentificationDocuments).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_EmployeeOffenseConfiguration : EntityTypeConfiguration<mf_EmployeeOffense>
    {
        public mf_EmployeeOffenseConfiguration()
            : this("dbo")
        {
        }
 
        public mf_EmployeeOffenseConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeOffense");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.offenseId).HasColumnName("offenseId").IsRequired().HasColumnType("int");
            Property(x => x.offenseDate).HasColumnName("offenseDate").IsRequired().HasColumnType("datetime");
            Property(x => x.memoDate).HasColumnName("memoDate").IsOptional().HasColumnType("datetime");
            Property(x => x.penaltyTypeId).HasColumnName("penaltyTypeId").IsRequired().HasColumnType("int");
            Property(x => x.frequency).HasColumnName("frequency").IsRequired().HasColumnType("int");
            Property(x => x.degree).HasColumnName("degree").IsRequired().HasColumnType("int");
            Property(x => x.startDate).HasColumnName("startDate").IsOptional().HasColumnType("datetime");
            Property(x => x.endDate).HasColumnName("endDate").IsOptional().HasColumnType("datetime");
            Property(x => x.remarks).HasColumnName("remarks").IsRequired().HasColumnType("nvarchar");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeOffenses).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.mf_Offense).WithMany(b => b.mf_EmployeeOffenses).HasForeignKey(c => c.offenseId);
            HasRequired(a => a.mf_PenaltyType).WithMany(b => b.mf_EmployeeOffenses).HasForeignKey(c => c.penaltyTypeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeOffenses).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_EmployeeSkillConfiguration : EntityTypeConfiguration<mf_EmployeeSkill>
    {
        public mf_EmployeeSkillConfiguration()
            : this("dbo")
        {
        }
 
        public mf_EmployeeSkillConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeSkill");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.skillName).HasColumnName("skillName").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.skillProficiencyLevel).HasColumnName("skillProficiencyLevel").IsOptional().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeSkills).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeSkills).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_EmployeeTrainingConfiguration : EntityTypeConfiguration<mf_EmployeeTraining>
    {
        public mf_EmployeeTrainingConfiguration()
            : this("dbo")
        {
        }
 
        public mf_EmployeeTrainingConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeTraining");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.trainingDate).HasColumnName("trainingDate").IsRequired().HasColumnType("datetime");
            Property(x => x.trainingName).HasColumnName("trainingName").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.description).HasColumnName("description").IsOptional().HasColumnType("nvarchar");
            Property(x => x.startDate).HasColumnName("startDate").IsOptional().HasColumnType("datetime");
            Property(x => x.endDate).HasColumnName("endDate").IsOptional().HasColumnType("datetime");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeTrainings).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeTrainings).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_EmployeeWorkDayConfiguration : EntityTypeConfiguration<mf_EmployeeWorkDay>
    {
        public mf_EmployeeWorkDayConfiguration()
            : this("dbo")
        {
        }
 
        public mf_EmployeeWorkDayConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeWorkDays");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.workDayId).HasColumnName("workDayId").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeWorkDays).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.mf_WorkDay).WithMany(b => b.mf_EmployeeWorkDays).HasForeignKey(c => c.workDayId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeWorkDays).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_EmployeeWorkHistoryConfiguration : EntityTypeConfiguration<mf_EmployeeWorkHistory>
    {
        public mf_EmployeeWorkHistoryConfiguration()
            : this("dbo")
        {
        }
 
        public mf_EmployeeWorkHistoryConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeWorkHistory");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.companyName).HasColumnName("companyName").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.position).HasColumnName("position").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.joinedMonth).HasColumnName("joinedMonth").IsRequired().HasColumnType("int");
            Property(x => x.joinedYear).HasColumnName("joinedYear").IsRequired().HasColumnType("int");
            Property(x => x.resignedMonth).HasColumnName("resignedMonth").IsOptional().HasColumnType("int");
            Property(x => x.resignedYear).HasColumnName("resignedYear").IsOptional().HasColumnType("int");
            Property(x => x.isPresent).HasColumnName("isPresent").IsOptional().HasColumnType("bit");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeWorkHistories).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeWorkHistories).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_EmploymentStatuConfiguration : EntityTypeConfiguration<mf_EmploymentStatu>
    {
        public mf_EmploymentStatuConfiguration()
            : this("dbo")
        {
        }
 
        public mf_EmploymentStatuConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmploymentStatus");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.allowProcessPayroll).HasColumnName("allowProcessPayroll").IsRequired().HasColumnType("bit");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmploymentStatus).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_EmploymentTypeConfiguration : EntityTypeConfiguration<mf_EmploymentType>
    {
        public mf_EmploymentTypeConfiguration()
            : this("dbo")
        {
        }
 
        public mf_EmploymentTypeConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmploymentType");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmploymentTypes).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_HolidayConfiguration : EntityTypeConfiguration<mf_Holiday>
    {
        public mf_HolidayConfiguration()
            : this("dbo")
        {
        }
 
        public mf_HolidayConfiguration(string schema)
        {
            ToTable(schema + ".mf_Holidays");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.holidayDate).HasColumnName("holidayDate").IsRequired().HasColumnType("datetime");
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.holidayTypeId).HasColumnName("holidayTypeId").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_HolidayType).WithMany(b => b.mf_Holidays).HasForeignKey(c => c.holidayTypeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_Holidays).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_HolidayTypeConfiguration : EntityTypeConfiguration<mf_HolidayType>
    {
        public mf_HolidayTypeConfiguration()
            : this("dbo")
        {
        }
 
        public mf_HolidayTypeConfiguration(string schema)
        {
            ToTable(schema + ".mf_HolidayType");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.rateNotWork).HasColumnName("rateNotWork").IsRequired().HasColumnType("float");
            Property(x => x.rateWork).HasColumnName("rateWork").IsRequired().HasColumnType("float");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_User).WithMany(b => b.mf_HolidayTypes).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_OffenseConfiguration : EntityTypeConfiguration<mf_Offense>
    {
        public mf_OffenseConfiguration()
            : this("dbo")
        {
        }
 
        public mf_OffenseConfiguration(string schema)
        {
            ToTable(schema + ".mf_Offense");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Company).WithMany(b => b.mf_Offenses).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_Offenses).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_PayrollGroupConfiguration : EntityTypeConfiguration<mf_PayrollGroup>
    {
        public mf_PayrollGroupConfiguration()
            : this("dbo")
        {
        }
 
        public mf_PayrollGroupConfiguration(string schema)
        {
            ToTable(schema + ".mf_PayrollGroup");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_User).WithMany(b => b.mf_PayrollGroups).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_PenaltyTypeConfiguration : EntityTypeConfiguration<mf_PenaltyType>
    {
        public mf_PenaltyTypeConfiguration()
            : this("dbo")
        {
        }
 
        public mf_PenaltyTypeConfiguration(string schema)
        {
            ToTable(schema + ".mf_PenaltyType");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Company).WithMany(b => b.mf_PenaltyTypes).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_PenaltyTypes).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_PositionConfiguration : EntityTypeConfiguration<mf_Position>
    {
        public mf_PositionConfiguration()
            : this("dbo")
        {
        }
 
        public mf_PositionConfiguration(string schema)
        {
            ToTable(schema + ".mf_Position");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Company).WithMany(b => b.mf_Positions).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_Positions).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class mf_WorkDayConfiguration : EntityTypeConfiguration<mf_WorkDay>
    {
        public mf_WorkDayConfiguration()
            : this("dbo")
        {
        }
 
        public mf_WorkDayConfiguration(string schema)
        {
            ToTable(schema + ".mf_WorkDays");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.monday).HasColumnName("monday").IsRequired().HasColumnType("bit");
            Property(x => x.tuesday).HasColumnName("tuesday").IsRequired().HasColumnType("bit");
            Property(x => x.wednesday).HasColumnName("wednesday").IsRequired().HasColumnType("bit");
            Property(x => x.thursday).HasColumnName("thursday").IsRequired().HasColumnType("bit");
            Property(x => x.friday).HasColumnName("friday").IsRequired().HasColumnType("bit");
            Property(x => x.saturday).HasColumnName("saturday").IsRequired().HasColumnType("bit");
            Property(x => x.sunday).HasColumnName("sunday").IsRequired().HasColumnType("bit");
            Property(x => x.fromTimeHour).HasColumnName("fromTimeHour").IsRequired().HasColumnType("int");
            Property(x => x.fromTimeMinute).HasColumnName("fromTimeMinute").IsRequired().HasColumnType("int");
            Property(x => x.toTimeHour).HasColumnName("toTimeHour").IsRequired().HasColumnType("int");
            Property(x => x.toTimeMinute).HasColumnName("toTimeMinute").IsRequired().HasColumnType("int");
            Property(x => x.breakHours).HasColumnName("breakHours").IsRequired().HasColumnType("float");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Company).WithMany(b => b.mf_WorkDays).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_WorkDays).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class pr_PayrollConfiguration : EntityTypeConfiguration<pr_Payroll>
    {
        public pr_PayrollConfiguration()
            : this("dbo")
        {
        }
 
        public pr_PayrollConfiguration(string schema)
        {
            ToTable(schema + ".pr_Payroll");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.cutOffAttendanceId).HasColumnName("cutOffAttendanceId").IsRequired().HasColumnType("int");
            Property(x => x.status).HasColumnName("status").IsRequired().HasColumnType("int");
            Property(x => x.includeLegalDeduction).HasColumnName("includeLegalDeduction").IsRequired().HasColumnType("bit");
            Property(x => x.generatedBy).HasColumnName("generatedBy").IsRequired().HasColumnType("int");
            Property(x => x.generatedDate).HasColumnName("generatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Company).WithMany(b => b.pr_Payrolls).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User_generatedBy).WithMany(b => b.pr_Payrolls_generatedBy).HasForeignKey(c => c.generatedBy);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.pr_Payrolls_updatedBy).HasForeignKey(c => c.updatedBy);
            HasRequired(a => a.ta_CutOffAttendance).WithMany(b => b.pr_Payrolls).HasForeignKey(c => c.cutOffAttendanceId);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class pr_PayrollEmployeeConfiguration : EntityTypeConfiguration<pr_PayrollEmployee>
    {
        public pr_PayrollEmployeeConfiguration()
            : this("dbo")
        {
        }
 
        public pr_PayrollEmployeeConfiguration(string schema)
        {
            ToTable(schema + ".pr_PayrollEmployee");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.payrollId).HasColumnName("payrollId").IsRequired().HasColumnType("int");
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.noOfDays).HasColumnName("noOfDays").IsRequired().HasColumnType("float");
            Property(x => x.totalHours).HasColumnName("totalHours").IsRequired().HasColumnType("float");
            Property(x => x.hourlyRates).HasColumnName("hourlyRates").IsRequired().HasColumnType("float");
            Property(x => x.payRateType).HasColumnName("payRateType").IsRequired().HasColumnType("int");
            Property(x => x.basicRate).HasColumnName("basicRate").IsRequired().HasColumnType("float");
            Property(x => x.totalDeduction).HasColumnName("totalDeduction").IsRequired().HasColumnType("float");
            Property(x => x.totalIncome).HasColumnName("totalIncome").IsRequired().HasColumnType("float");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.pr_PayrollEmployees).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.pr_Payroll).WithMany(b => b.pr_PayrollEmployees).HasForeignKey(c => c.payrollId);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class pr_PayrollEmployeeDeductionConfiguration : EntityTypeConfiguration<pr_PayrollEmployeeDeduction>
    {
        public pr_PayrollEmployeeDeductionConfiguration()
            : this("dbo")
        {
        }
 
        public pr_PayrollEmployeeDeductionConfiguration(string schema)
        {
            ToTable(schema + ".pr_PayrollEmployeeDeductions");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.payrollEmployeeId).HasColumnName("payrollEmployeeId").IsRequired().HasColumnType("int");
            Property(x => x.deductionId).HasColumnName("deductionId").IsOptional().HasColumnType("int");
            Property(x => x.paySlipDetail).HasColumnName("paySlipDetail").IsOptional().HasColumnType("int");
            Property(x => x.value).HasColumnName("value").IsRequired().HasColumnType("float");

            HasOptional(a => a.mf_Deduction).WithMany(b => b.pr_PayrollEmployeeDeductions).HasForeignKey(c => c.deductionId);
            HasRequired(a => a.pr_PayrollEmployee).WithMany(b => b.pr_PayrollEmployeeDeductions).HasForeignKey(c => c.payrollEmployeeId);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class pr_PayrollEmployeeEarningConfiguration : EntityTypeConfiguration<pr_PayrollEmployeeEarning>
    {
        public pr_PayrollEmployeeEarningConfiguration()
            : this("dbo")
        {
        }
 
        public pr_PayrollEmployeeEarningConfiguration(string schema)
        {
            ToTable(schema + ".pr_PayrollEmployeeEarnings");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.payrollEmployeeId).HasColumnName("payrollEmployeeId").IsRequired().HasColumnType("int");
            Property(x => x.allowanceId).HasColumnName("allowanceId").IsOptional().HasColumnType("int");
            Property(x => x.paySlipDetail).HasColumnName("paySlipDetail").IsOptional().HasColumnType("int");
            Property(x => x.value).HasColumnName("value").IsRequired().HasColumnType("float");

            HasOptional(a => a.mf_Allowance).WithMany(b => b.pr_PayrollEmployeeEarnings).HasForeignKey(c => c.allowanceId);
            HasRequired(a => a.pr_PayrollEmployee).WithMany(b => b.pr_PayrollEmployeeEarnings).HasForeignKey(c => c.payrollEmployeeId);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sys_CompanyConfiguration : EntityTypeConfiguration<sys_Company>
    {
        public sys_CompanyConfiguration()
            : this("dbo")
        {
        }
 
        public sys_CompanyConfiguration(string schema)
        {
            ToTable(schema + ".sys_Company");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.businessName).HasColumnName("businessName").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.address1).HasColumnName("address1").IsOptional().HasColumnType("nvarchar");
            Property(x => x.address2).HasColumnName("address2").IsOptional().HasColumnType("nvarchar");
            Property(x => x.address3).HasColumnName("address3").IsOptional().HasColumnType("nvarchar");
            Property(x => x.countryId).HasColumnName("countryId").IsRequired().HasColumnType("int");
            Property(x => x.city).HasColumnName("city").IsOptional().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.postalCode).HasColumnName("postalCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.email).HasColumnName("email").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.telephone).HasColumnName("telephone").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.mobile).HasColumnName("mobile").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.fax).HasColumnName("fax").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Country).WithMany(b => b.sys_Companies).HasForeignKey(c => c.countryId);
            HasRequired(a => a.sys_User).WithMany(b => b.sys_Companies).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sys_CompanySettingConfiguration : EntityTypeConfiguration<sys_CompanySetting>
    {
        public sys_CompanySettingConfiguration()
            : this("dbo")
        {
        }
 
        public sys_CompanySettingConfiguration(string schema)
        {
            ToTable(schema + ".sys_CompanySetting");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.settingId).HasColumnName("settingId").IsRequired().HasColumnType("int");
            Property(x => x.companyId).HasColumnName("companyId").IsOptional().HasColumnType("int");
            Property(x => x.value).HasColumnName("value").IsRequired().HasColumnType("nvarchar");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasOptional(a => a.sys_Company).WithMany(b => b.sys_CompanySettings).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_Setting).WithMany(b => b.sys_CompanySettings).HasForeignKey(c => c.settingId);
            HasRequired(a => a.sys_User).WithMany(b => b.sys_CompanySettings).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sys_EnumReferenceConfiguration : EntityTypeConfiguration<sys_EnumReference>
    {
        public sys_EnumReferenceConfiguration()
            : this("dbo")
        {
        }
 
        public sys_EnumReferenceConfiguration(string schema)
        {
            ToTable(schema + ".sys_EnumReference");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.name).HasColumnName("name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.value).HasColumnName("value").IsRequired().HasColumnType("int");
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.displayOrder).HasColumnName("displayOrder").IsRequired().HasColumnType("int");
            Property(x => x.hidden).HasColumnName("hidden").IsRequired().HasColumnType("bit");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");
            Property(x => x.field1).HasColumnName("field1").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.field2).HasColumnName("field2").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.field3).HasColumnName("field3").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.field4).HasColumnName("field4").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.field5).HasColumnName("field5").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);

            HasRequired(a => a.sys_Company).WithMany(b => b.sys_EnumReferences).HasForeignKey(c => c.companyId);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sys_ErrorLogConfiguration : EntityTypeConfiguration<sys_ErrorLog>
    {
        public sys_ErrorLogConfiguration()
            : this("dbo")
        {
        }
 
        public sys_ErrorLogConfiguration(string schema)
        {
            ToTable(schema + ".sys_ErrorLogs");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.message).HasColumnName("message").IsOptional().HasColumnType("nvarchar");
            Property(x => x.innerException).HasColumnName("innerException").IsOptional().HasColumnType("nvarchar");
            Property(x => x.loggedType).HasColumnName("loggedType").IsRequired().HasColumnType("int");
            Property(x => x.controllerName).HasColumnName("controllerName").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.actionName).HasColumnName("actionName").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.areaName).HasColumnName("areaName").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.createdBy).HasColumnName("createdBy").IsOptional().HasColumnType("int");
            Property(x => x.createdDate).HasColumnName("createdDate").IsRequired().HasColumnType("datetime");

            HasOptional(a => a.sys_User).WithMany(b => b.sys_ErrorLogs).HasForeignKey(c => c.createdBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sys_IdentificationDocumentConfiguration : EntityTypeConfiguration<sys_IdentificationDocument>
    {
        public sys_IdentificationDocumentConfiguration()
            : this("dbo")
        {
        }
 
        public sys_IdentificationDocumentConfiguration(string schema)
        {
            ToTable(schema + ".sys_IdentificationDocument");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_User).WithMany(b => b.sys_IdentificationDocuments).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sys_LocationConfiguration : EntityTypeConfiguration<sys_Location>
    {
        public sys_LocationConfiguration()
            : this("dbo")
        {
        }
 
        public sys_LocationConfiguration(string schema)
        {
            ToTable(schema + ".sys_Location");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Company).WithMany(b => b.sys_Locations).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.sys_Locations).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sys_MenuConfiguration : EntityTypeConfiguration<sys_Menu>
    {
        public sys_MenuConfiguration()
            : this("dbo")
        {
        }
 
        public sys_MenuConfiguration(string schema)
        {
            ToTable(schema + ".sys_Menu");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.controllerName).HasColumnName("controllerName").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.actionName).HasColumnName("actionName").IsOptional().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.areaName).HasColumnName("areaName").IsOptional().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.parameter).HasColumnName("parameter").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_User).WithMany(b => b.sys_Menus).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sys_PermissionConfiguration : EntityTypeConfiguration<sys_Permission>
    {
        public sys_PermissionConfiguration()
            : this("dbo")
        {
        }
 
        public sys_PermissionConfiguration(string schema)
        {
            ToTable(schema + ".sys_Permission");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Company).WithMany(b => b.sys_Permissions).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.sys_Permissions).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sys_RoleConfiguration : EntityTypeConfiguration<sys_Role>
    {
        public sys_RoleConfiguration()
            : this("dbo")
        {
        }
 
        public sys_RoleConfiguration(string schema)
        {
            ToTable(schema + ".sys_Role");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Company).WithMany(b => b.sys_Roles).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.sys_Roles).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sys_RoleMenuConfiguration : EntityTypeConfiguration<sys_RoleMenu>
    {
        public sys_RoleMenuConfiguration()
            : this("dbo")
        {
        }
 
        public sys_RoleMenuConfiguration(string schema)
        {
            ToTable(schema + ".sys_RoleMenu");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.roleId).HasColumnName("roleId").IsRequired().HasColumnType("int");
            Property(x => x.sourceMenuId).HasColumnName("sourceMenuId").IsRequired().HasColumnType("int");
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.parentRoleMenuId).HasColumnName("parentRoleMenuId").IsOptional().HasColumnType("int");
            Property(x => x.displayOrder).HasColumnName("displayOrder").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasOptional(a => a.sys_RoleMenu_parentRoleMenuId).WithMany(b => b.sys_RoleMenus).HasForeignKey(c => c.parentRoleMenuId);
            HasRequired(a => a.sys_Menu).WithMany(b => b.sys_RoleMenus).HasForeignKey(c => c.sourceMenuId);
            HasRequired(a => a.sys_Role).WithMany(b => b.sys_RoleMenus).HasForeignKey(c => c.roleId);
            HasRequired(a => a.sys_User).WithMany(b => b.sys_RoleMenus).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sys_RolePermissionConfiguration : EntityTypeConfiguration<sys_RolePermission>
    {
        public sys_RolePermissionConfiguration()
            : this("dbo")
        {
        }
 
        public sys_RolePermissionConfiguration(string schema)
        {
            ToTable(schema + ".sys_RolePermission");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.roleId).HasColumnName("roleId").IsRequired().HasColumnType("int");
            Property(x => x.permissionId).HasColumnName("permissionId").IsRequired().HasColumnType("int");
            Property(x => x.viewAccess).HasColumnName("viewAccess").IsRequired().HasColumnType("bit");
            Property(x => x.createAccess).HasColumnName("createAccess").IsRequired().HasColumnType("bit");
            Property(x => x.updateAccess).HasColumnName("updateAccess").IsRequired().HasColumnType("bit");
            Property(x => x.deleteAccess).HasColumnName("deleteAccess").IsRequired().HasColumnType("bit");
            Property(x => x.printAccess).HasColumnName("printAccess").IsRequired().HasColumnType("bit");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Permission).WithMany(b => b.sys_RolePermissions).HasForeignKey(c => c.permissionId);
            HasRequired(a => a.sys_Role).WithMany(b => b.sys_RolePermissions).HasForeignKey(c => c.roleId);
            HasRequired(a => a.sys_User).WithMany(b => b.sys_RolePermissions).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sys_SettingConfiguration : EntityTypeConfiguration<sys_Setting>
    {
        public sys_SettingConfiguration()
            : this("dbo")
        {
        }
 
        public sys_SettingConfiguration(string schema)
        {
            ToTable(schema + ".sys_Setting");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.name).HasColumnName("name").IsRequired().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.description).HasColumnName("description").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sys_UserConfiguration : EntityTypeConfiguration<sys_User>
    {
        public sys_UserConfiguration()
            : this("dbo")
        {
        }
 
        public sys_UserConfiguration(string schema)
        {
            ToTable(schema + ".sys_User");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.username).HasColumnName("username").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.password).HasColumnName("password").IsOptional().HasColumnType("nvarchar");
            Property(x => x.hashKey).HasColumnName("hashKey").IsOptional().HasColumnType("nvarchar");
            Property(x => x.vector).HasColumnName("vector").IsOptional().HasColumnType("nvarchar");
            Property(x => x.email).HasColumnName("email").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.employeeId).HasColumnName("employeeId").IsOptional().HasColumnType("int");
            Property(x => x.status).HasColumnName("status").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsOptional().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasOptional(a => a.mf_Employee).WithMany(b => b.sys_Users).HasForeignKey(c => c.employeeId);
            HasOptional(a => a.sys_User_updatedBy).WithMany(b => b.sys_Users).HasForeignKey(c => c.updatedBy);
            HasRequired(a => a.sys_Company).WithMany(b => b.sys_Users).HasForeignKey(c => c.companyId);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sys_UserRoleConfiguration : EntityTypeConfiguration<sys_UserRole>
    {
        public sys_UserRoleConfiguration()
            : this("dbo")
        {
        }
 
        public sys_UserRoleConfiguration(string schema)
        {
            ToTable(schema + ".sys_UserRole");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.roleId).HasColumnName("roleId").IsRequired().HasColumnType("int");
            Property(x => x.userId).HasColumnName("userId").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Role).WithMany(b => b.sys_UserRoles).HasForeignKey(c => c.roleId);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.sys_UserRoles_updatedBy).HasForeignKey(c => c.updatedBy);
            HasRequired(a => a.sys_User_userId).WithMany(b => b.sys_UserRoles_userId).HasForeignKey(c => c.userId);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sys_UserSessionConfiguration : EntityTypeConfiguration<sys_UserSession>
    {
        public sys_UserSessionConfiguration()
            : this("dbo")
        {
        }
 
        public sys_UserSessionConfiguration(string schema)
        {
            ToTable(schema + ".sys_UserSession");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.userId).HasColumnName("userId").IsRequired().HasColumnType("int");
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.loggedDate).HasColumnName("loggedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.ipAddress).HasColumnName("ipAddress").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.expiredDate).HasColumnName("expiredDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Company).WithMany(b => b.sys_UserSessions).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.sys_UserSessions).HasForeignKey(c => c.userId);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class sysdiagramConfiguration : EntityTypeConfiguration<sysdiagram>
    {
        public sysdiagramConfiguration()
            : this("dbo")
        {
        }
 
        public sysdiagramConfiguration(string schema)
        {
            ToTable(schema + ".sysdiagrams");
            HasKey(x => x.diagram_id);

            Property(x => x.name).HasColumnName("name").IsRequired().HasColumnType("nvarchar").HasMaxLength(128);
            Property(x => x.principal_id).HasColumnName("principal_id").IsRequired().HasColumnType("int");
            Property(x => x.diagram_id).HasColumnName("diagram_id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.version).HasColumnName("version").IsOptional().HasColumnType("int");
            Property(x => x.definition).HasColumnName("definition").IsOptional().HasColumnType("varbinary");
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class ta_ApplicationRequestConfiguration : EntityTypeConfiguration<ta_ApplicationRequest>
    {
        public ta_ApplicationRequestConfiguration()
            : this("dbo")
        {
        }
 
        public ta_ApplicationRequestConfiguration(string schema)
        {
            ToTable(schema + ".ta_ApplicationRequest");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.applicationRequestTypeId).HasColumnName("applicationRequestTypeId").IsRequired().HasColumnType("int");
            Property(x => x.note).HasColumnName("note").IsRequired().HasColumnType("nvarchar");
            Property(x => x.status).HasColumnName("status").IsRequired().HasColumnType("int");
            Property(x => x.assignTo).HasColumnName("assignTo").IsRequired().HasColumnType("int");
            Property(x => x.requestedBy).HasColumnName("requestedBy").IsRequired().HasColumnType("int");
            Property(x => x.requestedDate).HasColumnName("requestedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_ApplicationRequestType).WithMany(b => b.ta_ApplicationRequests).HasForeignKey(c => c.applicationRequestTypeId);
            HasRequired(a => a.sys_User_assignTo).WithMany(b => b.ta_ApplicationRequests_assignTo).HasForeignKey(c => c.assignTo);
            HasRequired(a => a.sys_User_requestedBy).WithMany(b => b.ta_ApplicationRequests_requestedBy).HasForeignKey(c => c.requestedBy);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.ta_ApplicationRequests_updatedBy).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class ta_ApplicationRequestApproverConfiguration : EntityTypeConfiguration<ta_ApplicationRequestApprover>
    {
        public ta_ApplicationRequestApproverConfiguration()
            : this("dbo")
        {
        }
 
        public ta_ApplicationRequestApproverConfiguration(string schema)
        {
            ToTable(schema + ".ta_ApplicationRequestApprover");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.applicationRequestId).HasColumnName("applicationRequestId").IsRequired().HasColumnType("int");
            Property(x => x.approverId).HasColumnName("approverId").IsRequired().HasColumnType("int");
            Property(x => x.status).HasColumnName("status").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_User_approverId).WithMany(b => b.ta_ApplicationRequestApprovers_approverId).HasForeignKey(c => c.approverId);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.ta_ApplicationRequestApprovers_updatedBy).HasForeignKey(c => c.updatedBy);
            HasRequired(a => a.ta_ApplicationRequest).WithMany(b => b.ta_ApplicationRequestApprovers).HasForeignKey(c => c.applicationRequestId);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class ta_ApplicationRequestGatePassConfiguration : EntityTypeConfiguration<ta_ApplicationRequestGatePass>
    {
        public ta_ApplicationRequestGatePassConfiguration()
            : this("dbo")
        {
        }
 
        public ta_ApplicationRequestGatePassConfiguration(string schema)
        {
            ToTable(schema + ".ta_ApplicationRequestGatePass");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.applicationRequestId).HasColumnName("applicationRequestId").IsRequired().HasColumnType("int");
            Property(x => x.startDateTime).HasColumnName("startDateTime").IsRequired().HasColumnType("datetime");
            Property(x => x.endDateTime).HasColumnName("endDateTime").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.ta_ApplicationRequest).WithMany(b => b.ta_ApplicationRequestGatePasses).HasForeignKey(c => c.applicationRequestId);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class ta_ApplicationRequestLeaveConfiguration : EntityTypeConfiguration<ta_ApplicationRequestLeave>
    {
        public ta_ApplicationRequestLeaveConfiguration()
            : this("dbo")
        {
        }
 
        public ta_ApplicationRequestLeaveConfiguration(string schema)
        {
            ToTable(schema + ".ta_ApplicationRequestLeave");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.applicationRequestId).HasColumnName("applicationRequestId").IsRequired().HasColumnType("int");
            Property(x => x.startDate).HasColumnName("startDate").IsRequired().HasColumnType("datetime");
            Property(x => x.endDate).HasColumnName("endDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.ta_ApplicationRequest).WithMany(b => b.ta_ApplicationRequestLeaves).HasForeignKey(c => c.applicationRequestId);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class ta_CutOffAttendanceConfiguration : EntityTypeConfiguration<ta_CutOffAttendance>
    {
        public ta_CutOffAttendanceConfiguration()
            : this("dbo")
        {
        }
 
        public ta_CutOffAttendanceConfiguration(string schema)
        {
            ToTable(schema + ".ta_CutOffAttendance");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.payrollGroupId).HasColumnName("payrollGroupId").IsRequired().HasColumnType("int");
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.generatedDate).HasColumnName("generatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.startDate).HasColumnName("startDate").IsRequired().HasColumnType("datetime");
            Property(x => x.endDate).HasColumnName("endDate").IsRequired().HasColumnType("datetime");
            Property(x => x.status).HasColumnName("status").IsRequired().HasColumnType("int");
            Property(x => x.remarks).HasColumnName("remarks").IsOptional().HasColumnType("nvarchar");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.changeStatusBy).HasColumnName("changeStatusBy").IsRequired().HasColumnType("int");
            Property(x => x.changeStatusDate).HasColumnName("changeStatusDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_PayrollGroup).WithMany(b => b.ta_CutOffAttendances).HasForeignKey(c => c.payrollGroupId);
            HasRequired(a => a.sys_Company).WithMany(b => b.ta_CutOffAttendances).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User_changeStatusBy).WithMany(b => b.ta_CutOffAttendances_changeStatusBy).HasForeignKey(c => c.changeStatusBy);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.ta_CutOffAttendances_updatedBy).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class ta_CutOffAttendanceSummaryConfiguration : EntityTypeConfiguration<ta_CutOffAttendanceSummary>
    {
        public ta_CutOffAttendanceSummaryConfiguration()
            : this("dbo")
        {
        }
 
        public ta_CutOffAttendanceSummaryConfiguration(string schema)
        {
            ToTable(schema + ".ta_CutOffAttendanceSummary");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.cutOffAttendanceId).HasColumnName("cutOffAttendanceId").IsRequired().HasColumnType("int");
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.ta_CutOffAttendanceSummaries).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.ta_CutOffAttendanceSummaries).HasForeignKey(c => c.updatedBy);
            HasRequired(a => a.ta_CutOffAttendance).WithMany(b => b.ta_CutOffAttendanceSummaries).HasForeignKey(c => c.cutOffAttendanceId);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class ta_CutOffAttendanceSummaryDetailConfiguration : EntityTypeConfiguration<ta_CutOffAttendanceSummaryDetail>
    {
        public ta_CutOffAttendanceSummaryDetailConfiguration()
            : this("dbo")
        {
        }
 
        public ta_CutOffAttendanceSummaryDetailConfiguration(string schema)
        {
            ToTable(schema + ".ta_CutOffAttendanceSummaryDetail");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.cutOffAttendanceSummaryId).HasColumnName("cutOffAttendanceSummaryId").IsRequired().HasColumnType("int");
            Property(x => x.workDate).HasColumnName("workDate").IsRequired().HasColumnType("datetime");
            Property(x => x.workHours).HasColumnName("workHours").IsRequired().HasColumnType("float");
            Property(x => x.undertimeHours).HasColumnName("undertimeHours").IsRequired().HasColumnType("float");
            Property(x => x.lateHours).HasColumnName("lateHours").IsRequired().HasColumnType("float");
            Property(x => x.overtimeHours).HasColumnName("overtimeHours").IsRequired().HasColumnType("float");
            Property(x => x.workHolidayHours).HasColumnName("workHolidayHours").IsOptional().HasColumnType("float");
            Property(x => x.holidayTypeId).HasColumnName("holidayTypeId").IsOptional().HasColumnType("int");
            Property(x => x.absent).HasColumnName("absent").IsRequired().HasColumnType("bit");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasOptional(a => a.mf_HolidayType).WithMany(b => b.ta_CutOffAttendanceSummaryDetails).HasForeignKey(c => c.holidayTypeId);
            HasRequired(a => a.sys_User).WithMany(b => b.ta_CutOffAttendanceSummaryDetails).HasForeignKey(c => c.updatedBy);
            HasRequired(a => a.ta_CutOffAttendanceSummary).WithMany(b => b.ta_CutOffAttendanceSummaryDetails).HasForeignKey(c => c.cutOffAttendanceSummaryId);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    internal partial class ta_EmployeeAttendanceConfiguration : EntityTypeConfiguration<ta_EmployeeAttendance>
    {
        public ta_EmployeeAttendanceConfiguration()
            : this("dbo")
        {
        }
 
        public ta_EmployeeAttendanceConfiguration(string schema)
        {
            ToTable(schema + ".ta_EmployeeAttendance");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.timeLogType).HasColumnName("timeLogType").IsRequired().HasColumnType("int");
            Property(x => x.workDate).HasColumnName("workDate").IsRequired().HasColumnType("datetime");
            Property(x => x.timeLog).HasColumnName("timeLog").IsRequired().HasColumnType("datetime");
            Property(x => x.workDayId).HasColumnName("workDayId").IsOptional().HasColumnType("int");
            Property(x => x.remarks).HasColumnName("remarks").IsOptional().HasColumnType("nvarchar");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasOptional(a => a.mf_WorkDay).WithMany(b => b.ta_EmployeeAttendances).HasForeignKey(c => c.workDayId);
            HasRequired(a => a.mf_Employee).WithMany(b => b.ta_EmployeeAttendances).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.ta_EmployeeAttendances).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }
        partial void InitializePartial();
    }


    // ************************************************************************
    // Stored procedure return models

}

