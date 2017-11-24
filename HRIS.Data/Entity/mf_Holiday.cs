using Repository;
using System;

namespace HRIS.Data.Entity
{
    public class mf_Holiday : EntityBase
    {
        public DateTime holidayDate { get; set; }
        public string description { get; set; }
        public Guid holidayTypeId { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_HolidayType mf_HolidayType { get; set; }
        public virtual sys_User sys_User { get; set; }

        public mf_Holiday()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
        }
    }
}