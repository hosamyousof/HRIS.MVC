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
    public class PositionController : BaseController
    {
        private readonly IPositionService _positionService;

        public PositionController(IPositionService positionService)
        {
            this._positionService = positionService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PositionCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , PositionModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int positionId;
                            this._positionService.Create(model, out positionId);
                            model.id = positionId;
                            break;
                        case UpdateType.Update:
                            this._positionService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._positionService.Delete(model.id.Value);
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
                model = this._positionService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult PositionList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._positionService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ValueTextList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._positionService.GetQuery().Select(x => new ValueText() { Value = x.id.Value.ToString(), Text = x.description });
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
