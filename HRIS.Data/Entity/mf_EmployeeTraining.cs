using Repository;
using System;

namespace HRIS.Data.Entity
{
    public class mf_EmployeeTraining : EntityBase
    {
        public Guid employeeId { get; set; }
        public DateTime trainingDate { get; set; }
        public string trainingName { get; set; }
        public string description { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }

        public mf_EmployeeTraining()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
        }
    }
}