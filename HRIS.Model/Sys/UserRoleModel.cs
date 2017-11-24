using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Sys
{
    public class UserRoleModel
    {
        public int userId { get; set; }

        [DisplayName("Username")]
        public string username { get; set; }

        [DisplayName("Has Access")]
        public bool hasAccess { get; set; }
    }
}
