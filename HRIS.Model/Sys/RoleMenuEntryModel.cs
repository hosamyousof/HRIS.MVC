using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Sys
{
   public class RoleMenuEntryModel
    {
        public int id { get; set; }
        public int menuId { get; set; }
        public string description { get; set; }
        public int? parentMenuId { get; set; }
        public int roleId { get; set; }
        public int displayOrder { get; set; }
    }
}
