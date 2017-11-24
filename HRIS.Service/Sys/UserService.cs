using HRIS.Data.Entity;
using HRIS.Model;
using HRIS.Model.Sys;
using Repository;
using System;
using System.Linq;
using System.Transactions;

namespace HRIS.Service.Sys
{
    public class UserService : BaseService, IUserService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<sys_Permission> _repoPermission;
        private readonly IRepository<sys_User> _repoUser;
        private readonly IRepository<sys_Role> _repoRole;
        private readonly IRepository<sys_UserRole> _repoUserRole;
        private readonly IRepository<sys_UserSession> _repoUserSession;
        private readonly IRepository<sys_Company> _repoCompany;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<sys_Role> repoRole
            , IRepository<sys_Company> repoCompany
            , IRepository<sys_Permission> repoPermission
            , IRepository<sys_UserSession> repoUserSession
            , IRepository<sys_UserRole> repoUserRole
            , IRepository<sys_User> repoUser)
        {
            this._repoRole = repoRole;
            this._repoUserRole = repoUserRole;
            this._repoCompany = repoCompany;
            this._repoPermission = repoPermission;
            this._enumReferenceService = enumReferenceService;
            this._repoUserSession = repoUserSession;
            this._unitOfWork = unitOfWork;
            this._repoUser = repoUser;
        }

        public void Create(UserModel model, out Guid userId)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                Guid companyId = this.GetCurrentCompanyId();
                if (this._repoUser.Query().Filter(x => x.username == model.username && x.companyId == companyId).Get().Any())
                {
                    throw new Exception(model.username + " is already exists.");
                }

                var currentUser = this.GetCurrentUserId();

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

        public Guid CreateUserSession(Guid companyId, Guid userId)
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

        public void Delete(Guid userId)
        {
            var data = this._repoUser.Find(userId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoUser.Update(data);
            this._unitOfWork.Save();
        }

        public void DisableUser(Guid userId, bool disable = true)
        {
            var data = this._repoUser.Find(userId);
            data.status = disable ? (int)UserStatus.Disabled : (int)UserStatus.Active;
            this._repoUser.Update(data);
            this._unitOfWork.Save();
        }

        public UserModel GetById(Guid userId)
        {
            return this.GetQuery().First(x => x.id == userId);
        }

        public Guid GetCompanyIdBySessionId(Guid sessionId)
        {
            return this._repoUserSession.Query().Filter(x => x.id == sessionId).Get().Select(x => x.companyId).First();
        }

        public AccountProfileModel GetCurrentAccountProfile()
        {
            Guid sessionId = this.GetCurrentSessionId();

            var data = this._repoUserSession
                .Query().Filter(x => x.id == sessionId)
                .Get()
                .JoinSystemUser(ur => ur.userId)
                .Select(x => new AccountProfileModel()
                {
                    username = x.User.username,
                    company = x.Source.sys_Company.businessName,
                    email = x.User.email,
                })
                .First();
            return data;
        }

        public IQueryable<UserModel> GetQuery()
        {
            Guid companyId = this.GetCurrentCompanyId();
            var data = this._repoUser
                .Query().Filter(x => !x.deleted && x.companyId == companyId)
                .Get()
                .Join(this._enumReferenceService.GetQuery(ReferenceList.USER_STATUS), u => u.status, r => r.value, (u, r) => new { User = u, Ref = r })
                .LeftJoinSystemUser(u => u.User.updatedBy)
                .Select(x => new UserModel()
                {
                    id = x.Source.GroupSource.User.id,
                    username = x.Source.GroupSource.User.username,
                    email = x.Source.GroupSource.User.email,
                    UserStatus = new ReferenceModel { value = x.Source.GroupSource.User.status, description = x.Source.GroupSource.Ref.description, },
                    updatedBy = x.User.username,
                    updatedDate = x.Source.GroupSource.User.updatedDate,
                });

            return data;
        }

        public IQueryable<UserRoleModel> GetRoleUsers(Guid roleId)
        {
            Guid companyId = this.GetCurrentCompanyId();

            var data = this._repoUser
                .Query().Filter(x => !x.deleted && x.companyId == companyId)
                .Get()
                .Join(this._repoUserRole.QueryGet(), u => u.id, ur => ur.userId, (u, ur) => new { u, ur })
                .GroupBy(x => new { x.u.id, x.u.username })
                .Select(x => new UserRoleModel()
                {
                    userId = x.Key.id,
                    username = x.Key.username,
                    hasAccess = x.Any(ur => ur.ur.roleId == roleId && !ur.ur.deleted)
                });

            return data;
        }

        public Guid GetUserIdByUsername(string username)
        {
            Guid companyId = this.GetCurrentCompanyId();

            return this._repoUser.Query().Filter(x => x.username == username && x.companyId == companyId).Get().Select(x => x.id).First();
        }

        public bool HasPermission(string username, RoleAccessType accessType, string permissionCode)
        {
            if (!this._repoPermission.Query(true).Filter(x => x.code == permissionCode).Get().Any())
            {
                Guid companyId = this.GetCurrentCompanyId();
                this.ExecuteSql("insert into sys_Permission (companyId, code, description, updatedBy) values (" + companyId + ", '" + permissionCode + "', '" + permissionCode + "', " + this.GetCurrentUserId() + ")");
            }
            var query = this._repoUser.Query().Filter(x => x.username == username)
              .Get()
              .Join(this._repoUserRole.QueryGet(), u => u.id, ur => ur.userId, (u, ur) => new { u, ur });

            switch (accessType)
            {
                case RoleAccessType.View:
                    query = query.Where(x => x.ur.sys_Role.sys_RolePermissions.Any(rp => rp.viewAccess && rp.sys_Permission.code == permissionCode));
                    break;
                case RoleAccessType.Create:
                    query = query.Where(x => x.ur.sys_Role.sys_RolePermissions.Any(rp => rp.createAccess && rp.sys_Permission.code == permissionCode));
                    break;
                case RoleAccessType.Update:
                    query = query.Where(x => x.ur.sys_Role.sys_RolePermissions.Any(rp => rp.updateAccess && rp.sys_Permission.code == permissionCode));
                    break;
                case RoleAccessType.Delete:
                    query = query.Where(x => x.ur.sys_Role.sys_RolePermissions.Any(rp => rp.deleteAccess && rp.sys_Permission.code == permissionCode));
                    break;
                case RoleAccessType.Print:
                    query = query.Where(x => x.ur.sys_Role.sys_RolePermissions.Any(rp => rp.printAccess && rp.sys_Permission.code == permissionCode));
                    break;
                default:
                    break;
            }

            return query.Any();
        }

        public bool IsSessionValid(Guid sessionId, string username)
        {
            bool isValid = this._repoUserSession
                .Query()
                .Filter(x =>
                    x.id == sessionId
                    && x.expiredDate >= DateTime.Now)
                .Get()
                .JoinSystemUser(x => x.userId)
                .Where(x => x.User.username == username)
                .Any();

            return isValid;
        }

        public void LoggedUser(Guid companyId, string username, out Guid sessionId)
        {
            sessionId = Guid.Empty;
            using (TransactionScope ts = new TransactionScope())
            {
                Guid? userId = this._repoUser.Query().Filter(x => x.username == username).Get().Select(x => x.id).FirstOrDefault();
                if (userId.HasValue == false) throw new Exception("Invalid Username");

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
            Guid userId = this.GetCurrentUserId();
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

        public void UpdateStatus(Guid userId, UserStatus status)
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

        public void UpdateUserSessionExpiration(Guid sessionId)
        {
            var data = this._repoUserSession.Find(sessionId);
            data.expiredDate = DateTime.Now.AddMinutes(60);
            this._repoUserSession.Update(data);
            this._unitOfWork.Save();
        }

        public string GetUsernameByUserId(Guid userId)
        {
            return this._repoUser.Query().Filter(x => x.id == userId).Get().Select(x => x.username).FirstOrDefault();
        }

        public void ValidateLogin(string companyCode, string username, string password, out Guid sessionId)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                Guid companyId = this._repoCompany.Query().Filter(x => x.code == companyCode).Get().Select(x => x.id).FirstOrDefault();

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