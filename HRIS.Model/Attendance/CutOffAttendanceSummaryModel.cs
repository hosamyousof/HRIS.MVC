using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Attendance
{
    public class CutOffAttendanceSummaryModel : ModelAuditInfo
    {
        public int id { get; set; }

        [DisplayName("Employee Name")]
        public string employeeName { get; set; }

        [UIHint("NumericTextBox")]
        [DisplayName("Work Hours")]
        public double totalWorkHours { get; set; }

        [UIHint("NumericTextBox")]
        [DisplayName("Late Hours")]
        public double totalLateHours { get; set; }

        [UIHint("NumericTextBox")]
        [DisplayName("Overtime Hours")]
        public double totalOvertimeHours { get; set; }

        [UIHint("NumericTextBox")]
        [DisplayName("Late Hours")]
        public double totalUndertimeHours { get; set; }
    }
}