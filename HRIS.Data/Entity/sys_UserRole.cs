using Repository;
using System;

namespace HRIS.Data.Entity
{
    public partial class sys_UserRole : EntityBase
    {
        public Guid roleId { get; set; }
        public Guid userId { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual sys_Role sys_Role { get; set; }

        public sys_UserRole()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}