using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public class sys_Permission : EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<sys_RolePermission> sys_RolePermissions { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }

        public sys_Permission()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            sys_RolePermissions = new List<sys_RolePermission>();
        }
    }
}