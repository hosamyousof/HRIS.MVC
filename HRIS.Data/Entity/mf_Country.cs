using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public partial class mf_Country : EntityBase
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_EmployeeAddress> mf_EmployeeAddresses { get; set; }
        public virtual ICollection<sys_Company> sys_Companies { get; set; }


        public mf_Country()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_EmployeeAddresses = new List<mf_EmployeeAddress>();
            sys_Companies = new List<sys_Company>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}