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
    public class AllowanceService : BaseService, IAllowanceService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<mf_Allowance> _repoAllowance;
        private readonly IUnitOfWork _unitOfWork;

        public AllowanceService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<mf_Allowance> repoAllowance)
        {
            this._unitOfWork = unitOfWork;
            this._enumReferenceService = enumReferenceService;
            this._repoAllowance = repoAllowance;
        }

        public void Create(AllowanceModel model, out int allowanceId)
        {
            int companyId = this.GetCurrentCompanyId();
            if (this._repoAllowance.Query().Filter(x => x.code == model.code && x.companyId == companyId).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            int userId = this.GetCurrentUserId();
            var ins = this._repoAllowance.Insert(new mf_Allowance()
            {
                companyId = companyId,
                code = model.code,
                description = model.description,
                updatedBy = userId,
                isTaxable = model.isTaxable,
            });
            this._unitOfWork.Save();
            allowanceId = ins.id;
        }

        public void Delete(int allowanceId)
        {
            var data = this._repoAllowance.Find(allowanceId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoAllowance.Update(data);
            this._unitOfWork.Save();
        }

        public AllowanceModel GetById(int allowanceId)
        {
            return this.GetQuery().First(x => x.id == allowanceId);
        }

        public IQueryable<AllowanceModel> GetQuery()
        {
            int companyId = this.GetCurrentCompanyId();
            var data = this._repoAllowance
                .Query().Filter(x => x.companyId == companyId)
                .Get()
                .Select(x => new AllowanceModel()
                {
                    id = x.id,
                    code = x.code,
                    description = x.description,
                    isTaxable = x.isTaxable,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void Update(AllowanceModel model)
        {

            var upt = this._repoAllowance.Find(model.id);
            if (upt.code != model.code)
            {
                int companyId = this.GetCurrentCompanyId();
                if (this._repoAllowance.Query().Filter(x => x.code == model.code && x.companyId == companyId ).Get().Any())
                {
                    throw new Exception(model.code + " is already exists");
                }
                upt.code = model.code;
            }

            var userId = this.GetCurrentUserId();

            upt.isTaxable = model.isTaxable;
            upt.description = model.description;
            upt.updatedBy = userId;
            upt.updatedDate = DateTime.Now;
            this._repoAllowance.Update(upt);
            this._unitOfWork.Save();
        }
    }
}