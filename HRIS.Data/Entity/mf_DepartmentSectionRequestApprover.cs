using System;
using Repository;

using System;

namespace HRIS.Data
{
    public partial class mf_DepartmentSectionRequestApprover : EntityBase
    {
        public int approverId { get; set; }
        public int departmentSectionId { get; set; }
        public int applicationRequestTypeId { get; set; }
        public int orderNo { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_ApplicationRequestType mf_ApplicationRequestType { get; set; }
        public virtual mf_DepartmentSection mf_DepartmentSection { get; set; }
        public virtual sys_User sys_User_approverId { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }

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