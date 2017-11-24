using System;
using Repository;

using System;

namespace HRIS.Data
{
    public partial class ta_CutOffAttendanceSummaryDetail : EntityBase
    {
        public int cutOffAttendanceSummaryId { get; set; }
        public DateTime workDate { get; set; }
        public double workHours { get; set; }
        public double undertimeHours { get; set; }
        public double lateHours { get; set; }
        public double overtimeHours { get; set; }
        public double? workHolidayHours { get; set; }
        public int? holidayTypeId { get; set; }
        public bool absent { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_HolidayType mf_HolidayType { get; set; }
        public virtual sys_User sys_User { get; set; }
        public virtual ta_CutOffAttendanceSummary ta_CutOffAttendanceSummary { get; set; }

        public ta_CutOffAttendanceSummaryDetail()
        {
            absent = false;
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}