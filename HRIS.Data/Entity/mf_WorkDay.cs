using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public partial class mf_WorkDay : EntityBaseCompany
    {
        public string code { get; set; }
        public string description { get; set; }
        public bool monday { get; set; }
        public bool tuesday { get; set; }
        public bool wednesday { get; set; }
        public bool thursday { get; set; }
        public bool friday { get; set; }
        public bool saturday { get; set; }
        public bool sunday { get; set; }
        public int fromTimeHour { get; set; }
        public int fromTimeMinute { get; set; }
        public int toTimeHour { get; set; }
        public int toTimeMinute { get; set; }
        public double breakHours { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_EmployeeWorkDay> mf_EmployeeWorkDays { get; set; }
        public virtual ICollection<ta_EmployeeAttendance> ta_EmployeeAttendances { get; set; }

        public virtual sys_Company sys_Company { get; set; }
        public virtual sys_User sys_User { get; set; }

        public mf_WorkDay()
        {
            monday = false;
            tuesday = false;
            wednesday = false;
            thursday = false;
            friday = false;
            saturday = false;
            sunday = false;
            fromTimeHour = 0;
            fromTimeMinute = 0;
            toTimeHour = 0;
            toTimeMinute = 0;
            breakHours = 0;
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_EmployeeWorkDays = new List<mf_EmployeeWorkDay>();
            ta_EmployeeAttendances = new List<ta_EmployeeAttendance>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}