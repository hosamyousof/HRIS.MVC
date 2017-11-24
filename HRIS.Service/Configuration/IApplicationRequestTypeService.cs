using Common;
using HRIS.Model.Configuration;
using HRIS.Model.Sys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HRIS.Service.Configuration
{
    public interface IApplicationRequestTypeService
    {
        void DepartmentSectionRequestApproverAdd(Guid departmentSectionId, Guid applicationRequestTypeId, Guid approverId, out Guid departmentSectionRequestApprover);

        void DepartmentsectionRequestApproverDelete(Guid departmentSectionId, Guid applicationRequestTypeId, IEnumerable<DepartmentSectionRequestApproverModel> models);

        void DepartmentSectionRequestApproverUpdate(Guid departmentSectionId, Guid applicationRequestTypeId, IEnumerable<DepartmentSectionRequestApproverModel> models);

        IQueryable<DepartmentSectionRequestApproverModel> GetApplicationRequestApprover(Guid departmentSectionId, Guid applicationRequestTypeId);

        IEnumerable<DataReference> GetLeaveTypeList();

        IEnumerable<ValueText> GetValueTextList();
    }
}