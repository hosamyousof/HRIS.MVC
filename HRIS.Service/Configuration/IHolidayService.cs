using HRIS.Model.Configuration;
using System;
using System.Linq;

namespace HRIS.Service.Configuration
{
    public interface IHolidayService
    {
        void Create(HolidayModel model, out Guid holidayId);

        void Delete(Guid holidayId);

        HolidayModel GetById(Guid holidayId);

        IQueryable<HolidayModel> GetQuery();

        void Update(HolidayModel model);

        bool IsHolidayDate(DateTime date);
    }
}