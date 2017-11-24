using HRIS.Model.Configuration;
using System;
using System.Linq;

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