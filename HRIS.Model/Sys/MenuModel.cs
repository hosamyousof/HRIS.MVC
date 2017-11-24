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
    public class MenuModel : ModelAuditInfo
    {
        [PrimaryKey]
        public int? id { get; set; }

        [Required]
        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("Controller Name")]
        public string controllerName { get; set; }

        [DisplayName("Action Name")]
        public string actionName { get; set; }

        [DisplayName("Area Name")]
        public string areaName { get; set; }

        [DisplayName("Parameter")]
        public string parameter { get; set; }
    }
}