using HRIS.Model.Configuration;
using System;
using System.Linq;

namespace HRIS.Service.Configuration
{
    public interface ICountryService
    {
        void Create(CountryModel model, out Guid countryId);

        void Delete(Guid countryId);

        CountryModel GetById(Guid countryId);

        IQueryable<CountryModel> GetQuery();

        void Update(CountryModel model);
    }
}