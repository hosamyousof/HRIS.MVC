using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public class sys_Menu : EntityBase
    {
        public string description { get; set; }
        public string controllerName { get; set; }
        public string actionName { get; set; }
        public string areaName { get; set; }
        public string parameter { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<sys_RoleMenu> sys_RoleMenus { get; set; }

        public virtual sys_User sys_User_updatedBy { get; set; }

        public sys_Menu()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            sys_RoleMenus = new List<sys_RoleMenu>();
        }
    }
}