using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Sys
{
    public class RolePermissionModel
    {
        public int permissionId { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("View")]
        public bool viewAccess { get; set; }

        [DisplayName("Create")]
        public bool createAccess { get; set; }

        [DisplayName("Update")]
        public bool updateAccess { get; set; }

        [DisplayName("Delete")]
        public bool deleteAccess { get; set; }

        [DisplayName("Print")]
        public bool printAccess { get; set; }
    }
}