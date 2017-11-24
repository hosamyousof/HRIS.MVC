using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Attendance
{
    public class GenerateCutOffModel
    {
        public int payrollGroupId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string remarks { get; set; }
    }
}