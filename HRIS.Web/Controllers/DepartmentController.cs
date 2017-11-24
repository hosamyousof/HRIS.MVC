using HRIS.Model;
using HRIS.Model.Configuration;
using HRIS.Model.MasterFile;
using HRIS.Model.Sys;
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
    public class DepartmentController : BaseController
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            this._departmentService = departmentService;
        }

        #region Department

        public ActionResult DepartmentCRUD([DataSourceRequest] DataSourceRequest request
          , UpdateType updateType
          , DepartmentModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int departmentId;
                            this._departmentService.Create(model, out departmentId);
                            model.id = departmentId;
                            break;
                        case UpdateType.Update:
                            this._departmentService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._departmentService.Delete(model.id.Value);
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
                model = this._departmentService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult DepartmentList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._departmentService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReferenceModelList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._departmentService.GetQuery().Select(x => new ReferenceModel() { value = x.id.Value, description = x.description });
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ValueTextList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._departmentService.GetQuery().Select(x => new ValueText() { Value = x.id.Value.ToString(), Text = x.description });
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        #endregion Department

        #region Section

        public ActionResult DepartmentSectionCRUD([DataSourceRequest] DataSourceRequest request
                  , UpdateType updateType
          , DepartmentSectionModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int departmentId;
                            this._departmentService.SectionCreate(model, out departmentId);
                            model.id = departmentId;
                            break;
                        case UpdateType.Update:
                            this._departmentService.SectionUpdate(model);
                            break;
                        case UpdateType.Destroy:
                            this._departmentService.SectionDelete(model.id.Value);
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
                model = this._departmentService.SectionGetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult DepartmentSectionList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._departmentService.SectionGetQuery();

            var department = (Kendo.Mvc.FilterDescriptor)request.Filters.FirstOrDefault(f => ((Kendo.Mvc.FilterDescriptor)f).Member == "department");

            if (department != null)
            {
                department.Member = "department.value";
            }

            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Section()
        {
            return View();
        }

        public ActionResult SectionReferenceModelList([DataSourceRequest] DataSourceRequest request, int? departmentId)
        {
            if (departmentId.HasValue)
            {
                var data = this._departmentService.SectionGetQuery().Where(x => x.department.value == departmentId.Value).Select(x => new ReferenceModel() { value = x.id.Value, description = x.description });
                var result = data.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new List<ReferenceModel>().ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
            }
        }

        #endregion Section
    }
}