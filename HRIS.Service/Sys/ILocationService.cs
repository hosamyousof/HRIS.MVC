using System.Linq;
using HRIS.Model.Sys;

namespace HRIS.Service.Sys
{
    public interface ILocationService
    {
        void Create(LocationModel model, out int LocationId);
        void Delete(int LocationId);
        LocationModel GetById(int LocationId);
        IQueryable<LocationModel> GetQuery();
        void Update(LocationModel model);
    }
}