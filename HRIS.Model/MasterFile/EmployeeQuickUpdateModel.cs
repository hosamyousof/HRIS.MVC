using Common;
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
        public Guid id { get; set; }

        [Required]
        [DisplayName("Employee Code")]
        public string employeeCode { get; set; }

        [DisplayName("Position")]
        public DataReference position { get; set; }

        [DisplayName("Department")]
        public DataReference department { get; set; }

        [DisplayName("Employment Status")]
        public DataReference employmentStatus { get; set; }

        [DisplayName("Employment Type")]
        public DataReference employmentType { get; set; }

        [DisplayName("Position Level")]
        public ReferenceModel positionLevel { get; set; }
    }
}