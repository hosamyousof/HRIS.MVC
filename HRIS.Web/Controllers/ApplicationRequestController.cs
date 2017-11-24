using HRIS.Model.Configuration;
using HRIS.Model.LeaveMgmt;
using HRIS.Service.Configuration;
using HRIS.Service.LeaveMgmt;
using HRIS.Web.Framework;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

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

        public ActionResult DepartmentSectionApproverList([DataSourceRequest] DataSourceRequest request, Guid? requestTypeId, Guid? sectionId)
        {
            var data = this._applicationRequestTypeService.GetApplicationRequestApprover(sectionId ?? Guid.Empty, requestTypeId ?? Guid.Empty);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DepartmentSectionApproverListUpdate([DataSourceRequest] DataSourceRequest request
            , Guid requestTypeId
            , Guid sectionId
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
            , Guid requestTypeId
            , Guid sectionId
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
        public ActionResult DepartmentSectionApproverAdd(Guid approverId, Guid sectionId, Guid requestTypeId)
        {
            try
            {
                Guid applicationRequestDepartmentSectionApproverId = Guid.Empty;
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
                var data = this._applicationRequestService.GetById(model.id ?? Guid.Empty);
                return this.JsonResultSuccess(new { data });
            }
            catch (Exception ex)
            {
                return this.JsonResultError(ex);
            }
        }
    }
}