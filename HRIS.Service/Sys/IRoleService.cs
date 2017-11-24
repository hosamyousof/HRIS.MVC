using HRIS.Model.Sys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HRIS.Service.Sys
{
    public interface IRoleService
    {
        void Create(RoleModel model, out Guid userId);

        void Delete(Guid userId);

        RoleModel GetById(Guid userId);

        IEnumerable<RoleMenuModel> GetCurrentUserRoleMenu();

        IQueryable<RoleModel> GetQuery();

        void MenuChangeParent(Guid sourceId, Guid? destinationId);

        void RoleMenuAdd(RoleMenuEntryModel model);

        void RoleMenuDelete(Guid id);

        RoleMenuTreeViewModel RoleMenuGetById(Guid id);

        IEnumerable<RoleMenuTreeViewModel> RoleMenuList(Guid roleId, string id);

        void RoleMenuUpdate(RoleMenuEntryModel model);

        void RolePermissionUpdate(Guid roleId, IEnumerable<RolePermissionModel> models);

        void Update(RoleModel model);

        void RoleMenuCopyFromRoleId(Guid fromRoleId, Guid toRoleId);

        void UserRoleUpdate(Guid roleId, IEnumerable<UserRoleModel> models);
    }
}