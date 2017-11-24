using HRIS.Model.Sys;
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
    public class EmployeeBalanceLeaveModel : ModelAuditInfo
    {
        [PrimaryKey]
        public int? id { get; set; }

        [Required]
        [DisplayName("Leave Type")]
        public ReferenceModel leaveType { get; set; }

        [Required]
        [DisplayName("Balance")]
        [UIHint("NumericTextBox")]
        public double balance { get; set; }
    }
}