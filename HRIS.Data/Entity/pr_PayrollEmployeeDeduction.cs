using Repository;
using System;

namespace HRIS.Data.Entity
{
    public partial class pr_PayrollEmployeeDeduction : EntityBase
    {
        public Guid payrollEmployeeId { get; set; }
        public Guid? deductionId { get; set; }
        //public Guid? paySlipDetail { get; set; }
        public double value { get; set; }

        public virtual mf_Deduction mf_Deduction { get; set; }
        public virtual pr_PayrollEmployee pr_PayrollEmployee { get; set; }

        public pr_PayrollEmployeeDeduction()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }
}