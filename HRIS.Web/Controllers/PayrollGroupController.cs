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
    public class PayrollGroupController : BaseController
    {
        private readonly IPayrollGroupService _payrollGroupService;

        public PayrollGroupController(IPayrollGroupService payrollGroupService)
        {
            this._payrollGroupService = payrollGroupService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PayrollGroupList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._payrollGroupService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ValueTextList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._payrollGroupService.GetQuery().Select(x => new ValueText()
            {
                Value = x.id.Value.ToString(),
                Text = x.description,
            });
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult PayrollGroupCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , PayrollGroupModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int payrollGroupId;
                            this._payrollGroupService.Create(model, out payrollGroupId);
                            model.id = payrollGroupId;
                            break;
                        case UpdateType.Update:
                            this._payrollGroupService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._payrollGroupService.Delete(model.id.Value);
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
                model = this._payrollGroupService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
    }
}
