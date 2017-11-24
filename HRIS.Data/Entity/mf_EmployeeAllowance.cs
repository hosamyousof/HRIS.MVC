using Repository;
using System;

namespace HRIS.Data.Entity
{
    public class mf_EmployeeAllowance : EntityBase
    {
        public Guid employeeId { get; set; }
        public Guid allowanceId { get; set; }
        public double? amount { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Allowance mf_Allowance { get; set; }
        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User { get; set; }

        public mf_EmployeeAllowance()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
        }
    }
}