using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public partial class ta_CutOffAttendanceSummary : EntityBase
    {
        public int cutOffAttendanceId { get; set; }
        public int employeeId { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<ta_CutOffAttendanceSummaryDetail> ta_CutOffAttendanceSummaryDetails { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        
        public virtual ta_CutOffAttendance ta_CutOffAttendance { get; set; }

        public ta_CutOffAttendanceSummary()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            ta_CutOffAttendanceSummaryDetails = new List<ta_CutOffAttendanceSummaryDetail>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}