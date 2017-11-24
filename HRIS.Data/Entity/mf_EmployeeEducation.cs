using System;
using Repository;

using System;

namespace HRIS.Data
{
    public partial class mf_EmployeeEducation : EntityBase
    {
        public int employeeId { get; set; }
        public string schoolName { get; set; }
        public int? fromYear { get; set; }
        public int? toYear { get; set; }
        public bool? isGraduated { get; set; }
        public string course { get; set; }
        public int createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User { get; set; }

        public mf_EmployeeEducation()
        {
            createdDate = System.DateTime.Now;
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}