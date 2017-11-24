using HRIS.Data;
using HRIS.Model.Sys;
using HRIS.Service.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Sys
{
    public class LocationService : BaseService, ILocationService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<sys_Location> _repoLocation;
        private readonly IUnitOfWork _unitOfWork;

        public LocationService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<sys_Location> repoLocation)
        {
            this._unitOfWork = unitOfWork;
            this._enumReferenceService = enumReferenceService;
            this._repoLocation = repoLocation;
        }

        public void Create(LocationModel model, out int LocationId)
        {
            if (this._repoLocation.Query().Filter(x => x.code == model.code).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            int currentUserId = this.GetCurrentUserId();
            var ins = this._repoLocation.Insert(new sys_Location()
            {
                code = model.code,
                description = model.description,
                updatedBy = currentUserId,
                companyId = this.GetCurrentCompanyId(),
            });
            this._unitOfWork.Save();
            LocationId = ins.id;
        }

        public void Delete(int LocationId)
        {
            var data = this._repoLocation.Find(LocationId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoLocation.Update(data);
            this._unitOfWork.Save();
        }

        public LocationModel GetById(int LocationId)
        {
            return this.GetQuery().First(x => x.id == LocationId);
        }

        public IQueryable<LocationModel> GetQuery()
        {
            int companyId = this.GetCurrentCompanyId();
            var data = this._repoLocation
                .Query().Filter(x => x.deleted == false && x.companyId == companyId)
                .Get()
                .Select(x => new LocationModel()
                {
                    id = x.id,
                    code = x.code,
                    description = x.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void Update(LocationModel model)
        {
            var upt = this._repoLocation.Find(model.id);
            if (upt.code != model.code)
            {
                if (this._repoLocation.Query().Filter(x => x.code == model.code).Get().Any())
                {
                    throw new Exception(model.code + " is already exists");
                }
                upt.code = model.code;
            }
            upt.description = model.description;
            upt.updatedBy = this.GetCurrentUserId();
            upt.updatedDate = DateTime.Now;
            this._repoLocation.Update(upt);
            this._unitOfWork.Save();
        }
    }
}
