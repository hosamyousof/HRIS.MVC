using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data
{
    public partial class mf_Deduction : EntityBaseCompany
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
}