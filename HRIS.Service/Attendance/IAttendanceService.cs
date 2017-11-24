using HRIS.Model;
using HRIS.Model.Attendance;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HRIS.Service.Attendance
{
    public interface IAttendanceService
    {
        bool CheckIfEmployeeAttendanceHasRecord(DateTime startDate, DateTime endDate);

        bool CheckIfEmployeeAttendanceHasWorkDay(DateTime startDate, DateTime endDate);

        CutOffAttendanceModel CutOffAttendanceGetById(int id);

        CutOffAttendanceModel CutOffAttendanceGetBySummaryId(int cutOffAttendanceSummaryId);

        IQueryable<CutOffAttendanceListModel> CutOffAttendanceListModelGetQuery();

        IQueryable<CutOffAttendanceSummaryDetailModel> CutOffAttendanceSummaryDetailGetByCutOffAttendanceSummaryId(int cutOffAttendanceSummaryId);

        void CutOffAttendanceSummaryDetailUpdate(CutOffAttendanceSummaryDetailModel model);

        IQueryable<CutOffAttendanceSummaryModel> CutOffAttendanceSummaryGetByCutOffAttendanceId(int cutOffAttendanceId);

        void CutOffAttendanceUpdateStatus(int id, CUT_OFF_ATTENDANCE status, string remarks);

        void GenerateCutOffAttendance(GenerateCutOffAttendance model, out int cutOffAttendanceId);

        IQueryable<EmployeeAttendanceModel> GetEmployeeAttendance(int? payrollId, int? employeeId, DateTime? startDate, DateTime? endDate);

        IQueryable<EmployeeCutOffAttendanceListModel> GetEmployeeCutOffAttendanceList();

        void SaveManualTimeLog(ManualTimeLogModel model);

        void UpdateWorkDaysAttendance(EmployeeAttendanceModel attendance);
        void CutOffAttendance_UpdateStatus(int id, CUT_OFF_ATTENDANCE status);
    }
}