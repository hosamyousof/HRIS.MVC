using HRIS.Model;
using HRIS.Model.Sys;
using HRIS.Model.MasterFile;
using HRIS.Service.Sys;
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
    public class IdentificationDocumentController : BaseController
    {
        private readonly IIdentificationDocumentService _identificationDocumentService;

        public IdentificationDocumentController(IIdentificationDocumentService identificationDocumentService)
        {
            this._identificationDocumentService = identificationDocumentService;
        }

        public ActionResult IdentificationDocumentCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , IdentificationDocumentModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int IdentificationDocumentId;
                            this._identificationDocumentService.Create(model, out IdentificationDocumentId);
                            model.id = IdentificationDocumentId;
                            break;
                        case UpdateType.Update:
                            this._identificationDocumentService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._identificationDocumentService.Delete(model.id.Value);
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
                model = this._identificationDocumentService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult IdentificationDocumentList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._identificationDocumentService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ValueTextList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._identificationDocumentService.GetQuery().Select(x => new ValueText() { Value = x.id.Value.ToString(), Text = x.description });
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
