using System;
using System.ComponentModel.DataAnnotations;

namespace HRIS.Model.Attendance
{
    public class CutOffAttendanceModel
    {
        public Guid id { get; set; }

        public string payrollGroup { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]
        public DateTime generatedDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]
        public DateTime startDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]
        public DateTime endDate { get; set; }

        public string status { get; set; }

        public string changeStatusBy { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]
        public DateTime changeStatusDate { get; set; }

        public string remarks { get; set; }

        public int statusValue { get; set; }

        public Guid changeStatusById { get; set; }

        public CUT_OFF_ATTENDANCE statusEnum { get { return (CUT_OFF_ATTENDANCE)statusValue; } }
    }
}