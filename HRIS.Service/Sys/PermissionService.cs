using HRIS.Data;
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
    public class PermissionService : BaseService, IPermissionService
    {
        private readonly IRepository<sys_Permission> _repoPermission;
        private readonly IUnitOfWork _unitOfWork;

        public PermissionService(IUnitOfWork unitOfWork
               , IRepository<sys_Permission> repoPermission)
        {
            this._repoPermission = repoPermission;
            this._unitOfWork = unitOfWork;
        }

        public void Create(PermissionModel model, out int userId)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                int companyId = this.GetCurrentCompanyId();
                if (this._repoPermission.Query().Filter(x => x.code == model.code && !x.deleted && x.companyId == companyId).Get().Any())
                {
                    throw new Exception(model.code + " is already exists.");
                }

                int currentUser = this.GetCurrentUserId();

                var ins = this._repoPermission.Insert(new sys_Permission()
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

        public IQueryable<RolePermissionModel> GetRolePermission(int roleId)
        {
            int companyId = this.GetCurrentCompanyId();
            var data = this._repoPermission
                .Query().Filter(x => !x.deleted && x.companyId == companyId)
                .Get()
                .Select(x => new RolePermissionModel()
                {
                    permissionId = x.id,
                    description = x.description,
                    viewAccess = x.sys_RolePermissions.Any(ur => ur.roleId == roleId && ur.viewAccess),
                    createAccess = x.sys_RolePermissions.Any(ur => ur.roleId == roleId && ur.createAccess),
                    updateAccess = x.sys_RolePermissions.Any(ur => ur.roleId == roleId && ur.updateAccess),
                    deleteAccess = x.sys_RolePermissions.Any(ur => ur.roleId == roleId && ur.deleteAccess),
                    printAccess = x.sys_RolePermissions.Any(ur => ur.roleId == roleId && ur.printAccess),
                });

            return data;
        }

        public void Delete(int userId)
        {
            var data = this._repoPermission.Find(userId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoPermission.Update(data);
            this._unitOfWork.Save();
        }

        public PermissionModel GetById(int userId)
        {
            return this.GetQuery().First(x => x.id == userId);
        }

        public IQueryable<PermissionModel> GetQuery()
        {
            int companyId = this.GetCurrentCompanyId();
            var data = this._repoPermission.Query().Filter(x => !x.deleted && x.companyId == companyId).Get()
                .Select(x => new PermissionModel
                {
                    id = x.id,
                    code = x.code,
                    description = x.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate
                });
            return data;
        }

        public void Update(PermissionModel model)
        {
            var data = this._repoPermission.Find(model.id);

            if (model.code != data.code)
            {
                int companyId = this.GetCurrentCompanyId();
                if (this._repoPermission.Query().Filter(x => x.code == model.code && !x.deleted && x.companyId == companyId).Get().Any())
                {
                    throw new Exception(model.code + " is already exists.");
                }
                data.code = model.code;
            }
            data.description = model.description;
            this._repoPermission.Update(data);
            this._unitOfWork.Save();
        }
    }
}