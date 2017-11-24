using HRIS.Model.Configuration;
using HRIS.Model.Sys;
using System.Collections.Generic;
using System.Linq;

namespace HRIS.Service.Configuration
{
    public interface IApplicationRequestTypeService
    {
        void DepartmentSectionRequestApproverAdd(int departmentSectionId, int requestTypeId, int approverId, out int departmentSectionRequestApprover);

        void DepartmentsectionRequestApproverDelete(int departmentSectionId, int requestTypeId, IEnumerable<DepartmentSectionRequestApproverModel> models);

        void DepartmentSectionRequestApproverUpdate(int departmentSectionId, int requestTypeId, IEnumerable<DepartmentSectionRequestApproverModel> models);

        IQueryable<DepartmentSectionRequestApproverModel> GetApplicationRequestApprover(int departmentSectionId, int requestTypeId);

        IEnumerable<ReferenceModel> GetLeaveTypeList();

        IEnumerable<ValueText> GetValueTextList();
    }
}