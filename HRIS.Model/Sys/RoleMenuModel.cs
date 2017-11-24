using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Sys
{
    public class RoleMenuModel
    {
        public string description { get; set; }
        public string actionName { get; set; }
        public string controllerName { get; set; }
        public string areaName { get; set; }
        public IEnumerable<RoleMenuModel> Childs { get; set; }
        public bool mainMenu { get; set; }
        public IEnumerable<int> parentMenuIds { get; set; }
        public int menuId { get; set; }
        public int displayOrder { get; set; }
        public string parameter { get; set; }
    }
}
