using System.Linq;
using HRIS.Model.Configuration;
using System;

namespace HRIS.Service.Configuration
{
    public interface IPayrollGroupService
    {
        void Create(PayrollGroupModel model, out Guid payrollGroupId);
        void Delete(Guid payrollGroupId);
        PayrollGroupModel GetById(Guid payrollGroupId);
        IQueryable<PayrollGroupModel> GetQuery();
        void Update(PayrollGroupModel model);
    }
}