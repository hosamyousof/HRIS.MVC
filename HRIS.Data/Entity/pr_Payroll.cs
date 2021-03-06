using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public class pr_Payroll : EntityBaseCompany
    {
        public Guid cutOffAttendanceId { get; set; }
        public int status { get; set; }
        public bool includeLegalDeduction { get; set; }
        public Guid generatedBy { get; set; }
        public DateTime generatedDate { get; set; }
        public Guid updatedBy { get; set; }
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
        }
    }
}