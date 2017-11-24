using Repository;
using System;

namespace HRIS.Data.Entity
{
    public partial class ta_ApplicationRequestApprover : EntityBase
    {
        public int applicationRequestId { get; set; }
        public int approverId { get; set; }
        public int status { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ta_ApplicationRequest ta_ApplicationRequest { get; set; }

        public ta_ApplicationRequestApprover()
        {
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}