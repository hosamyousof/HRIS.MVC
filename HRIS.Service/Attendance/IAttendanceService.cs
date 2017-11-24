using HRIS.Model;
using HRIS.Model.Attendance;
using System;
using System.Linq;

namespace HRIS.Service.Attendance
{
    public interface IAttendanceService
    {
        bool CheckIfEmployeeAttendanceHasRecord(DateTime startDate, DateTime endDate);

        bool CheckIfEmployeeAttendanceHasWorkDay(DateTime startDate, DateTime endDate);

        CutOffAttendanceModel CutOffAttendanceGetById(Guid id);

        CutOffAttendanceModel CutOffAttendanceGetBySummaryId(Guid cutOffAttendanceSummaryId);

        IQueryable<CutOffAttendanceListModel> CutOffAttendanceListModelGetQuery();

        IQueryable<CutOffAttendanceSummaryDetailModel> CutOffAttendanceSummaryDetailGetByCutOffAttendanceSummaryId(Guid cutOffAttendanceSummaryId);

        void CutOffAttendanceSummaryDetailUpdate(CutOffAttendanceSummaryDetailModel model);

        IQueryable<CutOffAttendanceSummaryModel> CutOffAttendanceSummaryGetByCutOffAttendanceId(Guid cutOffAttendanceId);

        void CutOffAttendanceUpdateStatus(Guid id, CUT_OFF_ATTENDANCE status, string remarks);

        void GenerateCutOffAttendance(GenerateCutOffAttendance model, out Guid cutOffAttendanceId);

        IQueryable<EmployeeAttendanceModel> GetEmployeeAttendance(Guid? payrollId, Guid? employeeId, DateTime? startDate, DateTime? endDate);

        IQueryable<EmployeeCutOffAttendanceListModel> GetEmployeeCutOffAttendanceList();

        void SaveManualTimeLog(ManualTimeLogModel model);

        void UpdateWorkDaysAttendance(EmployeeAttendanceModel attendance);

        void CutOffAttendance_UpdateStatus(Guid id, CUT_OFF_ATTENDANCE status);
    }
}