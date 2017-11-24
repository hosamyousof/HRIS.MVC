using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Sys
{
    public class RoleMenuTreeViewModel : TreeViewModel
    {
        public int displayOrder { get; set; }
        public int menuId { get; set; }
    }
}
