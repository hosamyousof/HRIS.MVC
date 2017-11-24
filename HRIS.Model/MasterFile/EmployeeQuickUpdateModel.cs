using HRIS.Model.Sys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.MasterFile
{
    public class EmployeeQuickUpdateModel
    {
        public int id { get; set; }

        [Required]
        [DisplayName("Employee Code")]
        public string employeeCode { get; set; }

        [DisplayName("Position")]
        public ReferenceModel position { get; set; }

        [DisplayName("Department")]
        public ReferenceModel department { get; set; }

        [DisplayName("Employment Status")]
        public ReferenceModel employmentStatus { get; set; }

        [DisplayName("Employment Type")]
        public ReferenceModel employmentType { get; set; }

        [DisplayName("Position Level")]
        public ReferenceModel positionLevel { get; set; }
    }
}