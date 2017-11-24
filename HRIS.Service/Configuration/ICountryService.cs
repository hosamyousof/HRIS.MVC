using System.Linq;
using HRIS.Model.Configuration;

namespace HRIS.Service.Configuration
{
    public interface ICountryService
    {
        void Create(CountryModel model, out int countryId);
        void Delete(int countryId);
        CountryModel GetById(int countryId);
        IQueryable<CountryModel> GetQuery();
        void Update(CountryModel model);
    }
}