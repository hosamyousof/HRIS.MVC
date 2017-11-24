using HRIS.Model;
using HRIS.Model.MasterFile;
using HRIS.Model.Sys;
using HRIS.Service.Configuration;
using HRIS.Service.MasterFile;
using HRIS.Service.Sys;
using HRIS.Web.Framework;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Linq;
using System.Web.Mvc;

namespace HRIS.Web.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly ICountryService _countryService;
        private readonly IEmployeeService _employeeService;
        private readonly IEmploymentStatusService _employmentStatusService;
        private readonly IEmploymentTypeService _employmentTypeService;
        private readonly IEnumReferenceService _enumReferenceService;

        public EmployeeController(IEnumReferenceService enumReferenceService
            , IEmploymentStatusService employmentStatusService
            , IEmploymentTypeService employmentTypeService
            , ICountryService countryService
            , IEmployeeService employeeService)
        {
            this._employmentTypeService = employmentTypeService;
            this._employmentStatusService = employmentStatusService;
            this._countryService = countryService;
            this._enumReferenceService = enumReferenceService;
            this._employeeService = employeeService;
        }

        public ActionResult _EmployeeDetails(int? employeeId)
        {
            return PartialView(employeeId);
        }

        [HttpPost]
        public ActionResult AjaxUpdateEmployeeBasicInfo(EmployeeBasicInfoModel model, int employeeId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this._employeeService.BasicInfoUpdate(employeeId, model);
                }
            }
            catch (Exception ex)
            {
                this.AddModelError(ex);
            }
            model.image = null;
            return this.JsonResultWithModelStateInfo(data: new
            {
                extesion = model.pictureExtension,
                path = Url.Content("~/ProfilePicture/" + employeeId + model.pictureExtension + "?v=" + Guid.NewGuid()),
            }, successMsg: "Employee Basic Information successfully saved.");
        }

        public ActionResult Create(bool confidential)
        {
            var model = new EmployeeBasicInfoModel();
            model.confidential = confidential;
            this.PrepareEmployeeBasicInfoModel(model);
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(EmployeeBasicInfoModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int employeeId;
                    this._employeeService.BasicInfoCreate(model, out employeeId);
                    return RedirectToAction("Edit", new { id = employeeId });
                }
            }
            catch (Exception ex)
            {
                this.AddModelError(ex);
            }

            this.PrepareEmployeeBasicInfoModel(model);
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            ViewBag.confidential = this._employeeService.EmployeeIsConfidential(id);
            return View(id);
        }

        public ActionResult EmployeeConfi()
        {
            ViewBag.confidential = true;
            return View("Index");
        }

        public ActionResult EmployeeNonConfi()
        {
            ViewBag.confidential = false;
            return View("Index");
        }

        [HttpPost]
        public ActionResult EmployeeNonConfidentialGetQuery([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._employeeService.EmployeeNonConfidentialGetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetEmployeeBasicInfo(int id)
        {
            var model = this._employeeService.BasicInfoGetByEmployeeId(id);
            this.PrepareEmployeeBasicInfoModel(model);
            return PartialView("_EmployeeBasicInfo", model);
        }

        [HttpPost]
        public ActionResult GetEmployeeConfidentialGetQuery([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._employeeService.EmployeeConfidentialGetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetEmployeeAll([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._employeeService.EmployeeAllGetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult QuickUpdate()
        {
            return View();
        }

        public ActionResult QuickUpdateEmployee([DataSourceRequest] DataSourceRequest request, EmployeeQuickUpdateModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    this._employeeService.QuickUpdateEmployee(model);
                }
                catch (Exception ex)
                {
                    this.AddModelError(ex);
                }
            }

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult QuickUpdateEmployeeList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._employeeService.QuickUpdateEmployeeList();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        private void PrepareEmployee201FileModel(Employee201Model model)
        {
            model.EmploymentStatusList = this._employmentStatusService.GetQuery().Select(x => new ReferenceModel() { value = x.id.Value, description = x.description }).ToList();
            model.EmploymentTypeList = this._employmentTypeService.GetQuery().Select(x => new ReferenceModel() { value = x.id.Value, description = x.description }).ToList();
            model.PositionLevelList = this._enumReferenceService.GetQuery(ReferenceList.POSITION_LEVEL).ToList();
            model.PayRateTypeList = this._enumReferenceService.GetQuery(ReferenceList.PAY_RATE_TYPE).ToList();
            model.TaxStatusList = this._enumReferenceService.GetQuery(ReferenceList.TAX_STATUS).ToList();
        }

        private void PrepareEmployeeBasicInfoModel(EmployeeBasicInfoModel model)
        {
            model.MaritalStatusList = this._enumReferenceService.GetQuery(ReferenceList.MARITAL_STATUS).ToList();
            model.GenderList = this._enumReferenceService.GetQuery(ReferenceList.GENDER).ToList();
            model.CountryList = this._countryService.GetQuery().ToList();
        }

        #region Employee 201 File

        [HttpPost]
        public ActionResult AjaxUpdateEmployee201(Employee201Model model, int employeeId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this._employeeService.Employee201Update(employeeId, model);
                }
            }
            catch (Exception ex)
            {
                this.AddModelError(ex);
            }
            return this.JsonResultWithModelStateInfo(successMsg: "Employee 201 File successfully saved.");
        }

        public ActionResult GetEmployee201File(int id)
        {
            var model = this._employeeService.Employee201FileGetByEmployeeId(id);
            if (model == null) model = new Employee201Model();
            model.employeeId = id;
            this.PrepareEmployee201FileModel(model);
            return PartialView("_Employee201File", model);
        }

        #endregion Employee 201 File

        #region Work History

        public ActionResult GetEmployeeWorkHistory(int id)
        {
            return PartialView("_EmployeeWorkHistory", id);
        }

        [HttpPost]
        public ActionResult GetEmployeeWorkHistoryList([DataSourceRequest] DataSourceRequest request, int employeeId)
        {
            var data = this._employeeService.WorkHistoryList(employeeId);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult WorkHistoryCRUD([DataSourceRequest] DataSourceRequest request
                                           , int employeeId
                   , UpdateType updateType
                   , EmployeeWorkHistoryModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int workHistoryId;
                            this._employeeService.WorkHistoryCreate(employeeId, model, out workHistoryId);
                            model = this._employeeService.WorkHistoryList(employeeId).FirstOrDefault(x => x.id == workHistoryId);
                            break;

                        case UpdateType.Update:
                            this._employeeService.WorkHistoryUpdate(employeeId, model);
                            model = this._employeeService.WorkHistoryList(employeeId).FirstOrDefault(x => x.id == model.id);
                            break;

                        case UpdateType.Destroy:
                            this._employeeService.WorkHistoryDelete(employeeId, model.id.Value);
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

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        #endregion Work History

        #region Skill

        [HttpPost]
        public ActionResult GetEmployeeSkillList([DataSourceRequest] DataSourceRequest request, int employeeId)
        {
            var data = this._employeeService.SkillList(employeeId);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetEmployeeSkills(int id)
        {
            return PartialView("_EmployeeSkill", id);
        }

        public ActionResult SkillCRUD([DataSourceRequest] DataSourceRequest request
                           , int employeeId
                   , UpdateType updateType
                   , EmployeeSkillModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                        case UpdateType.Update:
                            this._employeeService.SkillUpdate(employeeId, model);
                            model = this._employeeService.SkillList(employeeId).FirstOrDefault(x => x.id == model.id);
                            break;

                        case UpdateType.Destroy:
                            this._employeeService.SkillDelete(employeeId, model.id.Value);
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

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        #endregion Skill

        #region Training

        [HttpPost]
        public ActionResult GetEmployeeTrainingList([DataSourceRequest] DataSourceRequest request, int employeeId)
        {
            var data = this._employeeService.TrainingList(employeeId);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetEmployeeTrainings(int id)
        {
            return PartialView("_EmployeeTraining", id);
        }

        public ActionResult TrainingCRUD([DataSourceRequest] DataSourceRequest request
                           , int employeeId
                   , UpdateType updateType
                   , EmployeeTrainingModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                        case UpdateType.Update:
                            this._employeeService.TrainingUpdate(employeeId, model);
                            model = this._employeeService.TrainingList(employeeId).FirstOrDefault(x => x.id == model.id);
                            break;

                        case UpdateType.Destroy:
                            this._employeeService.TrainingDelete(employeeId, model.id.Value);
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

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        #endregion Training

        #region WorkDay

        [HttpPost]
        public ActionResult GetEmployeeWorkDayList([DataSourceRequest] DataSourceRequest request, int employeeId)
        {
            var data = this._employeeService.WorkDayList(employeeId);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetEmployeeWorkDays(int id)
        {
            return PartialView("_EmployeeWorkDay", id);
        }

        public ActionResult WorkDayUpdate([DataSourceRequest] DataSourceRequest request, int employeeId, EmployeeWorkDayModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    if (model.hasWorkDay)
                    {
                        this._employeeService.WorkDayAdd(employeeId, model.workDayId);
                    }
                    else
                    {
                        this._employeeService.WorkDayDelete(employeeId, model.workDayId);
                    }
                    model = this._employeeService.WorkDayList(employeeId).FirstOrDefault(x => x.workDayId == model.workDayId);
                }
                catch (Exception ex)
                {
                    this.AddModelError(ex);
                }
            }

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        #endregion WorkDay

        #region IdentificationDocument

        [HttpPost]
        public ActionResult GetEmployeeIdentificationDocumentList([DataSourceRequest] DataSourceRequest request, int employeeId)
        {
            var data = this._employeeService.IdentificationDocumentList(employeeId);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetEmployeeIdentificationDocuments(int id)
        {
            return PartialView("_EmployeeIdentificationDocument", id);
        }

        public ActionResult IdentificationDocumentCRUD([DataSourceRequest] DataSourceRequest request
                           , int employeeId
                   , UpdateType updateType
                   , EmployeeIdentificationDocumentModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                        case UpdateType.Update:
                            this._employeeService.IdentificationDocumentUpdate(employeeId, model);
                            model = this._employeeService.IdentificationDocumentList(employeeId).FirstOrDefault(x => x.id == model.id);
                            break;

                        case UpdateType.Destroy:
                            this._employeeService.IdentificationDocumentDelete(model.id.Value);
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

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        #endregion IdentificationDocument

        #region Offense

        [HttpPost]
        public ActionResult GetEmployeeOffenseList([DataSourceRequest] DataSourceRequest request, int employeeId)
        {
            var data = this._employeeService.OffenseList(employeeId);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetEmployeeOffenses(int id)
        {
            return PartialView("_EmployeeOffense", id);
        }

        public ActionResult OffenseCRUD([DataSourceRequest] DataSourceRequest request, int employeeId, UpdateType updateType, EmployeeOffenseModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                        case UpdateType.Update:
                            this._employeeService.OffenseUpdate(employeeId, model);
                            model = this._employeeService.OffenseList(employeeId).FirstOrDefault(x => x.id == model.id);
                            break;

                        case UpdateType.Destroy:
                            this._employeeService.OffenseDelete(model.id.Value);
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

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        #endregion Offense

        #region Allowance

        [HttpPost]
        public ActionResult GetEmployeeAllowanceList([DataSourceRequest] DataSourceRequest request, int employeeId)
        {
            var data = this._employeeService.AllowanceList(employeeId);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetEmployeeAllowances(int id)
        {
            return PartialView("_EmployeeAllowance", id);
        }

        public ActionResult AllowanceCRUD([DataSourceRequest] DataSourceRequest request, int employeeId, UpdateType updateType, EmployeeAllowanceModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                        case UpdateType.Update:
                            this._employeeService.AllowanceUpdate(employeeId, model);
                            model = this._employeeService.AllowanceList(employeeId).FirstOrDefault(x => x.id == model.id);
                            break;

                        case UpdateType.Destroy:
                            this._employeeService.AllowanceDelete(model.id.Value);
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

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        #endregion Allowance

        #region Deduction

        [HttpPost]
        public ActionResult GetEmployeeDeductionList([DataSourceRequest] DataSourceRequest request, int employeeId)
        {
            var data = this._employeeService.DeductionList(employeeId);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetEmployeeDeductions(int id)
        {
            return PartialView("_EmployeeDeduction", id);
        }

        public ActionResult DeductionCRUD([DataSourceRequest] DataSourceRequest request, int employeeId, UpdateType updateType, EmployeeDeductionModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                        case UpdateType.Update:
                            this._employeeService.DeductionUpdate(employeeId, model);
                            model = this._employeeService.DeductionList(employeeId).FirstOrDefault(x => x.id == model.id);
                            break;

                        case UpdateType.Destroy:
                            this._employeeService.DeductionDelete(model.id.Value);
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

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        #endregion Deduction

        #region BasicPay

        [HttpPost]
        public ActionResult GetEmployeeBasicPayList([DataSourceRequest] DataSourceRequest request, int employeeId)
        {
            var data = this._employeeService.BasicPayList(employeeId);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetEmployeeBasicPays(int id)
        {
            return PartialView("_EmployeeBasicPay", id);
        }

        public ActionResult BasicPayCRUD([DataSourceRequest] DataSourceRequest request, int employeeId, UpdateType updateType, EmployeeBasicPayModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                        case UpdateType.Update:
                            this._employeeService.BasicPayUpdate(employeeId, model);
                            model = this._employeeService.BasicPayList(employeeId).FirstOrDefault(x => x.id == model.id);
                            break;

                        case UpdateType.Destroy:
                            this._employeeService.BasicPayDelete(model.id.Value);
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

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        #endregion BasicPay

        #region BalanceLeave

        [HttpPost]
        public ActionResult GetEmployeeBalanceLeaveList([DataSourceRequest] DataSourceRequest request, int employeeId)
        {
            var data = this._employeeService.BalanceLeaveList(employeeId);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetEmployeeBalanceLeaves(int id)
        {
            return PartialView("_EmployeeBalanceLeave", id);
        }

        public ActionResult BalanceLeaveCRUD([DataSourceRequest] DataSourceRequest request, int employeeId, UpdateType updateType, EmployeeBalanceLeaveModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                        case UpdateType.Update:
                            this._employeeService.BalanceLeaveUpdate(employeeId, model);
                            model = this._employeeService.BalanceLeaveList(employeeId).FirstOrDefault(x => x.id == model.id);
                            break;

                        case UpdateType.Destroy:
                            this._employeeService.BalanceLeaveDelete(model.id.Value);
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

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        #endregion BalanceLeave
    }
}