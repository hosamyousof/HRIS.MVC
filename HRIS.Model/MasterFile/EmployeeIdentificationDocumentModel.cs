using Common;
using HRIS.Model.Sys;
using Repository;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HRIS.Model.MasterFile
{
    public class EmployeeIdentificationDocumentModel : ModelAuditInfo
    {
        public EmployeeIdentificationDocumentModel()
        {
            this.IdentificationDocument = new DataReference();
        }

        [PrimaryKey]
        public Guid? id { get; set; }

        [DisplayName("Identification")]
        public DataReference IdentificationDocument { get; set; }

        [DisplayName("ID Number")]
        public string idNumber { get; set; }
        
    }
}
