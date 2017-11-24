using System.Linq;
using HRIS.Model.Configuration;

namespace HRIS.Service.Configuration
{
    public interface IAgencyService
    {
        void Create(AgencyModel model, out int agencyId);
        void Delete(int agencyId);
        AgencyModel GetById(int agencyId);
        IQueryable<AgencyModel> GetQuery();
        void Update(AgencyModel model);
    }
}