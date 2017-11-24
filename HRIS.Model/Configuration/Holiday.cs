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
    public class HolidayModel : ModelAuditInfo
    {
        [PrimaryKey]
        public int? id { get; set; }

        [DisplayName("Holiday Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime holidayDate { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("Holiday Type")]
        public ReferenceModel HolidayType { get; set; }
        
    }
}