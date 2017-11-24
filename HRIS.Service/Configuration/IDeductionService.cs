using System.Linq;
using HRIS.Model.Configuration;
using System;

namespace HRIS.Service.Configuration
{
    public interface IDeductionService
    {
        void Create(DeductionModel model, out Guid deductionId);
        void Delete(Guid deductionId);
        DeductionModel GetById(Guid deductionId);
        IQueryable<DeductionModel> GetQuery();
        void Update(DeductionModel model);
    }
}