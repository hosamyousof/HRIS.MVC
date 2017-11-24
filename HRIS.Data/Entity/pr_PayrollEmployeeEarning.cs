using Repository;
using System;

namespace HRIS.Data.Entity
{
    public class pr_PayrollEmployeeEarning : EntityBase
    {
        public Guid payrollEmployeeId { get; set; }
        public Guid? allowanceId { get; set; }
        public Guid? paySlipDetail { get; set; }
        public double value { get; set; }

        public virtual mf_Allowance mf_Allowance { get; set; }
        public virtual pr_PayrollEmployee pr_PayrollEmployee { get; set; }
    }
}