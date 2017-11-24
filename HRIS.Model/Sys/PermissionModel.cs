using Common;
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
    public class PermissionModel : ModelAuditInfo
    {
        [PrimaryKey]
        public int? id { get; set; }

        [Required]
        [DisplayName("code")]
        public string code { get; set; }

        [Required]
        [DisplayName("Description")]
        public string description { get; set; }
    }
}