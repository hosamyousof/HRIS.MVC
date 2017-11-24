using HRIS.Data.Entity;
using HRIS.Model.Sys;
using Repository;
using System;
using System.Linq;
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

        public void Create(PermissionModel model, out Guid userId)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                Guid companyId = this.GetCurrentCompanyId();
                if (this._repoPermission.Query().Filter(x => x.code == model.code && !x.deleted && x.companyId == companyId).Get().Any())
                {
                    throw new Exception(model.code + " is already exists.");
                }

                var currentUser = this.GetCurrentUserId();

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

        public IQueryable<RolePermissionModel> GetRolePermission(Guid roleId)
        {
            Guid companyId = this.GetCurrentCompanyId();
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

        public void Delete(Guid userId)
        {
            var data = this._repoPermission.Find(userId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoPermission.Update(data);
            this._unitOfWork.Save();
        }

        public PermissionModel GetById(Guid userId)
        {
            return this.GetQuery().First(x => x.id == userId);
        }

        public IQueryable<PermissionModel> GetQuery()
        {
            Guid companyId = this.GetCurrentCompanyId();
            var data = this._repoPermission.Query()
                .Filter(x => x.companyId == companyId).Get()
                .JoinSystemUser(x => x.updatedBy)
                .Select(x => new PermissionModel
                {
                    id = x.Source.id,
                    code = x.Source.code,
                    description = x.Source.description,
                    updatedBy = x.User.username,
                    updatedDate = x.Source.updatedDate
                });
            return data;
        }

        public void Update(PermissionModel model)
        {
            var data = this._repoPermission.Find(model.id);

            if (model.code != data.code)
            {
                Guid companyId = this.GetCurrentCompanyId();
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