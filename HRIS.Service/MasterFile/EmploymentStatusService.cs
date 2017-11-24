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
    public class EmploymentStatusService : BaseService, IEmploymentStatusService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<mf_EmploymentStatu> _repoEmploymentStatus;
        private readonly IUnitOfWork _unitOfWork;

        public EmploymentStatusService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<mf_EmploymentStatu> repoEmploymentStatus)
        {
            this._unitOfWork = unitOfWork;
            this._enumReferenceService = enumReferenceService;
            this._repoEmploymentStatus = repoEmploymentStatus;
        }

        public void Create(EmploymentStatusModel model, out int employmentStatusId)
        {
            if (this._repoEmploymentStatus.Query().Filter(x => x.code == model.code ).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            int currentUserId = this.GetCurrentUserId();
            var ins = this._repoEmploymentStatus.Insert(new mf_EmploymentStatu()
            {
                code = model.code,
                description = model.description,
                updatedBy = currentUserId,
                allowProcessPayroll = model.allowProcessPayroll
            });
            this._unitOfWork.Save();
            employmentStatusId = ins.id;
        }

        public void Delete(int employmentStatusId)
        {
            var data = this._repoEmploymentStatus.Find(employmentStatusId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoEmploymentStatus.Update(data);
            this._unitOfWork.Save();
        }

        public EmploymentStatusModel GetById(int employmentStatusId)
        {
            return this.GetQuery().First(x => x.id == employmentStatusId);
        }

        public IQueryable<EmploymentStatusModel> GetQuery()
        {
            var data = this._repoEmploymentStatus
                .Query()
                .Get()
                .Select(x => new EmploymentStatusModel()
                {
                    id = x.id,
                    code = x.code,
                    description = x.description,
                     allowProcessPayroll = x.allowProcessPayroll,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void Update(EmploymentStatusModel model)
        {
            var upt = this._repoEmploymentStatus.Find(model.id);
            if (upt.code != model.code)
            {
                if (this._repoEmploymentStatus.Query().Filter(x => x.code == model.code ).Get().Any())
                {
                    throw new Exception(model.code + " is already exists");
                }
                upt.code = model.code;
            }
            upt.allowProcessPayroll = model.allowProcessPayroll;
            upt.description = model.description;
            upt.updatedBy = this.GetCurrentUserId();
            upt.updatedDate = DateTime.Now;
            this._repoEmploymentStatus.Update(upt);
            this._unitOfWork.Save();
        }
    }
}
