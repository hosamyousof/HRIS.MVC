using HRIS.Model.Sys;
using System.Linq;
namespace HRIS.Service.Sys
{
   public  interface IPermissionService
    {
        IQueryable<PermissionModel> GetQuery();
        PermissionModel GetById(int userId);
        void Create(PermissionModel model, out int userId);
        void Update(PermissionModel model);
        void Delete(int userId);
        IQueryable<RolePermissionModel> GetRolePermission(int roleId);
    }
}
