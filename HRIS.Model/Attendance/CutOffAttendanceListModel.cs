using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HRIS.Model.Attendance
{
    public class CutOffAttendanceListModel : ModelAuditInfo
    {
        public Guid id { get; set; }

        [DisplayName("Generated Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime generatedDate { get; set; }

        [DisplayName("Payroll Group")]
        public string payrollGroup { get; set; }

        [DisplayName("End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]
        public DateTime endDate { get; set; }

        [DisplayName("Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]
        public DateTime startDate { get; set; }

        [DisplayName("Status")]
        public string statusDescr { get; set; }

        [DisplayName("Employee Count")]
        public int employeeCount { get; set; }

        public Guid payrollGroupId { get; set; }

        public int statusId { get; set; }
    }
}