using HRIS.Data;
using HRIS.Model;
using HRIS.Model.Attendance;
using HRIS.Model.Sys;
using HRIS.Service.Configuration;
using HRIS.Service.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Attendance
{
    public class AttendanceService : BaseService, IAttendanceService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IHolidayService _holidayService;
        private readonly IRepository<ta_CutOffAttendance> _repoCutOffAttendance;
        private readonly IRepository<ta_CutOffAttendanceSummary> _repoCutOffAttendanceSummary;
        private readonly IRepository<ta_CutOffAttendanceSummaryDetail> _repoCutOffAttendanceSummaryDetail;
        private readonly IRepository<mf_Employee> _repoEmployee;
        private readonly IRepository<ta_EmployeeAttendance> _repoEmployeeAttendance;
        private readonly IRepository<mf_WorkDay> _repoWorkDay;
        private readonly IUnitOfWork _unitOfWork;

        public AttendanceService(
            IEnumReferenceService enumReferenceService
            , IHolidayService holidayService
            , IRepository<mf_Employee> repoEmployee
            , IRepository<mf_WorkDay> repoWorkDay
            , IRepository<ta_CutOffAttendance> repoCutOffAttendance
            , IRepository<ta_CutOffAttendanceSummary> repoCutOffAttendanceSummary
            , IRepository<ta_CutOffAttendanceSummaryDetail> repoCutOffAttendanceSummaryDetail
            , IRepository<ta_EmployeeAttendance> repoEmployeeAttendance
            , IUnitOfWork unitOfWork
            )
        {
            this._holidayService = holidayService;
            this._enumReferenceService = enumReferenceService;
            this._repoCutOffAttendance = repoCutOffAttendance;
            this._repoCutOffAttendanceSummary = repoCutOffAttendanceSummary;
            this._repoCutOffAttendanceSummaryDetail = repoCutOffAttendanceSummaryDetail;
            this._repoEmployee = repoEmployee;
            this._repoEmployeeAttendance = repoEmployeeAttendance;
            this._repoWorkDay = repoWorkDay;
            this._unitOfWork = unitOfWork;
        }

        public bool CheckIfEmployeeAttendanceHasRecord(DateTime startDate, DateTime endDate)
        {
            int companyId = this.GetCurrentCompanyId();
            return this._repoEmployeeAttendance.Query()
                .Filter(x => x.workDate >= startDate && x.workDate <= endDate && x.mf_Employee.companyId == companyId)
                .Get()
                .Any();
        }

        public bool CheckIfEmployeeAttendanceHasWorkDay(DateTime startDate, DateTime endDate)
        {
            int companyId = this.GetCurrentCompanyId();
            return this._repoEmployeeAttendance.Query()
                .Filter(x => x.workDate >= startDate && x.workDate <= endDate && x.workDayId == null && x.mf_Employee.companyId == companyId)
                .Get()
                .Any() == false;
        }

        public CutOffAttendanceModel CutOffAttendanceGetById(int id)
        {
            var statuses = this._enumReferenceService.GetQuery(ReferenceList.CUT_OFF_ATTENDANCE);
            var data = this._repoCutOffAttendance
                .Query()
                .Filter(x => x.id == id)
                .Get()
                .Join(statuses, da => da.status, s => s.value, (da, status) => new { da, status })
                .Select(x => new CutOffAttendanceModel()
                {
                    id = x.da.id,
                    payrollGroup = x.da.mf_PayrollGroup.description,
                    generatedDate = x.da.generatedDate,
                    startDate = x.da.startDate,
                    endDate = x.da.endDate,
                    status = x.status.description,
                    statusValue = x.status.value,
                    changeStatusBy = x.da.sys_User_changeStatusBy.username,
                    changeStatusDate = x.da.changeStatusDate,
                    remarks = x.da.remarks,
                })
                .FirstOrDefault();

            return data;
        }

        public CutOffAttendanceModel CutOffAttendanceGetBySummaryId(int cutOffAttendanceSummaryId)
        {
            var statuses = this._enumReferenceService.GetQuery(ReferenceList.CUT_OFF_ATTENDANCE);
            var data = this._repoCutOffAttendance
                .Query()
                .Filter(x => x.ta_CutOffAttendanceSummaries.Any(s => s.id == cutOffAttendanceSummaryId))
                .Get()
                .Join(statuses, da => da.status, s => s.value, (da, status) => new { da, status })
                .Select(x => new CutOffAttendanceModel()
                {
                    id = x.da.id,
                    payrollGroup = x.da.mf_PayrollGroup.description,
                    generatedDate = x.da.generatedDate,
                    startDate = x.da.startDate,
                    endDate = x.da.endDate,
                    status = x.status.description,
                    statusValue = x.status.value,
                    changeStatusBy = x.da.sys_User_changeStatusBy.username,
                    changeStatusDate = x.da.changeStatusDate,
                    remarks = x.da.remarks,
                })
                .FirstOrDefault();

            return data;
        }

        public IQueryable<CutOffAttendanceListModel> CutOffAttendanceListModelGetQuery()
        {
            var statuses = this._enumReferenceService.GetQuery(ReferenceList.CUT_OFF_ATTENDANCE);
            var data = this._repoCutOffAttendance
                .Query()
                .Get()
                .Join(statuses, da => da.status, s => s.value, (da, status) => new { da, status })
                .Select(x => new CutOffAttendanceListModel()
                {
                    id = x.da.id,
                    payrollGroupId = x.da.payrollGroupId,
                    payrollGroup = x.da.mf_PayrollGroup.description,
                    generatedDate = x.da.generatedDate,
                    startDate = x.da.startDate,
                    endDate = x.da.endDate,
                    statusDescr = x.status.description,
                    statusId = x.da.status,
                    employeeCount = x.da.ta_CutOffAttendanceSummaries.Count()
                });
            return data;
        }

        public IQueryable<CutOffAttendanceSummaryDetailModel> CutOffAttendanceSummaryDetailGetByCutOffAttendanceSummaryId(int cutOffAttendanceSummaryId)
        {
            var data = this._repoCutOffAttendanceSummaryDetail.Query()
                .Filter(x => x.cutOffAttendanceSummaryId == cutOffAttendanceSummaryId)
                .Get()
                .Select(x => new CutOffAttendanceSummaryDetailModel()
                {
                    id = x.id,
                    workDate = x.workDate,
                    workHours = x.workHours,
                    undertimeHours = x.undertimeHours,
                    lateHours = x.lateHours,
                    overtimeHours = x.overtimeHours,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void CutOffAttendanceSummaryDetailUpdate(CutOffAttendanceSummaryDetailModel model)
        {
            int userId = this.GetCurrentUserId();
            this._repoCutOffAttendanceSummaryDetail.FindAndUpdateFromModel(model, model.id)
                .MatchAllDataField()
                .SetValue(x => x.updatedBy, userId)
                .Update();

            this._unitOfWork.Save();
        }

        public IQueryable<CutOffAttendanceSummaryModel> CutOffAttendanceSummaryGetByCutOffAttendanceId(int cutOffAttendanceId)
        {
            var data = this._repoCutOffAttendanceSummary.Query()
                .Filter(x => x.cutOffAttendanceId == cutOffAttendanceId)
                .Get()
                .Select(x => new CutOffAttendanceSummaryModel()
                {
                    id = x.id,
                    employeeName = x.mf_Employee.lastName + ", " + x.mf_Employee.firstName,
                    totalWorkHours = x.ta_CutOffAttendanceSummaryDetails.Sum(s => s.workHours),
                    totalUndertimeHours = x.ta_CutOffAttendanceSummaryDetails.Sum(s => s.undertimeHours),
                    totalLateHours = x.ta_CutOffAttendanceSummaryDetails.Sum(s => s.lateHours),
                    totalOvertimeHours = x.ta_CutOffAttendanceSummaryDetails.Sum(s => s.overtimeHours),
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void CutOffAttendanceUpdateStatus(int id, CUT_OFF_ATTENDANCE status, string remarks)
        {
            var data = this._repoCutOffAttendance.Find(id);

            var currentStatus = (CUT_OFF_ATTENDANCE)data.status;

            switch (status)
            {
                case CUT_OFF_ATTENDANCE.Draft:
                    break;
                case CUT_OFF_ATTENDANCE.Submitted:
                    if (new[] { CUT_OFF_ATTENDANCE.Draft, CUT_OFF_ATTENDANCE.Reject }.Contains(currentStatus) == false)
                    {
                        throw new Exception("Only Status \"Draft\" and \"Reject\" can submit Cut Off Attendance.");
                    }
                    break;
                case CUT_OFF_ATTENDANCE.Posted:
                    if (currentStatus != CUT_OFF_ATTENDANCE.Submitted)
                    {
                        throw new Exception("Only status Submitted Cut Off Attendance can be process");
                    }
                    break;
                case CUT_OFF_ATTENDANCE.Reject:
                    if (currentStatus != CUT_OFF_ATTENDANCE.Submitted)
                    {
                        throw new Exception("Only status Submitted Cut Off Attendance can be rejected.");
                    }
                    break;
                case CUT_OFF_ATTENDANCE.Cancel:
                    break;
                default:
                    break;
            }

            data.remarks = remarks;
            data.status = (int)CUT_OFF_ATTENDANCE.Submitted;
            data.changeStatusBy = this.GetCurrentUserId();
            data.changeStatusDate = DateTime.Now;
            data.updatedBy = data.changeStatusBy;
            data.updatedDate = DateTime.Now;

            this._repoCutOffAttendance.Update(data);
            this._unitOfWork.Save();
        }

        public void GenerateCutOffAttendance(GenerateCutOffAttendance model, out int cutOffAttendanceId)
        {
            int userId = this.GetCurrentUserId();
            var cutOffAttendance = this._repoCutOffAttendance.Insert(new ta_CutOffAttendance()
            {
                generatedDate = DateTime.Now.Date,
                payrollGroupId = model.payrollGroupId,
                startDate = model.startDate,
                endDate = model.endDate,
                companyId = this.GetCurrentCompanyId(),
                updatedBy = userId,
                status = (int)CUT_OFF_ATTENDANCE.Draft,
                changeStatusBy = userId,
                changeStatusDate = DateTime.Now,
            });

            DateTime startDate = model.startDate.Date;
            DateTime endDate = model.endDate.Date.AddDays(1).AddMinutes(-1);

            this._repoEmployee
                .Query().Filter(x => x.mf_Employee201.payrollGroupId == model.payrollGroupId && x.mf_Employee201.mf_EmploymentStatu.allowProcessPayroll)
                .Get()
                .Select(x => new { x.id, _201 = x.mf_Employee201, })
                .ToList()
                .ForEach(x =>
                {
                    var summary = new ta_CutOffAttendanceSummary()
                    {
                        ObjectState = ObjectState.Added,
                        employeeId = x.id,
                        updatedBy = userId,
                    };
                    FixEmployeeTotalWorkHours(model.startDate, model.endDate, summary, x._201);
                    cutOffAttendance.ta_CutOffAttendanceSummaries.Add(summary);
                });

            this._unitOfWork.Save();

            cutOffAttendanceId = cutOffAttendance.id;
        }

        public IQueryable<EmployeeAttendanceModel> GetEmployeeAttendance(int? payrollId, int? employeeId, DateTime? startDate, DateTime? endDate)
        {
            var prepare = this._repoEmployeeAttendance.Query();

            if (employeeId.HasValue)
            {
                prepare.Filter(x => x.employeeId == employeeId);
            }

            if (payrollId.HasValue)
            {
                prepare.Filter(x => x.mf_Employee.pr_PayrollEmployees.Any(pe => pe.payrollId == payrollId));
            }

            if (startDate.HasValue)
            {
                prepare.Filter(x => x.timeLog >= startDate);
            }

            if (endDate.HasValue)
            {
                prepare.Filter(x => x.timeLog <= endDate);
            }
            var data = prepare
                .Get()
                .Join(this._enumReferenceService.GetQuery(ReferenceList.TIME_LOG_TYPE), a => a.timeLogType, tlt => tlt.value, (a, tlt) => new { Attendance = a, timeLogType = tlt })
                .Select(x => new EmployeeAttendanceModel()
                {
                    id = x.Attendance.id,
                    employeeName = x.Attendance.mf_Employee.lastName + ", " + x.Attendance.mf_Employee.firstName,
                    workDate = x.Attendance.workDate,
                    timeLog = x.Attendance.timeLog,
                    timeLogType = x.timeLogType,
                    workDay = x.Attendance.mf_WorkDay != null ? new ReferenceModel()
                    {
                        value = x.Attendance.mf_WorkDay.id,
                        description = x.Attendance.mf_WorkDay.description,
                    } : null
                });
            return data;
        }

        public IQueryable<EmployeeCutOffAttendanceListModel> GetEmployeeCutOffAttendanceList()
        {
            var data = this._repoCutOffAttendanceSummary
                .Query()
                .Select(x => new EmployeeCutOffAttendanceListModel()
                {
                    id = x.id,
                    employeeId = x.employeeId,
                });

            return data;
        }

        public void SaveManualTimeLog(ManualTimeLogModel model)
        {
          
            this._repoEmployeeAttendance.Insert(new ta_EmployeeAttendance()
            {
                employeeId = model.employeeId,
                timeLogType = model.logType,
                workDate = model.timeLog.Date,
                timeLog = model.timeLog,
                remarks = model.remarks,
                updatedBy = this.GetCurrentUserId(),
            });
            this._unitOfWork.Save();
        }

        public void UpdateWorkDaysAttendance(EmployeeAttendanceModel attendance)
        {
            var userId = this.GetCurrentUserId();
            var upt = this._repoEmployeeAttendance.Find(attendance.id);
            if (attendance.workDay != null)
            {
                upt.workDayId = attendance.workDay.value;
            }
            else
            {
                upt.workDayId = null;
            }
            upt.workDate = attendance.workDate;
            upt.updatedBy = userId;
            upt.updatedDate = DateTime.Now;
            this._repoEmployeeAttendance.Update(upt);
            this._unitOfWork.Save();
        }

        private Func<DayOfWeek, mf_WorkDay, bool> checkDaysOfWeek = (DayOfWeek dow, mf_WorkDay mf) =>
        {
            switch (dow)
            {
                case DayOfWeek.Sunday: return mf.sunday;
                case DayOfWeek.Monday: return mf.monday;
                case DayOfWeek.Tuesday: return mf.tuesday;
                case DayOfWeek.Wednesday: return mf.wednesday;
                case DayOfWeek.Thursday: return mf.thursday;
                case DayOfWeek.Friday: return mf.friday;
                case DayOfWeek.Saturday: return mf.saturday;
                default: return false;
            }
        };

        private void FixEmployeeTotalWorkHours(DateTime startDate, DateTime endDate, ta_CutOffAttendanceSummary eda, mf_Employee201 _201)
        {
            var workDays = this._repoWorkDay
                .Query()
                .Filter(x => x.mf_EmployeeWorkDays.Any(ewd => ewd.employeeId == eda.employeeId && !eda.deleted))
                .Get()
                .ToList();

            var attendance = this._repoEmployeeAttendance.Query().Filter(x =>
                    x.employeeId == eda.employeeId
                    && x.workDate >= startDate
                    && x.workDate <= endDate)
                .Get()
                .OrderBy(x => x.workDate)
                .ToList();

            int userId = this.GetCurrentUserId();

            DateTime date = startDate.Date;
            while (date <= endDate.Date)
            {
                var wDays = workDays.Where(x => checkDaysOfWeek(date.Date.DayOfWeek, x));
                var atts = attendance.Where(x => x.workDate.Date == date).OrderBy(x => x.timeLog);

                var workHours = 0d;
                var undertimeHours = 0d;
                var lateHours = 0d;
                var overtimeHours = 0d;

                if (wDays.Any() && atts.Any())
                {
                    workHours = wDays
                        .Sum(x =>
                        {
                            var hours = new TimeSpan(x.toTimeHour, x.toTimeMinute, 0).TotalHours - new TimeSpan(x.fromTimeHour, x.fromTimeMinute, 0).TotalHours;
                            hours -= x.breakHours;
                            return hours;
                        });

                    foreach (var wd in wDays)
                    {
                        var dutyOn = atts.Where(x => (TIME_LOG_TYPE)x.timeLogType == TIME_LOG_TYPE.DutyOn && x.workDayId == wd.id).FirstOrDefault();
                        var dutyOff = atts.Where(x => (TIME_LOG_TYPE)x.timeLogType == TIME_LOG_TYPE.DutyOff && x.workDayId == wd.id).FirstOrDefault();
                        if (dutyOn == null) continue;
                        if (dutyOff == null) continue;

                        var totalHoursOnCurrentDay = (dutyOff.timeLog - dutyOn.timeLog).TotalHours - wd.breakHours;

                        if (dutyOn.timeLog > dutyOn.timeLog.Date.AddHours(wd.fromTimeHour).AddMinutes(wd.fromTimeMinute))
                        {
                            lateHours += (dutyOn.timeLog - dutyOn.timeLog.Date.AddHours(wd.fromTimeHour).AddMinutes(wd.fromTimeMinute)).TotalHours;
                        }
                        if (dutyOff.timeLog < dutyOff.timeLog.Date.AddHours(wd.toTimeHour).AddMinutes(wd.toTimeMinute))
                        {
                            undertimeHours += (dutyOff.timeLog.Date.AddHours(wd.toTimeHour).AddMinutes(wd.toTimeMinute) - dutyOff.timeLog).TotalHours;
                        }
                        //workHours -= lateHours;
                        //workHours -= undertimeHours;
                        if (_201.entitledOvertime == true)
                        {
                            overtimeHours = (dutyOff.timeLog - dutyOff.timeLog.Date.AddHours(wd.toTimeHour).AddMinutes(wd.toTimeMinute)).TotalHours;
                            if (overtimeHours < 0)
                                overtimeHours = 0; ;
                        }
                    }
                }

                bool absent = wDays.Any() && workHours == 0;

                if (_holidayService.IsHolidayDate(date.Date)) {
                    absent = false; 
                }

                eda.ta_CutOffAttendanceSummaryDetails.Add(new ta_CutOffAttendanceSummaryDetail()
                {
                    workHours = workHours,
                    undertimeHours = undertimeHours,
                    lateHours = lateHours,
                    overtimeHours = overtimeHours,
                    workDate = date,
                    absent = absent,
                    updatedBy = userId,
                    ObjectState = ObjectState.Added,
                });

                date = date.AddDays(1);
            }
        }

        public void CutOffAttendance_UpdateStatus(int id, CUT_OFF_ATTENDANCE status)
        {
            var userId = this.GetCurrentUserId();
            var upt = this._repoCutOffAttendance.Find(id);

            upt.status = (int)status;
            upt.updatedBy = userId;
            upt.updatedDate = DateTime.Now;
            this._repoCutOffAttendance.Update(upt);
            this._unitOfWork.Save();
        }
    }
}