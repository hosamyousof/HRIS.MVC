using Repository;
using System;

namespace HRIS.Data.Entity
{
    public partial class mf_EmployeeIdentificationDocument : EntityBase
    {
        public Guid employeeId { get; set; }
        public Guid identificationDocumentId { get; set; }
        public string idNumber { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_IdentificationDocument sys_IdentificationDocument { get; set; }
        

        public mf_EmployeeIdentificationDocument()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}