using Repository;
using System;

namespace HRIS.Data.Entity
{
    public class mf_EmployeeBasicPay : EntityBase
    {
        public Guid employeeId { get; set; }
        public double basicPay { get; set; }
        public int rateType { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }

        public mf_EmployeeBasicPay()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
        }
    }
}