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
    public class DeductionController : BaseController
    {
        private readonly IDeductionService _deductionService;

        public DeductionController(IDeductionService deductionService)
        {
            this._deductionService = deductionService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeductionList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._deductionService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DeductionCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , DeductionModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int deductionId;
                            this._deductionService.Create(model, out deductionId);
                            model.id = deductionId;
                            break;
                        case UpdateType.Update:
                            this._deductionService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._deductionService.Delete(model.id.Value);
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
                model = this._deductionService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
    }
}
