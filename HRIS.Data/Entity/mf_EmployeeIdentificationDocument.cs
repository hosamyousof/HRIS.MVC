using Repository;
using System;

namespace HRIS.Data.Entity
{
    public partial class mf_EmployeeIdentificationDocument : EntityBase
    {
        public int employeeId { get; set; }
        public int identificationDocumentId { get; set; }
        public string idNumber { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_IdentificationDocument sys_IdentificationDocument { get; set; }
        public virtual sys_User sys_User { get; set; }

        public mf_EmployeeIdentificationDocument()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}