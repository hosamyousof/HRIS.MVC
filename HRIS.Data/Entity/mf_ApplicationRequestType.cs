using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public class mf_ApplicationRequestType : EntityBase
    {
        public string code { get; set; }
        public string description { get; set; }
        public bool requiredLeavePoints { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<mf_DepartmentSectionRequestApprover> mf_DepartmentSectionRequestApprovers { get; set; }
        public virtual ICollection<mf_EmployeeBalanceLeave> mf_EmployeeBalanceLeaves { get; set; }
        public virtual ICollection<ta_ApplicationRequest> ta_ApplicationRequests { get; set; }

        public virtual sys_User sys_User_updatedBy { get; set; }

        public mf_ApplicationRequestType()
        {
            requiredLeavePoints = false;
            updatedDate = System.DateTime.Now;
            deleted = false;
            mf_DepartmentSectionRequestApprovers = new List<mf_DepartmentSectionRequestApprover>();
            mf_EmployeeBalanceLeaves = new List<mf_EmployeeBalanceLeave>();
            ta_ApplicationRequests = new List<ta_ApplicationRequest>();
        }
    }
}