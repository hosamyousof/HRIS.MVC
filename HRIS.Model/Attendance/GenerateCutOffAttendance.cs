using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Attendance
{
    public class GenerateCutOffAttendance
    {
        public Guid payrollGroupId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}