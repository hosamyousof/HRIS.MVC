using System.Linq;
using HRIS.Model.Configuration;
using System;

namespace HRIS.Service.Configuration
{
    public interface IHolidayTypeService
    {
        void Create(HolidayTypeModel model, out Guid holidayTypeId);
        void Delete(Guid holidayTypeId);
        HolidayTypeModel GetById(Guid holidayTypeId);
        IQueryable<HolidayTypeModel> GetQuery();
        void Update(HolidayTypeModel model);
    }
}