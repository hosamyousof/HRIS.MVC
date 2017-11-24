using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.MasterFile
{
    public class EmployeeWorkDayModel
    {
        public int workDayId { get; set; }

        [DisplayName("Name")]
        public string name { get; set; }

        [DisplayName("Time")]
        public string time { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("Has Work Day")]
        public bool hasWorkDay { get; set; }
    }
}
