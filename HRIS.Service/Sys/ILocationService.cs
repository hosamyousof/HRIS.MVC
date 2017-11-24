using System.Linq;
using HRIS.Model.Sys;
using System;

namespace HRIS.Service.Sys
{
    public interface ILocationService
    {
        void Create(LocationModel model, out Guid locationId);
        void Delete(Guid locationId);
        LocationModel GetById(Guid locationId);
        IQueryable<LocationModel> GetQuery();
        void Update(LocationModel model);
    }
}