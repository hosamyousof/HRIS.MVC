using System.Linq;
using HRIS.Model.Configuration;

namespace HRIS.Service.Configuration
{
    public interface IPositionService
    {
        void Create(PositionModel model, out int positionId);
        void Delete(int positionId);
        IQueryable<PositionModel> GetQuery();
        void Update(PositionModel model);
        PositionModel GetById(int positionId);
    }
}