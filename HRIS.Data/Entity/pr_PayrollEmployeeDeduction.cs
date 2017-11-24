using Repository;

namespace HRIS.Data
{
    public partial class pr_PayrollEmployeeDeduction : EntityBase
    {
        public int payrollEmployeeId { get; set; }
        public int? deductionId { get; set; }
        public int? paySlipDetail { get; set; }
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