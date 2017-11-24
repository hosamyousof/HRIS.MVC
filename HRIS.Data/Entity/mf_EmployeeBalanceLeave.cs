using Repository;
using System;

namespace HRIS.Data.Entity
{
    public class mf_EmployeeBalanceLeave : EntityBase
    {
        public Guid employeeId { get; set; }
        public double balance { get; set; }
        public Guid applicationRequestTypeId { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_ApplicationRequestType mf_ApplicationRequestType { get; set; }
        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User { get; set; }

        public mf_EmployeeBalanceLeave()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
        }
    }
}