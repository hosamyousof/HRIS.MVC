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
    public class OffenseController : BaseController
    {
        private readonly IOffenseService _offenseService;

        public OffenseController(IOffenseService offenseService)
        {
            this._offenseService = offenseService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OffenseList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._offenseService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult OffenseCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , OffenseModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int offenseId;
                            this._offenseService.Create(model, out offenseId);
                            model.id = offenseId;
                            break;
                        case UpdateType.Update:
                            this._offenseService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._offenseService.Delete(model.id.Value);
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
                model = this._offenseService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
    }
}
