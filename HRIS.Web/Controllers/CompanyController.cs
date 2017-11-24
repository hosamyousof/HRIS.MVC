using HRIS.Model.Sys;
using HRIS.Service.Configuration;
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
    public class CompanyController : BaseController
    {
        private readonly ICompanyService _companyService;
        private readonly ICountryService _countryService;
        private readonly ISettingService _settingService;

        public CompanyController(ISettingService settingService
            , ICountryService countryService
            , ICompanyService companyService)
        {
            this._settingService = settingService;
            this._companyService = companyService;
            this._countryService = countryService;
        }

        public ActionResult AjaxUpdateCompanyInformation(CompanyModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this._companyService.UpdateCurrentCompany(model);
                }
            }
            catch (Exception ex)
            {
                this.AddModelError(ex);
            }
            return this.JsonResultWithModelStateInfo(successMsg: "Company successfully update.");
        }

        public ActionResult CompanyInformation()
        {
            var model = this._companyService.GetCurrentCompany();
            this.PrepareCompanyModel(model);
            return PartialView("_CompanyInformation", model);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetSettings()
        {
            return PartialView("_SettingList");
        }

        public ActionResult SettingList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._settingService.GetSettingList();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SettingUpdate([DataSourceRequest] DataSourceRequest request, SettingModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    this._settingService.Update(model.settingId.Value, model.value);
                    model = this._settingService.GetSettingList().FirstOrDefault(x => x.settingId == model.settingId);
                }
                catch (Exception ex)
                {
                    this.AddModelError(ex);
                }
            }

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        private void PrepareCompanyModel(CompanyModel model)
        {
            model.CountryList = this._countryService.GetQuery().ToList();
        }
    }
}