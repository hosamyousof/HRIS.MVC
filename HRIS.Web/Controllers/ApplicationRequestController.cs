using HRIS.Model;
using HRIS.Model.Configuration;
using HRIS.Model.MasterFile;
using HRIS.Service.Configuration;
using HRIS.Service.MasterFile;
using HRIS.Web.Framework;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRIS.Model.LeaveMgmt;
using HRIS.Service.LeaveMgmt;

namespace HRIS.Web.Controllers
{
    public class ApplicationRequestController : BaseController
    {
        private readonly IDepartmentService _departmentService;
        private readonly IApplicationRequestTypeService _applicationRequestTypeService;
        private readonly IApplicationRequestService _applicationRequestService;

        public ApplicationRequestController(IApplicationRequestTypeService applicationRequestTypeService
            , IDepartmentService departmentService
            , IApplicationRequestService applicationRequestService)
        {
            this._applicationRequestTypeService = applicationRequestTypeService;
            this._departmentService = departmentService;
            this._applicationRequestService = applicationRequestService;
        }

        public ActionResult DepartmentSectionApproverList([DataSourceRequest] DataSourceRequest request, int? requestTypeId, int? sectionId)
        {
            var data = this._applicationRequestTypeService.GetApplicationRequestApprover(sectionId ?? 0, requestTypeId ?? 0);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DepartmentSectionApproverListUpdate([DataSourceRequest] DataSourceRequest request
            , int requestTypeId
            , int sectionId
            , [Bind(Prefix = "models")]IEnumerable<DepartmentSectionRequestApproverModel> models)
        {
            if (models != null && ModelState.IsValid)
            {
                try
                {
                    this._applicationRequestTypeService.DepartmentSectionRequestApproverUpdate(sectionId, requestTypeId, models);
                }
                catch (Exception ex)
                {
                    this.AddModelError(ex);
                }
            }
            return Json(models.ToDataSourceResult(request, ModelState));
        }

        public ActionResult DepartmentSectionApproverListDelete([DataSourceRequest] DataSourceRequest request
            , int requestTypeId
            , int sectionId
            , [Bind(Prefix = "models")]IEnumerable<DepartmentSectionRequestApproverModel> models)
        {
            if (models != null && ModelState.IsValid)
            {
                try
                {
                    this._applicationRequestTypeService.DepartmentsectionRequestApproverDelete(sectionId, requestTypeId, models);
                }
                catch (Exception ex)
                {
                    this.AddModelError(ex);
                }
            }
            return Json(models.ToDataSourceResult(request, ModelState));
        }


        [HttpPost]
        public ActionResult DepartmentSectionApproverAdd(int approverId, int sectionId, int requestTypeId)
        {
            try
            {
                int applicationRequestDepartmentSectionApproverId;
                this._applicationRequestTypeService.DepartmentSectionRequestApproverAdd(sectionId, requestTypeId, approverId, out applicationRequestDepartmentSectionApproverId);
            }
            catch (Exception ex)
            {
                this.AddModelError(ex);
            }
            return this.JsonResultWithModelStateInfo(successMsg: "Approver successfully add.");
        }

        [Route("ApplicationRequestApprover")]
        public ActionResult DepartmentSectionApprover()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetRequestTypeAll([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._applicationRequestTypeService.GetValueTextList();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult RequestTypeAdd(ApplicationRequestModel model)
        {
            try
            {               
                this._applicationRequestService.RequestTypeAdd(model);                               
                var data = this._applicationRequestService.GetByID(model.id??0);
                return this.JsonResultSuccess(new { data });
            }
            catch (Exception ex)
            {
                return this.JsonResultError(ex);
            }
        }


    }
}