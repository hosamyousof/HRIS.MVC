using System.Linq;
using HRIS.Model.Configuration;
using System;

namespace HRIS.Service.Configuration
{
    public interface IAllowanceService
    {
        void Create(AllowanceModel model, out Guid allowanceId);
        void Delete(Guid allowanceId);
        AllowanceModel GetById(Guid allowanceId);
        IQueryable<AllowanceModel> GetQuery();
        void Update(AllowanceModel model);
    }
}