using HRIS.Data;
using HRIS.Model;
using HRIS.Model.Payroll;
using HRIS.Service.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Payroll
{
    public interface IPayrollService
    {
        void GeneratePayroll(GeneratePayrollModel model, out int payrollId);
    }

    public class PayrollService : BaseService, IPayrollService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<pr_Payroll> _repoPayroll;
        private readonly IRepository<ta_CutOffAttendance> _repoCutOffAttendance;
        private readonly IRepository<ta_CutOffAttendanceSummary> _repoCutOffAttendanceSummary;

        public PayrollService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<ta_CutOffAttendanceSummary> repoCutOffAttendanceSummary
            , IRepository<ta_CutOffAttendance> repoCutOffAttendance
            , IRepository<pr_Payroll> repoPayroll)
        {
            this._enumReferenceService = enumReferenceService;
            this._unitOfWork = unitOfWork;
            this._repoCutOffAttendanceSummary = repoCutOffAttendanceSummary;
            this._repoPayroll = repoPayroll;
            this._repoCutOffAttendance = repoCutOffAttendance;
        }

        public void GeneratePayroll(GeneratePayrollModel model, out int payrollId)
        {
            var companyId = this.GetCurrentCompanyId();
            var userId = this.GetCurrentUserId();

            var paySlipDetails = this._enumReferenceService.GetEntityListByName(ReferenceList.PAYSLIP_DETAILS).Where(x => x.field2 == "True").ToList();

            var cutOffAttendance = this._repoCutOffAttendance
                .Query()
                .Filter(x => x.id == model.cutOffAttendanceId)
                .Get()
                .First();

            if ((CUT_OFF_ATTENDANCE)cutOffAttendance.status != CUT_OFF_ATTENDANCE.Submitted)
            {
                throw new Exception("Selected Cut Off Attendance is not Submitted.");
            }

            cutOffAttendance.status = (int)CUT_OFF_ATTENDANCE.Posted;
            cutOffAttendance.changeStatusBy = userId;
            cutOffAttendance.changeStatusDate = DateTime.Now;

            this._repoCutOffAttendance.Update(cutOffAttendance);

            var ins = this._repoPayroll.Insert(new pr_Payroll()
            {
                companyId = companyId,
                generatedBy = userId,
                cutOffAttendanceId = model.cutOffAttendanceId,
                status = (int)PAYROLL_STATUS.New,
                updatedBy = userId,
            });

            var emps = this._repoCutOffAttendanceSummary
                .Query()
                .Filter(x => x.cutOffAttendanceId == cutOffAttendance.id)
                .Get()
                .Select(x => new
                {
                    x.employeeId,
                    deductions = x.mf_Employee.mf_EmployeeDeductions,
                    allowances = x.mf_Employee.mf_EmployeeAllowances,
                    emp201 = x.mf_Employee.mf_Employee201,
                    basicPay = x.mf_Employee.mf_EmployeeBasicPays,
                    totalDays = x.ta_CutOffAttendanceSummaryDetails.Sum(c => c.workHours),
                    workHours = x.ta_CutOffAttendanceSummaryDetails.Sum(c => c.workHours),
                    undertimeHours = x.ta_CutOffAttendanceSummaryDetails.Sum(c => c.undertimeHours),
                    lateHours = x.ta_CutOffAttendanceSummaryDetails.Sum(c => c.lateHours),
                    overtimeHours = x.ta_CutOffAttendanceSummaryDetails.Sum(c => c.overtimeHours),
                })
                .ToList();

            foreach (var emp in emps)
            {
                double? hourRate = emp
                    .basicPay
                    .Where(x => x.rateType == (int)PAY_RATE_TYPE.Hourly)
                    .Select(x => x.basicPay)
                    .FirstOrDefault();

                if (!hourRate.HasValue) continue;

                var pr_emp = new pr_PayrollEmployee()
                {
                    ObjectState = ObjectState.Added,
                    employeeId = emp.employeeId,
                    updatedBy = userId,
                };

                if (model.includeLegalDeduction)
                {
                    foreach (var item in emp.deductions.Where(x=> (x.amount ?? 0) > 0))
                    {
                        pr_emp.pr_PayrollEmployeeDeductions.Add(new pr_PayrollEmployeeDeduction()
                        {
                            deductionId = item.deductionId,
                            value = item.amount ?? 0,
                        });
                    }
                }

                if (model.includeAllowance)
                {

                }

                //pr_emp.no

                ins.pr_PayrollEmployees.Add(pr_emp);
            }

            this._unitOfWork.Save();
            payrollId = ins.id;
        }
    }
}