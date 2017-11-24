using Common;
using HRIS.Data.Entity;
using HRIS.Model.Configuration;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HRIS.Service.Configuration
{
    public class ApplicationRequestTypeService : BaseService, IApplicationRequestTypeService
    {
        private readonly IRepository<mf_ApplicationRequestType> _repoApplicationRequestType;
        private readonly IRepository<mf_DepartmentSectionRequestApprover> _repoDepartmentSectionRequestApprover;
        private readonly IUnitOfWork _unitOfWork;

        public ApplicationRequestTypeService(IUnitOfWork unitOfWork
            , IRepository<mf_ApplicationRequestType> repoApplicationRequestType
            , IRepository<mf_DepartmentSectionRequestApprover> repoDepartmentSectionRequestApprover)
        {
            this._unitOfWork = unitOfWork;
            this._repoApplicationRequestType = repoApplicationRequestType;
            this._repoDepartmentSectionRequestApprover = repoDepartmentSectionRequestApprover;
        }

        public void ApplicationRequestApproverDelete(Guid id)
        {
            var data = this._repoDepartmentSectionRequestApprover.Find(id);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoDepartmentSectionRequestApprover.Update(data);
        }

        public void DepartmentSectionRequestApproverAdd(Guid departmentSectionId, Guid applicationRequestTypeId, Guid approverId, out Guid departmentSectionRequestApprover)
        {
            var userId = this.GetCurrentUserId();

            var ins = this._repoDepartmentSectionRequestApprover.Insert(new mf_DepartmentSectionRequestApprover()
            {
                approverId = approverId,
                departmentSectionId = departmentSectionId,
                applicationRequestTypeId = applicationRequestTypeId,
                updatedBy = userId,
                orderNo = 0,
            });
            this._unitOfWork.Save();
            departmentSectionRequestApprover = ins.id;
        }

        public void DepartmentsectionRequestApproverDelete(Guid departmentSectionId, Guid applicationRequestTypeId, IEnumerable<DepartmentSectionRequestApproverModel> models)
        {
            var ids = models.Select(x => x.id).ToList();

            var userId = this.GetCurrentUserId();
            this._repoDepartmentSectionRequestApprover.Query().Filter(x => ids.Contains(x.id)).Get()
                .ToList()
                .ForEach(upt =>
                {
                    var model = models.First(x => x.id == upt.id);
                    upt.deleted = true;
                    upt.updatedBy = userId;
                    upt.updatedDate = DateTime.Now;
                    this._repoDepartmentSectionRequestApprover.Update(upt);
                });
            this._unitOfWork.Save();
        }

        public void DepartmentSectionRequestApproverUpdate(Guid departmentSectionId, Guid applicationRequestTypeId, IEnumerable<DepartmentSectionRequestApproverModel> models)
        {
            var ids = models.Select(x => x.id).ToList();
            var userId = this.GetCurrentUserId();
            this._repoDepartmentSectionRequestApprover.Query().Filter(x => ids.Contains(x.id)).Get()
                .ToList()
                .ForEach(upt =>
                {
                    var model = models.First(x => x.id == upt.id);
                    upt.orderNo = model.orderNo;
                    upt.updatedBy = userId;
                    upt.updatedDate = DateTime.Now;
                    this._repoDepartmentSectionRequestApprover.Update(upt);
                });
            this._unitOfWork.Save();
        }

        public IQueryable<DepartmentSectionRequestApproverModel> GetApplicationRequestApprover(Guid departmentSectionId, Guid applicationRequestTypeId)
        {
            var data = this._repoDepartmentSectionRequestApprover
                .Query().Filter(x => !x.deleted && !x.sys_User_approverId.deleted && x.departmentSectionId == departmentSectionId && x.applicationRequestTypeId == applicationRequestTypeId)
                .Get()
                .Select(x => new DepartmentSectionRequestApproverModel()
                {
                    id = x.id,
                    userId = x.approverId,
                    username = x.sys_User_approverId.username,
                    orderNo = x.orderNo,
                });
            return data;
        }

        public IEnumerable<DataReference> GetLeaveTypeList()
        {
            return this._repoApplicationRequestType
                .Query()
                .Filter(x => x.requiredLeavePoints)
                .Get()
                .Select(x => new DataReference()
                {
                    value = x.id,
                    description = x.description
                }).ToList();
        }

        public IEnumerable<ValueText> GetValueTextList()
        {
            return this._repoApplicationRequestType
                .Query()
                .Get()
                .Select(x => new ValueText()
                {
                    Value = x.id.ToString(),
                    Text = x.code + " - " + x.description
                }).ToList();
        }
    }
}