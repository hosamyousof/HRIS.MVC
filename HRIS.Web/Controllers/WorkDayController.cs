using Common;
using HRIS.Model;
using HRIS.Model.Configuration;
using HRIS.Service.Configuration;
using HRIS.Web.Framework;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Linq;
using System.Web.Mvc;

namespace HRIS.Web.Controllers
{
    public class WorkDayController : BaseController
    {
        private readonly IWorkDayService _workDayService;

        public WorkDayController(IWorkDayService workDayService)
        {
            this._workDayService = workDayService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WorkDayList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._workDayService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ReferenceModelList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._workDayService.GetQuery().Select(x => new DataReference()
            {
                value = x.id.Value,
                description = x.description
            });
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult WorkDayCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , WorkDayModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            _workDayService.Create(model, out Guid workDayId);
                            model.id = workDayId;
                            break;
                        case UpdateType.Update:
                            this._workDayService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._workDayService.Delete(model.id.Value);
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
                model = this._workDayService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
    }
}