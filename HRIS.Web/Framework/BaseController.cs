using HRIS.Model.Sys;
using HRIS.Service.Sys;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;

namespace HRIS.Web.Framework
{
    [Authorize]
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.RequestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                bool isValid = false;
                try
                {
                    var loggedUser = filterContext.RequestContext.HttpContext.User.Identity.Name.Split('-');
                    int sessionId = int.Parse(loggedUser[0]);
                    string username = loggedUser[1];

                    var userService = DependencyResolver.Current.GetService<IUserService>();
                    isValid = userService.IsSessionValid(sessionId, username);
                    if (isValid)
                        userService.UpdateUserSessionExpiration(sessionId);
                }
                catch (Exception)
                {
                    isValid = false;
                }

                if (isValid == false)
                {
                    FormsAuthentication.SignOut();
                    filterContext.Result = new RedirectResult(Url.Content("~/Login"));
                }
            }

            base.OnActionExecuting(filterContext);
        }

        [HttpPost]
        public ActionResult Pdf_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);
            return File(fileContents, contentType, fileName);
        }

        public JsonResult JsonResultError(Exception ex, object data = null, bool logError = true)
        {
            //if (logError) ex.Log(User.Identity.Name);

            string innerException = "";
            string innerException2 = "";

            try
            {
                innerException = ex.InnerException.Message;
            }
            catch { }

            try
            {
                innerException2 = ex.InnerException.InnerException.Message;
            }
            catch { }

            if (data == null)
            {
                return Json(new { success = false, msg = ex.Message, innerException, innerException2 }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                dynamic expando = new ExpandoObject();
                var d = expando as IDictionary<string, object>;
                d.Add("success", false);
                d.Add("data", data);
                d.Add("msg", ex.Message);
                d.Add("innerException", innerException);
                d.Add("innerException2", innerException2);
                d = d.ToDictionary(x => x.Key, x => x.Value);
                return Json(d, JsonRequestBehavior.AllowGet);
            }
        }

        public void AddModelError(Exception ex)
        {
            if (ex is DbEntityValidationException)
            {
                ModelState.AddModelError("", GetEntityValidationErrors(ex as DbEntityValidationException));
            }
            else if (ex is System.Data.Entity.Infrastructure.DbUpdateException)
            {
                ModelState.AddModelError("", ex.GetBaseException().Message);
            }
            else if (ex is System.Data.Entity.Core.EntityCommandExecutionException)
            {
                ModelState.AddModelError("", ex.GetBaseException().Message);
            }
            else
            {
                ModelState.AddModelError("", ex.Message);
            }
        }

        public JsonResult JsonResultWithModelStateInfo(object data = null, string successMsg = "", string errorMsg = "")
        {
            var allErrors = ModelState.Values.SelectMany(v => v.Errors).Select(x => x.ErrorMessage).Where(x => !string.IsNullOrEmpty(x)).ToList();

            var result = new
            {
                success = !allErrors.Any(),
                errors = allErrors,
                successMsg,
                errorMsg,
                data,
                modelStateValidation = true,
            };

            var jsonResult = Json(result, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;
        }

        public JsonResult JsonResultErrorEntityValidation(DbEntityValidationException ex)
        {
            string errors = "";
            errors = GetEntityValidationErrors(ex);
            return this.JsonResultError(new Exception(errors));
        }

        private static string GetEntityValidationErrors(DbEntityValidationException ex)
        {
            string errors = "";
            foreach (var eve in ex.EntityValidationErrors)
            {
                errors += string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:<br>", eve.Entry.Entity.GetType().Name, eve.Entry.State);
                foreach (var ve in eve.ValidationErrors)
                {
                    errors += string.Format("- Property: \"{0}\", Error: \"{1}\"<br>", ve.PropertyName, ve.ErrorMessage);
                }
            }
            return errors;
        }

        public JsonResult JsonResultException(Exception ex)
        {
            if (ex is ModelException)
            {
                return this.JsonResultError(ex as ModelException);
            }
            if (ex is DbEntityValidationException)
            {
                return this.JsonResultErrorEntityValidation(ex as DbEntityValidationException);
            }
            if (ex is System.Data.Entity.Infrastructure.DbUpdateException)
            {
                return this.JsonResultError(new Exception(ex.GetBaseException().Message));
            }
            if (ex is System.Data.Entity.Core.EntityCommandExecutionException)
            {
                return this.JsonResultError(new Exception(ex.GetBaseException().Message));
            }

            return this.JsonResultError(ex);
        }

        public JsonResult JsonResultSuccess()
        {
            var result = Json(new { success = true }, JsonRequestBehavior.AllowGet);
            result.MaxJsonLength = int.MaxValue;
            return result;
        }

        public JsonResult JsonResultSuccess(object data, string msg)
        {
            if (data == null)
            {
                var result = Json(new { success = true }, JsonRequestBehavior.AllowGet);
                result.MaxJsonLength = int.MaxValue;
                return result;
            }
            else
            {
                dynamic expando = new ExpandoObject();
                var d = expando as IDictionary<string, object>;
                d.Add("success", true);
                data.AsDictionary().ToList().ForEach(x =>
                {
                    d.Add(x.Key, x.Value);
                });
                d = d.ToDictionary(x => x.Key, x => x.Value);
                if (!string.IsNullOrEmpty(msg)) d.Add("msg", msg);
                var result = Json(d, JsonRequestBehavior.AllowGet);
                result.MaxJsonLength = int.MaxValue;
                return result;
            }
        }

        public ActionResult GetRoleMenu(bool? isVertical)
        {
            IEnumerable<RoleMenuModel> model = new List<RoleMenuModel>();

            try
            {
                model = DependencyResolver.Current.GetService<IRoleService>().GetCurrentUserRoleMenu();
            }
            catch { }
            if ((isVertical ?? false == true))
            {
                return PartialView("_RoleMenuVertical", model);
            }
            else
            {
                return PartialView("_RoleMenu", model);
            }
        }

        public JsonResult JsonResultSuccess(object data)
        {
            return this.JsonResultSuccess(data: data, msg: "");
        }

        public new RedirectToRouteResult RedirectToAction(string action, string controller, object routeValues = null)
        {
            return base.RedirectToAction(action, controller, routeValues);
        }

        public RedirectResult RedirectToUrl(string url)
        {
            return this.Redirect(Url.Content(url));
        }
    }
}