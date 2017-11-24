using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Attendance
{
    public class CutOffAttendanceModel
    {
        public int id { get; set; }

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

        public CUT_OFF_ATTENDANCE statusEnum { get { return (CUT_OFF_ATTENDANCE)statusValue; } }
    }
}