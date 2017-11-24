using Common;
using HRIS.Model;
using HRIS.Model.Sys;
using HRIS.Service.Sys;
using HRIS.Web.Framework;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Linq;
using System.Web.Mvc;

namespace HRIS.Web.Controllers
{
    public class MenuController : BaseController
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            this._menuService = menuService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._menuService.GetQuery();

            var parentMenu = (Kendo.Mvc.FilterDescriptor)request.Filters.FirstOrDefault(f => ((Kendo.Mvc.FilterDescriptor)f).Member == "parentMenu");

            if (parentMenu != null)
            {
                parentMenu.Member = "parentMenu.value";
            }

            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetReferenceModelList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._menuService.GetQuery()
                .Select(x => new DataReference()
                {
                    value = x.id.Value,
                    description = x.description,
                });
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult MenuCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , MenuModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            Guid menuId;
                            this._menuService.Create(model, out menuId);
                            model.id = menuId;
                            break;
                        case UpdateType.Update:
                            this._menuService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._menuService.Delete(model.id.Value);
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
                model = this._menuService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
    }
}