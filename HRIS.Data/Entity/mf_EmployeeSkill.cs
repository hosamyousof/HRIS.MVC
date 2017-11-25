using Repository;
using System;

namespace HRIS.Data.Entity
{
    public class mf_EmployeeSkill : EntityBase
    {
        public Guid employeeId { get; set; }
        public string skillName { get; set; }
        public int? skillProficiencyLevel { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }

        public mf_EmployeeSkill()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
        }
    }
}