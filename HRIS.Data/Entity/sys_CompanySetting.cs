using Repository;
using System;

namespace HRIS.Data.Entity
{
    public class sys_CompanySetting : EntityBase
    {
        public Guid settingId { get; set; }
        public Guid? companyId { get; set; }
        public string value { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_Setting sys_Setting { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }

        public sys_CompanySetting()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
        }
    }
}