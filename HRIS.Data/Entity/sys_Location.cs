using System;

namespace HRIS.Data.Entity
{
    public class sys_Location : EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }

        public sys_Location()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
        }
    }
}