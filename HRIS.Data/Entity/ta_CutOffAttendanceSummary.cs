using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public class ta_CutOffAttendanceSummary : EntityBase
    {
        public Guid cutOffAttendanceId { get; set; }
        public Guid employeeId { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<ta_CutOffAttendanceSummaryDetail> ta_CutOffAttendanceSummaryDetails { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual sys_User sys_User { get; set; }
        public virtual ta_CutOffAttendance ta_CutOffAttendance { get; set; }

        public ta_CutOffAttendanceSummary()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            ta_CutOffAttendanceSummaryDetails = new List<ta_CutOffAttendanceSummaryDetail>();
        }
    }
}