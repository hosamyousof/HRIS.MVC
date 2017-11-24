using Common;
using HRIS.Data;
using HRIS.Data.Entity;
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
    public class HolidayService : BaseService, IHolidayService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<mf_Holiday> _repoHoliday;
        private readonly IUnitOfWork _unitOfWork;

        public HolidayService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<mf_Holiday> repoHoliday)
        {
            this._unitOfWork = unitOfWork;
            this._enumReferenceService = enumReferenceService;
            this._repoHoliday = repoHoliday;
        }

        public void Create(HolidayModel model, out Guid holidayId)
        {
            var currentUserId = this.GetCurrentUserId();
            var ins = this._repoHoliday.PrepareEntity(model)
                .SetValue(x => x.holidayDate, model.holidayDate.Date)
                .SetValue(x => x.description, model.description)
                .SetValue(x => x.holidayTypeId, model.HolidayType.value)
                .SetValue(x => x.updatedBy, currentUserId)
                .Insert()
                .GetEntity();
            this._unitOfWork.Save();
            holidayId = ins.id;
        }

        public void Delete(Guid holidayId)
        {
            var data = this._repoHoliday.Find(holidayId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoHoliday.Update(data);
            this._unitOfWork.Save();
        }

        public HolidayModel GetById(Guid holidayId)
        {
            return this.GetQuery().First(x => x.id == holidayId);
        }

        public IQueryable<HolidayModel> GetQuery()
        {
            var data = this._repoHoliday.Query()
                .Get()
                .JoinSystemUser(x => x.updatedBy)
                .Select(x => new HolidayModel()
                {
                    id = x.Source.id,
                    holidayDate = x.Source.holidayDate,
                    description = x.Source.description,
                    HolidayType = new DataReference()
                    {
                        value = x.Source.mf_HolidayType.id,
                        description = x.Source.mf_HolidayType.description
                    },
                    updatedBy = x.User.username,
                    updatedDate = x.Source.updatedDate,
                })
                ;

            return data;
        }

        public bool IsHolidayDate(DateTime date)
        {
            return _repoHoliday
                .Query()
                .Filter(x => x.holidayDate == date)
                .Get()
                .Any();
        }

        public void Update(HolidayModel model)
        {
            var upt = this._repoHoliday.Find(model.id);

            upt.holidayDate = model.holidayDate.Date;
            upt.description = model.description;
            upt.holidayTypeId = model.HolidayType.value;

            upt.updatedBy = this.GetCurrentUserId();
            upt.updatedDate = DateTime.Now;
            this._repoHoliday.Update(upt);
            this._unitOfWork.Save();
        }
    }
}