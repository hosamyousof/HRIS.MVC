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
    public class RoleController : BaseController
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            this._roleService = roleService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RoleCRUD([DataSourceRequest] DataSourceRequest request
            , UpdateType updateType
            , RoleModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                try
                {
                    switch (updateType)
                    {
                        case UpdateType.Create:
                            Guid userId;
                            this._roleService.Create(model, out userId);
                            model.id = userId;
                            break;
                        case UpdateType.Update:
                            this._roleService.Update(model);
                            break;
                        case UpdateType.Destroy:
                            this._roleService.Delete(model.id.Value);
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
                model = this._roleService.GetById(model.id.Value);
            }
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult CopyMenuFromRole(Guid fromRoleId, Guid toRoleId)
        {
            try
            {
                this._roleService.RoleMenuCopyFromRoleId(fromRoleId, toRoleId);
                return this.JsonResultSuccess();
            }
            catch (Exception ex)
            {
                return this.JsonResultError(ex);
            }
        }

        public ActionResult RoleList([DataSourceRequest] DataSourceRequest request)
        {
            var data = this._roleService.GetQuery();
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UserRoleGetList([DataSourceRequest] DataSourceRequest request, Guid? roleId)
        {
            var userService = DependencyResolver.Current.GetService<IUserService>();
            var data = userService.GetRoleUsers(roleId ?? Guid.Empty);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UserRoleUpdate([DataSourceRequest] DataSourceRequest request, Guid roleId, [Bind(Prefix = "models")]IEnumerable<UserRoleModel> models)
        {
            if (models != null && ModelState.IsValid)
            {
                try
                {
                    this._roleService.UserRoleUpdate(roleId, models);
                }
                catch (Exception ex)
                {
                    this.AddModelError(ex);
                }
            }
            return Json(models.ToDataSourceResult(request, ModelState));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="id">Role Id</param>
        /// <returns></returns>
        public ActionResult MenuList(Guid id)
        {
            return PartialView("MenuList", id);
        }

        public ActionResult MenuChangeParent(Guid source, Guid? destination)
        {
            try
            {
                this._roleService.MenuChangeParent(source, destination);
                return this.JsonResultSuccess();
            }
            catch (Exception ex)
            {
                return this.JsonResultError(ex);
            }
        }

        [HttpPost]
        public ActionResult RoleMenuDelete(Guid id)
        {
            try
            {
                this._roleService.RoleMenuDelete(id);
                return this.JsonResultSuccess();
            }
            catch (Exception ex)
            {
                return this.JsonResultError(ex);
            }
        }

        public ActionResult RoleMenuList([DataSourceRequest] DataSourceRequest request, string id, Guid roleId)
        {
            var data = _roleService.RoleMenuList(roleId, id);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult RoleMenuAdd(RoleMenuEntryModel model)
        {
            try
            {
                this._roleService.RoleMenuAdd(model);
                var data = this._roleService.RoleMenuGetById(model.id);
                return this.JsonResultSuccess(new { data });
            }
            catch (Exception ex)
            {
                return this.JsonResultError(ex);
            }
        }

        [HttpPost]
        public ActionResult RoleMenuUpdate(RoleMenuEntryModel model)
        {
            try
            {
                this._roleService.RoleMenuUpdate(model);
                return this.JsonResultSuccess();
            }
            catch (Exception ex)
            {
                return this.JsonResultError(ex);
            }
        }

        #region Role Permission

        public ActionResult RolePermissionGetList([DataSourceRequest] DataSourceRequest request, Guid? roleId)
        {
            var permissionService = DependencyResolver.Current.GetService<IPermissionService>();
            var data = permissionService.GetRolePermission(roleId ?? Guid.Empty);
            var result = data.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult RolePermissionUpdate([DataSourceRequest] DataSourceRequest request, Guid roleId, [Bind(Prefix = "models")]IEnumerable<RolePermissionModel> models)
        {
            if (models != null && ModelState.IsValid)
            {
                try
                {
                    this._roleService.RolePermissionUpdate(roleId, models);
                }
                catch (Exception ex)
                {
                    this.AddModelError(ex);
                }
            }
            return Json(models.ToDataSourceResult(request, ModelState));
        }

        #endregion Role Permission
    }
}