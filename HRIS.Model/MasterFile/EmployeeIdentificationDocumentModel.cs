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
            this.IdentificationDocument = new ReferenceModel();
        }

        [PrimaryKey]
        public int? id { get; set; }

        [DisplayName("Identification")]
        public ReferenceModel IdentificationDocument { get; set; }

        [DisplayName("ID Number")]
        public string idNumber { get; set; }
        
    }
}
