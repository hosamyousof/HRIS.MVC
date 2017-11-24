using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Attendance
{
    public class ManualTimeLogModel
    {
        public ManualTimeLogModel()
        {
            this.timeLog = DateTime.Now.Date;
        }

        [Required]
        [DisplayName("Employee")]
        public int employeeId { get; set; }

        [Required]
        [DisplayName("Time Log")]
        public DateTime timeLog { get; set; }

        [Required]
        [DisplayName("Log Type")]
        public int logType { get; set; }

        [DisplayName("Remarks")]
        public string remarks { get; set; }
    }
}