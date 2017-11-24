using HRIS.Model.Sys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Attendance
{
    public class EmployeeAttendanceModel
    {
        public int id { get; set; }

        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy hh:mm tt}")]
        [DisplayName("Time Log")]
        public DateTime timeLog { get; set; }

        [DisplayName("Log Type")]
        public ReferenceModel timeLogType { get; set; }

        [DisplayName("Work Day")]
        public ReferenceModel workDay { get; set; }

        [DisplayName("Employee Name")]
        public string employeeName { get; set; }

        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy}")]
        [DisplayName("Work Date")]
        public DateTime workDate { get; set; }
    }
}