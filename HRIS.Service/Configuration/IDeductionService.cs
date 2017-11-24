using System.Linq;
using HRIS.Model.Configuration;

namespace HRIS.Service.Configuration
{
    public interface IDeductionService
    {
        void Create(DeductionModel model, out int deductionId);
        void Delete(int deductionId);
        DeductionModel GetById(int deductionId);
        IQueryable<DeductionModel> GetQuery();
        void Update(DeductionModel model);
    }
}