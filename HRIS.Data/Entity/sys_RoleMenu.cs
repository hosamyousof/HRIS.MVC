using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public partial class sys_RoleMenu : EntityBase
    {
        public int roleId { get; set; }
        public int sourceMenuId { get; set; }
        public string description { get; set; }
        public int? parentRoleMenuId { get; set; }
        public int displayOrder { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<sys_RoleMenu> sys_RoleMenus { get; set; }

        public virtual sys_Menu sys_Menu { get; set; }
        public virtual sys_Role sys_Role { get; set; }
        public virtual sys_RoleMenu sys_RoleMenu_parentRoleMenuId { get; set; }
        

        public sys_RoleMenu()
        {
            displayOrder = 0;
            updatedDate = System.DateTime.Now;
            deleted = false;
            sys_RoleMenus = new List<sys_RoleMenu>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}