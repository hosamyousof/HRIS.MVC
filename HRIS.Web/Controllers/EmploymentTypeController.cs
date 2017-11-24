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
    public class EmploymentTypeController : BaseController
    {
        private readonly IEmploymentTypeService _employmentTypeService;

        public EmploymentTypeController(IEmploymentTypeService employmentTypeService)
        {
            this._employmentTypeService = employmentTypeService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmploymentTypeList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._employmentTypeService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult EmploymentTypeCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , EmploymentTypeModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int employmentTypeId;
                            this._employmentTypeService.Create(model, out employmentTypeId);
                            model.id = employmentTypeId;
                            break;
                        case UpdateType.Update:
                            this._employmentTypeService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._employmentTypeService.Delete(model.id.Value);
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
                model = this._employmentTypeService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
    }
}
