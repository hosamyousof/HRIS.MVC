using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public partial class mf_PayrollGroup : EntityBase
    {
        public string code { get; set; }
        public string description { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_Employee201> mf_Employee201 { get; set; }
        public virtual ICollection<ta_CutOffAttendance> ta_CutOffAttendances { get; set; }

        public virtual sys_User sys_User { get; set; }

        public mf_PayrollGroup()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_Employee201 = new List<mf_Employee201>();
            ta_CutOffAttendances = new List<ta_CutOffAttendance>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}