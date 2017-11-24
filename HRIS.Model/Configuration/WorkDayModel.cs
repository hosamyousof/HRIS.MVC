using HRIS.Model.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Configuration
{
    public class WorkDayModel : ModelAuditInfo
    {
        [PrimaryKey]
        public int? id { get; set; }

        [DisplayName("Code")]
        public string code { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("Mon")]
        public bool monday { get; set; }

        [DisplayName("Tue")]
        public bool tuesday { get; set; }

        [DisplayName("Wed")]
        public bool wednesday { get; set; }

        [DisplayName("Thu")]
        public bool thursday { get; set; }

        [DisplayName("Fri")]
        public bool friday { get; set; }

        [DisplayName("Sat")]
        public bool saturday { get; set; }

        [DisplayName("Sun")]
        public bool sunday { get; set; }

        [DisplayName("From Hour")]
        public ReferenceModel FromTimeHour { get; set; }

        [DisplayName("From Minute")]
        public int fromTimeMinute { get; set; }

        [DisplayName("To Hour")]
        public ReferenceModel ToTimeHour { get; set; }

        [DisplayName("To Minute")]
        public int toTimeMinute { get; set; }

        [DisplayName("Break Hours")]
        public double breakHours { get; set; }
    }
}