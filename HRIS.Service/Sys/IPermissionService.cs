using HRIS.Model.Sys;
using System;
using System.Linq;
namespace HRIS.Service.Sys
{
   public  interface IPermissionService
    {
        IQueryable<PermissionModel> GetQuery();
        PermissionModel GetById(Guid userId);
        void Create(PermissionModel model, out Guid userId);
        void Update(PermissionModel model);
        void Delete(Guid userId);
        IQueryable<RolePermissionModel> GetRolePermission(Guid roleId);
    }
}
