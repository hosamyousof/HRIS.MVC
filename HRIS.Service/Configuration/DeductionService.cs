using HRIS.Data;
using HRIS.Model.Configuration;
using HRIS.Service.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Configuration
{
    public class DeductionService : BaseService, IDeductionService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<mf_Deduction> _repoDeduction;
        private readonly IUnitOfWork _unitOfWork;

        public DeductionService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<mf_Deduction> repoDeduction)
        {
            this._unitOfWork = unitOfWork;
            this._enumReferenceService = enumReferenceService;
            this._repoDeduction = repoDeduction;
        }

        public void Create(DeductionModel model, out int deductionId)
        {
            int companyId = this.GetCurrentCompanyId();
            if (this._repoDeduction.Query().Filter(x => x.code == model.code && x.companyId == companyId).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            int userId = this.GetCurrentUserId();
            var ins = this._repoDeduction.Insert(new mf_Deduction()
            {
                companyId = companyId,
                code = model.code,
                description = model.description,
                updatedBy = userId,
            });
            this._unitOfWork.Save();
            deductionId = ins.id;
        }

        public void Delete(int deductionId)
        {
            var data = this._repoDeduction.Find(deductionId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoDeduction.Update(data);
            this._unitOfWork.Save();
        }

        public DeductionModel GetById(int deductionId)
        {
            return this.GetQuery().First(x => x.id == deductionId);
        }

        public IQueryable<DeductionModel> GetQuery()
        {
            int companyId = this.GetCurrentCompanyId();
            var data = this._repoDeduction
                .Query().Filter(x => x.companyId == companyId)
                .Get()
                .Select(x => new DeductionModel()
                {
                    id = x.id,
                    code = x.code,
                    description = x.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void Update(DeductionModel model)
        {

            var upt = this._repoDeduction.Find(model.id);
            if (upt.code != model.code)
            {
                int companyId = this.GetCurrentCompanyId();
                if (this._repoDeduction.Query().Filter(x => x.code == model.code && x.companyId == companyId).Get().Any())
                {
                    throw new Exception(model.code + " is already exists");
                }
                upt.code = model.code;
            }

            var userId = this.GetCurrentUserId();

            upt.description = model.description;
            upt.updatedBy = userId;
            upt.updatedDate = DateTime.Now;
            this._repoDeduction.Update(upt);
            this._unitOfWork.Save();
        }
    }
}