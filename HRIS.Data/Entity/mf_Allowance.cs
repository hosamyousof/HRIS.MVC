using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public class mf_Allowance : EntityBaseCompany
    {
        public string code { get; set; }
        public bool isTaxable { get; set; }
        public string description { get; set; }
        public Guid updatedBy { get; set; }
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
        }
    }
}