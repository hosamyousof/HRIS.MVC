using System;
using Repository;

using System;

namespace HRIS.Data
{
    public partial class mf_EmployeeAllowance : EntityBase
    {
        public int employeeId { get; set; }
        public int allowanceId { get; set; }
        public double? amount { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Allowance mf_Allowance { get; set; }
        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User { get; set; }

        public mf_EmployeeAllowance()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}