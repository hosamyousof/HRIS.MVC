using HRIS.Data;
using HRIS.Model.MasterFile;
using HRIS.Service.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.MasterFile
{
    public class EmploymentTypeService : BaseService, IEmploymentTypeService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<mf_EmploymentType> _repoEmploymentType;
        private readonly IUnitOfWork _unitOfWork;

        public EmploymentTypeService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<mf_EmploymentType> repoEmploymentType)
        {
            this._unitOfWork = unitOfWork;
            this._enumReferenceService = enumReferenceService;
            this._repoEmploymentType = repoEmploymentType;
        }

        public void Create(EmploymentTypeModel model, out int employmentTypeId)
        {
            if (this._repoEmploymentType.Query().Filter(x => x.code == model.code ).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            int currentUserId = this.GetCurrentUserId();
            var ins = this._repoEmploymentType.Insert(new mf_EmploymentType()
            {
                code = model.code,
                description = model.description,
                updatedBy = currentUserId,
            });
            this._unitOfWork.Save();
            employmentTypeId = ins.id;
        }

        public void Delete(int employmentTypeId)
        {
            var data = this._repoEmploymentType.Find(employmentTypeId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoEmploymentType.Update(data);
            this._unitOfWork.Save();
        }

        public EmploymentTypeModel GetById(int employmentTypeId)
        {
            return this.GetQuery().First(x => x.id == employmentTypeId);
        }

        public IQueryable<EmploymentTypeModel> GetQuery()
        {
            var data = this._repoEmploymentType
                .Query().Filter(x => x.deleted == false)
                .Get()
                .Select(x => new EmploymentTypeModel()
                {
                    id = x.id,
                    code = x.code,
                    description = x.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void Update(EmploymentTypeModel model)
        {
            var upt = this._repoEmploymentType.Find(model.id);
            if (upt.code != model.code)
            {
                if (this._repoEmploymentType.Query().Filter(x => x.code == model.code ).Get().Any())
                {
                    throw new Exception(model.code + " is already exists");
                }
                upt.code = model.code;
            }
            upt.description = model.description;
            upt.updatedBy = this.GetCurrentUserId();
            upt.updatedDate = DateTime.Now;
            this._repoEmploymentType.Update(upt);
            this._unitOfWork.Save();
        }
    }
}
