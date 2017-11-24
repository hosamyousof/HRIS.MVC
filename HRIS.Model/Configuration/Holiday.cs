using Common;
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
        public Guid? id { get; set; }

        [DisplayName("Holiday Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime holidayDate { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("Holiday Type")]
        public DataReference HolidayType { get; set; }
        
    }
}