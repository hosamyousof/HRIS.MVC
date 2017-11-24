using System;
using Repository;

namespace HRIS.Data
{
    public partial class pr_PayrollEmployeeEarning : EntityBase
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
}