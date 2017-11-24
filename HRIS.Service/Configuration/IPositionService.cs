using HRIS.Model.Configuration;
using System;
using System.Linq;

namespace HRIS.Service.Configuration
{
    public interface IPositionService
    {
        void Create(PositionModel model, out Guid positionId);
        void Delete(Guid positionId);
        IQueryable<PositionModel> GetQuery();
        void Update(PositionModel model);
        PositionModel GetById(Guid positionId);
    }
}