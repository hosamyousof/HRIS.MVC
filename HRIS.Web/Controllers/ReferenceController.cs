using HRIS.Model;
using HRIS.Service.Sys;
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
    public class ReferenceController : BaseController
    {
        private readonly IEnumReferenceService _enumReferenceService;

        public ReferenceController(IEnumReferenceService enumReferenceService)
        {
            this._enumReferenceService = enumReferenceService;
        }

        public ActionResult GetReference([DataSourceRequest] DataSourceRequest request, ReferenceList name)
        {
            var data = this._enumReferenceService.GetQuery(name);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}