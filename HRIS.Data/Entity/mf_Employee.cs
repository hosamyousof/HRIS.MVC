using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public class mf_Employee : EntityBaseCompany
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
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }
        public Guid? employeeAddressId { get; set; }
        public Guid? employee201Id { get; set; }
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
        public virtual sys_User sys_User_updatedBy { get; set; }

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
        }
    }
}