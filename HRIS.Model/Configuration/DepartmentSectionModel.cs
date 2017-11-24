using HRIS.Model.Sys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Configuration
{
    public class DepartmentSectionModel : ModelAuditInfo
    {
        public int? id { get; set; }

        [DisplayName("Code")]
        [Required]
        public string code { get; set; }

        [DisplayName("Description")]
        [Required]
        public string description { get; set; }

        [UIHint("DropDownDepartment")]
        [Required]
        [DisplayName("Department")]
        public ReferenceModel department { get; set; }
    }
}
