using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public class mf_HolidayType : EntityBase
    {
        public string code { get; set; }
        public string description { get; set; }
        public double rateNotWork { get; set; }
        public double rateWork { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_Holiday> mf_Holidays { get; set; }
        public virtual ICollection<ta_CutOffAttendanceSummaryDetail> ta_CutOffAttendanceSummaryDetails { get; set; }

        public virtual sys_User sys_User_updatedBy { get; set; }

        public mf_HolidayType()
        {
            rateNotWork = 0;
            rateWork = 0;
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_Holidays = new List<mf_Holiday>();
            ta_CutOffAttendanceSummaryDetails = new List<ta_CutOffAttendanceSummaryDetail>();
        }
    }
}