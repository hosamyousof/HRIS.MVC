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
    public class AllowanceController : BaseController
    {
        private readonly IAllowanceService _allowanceService;

        public AllowanceController(IAllowanceService allowanceService)
        {
            this._allowanceService = allowanceService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllowanceList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._allowanceService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AllowanceCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , AllowanceModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int allowanceId;
                            this._allowanceService.Create(model, out allowanceId);
                            model.id = allowanceId;
                            break;
                        case UpdateType.Update:
                            this._allowanceService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._allowanceService.Delete(model.id.Value);
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
                model = this._allowanceService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
    }
}
