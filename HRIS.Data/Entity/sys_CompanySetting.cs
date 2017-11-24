using Repository;
using System;

namespace HRIS.Data
{
    public partial class sys_CompanySetting : EntityBase
    {
        public int settingId { get; set; }
        public int? companyId { get; set; }
        public string value { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_Setting sys_Setting { get; set; }
        public virtual sys_User sys_User { get; set; }

        public sys_CompanySetting()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}