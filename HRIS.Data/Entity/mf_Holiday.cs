using Repository;
using System;

namespace HRIS.Data
{
    public partial class mf_Holiday : EntityBase
    {
        public DateTime holidayDate { get; set; }
        public string description { get; set; }
        public int holidayTypeId { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_HolidayType mf_HolidayType { get; set; }
        public virtual sys_User sys_User { get; set; }

        public mf_Holiday()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}