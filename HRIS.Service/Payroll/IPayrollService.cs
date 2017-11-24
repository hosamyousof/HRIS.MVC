using System;
using HRIS.Model.Payroll;

namespace HRIS.Service.Payroll
{
    public interface IPayrollService
    {
        void GeneratePayroll(GeneratePayrollModel model, out Guid payrollId);
    }
}