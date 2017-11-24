using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public class mf_Department : EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_DepartmentSection> mf_DepartmentSections { get; set; }
        public virtual ICollection<mf_Employee201> mf_Employee201 { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }

        public mf_Department()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_DepartmentSections = new List<mf_DepartmentSection>();
            mf_Employee201 = new List<mf_Employee201>();
        }
    }
}