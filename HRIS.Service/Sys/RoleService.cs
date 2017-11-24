using Common;
using HRIS.Data;
using HRIS.Model;
using HRIS.Model.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HRIS.Service.Sys
{
    public class RoleService : BaseService, IRoleService
    {
        private readonly IRepository<sys_Menu> _repoMenu;
        private readonly IRepository<sys_Role> _repoRole;
        private readonly IRepository<sys_RoleMenu> _repoRoleMenu;
        private readonly IRepository<sys_RolePermission> _repoRolePermission;
        private readonly IRepository<sys_UserRole> _repoUserRole;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMemoryCacheManager _memoryCacheManager;

        public RoleService(IUnitOfWork unitOfWork
            , IMemoryCacheManager memoryCacheManager
            , IRepository<sys_RoleMenu> repoRoleMenu
            , IRepository<sys_Menu> repoMenu
            , IRepository<sys_RolePermission> repoRolePermission
            , IRepository<sys_UserRole> repoUserRole
            , IRepository<sys_Role> repoRole)
        {
            this._memoryCacheManager = memoryCacheManager;
            this._repoRole = repoRole;
            this._repoRoleMenu = repoRoleMenu;
            this._repoMenu = repoMenu;
            this._repoUserRole = repoUserRole;
            this._repoRolePermission = repoRolePermission;
            this._unitOfWork = unitOfWork;
        }

        public void Create(RoleModel model, out int userId)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                if (this._repoRole.Query().Filter(x => x.code == model.code && !x.deleted).Get().Any())
                {
                    throw new Exception(model.description + " is already exists.");
                }

                int currentUser = this.GetCurrentUserId();

                var ins = this._repoRole.Insert(new sys_Role()
                {
                    companyId = this.GetCurrentCompanyId(),
                    code = model.code,
                    description = model.description,
                    updatedBy = currentUser,
                });
                this._unitOfWork.Save();
                ts.Complete();
                userId = ins.id;
            }
        }

        public void Delete(int userId)
        {
            var data = this._repoRole.Find(userId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoRole.Update(data);
            this._unitOfWork.Save();
        }

        public RoleModel GetById(int userId)
        {
            return this.GetQuery().First(x => x.id == userId);
        }

        public IEnumerable<RoleMenuModel> GetCurrentUserRoleMenu()
        {
            int userId = this.GetCurrentUserId();

            var cache = _memoryCacheManager.Get(MemoryCacheKey.CURRENT_USER_ROLE_MENU, userId, () =>
            {

                var data = this._repoRoleMenu.Query()
                .Filter(x => x.sys_Role.sys_UserRoles.Any(ur => ur.userId == userId && !ur.deleted))
                .Include(x => x.sys_Menu)
                .Get()
                .ToList();

                List<RoleMenuModel> result = new List<RoleMenuModel>();

                var parents = data.Where(x => !x.parentRoleMenuId.HasValue)
                    .GroupBy(p => new
                    {
                        description = string.IsNullOrEmpty(p.description) ? p.sys_Menu.description : p.description,
                        actionName = p.sys_Menu.actionName,
                        controllerName = p.sys_Menu.controllerName,
                        areaName = p.sys_Menu.areaName,
                        parameter = p.sys_Menu.parameter,
                        menuId = p.sourceMenuId,
                        mainMenu = true,
                    })
                    .Select(x =>
                    {
                        return new RoleMenuModel()
                        {
                            description = x.Key.description,
                            actionName = x.Key.actionName,
                            controllerName = x.Key.controllerName,
                            parameter = x.Key.parameter,
                            areaName = x.Key.areaName,
                            menuId = x.Key.menuId,
                            mainMenu = x.Key.mainMenu,
                            Childs = _RoleMenuGetChildsWithGroupings(data, x.Select(s => s.id)),
                            displayOrder = x.Min(m => m.displayOrder)
                        };
                    })
                    .OrderBy(x => x.displayOrder)
                    .ThenBy(x => x.description)
                    ;

                result = parents.ToList();
                return result;
            });

            return cache;
        }

        public IEnumerable<RoleMenuModel> RoleMenuGetByRoleId(int roleId)
        {
            int userId = this.GetCurrentUserId();

            var data = this._repoRoleMenu.Query()
                .Filter(x => x.roleId == roleId)
                .Include(x => x.sys_Menu)
                .Get()
                .ToList();

            List<RoleMenuModel> result = new List<RoleMenuModel>();

            var parents = data.Where(x => !x.parentRoleMenuId.HasValue).OrderBy(x => x.displayOrder).ThenBy(x => x.description);

            foreach (var p in parents)
            {
                var m = new RoleMenuModel()
                {
                    description = string.IsNullOrEmpty(p.description) ? p.sys_Menu.description : p.description,
                    actionName = p.sys_Menu.actionName,
                    controllerName = p.sys_Menu.controllerName,
                    parameter = p.sys_Menu.parameter,
                    areaName = p.sys_Menu.areaName,
                    menuId = p.sourceMenuId,
                    displayOrder = p.displayOrder,
                    //parentMenuId = p.parentRoleMenuId,
                    mainMenu = true,
                };
                m.Childs = _RoleMenuGetChilds(data, p.id).ToList();
                result.Add(m);
            }
            return result;
        }

        public IQueryable<RoleModel> GetQuery()
        {
            var companyId = this.GetCurrentCompanyId();
            var data = this._repoRole.Query().Filter(x => !x.deleted && x.companyId == companyId).Get()
                .Select(x => new RoleModel
                {
                    id = x.id,
                    code = x.code,
                    description = x.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate
                });
            return data;
        }

        public void MenuChangeParent(int sourceId, int? destinationId)
        {
            var m = this._repoRoleMenu.Find(sourceId);
            m.parentRoleMenuId = destinationId;
            this._repoRoleMenu.Update(m);
            this._unitOfWork.Save();
        }

        public void RoleMenuAdd(RoleMenuEntryModel model)
        {
            this._memoryCacheManager.RemoveStartWith(MemoryCacheKey.CURRENT_USER_ROLE_MENU);
            var menu = this._repoMenu.Find(model.menuId);
            int userId = this.GetCurrentUserId();
            var ins = this._repoRoleMenu.Insert(new sys_RoleMenu()
            {
                roleId = model.roleId,
                sourceMenuId = model.menuId,
                description = model.description,
                parentRoleMenuId = model.parentMenuId,
                displayOrder = model.displayOrder,
                updatedBy = userId,
            });
            this._unitOfWork.Save();
            model.id = ins.id;
        }

        public void RoleMenuCopyFromRoleId(int fromRoleId, int toRoleId)
        {
            this._memoryCacheManager.RemoveStartWith(MemoryCacheKey.CURRENT_USER_ROLE_MENU);
            if (fromRoleId == toRoleId || fromRoleId == 0 || toRoleId == 0)
            {
                throw new Exception("Unable to copy Menu's. Please check your entry or get assistance from your administrator.");
            }

            var data = RoleMenuGetByRoleId(fromRoleId);
            int userId = this.GetCurrentUserId();

            using (TransactionScope ts = new TransactionScope())
            {
                foreach (var rm in data)
                {
                    var p = new sys_RoleMenu()
                    {
                        roleId = toRoleId,
                        sourceMenuId = rm.menuId,
                        description = rm.description,
                        displayOrder = rm.displayOrder,
                        updatedBy = userId,
                    };
                    this._repoRoleMenu.Insert(p);
                    this._unitOfWork.Save();

                    _RoleMenuModelToEntity(userId, toRoleId, rm, p);
                }
                ts.Complete();
            }
        }

        private void _RoleMenuModelToEntity(int userId, int roleId, RoleMenuModel model, sys_RoleMenu entity)
        {
            if (model.Childs.Any())
            {
                foreach (var item in model.Childs)
                {
                    var rm = new sys_RoleMenu()
                    {
                        roleId = roleId,
                        sourceMenuId = item.menuId,
                        description = item.description,
                        displayOrder = item.displayOrder,
                        updatedBy = userId,
                        parentRoleMenuId = entity.id,
                    };
                    this._repoRoleMenu.Insert(rm);
                    this._unitOfWork.Save();
                    _RoleMenuModelToEntity(userId, roleId, item, rm);
                }
            }
        }

        public void RoleMenuDelete(int id)
        {
            this._memoryCacheManager.RemoveStartWith(MemoryCacheKey.CURRENT_USER_ROLE_MENU);
            var rm = this._repoRoleMenu.Find(id);
            rm.updatedBy = this.GetCurrentUserId();
            rm.updatedDate = DateTime.Now;
            rm.deleted = true;
            this._repoRoleMenu.Update(rm);
            this._unitOfWork.Save();
        }

        public RoleMenuTreeViewModel RoleMenuGetById(int id)
        {
            var data = this._repoRoleMenu
                .Query()
                .Filter(x => x.id == id)
                .Get()
                .Select(x => new RoleMenuTreeViewModel()
                {
                    id = x.id.ToString(),
                    menuId = x.sourceMenuId,
                    description = !string.IsNullOrEmpty(x.description) ? x.description : x.sys_Menu.description,
                    displayOrder = x.displayOrder,
                    hasChildren = x.sys_RoleMenus.Any(rm => rm.deleted == false)
                }).FirstOrDefault();
            return data;
        }

        public IEnumerable<RoleMenuTreeViewModel> RoleMenuList(int roleId, string id)
        {
            int? parentMenuId = null;
            if (!string.IsNullOrEmpty(id))
            {
                parentMenuId = int.Parse(id);
            }

            var data = this._repoRoleMenu
                .Query()
                .Filter(x => x.roleId == roleId && x.parentRoleMenuId == parentMenuId)
                .Get()
                .Select(x => new RoleMenuTreeViewModel()
                {
                    id = x.id.ToString(),
                    menuId = x.sourceMenuId,
                    description = !string.IsNullOrEmpty(x.description) ? x.description : x.sys_Menu.description,
                    displayOrder = x.displayOrder,
                    hasChildren = x.sys_RoleMenus.Any(rm => rm.deleted == false)
                })
                .OrderBy(x => x.displayOrder)
                .ThenBy(x => x.description)
                .ToList();

            return data;
        }

        public void RoleMenuUpdate(RoleMenuEntryModel model)
        {
            this._memoryCacheManager.RemoveStartWith(MemoryCacheKey.CURRENT_USER_ROLE_MENU);
            var rm = this._repoRoleMenu.Find(model.id);
            rm.description = model.description;
            rm.displayOrder = model.displayOrder;
            rm.sourceMenuId = model.menuId;
            rm.updatedBy = this.GetCurrentUserId();
            rm.updatedDate = DateTime.Now;
            this._repoRoleMenu.Update(rm);
            this._unitOfWork.Save();
        }

        public void RolePermissionUpdate(int roleId, IEnumerable<RolePermissionModel> models)
        {
            int userId = this.GetCurrentUserId();
            var companyId = this.GetCurrentCompanyId();
            foreach (var model in models)
            {
                var data = this._repoRolePermission.Query(true).Filter(x => x.roleId == roleId && x.permissionId == model.permissionId).Get().FirstOrDefault();
                if (data != null)
                {
                    data.viewAccess = model.viewAccess;
                    data.createAccess = model.createAccess;
                    data.updateAccess = model.updateAccess;
                    data.deleteAccess = model.deleteAccess;
                    data.printAccess = model.printAccess;

                    data.updatedBy = userId;
                    data.updatedDate = DateTime.Now;
                    this._repoRolePermission.Update(data);
                }
                else
                {
                    this._repoRolePermission.Insert(new sys_RolePermission()
                    {
                        permissionId = model.permissionId,
                        roleId = roleId,
                        updatedBy = userId,
                        viewAccess = model.viewAccess,
                        createAccess = model.createAccess,
                        updateAccess = model.updateAccess,
                        deleteAccess = model.deleteAccess,
                        printAccess = model.printAccess,
                    });
                }
            }
            this._unitOfWork.Save();
        }

        public void Update(RoleModel model)
        {
            var data = this._repoRole.Find(model.id);
            var companyId = this.GetCurrentCompanyId();

            if (model.code != data.code)
            {
                if (this._repoRole.Query().Filter(x => x.code == model.code && !x.deleted && x.companyId == companyId).Get().Any())
                {
                    throw new Exception(model.description + " is already exists.");
                }
                data.code = model.code;
            }
            data.description = model.description;
            this._repoRole.Update(data);
            this._unitOfWork.Save();
        }

        public void UserRoleUpdate(int roleId, IEnumerable<UserRoleModel> models)
        {
            int userId = this.GetCurrentUserId();
            var companyId = this.GetCurrentCompanyId();
            foreach (var model in models)
            {
                var data = this._repoUserRole.Query().Filter(x => x.roleId == roleId && x.userId == model.userId && !x.deleted).Get().FirstOrDefault();
                if (data != null)
                {
                    if (!model.hasAccess)
                    {
                        data.deleted = true;
                        data.updatedBy = userId;
                        data.updatedDate = DateTime.Now;
                        this._repoUserRole.Update(data);
                    }
                }
                else
                {
                    if (model.hasAccess)
                    {
                        this._repoUserRole.Insert(new sys_UserRole()
                        {
                            userId = model.userId,
                            roleId = roleId,
                            updatedBy = userId,
                        });
                    }
                }
            }
            this._unitOfWork.Save();
        }

        private IEnumerable<RoleMenuModel> _RoleMenuGetChilds(IEnumerable<sys_RoleMenu> data, int id)
        {
            return data.Where(x => x.parentRoleMenuId == id)
                   .OrderBy(x => x.displayOrder).ThenBy(x => x.description)
                   .Select(p => new RoleMenuModel()
                   {
                       description = string.IsNullOrEmpty(p.description) ? p.sys_Menu.description : p.description,
                       actionName = p.sys_Menu.actionName,
                       controllerName = p.sys_Menu.controllerName,
                       areaName = p.sys_Menu.areaName,
                       parameter = p.sys_Menu.parameter,
                       //parentMenuId = p.parentRoleMenuId,
                       menuId = p.sourceMenuId,
                       displayOrder = p.displayOrder,
                       Childs = _RoleMenuGetChilds(data, p.id).ToList(),
                   })
                   .ToList();
        }

        private IEnumerable<RoleMenuModel> _RoleMenuGetChildsWithGroupings(IEnumerable<sys_RoleMenu> data, IEnumerable<int> ids)
        {


            var result = data.Where(x => ids.Contains(x.parentRoleMenuId ?? 0))
                .GroupBy(p => new
                {
                    description = string.IsNullOrEmpty(p.description) ? p.sys_Menu.description : p.description,
                    actionName = p.sys_Menu.actionName,
                    controllerName = p.sys_Menu.controllerName,
                    areaName = p.sys_Menu.areaName,
                    parameter = p.sys_Menu.parameter,
                    menuId = p.sourceMenuId,
                    mainMenu = true,
                })
                .Select(x =>
                {
                    return new RoleMenuModel()
                    {
                        description = x.Key.description,
                        actionName = x.Key.actionName,
                        controllerName = x.Key.controllerName,
                        areaName = x.Key.areaName,
                        parameter = x.Key.parameter,
                        menuId = x.Key.menuId,
                        mainMenu = x.Key.mainMenu,
                        Childs = _RoleMenuGetChildsWithGroupings(data, x.Select(s => s.id)),
                        displayOrder = x.Min(m => m.displayOrder)
                    };
                })
                .OrderBy(x => x.displayOrder)
                .ThenBy(x => x.description)
                ;

            return result;

            //return data.Where(x => x.parentRoleMenuId == id)
            //       .OrderBy(x => x.displayOrder).ThenBy(x => x.description)
            //       .Select(p => new RoleMenuModel()
            //       {
            //           description = string.IsNullOrEmpty(p.description) ? p.sys_Menu.description : p.description,
            //           actionName = p.sys_Menu.actionName,
            //           controllerName = p.sys_Menu.controllerName,
            //           areaName = p.sys_Menu.areaName,
            //           parentMenuId = p.parentRoleMenuId,
            //           menuId = p.sourceMenuId,
            //           displayOrder = p.displayOrder,
            //           Childs = _RoleMenuGetChildsWithGroupings(data, p.id).ToList(),
            //       })
            //       .ToList();
        }
    }
}