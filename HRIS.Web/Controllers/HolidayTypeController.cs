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
    public class HolidayTypeController : BaseController
    {
        private readonly IHolidayTypeService _HolidayTypeService;

        public HolidayTypeController(IHolidayTypeService HolidayTypeService)
        {
            this._HolidayTypeService = HolidayTypeService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HolidayTypeList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._HolidayTypeService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult HolidayTypeCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , HolidayTypeModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int HolidayTypeId;
                            this._HolidayTypeService.Create(model, out HolidayTypeId);
                            model.id = HolidayTypeId;
                            break;
                        case UpdateType.Update:
                            this._HolidayTypeService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._HolidayTypeService.Delete(model.id.Value);
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
                model = this._HolidayTypeService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
    }
}
