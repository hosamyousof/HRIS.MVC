using Repository;
using System;

namespace HRIS.Data.Entity
{
    public partial class ta_ApplicationRequestApprover : EntityBase
    {
        public Guid applicationRequestId { get; set; }
        public Guid approverId { get; set; }
        public int status { get; set; }
        public Guid updatedBy { get; set; }
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