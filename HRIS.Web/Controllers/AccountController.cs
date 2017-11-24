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
    public class AccountController : BaseController
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            this._userService = userService;
        }

        [Route("MyProfile")]
        public ActionResult MyProfile()
        {
            var model = this._userService.GetCurrentAccountProfile();
            return View(model);
        }

        [Route("MyProfile")]
        [HttpPost]
        public ActionResult MyProfile(AccountProfileModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this._userService.UpdateProfile(model);
                    model = this._userService.GetCurrentAccountProfile();
                }
            }
            catch (Exception ex)
            {
                this.AddModelError(ex);
            }
            return View(model);
        }

        [Route("Register")]
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        #region User Maintenance

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UserCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , UserModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            int userId;
                            this._userService.Create(model, out userId);
                            model.id = userId;
                            break;

                        case UpdateType.Update:
                            this._userService.Update(model);
                            break;

                        case UpdateType.Destroy:
                            this._userService.Delete(model.id.Value);
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
                model = this._userService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult UserList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._userService.GetQuery();

            var userStatus = (Kendo.Mvc.FilterDescriptor)request.Filters.FirstOrDefault(f => ((Kendo.Mvc.FilterDescriptor)f).Member == "UserStatus");

            if (userStatus != null)
            {
                userStatus.Member = "UserStatus.value";
            }
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UserMaintenance()
        {
            return View();
        }

        #endregion User Maintenance

        #region Login / Log Off

        [Route("Login")]
        [AllowAnonymous]
        public ActionResult Login(string ReturnUrl)
        {
            var model = new LoginModel(); 
            return View(model);
        }

        [Route("Login")]
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginModel model, string ReturnUrl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int sessionId = 0;
                    this._userService.ValidateLogin(model.CompanyCode, model.Username, model.Password, out sessionId);
                    FormsAuthentication.SetAuthCookie(sessionId.ToString() + "-" + model.Username, true);
                    return RedirectToUrl(Url.Content("~/"));
                }
            }
            catch (Exception ex)
            {
                this.AddModelError(ex);
            }
            return View(model);
        }

        [AllowAnonymous]
        [Route("LogOff")]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToUrl(Url.Content("~/"));
        }

        #endregion Login / Log Off
    }
}