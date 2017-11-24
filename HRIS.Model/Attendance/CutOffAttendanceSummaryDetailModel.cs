using Repository;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HRIS.Model.Attendance
{
    public class CutOffAttendanceSummaryDetailModel : ModelAuditInfo
    {
        [PrimaryKey]
        public Guid id { get; set; }

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