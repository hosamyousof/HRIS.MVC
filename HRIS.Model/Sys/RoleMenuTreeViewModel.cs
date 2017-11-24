using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Sys
{
    public class RoleMenuTreeViewModel : TreeViewModel
    {
        public Guid menuId { get; set; }
        public int displayOrder { get; set; }
    }
}
