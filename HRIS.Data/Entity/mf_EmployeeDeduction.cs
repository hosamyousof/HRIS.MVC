using Repository;
using System;

namespace HRIS.Data.Entity
{
    public partial class mf_EmployeeDeduction : EntityBase
    {
        public Guid employeeId { get; set; }
        public int deductionId { get; set; }
        public double? amount { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Deduction mf_Deduction { get; set; }
        public virtual mf_Employee mf_Employee { get; set; }

        public mf_EmployeeDeduction()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}