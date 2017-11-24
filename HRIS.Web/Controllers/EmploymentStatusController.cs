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

namespace HRIS.Web.Controllers
{
    public class EmploymentStatusController : BaseController
    {
        private readonly IEmploymentStatusService _employmentStatusService;

        public EmploymentStatusController(IEmploymentStatusService employmentStatusService)
        {
            this._employmentStatusService = employmentStatusService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmploymentStatusList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._employmentStatusService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult EmploymentStatusCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , EmploymentStatusModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int employmentStatusId;
                            this._employmentStatusService.Create(model, out employmentStatusId);
                            model.id = employmentStatusId;
                            break;
                        case UpdateType.Update:
                            this._employmentStatusService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._employmentStatusService.Delete(model.id.Value);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    this.AddModelError(ex);
                }
            }
            if (model.id.HasValue && updateType != UpdateType.Destroy)
            {
                model = this._employmentStatusService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
    }
}
