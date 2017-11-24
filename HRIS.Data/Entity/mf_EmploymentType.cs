using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public partial class mf_EmploymentType : EntityBase
    {
        public string code { get; set; }
        public string description { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_Employee201> mf_Employee201 { get; set; }

        

        public mf_EmploymentType()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_Employee201 = new List<mf_Employee201>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}