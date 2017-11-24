using System;
using Repository;

using System;

using System.Collections.Generic;

namespace HRIS.Data
{
    public partial class sys_Company : EntityBase
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
}