using System.Linq;
using HRIS.Model.Configuration;
using System;

namespace HRIS.Service.Configuration
{
    public interface IAgencyService
    {
        void Create(AgencyModel model, out Guid agencyId);
        void Delete(Guid agencyId);
        AgencyModel GetById(Guid agencyId);
        IQueryable<AgencyModel> GetQuery();
        void Update(AgencyModel model);
    }
}