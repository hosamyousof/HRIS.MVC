using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public partial class mf_PenaltyType : EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_EmployeeOffense> mf_EmployeeOffenses { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        

        public mf_PenaltyType()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_EmployeeOffenses = new List<mf_EmployeeOffense>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}