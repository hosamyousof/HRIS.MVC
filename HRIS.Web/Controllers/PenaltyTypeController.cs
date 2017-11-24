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
    public class PenaltyTypeController : BaseController
    {
        private readonly IPenaltyTypeService _PenaltyTypeService;

        public PenaltyTypeController(IPenaltyTypeService PenaltyTypeService)
        {
            this._PenaltyTypeService = PenaltyTypeService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PenaltyTypeList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._PenaltyTypeService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult PenaltyTypeCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , PenaltyTypeModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int PenaltyTypeId;
                            this._PenaltyTypeService.Create(model, out PenaltyTypeId);
                            model.id = PenaltyTypeId;
                            break;
                        case UpdateType.Update:
                            this._PenaltyTypeService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._PenaltyTypeService.Delete(model.id.Value);
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
                model = this._PenaltyTypeService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
    }
}
