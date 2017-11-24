using System;
using Repository;

using System;

using System.Collections.Generic;

namespace HRIS.Data
{
    public partial class mf_DepartmentSection : EntityBase
    {
        public int departmentId { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_DepartmentSectionRequestApprover> mf_DepartmentSectionRequestApprovers { get; set; }
        public virtual ICollection<mf_Employee201> mf_Employee201 { get; set; }

        public virtual mf_Department mf_Department { get; set; }
        public virtual sys_User sys_User { get; set; }

        public mf_DepartmentSection()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_DepartmentSectionRequestApprovers = new List<mf_DepartmentSectionRequestApprover>();
            mf_Employee201 = new List<mf_Employee201>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}