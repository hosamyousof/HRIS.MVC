using HRIS.Model.Configuration;
using System;
using System.Linq;

namespace HRIS.Service.Configuration
{
    public interface IHolidayService
    {
        void Create(HolidayModel model, out int HolidayId);

        void Delete(int HolidayId);

        HolidayModel GetById(int HolidayId);

        IQueryable<HolidayModel> GetQuery();

        void Update(HolidayModel model);

        bool IsHolidayDate(DateTime date);
    }
}