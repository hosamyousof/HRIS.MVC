using HRIS.Model.Attendance;
using HRIS.Service.Attendance;
using HRIS.Web.Framework;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRIS.Web.Controllers
{
    public class AttendanceController : BaseController
    {
        private readonly IAttendanceService _attendanceService;

        public AttendanceController(IAttendanceService attendanceService)
        {
            this._attendanceService = attendanceService;
        }

        public ActionResult _ManualTimeLog()
        {
            return PartialView();
        }

        public ActionResult _GenerateCutOffAttendanceEntry()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult AjaxGenerateCutOffAttendance(GenerateCutOffAttendance model)
        {
            try
            {
                if (model.payrollGroupId == 0)
                    throw new Exception("Please select Payroll Group.");

                //if (!this._attendanceService.CheckIfEmployeeAttendanceHasWorkDay(model.startDate, model.endDate))
                //{
                //    return this.JsonResultError(new Exception(), new { thereIsNoWorkDay = true });
                //}

                //if (!this._attendanceService.CheckIfEmployeeAttendanceHasRecord(model.startDate, model.endDate))
                //{
                //    return this.JsonResultError(new Exception(), new { noRecordAttendance = true });
                //}

                int dailyAttendanceId = 0;
                this._attendanceService.GenerateCutOffAttendance(model, out dailyAttendanceId);
                return this.JsonResultSuccess(new { id = dailyAttendanceId });
            }
            catch (Exception ex)
            {
                return this.JsonResultError(ex);
            }
        }

        [HttpPost]
        public ActionResult AjaxSaveManualTimeLog(ManualTimeLogModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this._attendanceService.SaveManualTimeLog(model);
                }
            }
            catch (Exception ex)
            {
                this.AddModelError(ex);
            }
            return this.JsonResultWithModelStateInfo(successMsg: "New Time Log has been save.");
        }

        public ActionResult CutOffAttendanceListModelGetQuery([DataSourceRequest] DataSourceRequest request
            , DateTime? generatedDate
            , int? status
            , int? payrollGroupId)
        {

            var data = this._attendanceService.CutOffAttendanceListModelGetQuery();

            if (status.HasValue)
            {
                data = data.Where(x => x.statusId == status);
            }
            if (payrollGroupId.HasValue)
            {
                data = data.Where(x => x.payrollGroupId == payrollGroupId);
            }

            if (generatedDate.HasValue)
            {
                data = data.Where(x => x.generatedDate == generatedDate);
            }

            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult EmployeeAttendanceUpdate([DataSourceRequest] DataSourceRequest request, EmployeeAttendanceModel model)
        {
            var results = new List<EmployeeAttendanceModel>();

            if (model != null)
            {
                try
                {
                    this._attendanceService.UpdateWorkDaysAttendance(model);
                    results.Add(model);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            return Json(results.ToDataSourceResult(request, ModelState));
        }

        public ActionResult CutOffAttendance()
        {
            return View();
        }

        public ActionResult GetEmployeeAttendance([DataSourceRequest] DataSourceRequest request
            , int? payrollId
            , int? employeeId
            , DateTime? startDate
            , DateTime? endDate
            )
        {
            var data = this._attendanceService.GetEmployeeAttendance(payrollId, employeeId, startDate, endDate);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CutOffAttendanceSummaryGetByCutOffAttendanceId([DataSourceRequest] DataSourceRequest request, int cutOffAttendanceId)
        {
            var data = this._attendanceService.CutOffAttendanceSummaryGetByCutOffAttendanceId(cutOffAttendanceId);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [Route("EmployeeAttendance")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UpdateWorkDayAttendance()
        {
            return View();
        }

        public ActionResult ViewCutOffSummary(int id)
        {
            var model = this._attendanceService.CutOffAttendanceGetById(id);
            return PartialView("_ViewCutOffSummary", model);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="id">cutOffAttendanceSummaryId</param>
        /// <returns></returns>
        public ActionResult ViewSummaryDetails(int id)
        {
            return PartialView("_ViewSummaryDetails", id);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="request"></param>
        /// <param name="id">cutOffAttendanceSummaryId</param>
        /// <returns></returns>
        public ActionResult SummaryDetailList([DataSourceRequest] DataSourceRequest request, int id)
        {
            var data = this._attendanceService.CutOffAttendanceSummaryDetailGetByCutOffAttendanceSummaryId(id);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SummaryDetailUpdate([DataSourceRequest] DataSourceRequest request, CutOffAttendanceSummaryDetailModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    this._attendanceService.CutOffAttendanceSummaryDetailUpdate(model);
                }
                catch (Exception ex)
                {
                    this.AddModelError(ex);
                }
            }

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult CutOffAttendanceStatusUpdate(CutOffAttendanceModel model)
        {
            try
            {
                model.status = model.statusEnum.ToString();
                this._attendanceService.CutOffAttendance_UpdateStatus(model.id, model.statusEnum);
                return JsonResultSuccess(model);
            }
            catch (Exception ex)
            {
                return this.JsonResultError(ex);
            }
        }
    }
}