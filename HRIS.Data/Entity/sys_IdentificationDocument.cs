using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data
{
    public partial class sys_IdentificationDocument : EntityBase
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_EmployeeIdentificationDocument> mf_EmployeeIdentificationDocuments { get; set; }

        public virtual sys_User sys_User { get; set; }

        public sys_IdentificationDocument()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_EmployeeIdentificationDocuments = new List<mf_EmployeeIdentificationDocument>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}