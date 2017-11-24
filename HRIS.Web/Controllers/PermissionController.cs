using HRIS.Model;
using HRIS.Model.Sys;
using HRIS.Service.Sys;
using HRIS.Web.Framework;
using HRIS.Web.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace HRIS.Web.Controllers
{
    public class PermissionController : BaseController
    {
        private readonly IPermissionService _permissionService;
        public PermissionController(IPermissionService permissionService)
        {
            this._permissionService = permissionService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PermissionCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , PermissionModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int userId;
                            this._permissionService.Create(model, out userId);
                            model.id = userId;
                            break;
                        case UpdateType.Update:
                            this._permissionService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._permissionService.Delete(model.id.Value);
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
                model = this._permissionService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult PermissionList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._permissionService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}