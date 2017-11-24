using System.Linq;
using HRIS.Model.Configuration;

namespace HRIS.Service.Configuration
{
    public interface IAllowanceService
    {
        void Create(AllowanceModel model, out int allowanceId);
        void Delete(int allowanceId);
        AllowanceModel GetById(int allowanceId);
        IQueryable<AllowanceModel> GetQuery();
        void Update(AllowanceModel model);
    }
}