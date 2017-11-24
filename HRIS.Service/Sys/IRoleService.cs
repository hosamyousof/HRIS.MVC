using HRIS.Model;
using HRIS.Model.Sys;
using System.Collections.Generic;
using System.Linq;

namespace HRIS.Service.Sys
{
    public interface IRoleService
    {
        void Create(RoleModel model, out int userId);

        void Delete(int userId);

        RoleModel GetById(int userId);

        IEnumerable<RoleMenuModel> GetCurrentUserRoleMenu();

        IQueryable<RoleModel> GetQuery();

        void MenuChangeParent(int sourceId, int? destinationId);

        void RoleMenuAdd(RoleMenuEntryModel model);

        void RoleMenuDelete(int id);

        RoleMenuTreeViewModel RoleMenuGetById(int id);

        IEnumerable<RoleMenuTreeViewModel> RoleMenuList(int roleId, string id);

        void RoleMenuUpdate(RoleMenuEntryModel model);

        void RolePermissionUpdate(int roleId, IEnumerable<RolePermissionModel> models);

        void Update(RoleModel model);
        void RoleMenuCopyFromRoleId(int fromRoleId, int toRoleId);
        void UserRoleUpdate(int roleId, IEnumerable<UserRoleModel> models);
    }
}