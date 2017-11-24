using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.MasterFile
{
    public class EmployeeListModel : ModelAuditInfo
    {
        public int id { get; set; }

        [DisplayName("Employee Code")]
        public string employeeCode { get; set; }

        [DisplayName("Employee Name")]
        public string name { get; set; }

        [DisplayName("Department")]
        public string department { get; set; }

        [DisplayName("Position")]
        public string position { get; set; }
        
    }
}
