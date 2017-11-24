using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public partial class ta_ApplicationRequest : EntityBase
    {
        public int applicationRequestTypeId { get; set; }
        public string note { get; set; }
        public int status { get; set; }
        public int assignTo { get; set; }
        public int requestedBy { get; set; }
        public DateTime requestedDate { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<ta_ApplicationRequestApprover> ta_ApplicationRequestApprovers { get; set; }
        public virtual ICollection<ta_ApplicationRequestGatePass> ta_ApplicationRequestGatePasses { get; set; }
        public virtual ICollection<ta_ApplicationRequestLeave> ta_ApplicationRequestLeaves { get; set; }

        public virtual mf_ApplicationRequestType mf_ApplicationRequestType { get; set; }
        public virtual sys_User sys_User_assignTo { get; set; }
        public virtual sys_User sys_User_requestedBy { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }

        public ta_ApplicationRequest()
        {
            requestedDate = System.DateTime.Now;
            updatedDate = System.DateTime.Now;
            deleted = false;
            ta_ApplicationRequestApprovers = new List<ta_ApplicationRequestApprover>();
            ta_ApplicationRequestGatePasses = new List<ta_ApplicationRequestGatePass>();
            ta_ApplicationRequestLeaves = new List<ta_ApplicationRequestLeave>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}