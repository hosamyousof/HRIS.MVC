using HRIS.Model.Payroll;
using System;

namespace HRIS.Service.Payroll
{
    public interface IPayrollService
    {
        void GeneratePayroll(GeneratePayrollModel model, out Guid payrollId);
    }
}