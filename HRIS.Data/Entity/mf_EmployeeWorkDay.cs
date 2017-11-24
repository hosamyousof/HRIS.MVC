using Repository;
using System;

namespace HRIS.Data.Entity
{
    public class mf_EmployeeWorkDay : EntityBase
    {
        public Guid employeeId { get; set; }
        public Guid workDayId { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual mf_WorkDay mf_WorkDay { get; set; }
        public virtual sys_User sys_User { get; set; }

        public mf_EmployeeWorkDay()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
        }
    }
}