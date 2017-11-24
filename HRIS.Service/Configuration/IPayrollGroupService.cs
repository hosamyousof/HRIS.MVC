using System.Linq;
using HRIS.Model.Configuration;

namespace HRIS.Service.Configuration
{
    public interface IPayrollGroupService
    {
        void Create(PayrollGroupModel model, out int payrollGroupId);
        void Delete(int payrollGroupId);
        PayrollGroupModel GetById(int payrollGroupId);
        IQueryable<PayrollGroupModel> GetQuery();
        void Update(PayrollGroupModel model);
    }
}