using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Attendance
{
    public class EmployeeCutOffAttendanceListModel
    {
        public Guid id { get; set; }
        public Guid employeeId { get; set; }
        public DateTime workDate { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public double totalWorkHours { get; set; }
        public double totalUndertimeHours { get; set; }
        public double totalLateHours { get; set; }
        public double totalOvertimeHours { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }
    }
}
