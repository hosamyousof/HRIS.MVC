using HRIS.Model.Configuration;
using System;
using System.Linq;

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