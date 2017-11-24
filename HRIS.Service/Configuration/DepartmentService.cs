using HRIS.Data;
using HRIS.Model.Configuration;
using HRIS.Model.Sys;
using HRIS.Service.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Configuration
{
    public class DepartmentService : BaseService, IDepartmentService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<mf_DepartmentSection> _repoDepartmentSection;
        private readonly IRepository<mf_Department> _repoDepartment;
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<mf_DepartmentSection> repoDepartmentSection
            , IRepository<mf_Department> repoDepartment)
        {
            this._unitOfWork = unitOfWork;
            this._repoDepartmentSection = repoDepartmentSection;
            this._enumReferenceService = enumReferenceService;
            this._repoDepartment = repoDepartment;
        }

        public void Create(DepartmentModel model, out int departmentId)
        {
            if (this._repoDepartment.Query().Filter(x => x.code == model.code).FilterCurrentCompany().Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }

            var ins = this._repoDepartment.NewEntity(ue =>
            {
                ue.SetValue(x => x.code, model.code)
                    .SetValue(x => x.description, model.description)
                    .SetCurrentCompany()
                    .SetCurrentUserTo(x => x.updatedBy);
            });

            this._unitOfWork.Save();
            departmentId = ins.id;
        }

        public void Delete(int departmentId)
        {
            var data = this._repoDepartment.Find(departmentId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoDepartment.Update(data);
            this._unitOfWork.Save();
        }

        public DepartmentModel GetById(int departmentId)
        {
            return this.GetQuery().First(x => x.id == departmentId);
        }

        public IQueryable<DepartmentModel> GetQuery()
        {
            var data = this._repoDepartment
                .Query()
                .FilterCurrentCompany()
                .Get()
                .Select(x => new DepartmentModel()
                {
                    id = x.id,
                    code = x.code,
                    description = x.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void Update(DepartmentModel model)
        {
            var upt = this._repoDepartment.Find(model.id);
            if (upt.code != model.code)
            {
                if (this._repoDepartment.Query().FilterCurrentCompany().Filter(x => x.code == model.code).Get().Any())
                {
                    throw new Exception(model.code + " is already exists");
                }
                upt.code = model.code;
            }
            upt.description = model.description;
            upt.updatedBy = this.GetCurrentUserId();
            upt.updatedDate = DateTime.Now;
            this._repoDepartment.Update(upt);
            this._unitOfWork.Save();
        }

        #region Section

        public void SectionCreate(DepartmentSectionModel model, out int departmentSectionId)
        {
            int currentUserId = this.GetCurrentUserId();
            var ins = this._repoDepartmentSection.Insert(new mf_DepartmentSection()
            {
                code = model.code,
                description = model.description,
                updatedBy = currentUserId,
                departmentId = model.department.value,
            });
            this._unitOfWork.Save();
            departmentSectionId = ins.id;
        }

        public void SectionDelete(int departmentSectionId)
        {
            var data = this._repoDepartmentSection.Find(departmentSectionId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoDepartmentSection.Update(data);
            this._unitOfWork.Save();
        }

        public DepartmentSectionModel SectionGetById(int departmentSectionId)
        {
            return this.SectionGetQuery().First(x => x.id == departmentSectionId);
        }

        public IQueryable<DepartmentSectionModel> SectionGetQuery()
        {
            int companyId = this.GetCurrentCompanyId();
            var data = this._repoDepartmentSection
                .Query()
                .Get()
                .Select(x => new DepartmentSectionModel()
                {
                    id = x.id,
                    code = x.code,
                    department = x.mf_Department == null ? null : new ReferenceModel() { value = x.mf_Department.id, description = x.mf_Department.description },
                    description = x.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void SectionUpdate(DepartmentSectionModel model)
        {
            var upt = this._repoDepartmentSection.Find(model.id);

            upt.code = model.code;
            upt.departmentId = model.department.value;
            upt.description = model.description;
            upt.updatedBy = this.GetCurrentUserId();
            upt.updatedDate = DateTime.Now;
            this._repoDepartmentSection.Update(upt);
            this._unitOfWork.Save();
        }

        #endregion Section
    }
}