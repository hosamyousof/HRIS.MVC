using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public partial class sys_User : EntityBaseCompany
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
}