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
    public class UserService : BaseService, IUserService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<sys_Permission> _repoPermission;
        private readonly IRepository<sys_User> _repoUser;
        private readonly IRepository<sys_UserSession> _repoUserSession;
        private readonly IRepository<sys_Company> _repoCompany;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<sys_Company> repoCompany
            , IRepository<sys_Permission> repoPermission
            , IRepository<sys_UserSession> repoUserSession
            , IRepository<sys_User> repoUser)
        {
            this._repoCompany = repoCompany;
            this._repoPermission = repoPermission;
            this._enumReferenceService = enumReferenceService;
            this._repoUserSession = repoUserSession;
            this._unitOfWork = unitOfWork;
            this._repoUser = repoUser;
        }

        public void Create(UserModel model, out int userId)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                int companyId = this.GetCurrentCompanyId();
                if (this._repoUser.Query().Filter(x => x.username == model.username && x.companyId == companyId).Get().Any())
                {
                    throw new Exception(model.username + " is already exists.");
                }

                int currentUser = this.GetCurrentUserId();

                CryptLib _crypt = new CryptLib();
                string defaultPassword = GetSettingValue("DEFAULT_PASSWORD");
                string key = CryptLib.getHashSha256(GetSettingValue("HRIS_HASHSHA_KEY"), 31); //32 bytes = 256 bits
                string iv = CryptLib.GenerateRandomIV(16);
                string encrypted = _crypt.encrypt(defaultPassword, key, iv);

                var ins = this._repoUser.Insert(new sys_User()
                {
                    companyId = this.GetCurrentCompanyId(),
                    username = model.username,
                    password = encrypted,
                    email = model.email,
                    hashKey = key,
                    vector = iv,
                    status = (int)UserStatus.Active,
                    updatedBy = currentUser,
                });
                this._unitOfWork.Save();
                ts.Complete();
                userId = ins.id;
            }
        }

        public int CreateUserSession(int companyId, int userId)
        {
            var ins = new sys_UserSession()
            {
                userId = userId,
                companyId = companyId,
                expiredDate = DateTime.Now.AddMinutes(5),
                ipAddress = System.Web.HttpContext.Current.Request.UserHostName,
                loggedDate = DateTime.Now,
            };
            this._repoUserSession.Insert(ins);
            this._unitOfWork.Save();
            return ins.id;
        }

        public void Delete(int userId)
        {
            var data = this._repoUser.Find(userId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoUser.Update(data);
            this._unitOfWork.Save();
        }

        public void DisableUser(int userId, bool disable = true)
        {
            var data = this._repoUser.Find(userId);
            data.status = disable ? (int)UserStatus.Disabled : (int)UserStatus.Active;
            this._repoUser.Update(data);
            this._unitOfWork.Save();
        }

        public UserModel GetById(int userId)
        {
            return this.GetQuery().First(x => x.id == userId);
        }

        public int GetCompanyIdBySessionId(int sessionId)
        {
            return this._repoUserSession.Query().Filter(x => x.id == sessionId).Get().Select(x => x.companyId).First();
        }

        public AccountProfileModel GetCurrentAccountProfile()
        {
            int sessionId = this.GetCurrentSessionId();

            var data = this._repoUserSession
                .Query().Filter(x => x.id == sessionId)
                .Get()
                .Select(x => new AccountProfileModel()
                {
                    username = x.sys_User.username,
                    company = x.sys_Company.businessName,
                    email = x.sys_User.email,
                })
                .First();
            return data;
        }

        public IQueryable<UserModel> GetQuery()
        {
            int companyId = this.GetCurrentCompanyId();
            var data = this._repoUser
                .Query().Filter(x => !x.deleted && x.companyId == companyId)
                .Get()
                .Join(this._enumReferenceService.GetQuery(ReferenceList.USER_STATUS), u => u.status, r => r.value, (u, r) => new { User = u, Ref = r })
                .Select(x => new UserModel()
                {
                    id = x.User.id,
                    username = x.User.username,
                    email = x.User.email,
                    UserStatus = new ReferenceModel { value = x.User.status, description = x.Ref.description, },
                    updatedBy = x.User.sys_User_updatedBy.username,
                    updatedDate = x.User.updatedDate,
                });

            return data;
        }

        public IQueryable<UserRoleModel> GetRoleUsers(int roleId)
        {
            int companyId = this.GetCurrentCompanyId();

            var data = this._repoUser
                .Query().Filter(x => !x.deleted && x.companyId == companyId)
                .Get()
                .Select(x => new UserRoleModel()
                {
                    userId = x.id,
                    username = x.username,
                    hasAccess = x.sys_UserRoles_userId.Any(ur => ur.roleId == roleId && !ur.deleted)
                });

            return data;
        }

        public int GetUserIdByUsername(string username)
        {
            int companyId = this.GetCurrentCompanyId();

            return this._repoUser.Query().Filter(x => x.username == username && x.companyId == companyId).Get().Select(x => x.id).First();
        }

        public bool HasPermission(string username, RoleAccessType accessType, string permissionCode)
        {
            var prepare = this._repoUser
                .Query()
                ;

            if (!this._repoPermission.Query(true).Filter(x => x.code == permissionCode).Get().Any())
            {
                int companyId = this.GetCurrentCompanyId();
                this.ExecuteSql("insert into sys_Permission (companyId, code, description, updatedBy) values (" + companyId + ", '" + permissionCode + "', '" + permissionCode + "', " + this.GetCurrentUserId() + ")");
            }

            switch (accessType)
            {
                case RoleAccessType.View:
                    prepare.Filter(x => x.sys_Roles.Any(r => r.sys_RolePermissions.Any(rp => rp.viewAccess && rp.sys_Permission.code == permissionCode)));
                    break;
                case RoleAccessType.Create:
                    prepare.Filter(x => x.sys_Roles.Any(r => r.sys_RolePermissions.Any(rp => rp.createAccess && rp.sys_Permission.code == permissionCode)));
                    break;
                case RoleAccessType.Update:
                    prepare.Filter(x => x.sys_Roles.Any(r => r.sys_RolePermissions.Any(rp => rp.updateAccess && rp.sys_Permission.code == permissionCode)));
                    break;
                case RoleAccessType.Delete:
                    prepare.Filter(x => x.sys_Roles.Any(r => r.sys_RolePermissions.Any(rp => rp.deleteAccess && rp.sys_Permission.code == permissionCode)));
                    break;
                case RoleAccessType.Print:
                    prepare.Filter(x => x.sys_Roles.Any(r => r.sys_RolePermissions.Any(rp => rp.printAccess && rp.sys_Permission.code == permissionCode)));
                    break;
                default:
                    break;
            }

            var check = prepare.Get()
                .Any();
            return check;
        }

        public bool IsSessionValid(int sessionId, string username)
        {
            bool isValid = this._repoUserSession
                .Query().Filter(x =>
                    x.id == sessionId
                    && x.sys_User.username == username
                    && x.expiredDate >= DateTime.Now)
                .Get()
                .Any();

            return isValid;
        }

        public void LoggedUser(int companyId, string username, out int sessionId)
        {
            sessionId = 0;
            using (TransactionScope ts = new TransactionScope())
            {
                int? userId = this._repoUser.Query().Filter(x => x.username == username).Get().Select(x => x.id).FirstOrDefault();
                if (userId == 0) throw new Exception("Invalid Username");

                sessionId = CreateUserSession(companyId, userId.Value);

                ts.Complete();
            }
        }

        public void Update(UserModel model)
        {
            var data = this._repoUser.Find(model.id);

            if (model.username != data.username)
            {
                if (this._repoUser.Query().Filter(x => x.username == model.username).Get().Any())
                {
                    throw new Exception(model.username + " is already exists.");
                }
                data.username = model.username;
            }

            if (model.UserStatus.value == (int)UserStatus.ResetPassword)
            {
                CryptLib _crypt = new CryptLib();
                string defaultPassword = GetSettingValue("DEFAULT_PASSWORD");
                string hashShaKey = GetSettingValue("HRIS_HASHSHA_KEY");
                string key = CryptLib.getHashSha256(hashShaKey, 31); //32 bytes = 256 bits
                string iv = CryptLib.GenerateRandomIV(16);
                string encrypted = _crypt.encrypt(defaultPassword, key, iv);
                data.password = encrypted;
                data.hashKey = key;
                data.vector = iv;
            }

            data.email = model.email;
            data.status = model.UserStatus.value;
            this._repoUser.Update(data);
            this._unitOfWork.Save();
        }

        public void UpdateProfile(AccountProfileModel model)
        {
            int userId = this.GetCurrentUserId();
            var data = this._repoUser.Find(userId);

            if (!string.IsNullOrEmpty(model.password))
            {
                if (string.IsNullOrEmpty(model.newPassword))
                    throw new Exception("Please provide new password.");

                CryptLib _crypt = new CryptLib();

                string decryptedPassword = _crypt.decrypt(data.password, data.hashKey, data.vector);
                if (decryptedPassword != model.password)
                {
                    throw new Exception("Invalid Password.");
                }

                string hashShaKey = GetSettingValue("HRIS_HASHSHA_KEY");
                string key = CryptLib.getHashSha256(hashShaKey, 31); //32 bytes = 256 bits
                string iv = CryptLib.GenerateRandomIV(16);
                string encrypted = _crypt.encrypt(model.newPassword, key, iv);
                data.password = encrypted;
                data.hashKey = key;
                data.vector = iv;
            }

            data.email = model.email;
            data.updatedBy = userId;
            data.updatedDate = DateTime.Now;
            this._repoUser.Update(data);
            this._unitOfWork.Save();
        }

        public void UpdateStatus(int userId, UserStatus status)
        {
            var data = this._repoUser.Find(userId);
            data.status = (int)status;

            if (status == UserStatus.ResetPassword)
            {
                CryptLib _crypt = new CryptLib();
                string defaultPassword = GetSettingValue("DEFAULT_PASSWORD");
                string hashShaKey = GetSettingValue("HRIS_HASHSHA_KEY");
                string key = CryptLib.getHashSha256(hashShaKey, 31); //32 bytes = 256 bits
                string iv = CryptLib.GenerateRandomIV(16);

                string encrypted = _crypt.encrypt(defaultPassword, key, iv);
                data.password = encrypted;
                data.hashKey = key;
                data.vector = iv;
            }

            this._repoUser.Update(data);
            this._unitOfWork.Save();
        }

        public void UpdateUserSessionExpiration(int sessionId)
        {
            var data = this._repoUserSession.Find(sessionId);
            data.expiredDate = DateTime.Now.AddMinutes(60);
            this._repoUserSession.Update(data);
            this._unitOfWork.Save();
        }

        public void ValidateLogin(string companyCode, string username, string password, out int sessionId)
        {
            using (TransactionScope ts = new TransactionScope())
            {

                int companyId = this._repoCompany.Query().Filter(x => x.code == companyCode).Get().Select(x => x.id).FirstOrDefault();

                var checkUser = this._repoUser.Query().Filter(x => x.username == username && x.companyId == companyId).Get();

                if (!checkUser.Any()) throw new Exception("Invalid Username");

                var user = checkUser.Single();

                var status = (UserStatus)user.status;

                switch (status)
                {
                    case UserStatus.Disabled:
                        throw new Exception("User has been disabled");
                    case UserStatus.Locked:
                        throw new Exception("User has been Locked");
                    default:
                        break;
                }

                CryptLib _crypt = new CryptLib();
                string hashShaKey = GetSettingValue(companyId, "HRIS_HASHSHA_KEY");
                string key = CryptLib.getHashSha256(hashShaKey, 31); //32 bytes = 256 bits
                                                                     //string encrypted = _crypt.encrypt(password, key, iv);
                string decrypt = _crypt.decrypt(user.password, user.hashKey, user.vector);

                if (decrypt != password)
                {
                    throw new Exception("Invalid Password");
                }

                sessionId = this.CreateUserSession(companyId, user.id);

                if (status == UserStatus.ResetPassword)
                {
                    this.UpdateStatus(user.id, UserStatus.Active);
                }

                ts.Complete();
            }
        }
    }
}