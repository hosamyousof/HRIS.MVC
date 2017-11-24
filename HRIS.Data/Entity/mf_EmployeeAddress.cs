using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public partial class mf_EmployeeAddress : EntityBase
    {
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public int countryId { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_Employee> mf_Employees { get; set; }

        public virtual mf_Country mf_Country { get; set; }

        public mf_EmployeeAddress()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_Employees = new List<mf_Employee>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}