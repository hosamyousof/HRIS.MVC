using HRIS.Model;
using HRIS.Model.Sys;
using HRIS.Model.MasterFile;
using HRIS.Service.Sys;
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
    public class LocationController : BaseController
    {
        private readonly ILocationService _LocationService;

        public LocationController(ILocationService LocationService)
        {
            this._LocationService = LocationService;
        }

        public ActionResult LocationCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , LocationModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int LocationId;
                            this._LocationService.Create(model, out LocationId);
                            model.id = LocationId;
                            break;
                        case UpdateType.Update:
                            this._LocationService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._LocationService.Delete(model.id.Value);
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
                model = this._LocationService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult LocationList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._LocationService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ValueTextList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._LocationService.GetQuery().Select(x => new ValueText() { Value = x.id.Value.ToString(), Text = x.description });
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
