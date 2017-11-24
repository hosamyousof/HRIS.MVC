using HRIS.Model.Configuration;
using System;
using System.Linq;

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