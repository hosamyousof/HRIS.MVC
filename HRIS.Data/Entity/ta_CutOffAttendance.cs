using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public partial class ta_CutOffAttendance : EntityBaseCompany
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
}