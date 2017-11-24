using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Sys
{
    public class LocationModel : ModelAuditInfo
    {
        public int? id { get; set; }

        [DisplayName("Code")]
        public string code { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }
        
    }
}
