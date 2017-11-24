using Repository;
using System;

namespace HRIS.Data.Entity
{
    public partial class mf_DepartmentSectionRequestApprover : EntityBase
    {
        public Guid approverId { get; set; }
        public Guid departmentSectionId { get; set; }
        public Guid applicationRequestTypeId { get; set; }
        public int orderNo { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_ApplicationRequestType mf_ApplicationRequestType { get; set; }
        public virtual mf_DepartmentSection mf_DepartmentSection { get; set; }

        public mf_DepartmentSectionRequestApprover()
        {
            orderNo = 0;
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}