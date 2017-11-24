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
    public class CountryService : BaseService, ICountryService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<mf_Country> _repoCountry;
        private readonly IUnitOfWork _unitOfWork;

        public CountryService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<mf_Country> repoCountry)
        {
            this._unitOfWork = unitOfWork;
            this._enumReferenceService = enumReferenceService;
            this._repoCountry = repoCountry;
        }

        public void Create(CountryModel model, out int countryId)
        {
            if (this._repoCountry.Query().Filter(x => x.code == model.code ).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            int currentUserId = this.GetCurrentUserId();
            var ins = this._repoCountry.Insert(new mf_Country()
            {
                code = model.code,
                description = model.description,
                updatedBy = currentUserId,
            });
            this._unitOfWork.Save();
            countryId = ins.id;
        }

        public void Delete(int countryId)
        {
            var data = this._repoCountry.Find(countryId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoCountry.Update(data);
            this._unitOfWork.Save();
        }

        public CountryModel GetById(int countryId)
        {
            return this.GetQuery().First(x => x.id == countryId);
        }

        public IQueryable<CountryModel> GetQuery()
        {
            var data = this._repoCountry
                .Query().Filter(x => x.deleted == false)
                .Get()
                .Select(x => new CountryModel()
                {
                    id = x.id,
                    code = x.code,
                    description = x.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void Update(CountryModel model)
        {
            var upt = this._repoCountry.Find(model.id);
            if (upt.code != model.code)
            {
                if (this._repoCountry.Query().Filter(x => x.code == model.code ).Get().Any())
                {
                    throw new Exception(model.code + " is already exists");
                }
                upt.code = model.code;
            }
            upt.description = model.description;
            upt.updatedBy = this.GetCurrentUserId();
            upt.updatedDate = DateTime.Now;
            this._repoCountry.Update(upt);
            this._unitOfWork.Save();
        }
    }
}