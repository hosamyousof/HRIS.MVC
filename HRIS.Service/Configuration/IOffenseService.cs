using System.Linq;
using HRIS.Model.Configuration;

namespace HRIS.Service.Configuration
{
    public interface IOffenseService
    {
        void Create(OffenseModel model, out int offenseId);
        void Delete(int offenseId);
        OffenseModel GetById(int offenseId);
        IQueryable<OffenseModel> GetQuery();
        void Update(OffenseModel model);
    }
}