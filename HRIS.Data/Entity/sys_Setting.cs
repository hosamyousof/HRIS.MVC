using System;
using Repository;
using System.Collections.Generic;

namespace HRIS.Data
{
    public partial class sys_Setting : EntityBase
    {
        public string name { get; set; }
        public string description { get; set; }

        public virtual ICollection<sys_CompanySetting> sys_CompanySettings { get; set; }

        public sys_Setting()
        {
            deleted = false;
            sys_CompanySettings = new List<sys_CompanySetting>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}