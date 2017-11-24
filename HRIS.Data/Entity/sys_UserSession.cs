using System;

namespace HRIS.Data.Entity
{
    public class sys_UserSession : EntityBaseCompany
    {
        public Guid userId { get; set; }
        public DateTime loggedDate { get; set; }
        public string ipAddress { get; set; }
        public DateTime expiredDate { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }

        public sys_UserSession()
        {
            deleted = false;
        }
    }
}