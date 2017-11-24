using System.Linq;
using HRIS.Model.Configuration;
using System;

namespace HRIS.Service.Configuration
{
    public interface IOffenseService
    {
        void Create(OffenseModel model, out Guid offenseId);
        void Delete(Guid offenseId);
        OffenseModel GetById(Guid offenseId);
        IQueryable<OffenseModel> GetQuery();
        void Update(OffenseModel model);
    }
}