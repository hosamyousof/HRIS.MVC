using HRIS.Data.Entity;
using HRIS.Model.Configuration;
using HRIS.Service.Sys;
using Repository;
using System;
using System.Linq;

namespace HRIS.Service.Configuration
{
    public class HolidayTypeService : BaseService, IHolidayTypeService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<mf_HolidayType> _repoHolidayType;
        private readonly IUnitOfWork _unitOfWork;

        public HolidayTypeService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<mf_HolidayType> repoHolidayType)
        {
            this._unitOfWork = unitOfWork;
            this._enumReferenceService = enumReferenceService;
            this._repoHolidayType = repoHolidayType;
        }

        public void Create(HolidayTypeModel model, out int HolidayTypeId)
        {
            if (this._repoHolidayType.Query().Filter(x => x.code == model.code).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            int currentUserId = this.GetCurrentUserId();
            var ins = this._repoHolidayType.PrepareEntity(model)
                .MatchAllDataField()
                .SetValue(x => x.updatedBy, currentUserId)
                .Insert()
                .GetEntity();
            this._unitOfWork.Save();
            HolidayTypeId = ins.id;
        }

        public void Delete(int HolidayTypeId)
        {
            var data = this._repoHolidayType.Find(HolidayTypeId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoHolidayType.Update(data);
            this._unitOfWork.Save();
        }

        public HolidayTypeModel GetById(int HolidayTypeId)
        {
            return this.GetQuery().First(x => x.id == HolidayTypeId);
        }

        public IQueryable<HolidayTypeModel> GetQuery()
        {
            var data = this._repoHolidayType.Query()
                .Get()
                .JoinSystemUser(x => x.updatedBy)
                .Select(x => new HolidayTypeModel()
                {
                    id = x.Source.id,
                    code = x.Source.code,
                    description = x.Source.description,
                    rateNotWork = x.Source.rateNotWork,
                    rateWork = x.Source.rateWork,
                    updatedBy = x.User.username,
                    updatedDate = x.Source.updatedDate,
                });

            return data;
        }

        public void Update(HolidayTypeModel model)
        {
            var upt = this._repoHolidayType.Find(model.id);
            if (upt.code != model.code)
            {
                if (this._repoHolidayType.Query().Filter(x => x.code == model.code).Get().Any())
                {
                    throw new Exception(model.code + " is already exists");
                }
                upt.code = model.code;
            }
            upt.description = model.description;

            upt.code = model.code;
            upt.description = model.description;
            upt.rateWork = model.rateWork;
            upt.rateNotWork = model.rateNotWork;

            upt.updatedBy = this.GetCurrentUserId();
            upt.updatedDate = DateTime.Now;
            this._repoHolidayType.Update(upt);
            this._unitOfWork.Save();
        }
    }
}