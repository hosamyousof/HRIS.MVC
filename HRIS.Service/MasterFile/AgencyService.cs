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
    public class AgencyService : BaseService, IAgencyService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<mf_Agency> _repoAgency;
        private readonly IUnitOfWork _unitOfWork;

        public AgencyService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<mf_Agency> repoAgency)
        {
            this._unitOfWork = unitOfWork;
            this._enumReferenceService = enumReferenceService;
            this._repoAgency = repoAgency;
        }

        public void Create(AgencyModel model, out int agencyId)
        {
            int companyId = this.GetCurrentCompanyId();
            if (this._repoAgency.Query().Filter(x => x.code == model.code  && x.companyId == companyId).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            int userId = this.GetCurrentUserId();
            var ins = this._repoAgency.Insert(new mf_Agency()
            {
                companyId = companyId,
                code = model.code,
                description = model.description,
                updatedBy = userId,
            });
            this._unitOfWork.Save();
            agencyId = ins.id;
        }

        public void Delete(int agencyId)
        {
            var data = this._repoAgency.Find(agencyId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoAgency.Update(data);
            this._unitOfWork.Save();
        }

        public AgencyModel GetById(int agencyId)
        {
            return this.GetQuery().First(x => x.id == agencyId);
        }

        public IQueryable<AgencyModel> GetQuery()
        {
            int companyId = this.GetCurrentCompanyId();
            var data = this._repoAgency
                .Query().Filter(x => x.companyId == companyId)
                .Get()
                .Select(x => new AgencyModel()
                {
                    id = x.id,
                    code = x.code,
                    description = x.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void Update(AgencyModel model)
        {
            var upt = this._repoAgency.Find(model.id);
            if (upt.code != model.code)
            {
                int companyId = this.GetCurrentCompanyId();
                if (this._repoAgency.Query().Filter(x => x.code == model.code && x.companyId == companyId ).Get().Any())
                {
                    throw new Exception(model.code + " is already exists");
                }
                upt.code = model.code;
            }

            var userId = this.GetCurrentUserId();

            upt.description = model.description;
            upt.updatedBy = userId;
            upt.updatedDate = DateTime.Now;
            this._repoAgency.Update(upt);
            this._unitOfWork.Save();
        }
    }
}