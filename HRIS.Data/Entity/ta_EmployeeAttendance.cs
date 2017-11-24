using Repository;
using System;

namespace HRIS.Data.Entity
{
    public partial class ta_EmployeeAttendance : EntityBase
    {
        public int employeeId { get; set; }
        public int timeLogType { get; set; }
        public DateTime workDate { get; set; }
        public DateTime timeLog { get; set; }
        public int? workDayId { get; set; }
        public string remarks { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual mf_WorkDay mf_WorkDay { get; set; }
        

        public ta_EmployeeAttendance()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}