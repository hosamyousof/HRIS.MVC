using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Attendance
{
    public class CutOffAttendanceSummaryDetailModel : ModelAuditInfo
    {
        [PrimaryKey]
        public int id { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy - dddd}")]
        [DisplayName("Work Date")]
        [ExcludeToUpdate]
        public DateTime workDate { get; set; }

        [UIHint("NumericTextBox")]
        [DisplayName("Work Hours")]
        public double workHours { get; set; }

        [UIHint("NumericTextBox")]
        [DisplayName("Late Hours")]
        public double lateHours { get; set; }

        [UIHint("NumericTextBox")]
        [DisplayName("Overtime Hours")]
        public double overtimeHours { get; set; }

        [UIHint("NumericTextBox")]
        [DisplayName("Late Hours")]
        public double undertimeHours { get; set; }
    }
}