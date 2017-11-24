using System.Linq;
using HRIS.Model.Configuration;

namespace HRIS.Service.Configuration
{
    public interface IHolidayTypeService
    {
        void Create(HolidayTypeModel model, out int HolidayTypeId);
        void Delete(int HolidayTypeId);
        HolidayTypeModel GetById(int HolidayTypeId);
        IQueryable<HolidayTypeModel> GetQuery();
        void Update(HolidayTypeModel model);
    }
}