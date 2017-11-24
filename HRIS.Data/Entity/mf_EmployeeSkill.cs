using Repository;
using System;

namespace HRIS.Data
{
    public partial class mf_EmployeeSkill : EntityBase
    {
        public int employeeId { get; set; }
        public string skillName { get; set; }
        public int? skillProficiencyLevel { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User { get; set; }

        public mf_EmployeeSkill()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}