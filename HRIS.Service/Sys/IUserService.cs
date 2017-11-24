using HRIS.Model.Sys;
using System.Linq;

namespace HRIS.Service.Sys
{
    public interface IUserService
    {
        void Create(UserModel model, out int userId);

        int CreateUserSession(int companyId, int userId);

        void Delete(int userId);

        void DisableUser(int userId, bool disable = true);

        UserModel GetById(int userId);

        int GetCompanyIdBySessionId(int sessionId);

        AccountProfileModel GetCurrentAccountProfile();

        IQueryable<UserModel> GetQuery();

        IQueryable<UserRoleModel> GetRoleUsers(int roleId);

        int GetUserIdByUsername(string username);

        bool HasPermission(string username, RoleAccessType accessType, string permissionCode);

        bool IsSessionValid(int sessionId, string username);

        void LoggedUser(int companyId, string username, out int sessionId);

        void Update(UserModel model);

        void UpdateProfile(AccountProfileModel model);

        void UpdateStatus(int userId, UserStatus status);

        void UpdateUserSessionExpiration(int sessionId);

        void ValidateLogin(string companyCode, string username, string password, out int sessionId);
    }
}