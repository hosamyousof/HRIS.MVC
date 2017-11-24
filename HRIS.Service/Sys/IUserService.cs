using HRIS.Model.Sys;
using System;
using System.Linq;

namespace HRIS.Service.Sys
{
    public interface IUserService
    {
        void Create(UserModel model, out Guid userId);

        Guid CreateUserSession(Guid companyId, Guid userId);

        void Delete(Guid userId);

        void DisableUser(Guid userId, bool disable = true);

        UserModel GetById(Guid userId);

        Guid GetCompanyIdBySessionId(Guid sessionId);

        AccountProfileModel GetCurrentAccountProfile();

        IQueryable<UserModel> GetQuery();

        IQueryable<UserRoleModel> GetRoleUsers(Guid roleId);

        Guid GetUserIdByUsername(string username);

        string GetUsernameByUserId(Guid userId);

        bool HasPermission(string username, RoleAccessType accessType, string permissionCode);

        bool IsSessionValid(Guid sessionId, string username);

        void LoggedUser(Guid companyId, string username, out Guid sessionId);

        void Update(UserModel model);

        void UpdateProfile(AccountProfileModel model);

        void UpdateStatus(Guid userId, UserStatus status);

        void UpdateUserSessionExpiration(Guid sessionId);

        void ValidateLogin(string companyCode, string username, string password, out Guid sessionId);
    }
}