using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Sys
{
   public class RoleMenuEntryModel
    {
        public Guid id { get; set; }
        public Guid menuId { get; set; }
        public string description { get; set; }
        public Guid? parentMenuId { get; set; }
        public Guid roleId { get; set; }
        public int displayOrder { get; set; }
    }
}
