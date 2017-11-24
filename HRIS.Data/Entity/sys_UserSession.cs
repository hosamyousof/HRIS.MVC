using Repository;
using System;

namespace HRIS.Data.Entity
{
    public partial class sys_UserSession : EntityBaseCompany
    {
        public Guid userId { get; set; }
        public DateTime loggedDate { get; set; }
        public string ipAddress { get; set; }
        public DateTime expiredDate { get; set; }

        public virtual sys_Company sys_Company { get; set; }

        public sys_UserSession()
        {
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}