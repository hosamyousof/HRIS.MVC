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
    public class AgencyController : BaseController
    {
        private readonly IAgencyService _agencyService;

        public AgencyController(IAgencyService agencyService)
        {
            this._agencyService = agencyService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AgencyList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._agencyService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AgencyCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , AgencyModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int agencyId;
                            this._agencyService.Create(model, out agencyId);
                            model.id = agencyId;
                            break;
                        case UpdateType.Update:
                            this._agencyService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._agencyService.Delete(model.id.Value);
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
                model = this._agencyService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
    }
}
