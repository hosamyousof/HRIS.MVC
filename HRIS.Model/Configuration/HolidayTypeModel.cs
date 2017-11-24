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
    public class HolidayTypeModel : ModelAuditInfo
    {
        [PrimaryKey]
        public int? id { get; set; }

        [DisplayName("Code")]
        public string code { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("Rate if not Work")]
        public double rateNotWork { get; set; }

        [DisplayName("Rate if Work")]
        public double rateWork { get; set; }
    }
}