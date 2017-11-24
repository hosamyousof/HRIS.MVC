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
    public class HolidayController : BaseController
    {
        private readonly IHolidayService _HolidayService;

        public HolidayController(IHolidayService HolidayService)
        {
            this._HolidayService = HolidayService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HolidayList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._HolidayService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult HolidayCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , HolidayModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int HolidayId;
                            this._HolidayService.Create(model, out HolidayId);
                            model.id = HolidayId;
                            break;
                        case UpdateType.Update:
                            this._HolidayService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._HolidayService.Delete(model.id.Value);
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
                model = this._HolidayService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
    }
}
