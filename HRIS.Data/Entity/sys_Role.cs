using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public partial class sys_Role : EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<sys_RoleMenu> sys_RoleMenus { get; set; }
        public virtual ICollection<sys_RolePermission> sys_RolePermissions { get; set; }
        public virtual ICollection<sys_UserRole> sys_UserRoles { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }

        public sys_Role()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            sys_RoleMenus = new List<sys_RoleMenu>();
            sys_RolePermissions = new List<sys_RolePermission>();
            sys_UserRoles = new List<sys_UserRole>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}