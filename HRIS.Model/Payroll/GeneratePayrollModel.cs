using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Payroll
{
    public class GeneratePayrollModel
    {
        public int cutOffAttendanceId { get; set; }

        public bool includeLegalDeduction { get; set; }

        public bool includeAllowance { get; set; }
    }
}
