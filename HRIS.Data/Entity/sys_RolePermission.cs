using Repository;
using System;

namespace HRIS.Data.Entity
{
    public partial class sys_RolePermission : EntityBase
    {
        public Guid roleId { get; set; }
        public Guid permissionId { get; set; }
        public bool viewAccess { get; set; }
        public bool createAccess { get; set; }
        public bool updateAccess { get; set; }
        public bool deleteAccess { get; set; }
        public bool printAccess { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual sys_Permission sys_Permission { get; set; }
        public virtual sys_Role sys_Role { get; set; }
        

        public sys_RolePermission()
        {
            viewAccess = false;
            createAccess = false;
            updateAccess = false;
            deleteAccess = false;
            printAccess = false;
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}