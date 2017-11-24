using HRIS.Data.Entity;
using HRIS.Model.Sys;
using Repository;
using System;
using System.Linq;

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

        public void Create(LocationModel model, out Guid locationId)
        {
            if (this._repoLocation.Query().Filter(x => x.code == model.code).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            var currentUserId = this.GetCurrentUserId();
            var ins = this._repoLocation.Insert(new sys_Location()
            {
                code = model.code,
                description = model.description,
                updatedBy = currentUserId,
                companyId = this.GetCurrentCompanyId(),
            });
            this._unitOfWork.Save();
            locationId = ins.id;
        }

        public void Delete(Guid locationId)
        {
            var data = this._repoLocation.Find(locationId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoLocation.Update(data);
            this._unitOfWork.Save();
        }

        public LocationModel GetById(Guid locationId)
        {
            return this.GetQuery().First(x => x.id == locationId);
        }

        public IQueryable<LocationModel> GetQuery()
        {
            Guid companyId = this.GetCurrentCompanyId();
            var data = this._repoLocation
                .Query().Filter(x => x.deleted == false && x.companyId == companyId)
                .Get()
                .JoinSystemUser(x => x.updatedBy)
                .Select(x => new LocationModel()
                {
                    id = x.Source.id,
                    code = x.Source.code,
                    description = x.Source.description,
                    updatedBy = x.User.username,
                    updatedDate = x.Source.updatedDate,
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