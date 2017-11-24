using HRIS.Model;
using HRIS.Model.Sys;
using HRIS.Service.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HRIS.Web.Framework.Extensions
{
    public static class ViewExtensions
    {
        public static string GetSetting(this WebViewPage wvp, string name)
        {
            var settingService = DependencyResolver.Current.GetService<ISettingService>();
            int sessionId = int.Parse(System.Web.HttpContext.Current.User.Identity.Name.Split('-')[0]);

            string content = settingService.GetValue(sessionId, name);
            return content;
        }

        public static IEnumerable<ReferenceModel> GetReferenceList(this WebViewPage wvp, ReferenceList reference)
        {
            var service = DependencyResolver.Current.GetService<IEnumReferenceService>();
            return service.GetQuery(reference).ToList();
        }

        public static bool IsPagePost(this WebViewPage wvp)
        {
            return string.Equals("post", wvp.Request.HttpMethod, StringComparison.OrdinalIgnoreCase);
        }

        public static string GetCurrentUsername(this WebViewPage wvp)
        {
            var userService = DependencyResolver.Current.GetService<HRIS.Service.Sys.IUserService>();
            var profile = userService.GetCurrentAccountProfile();
            return profile.username;
        }

        public static T GetSetting<T>(this WebViewPage wvp, string name) where T : struct
        {
            var settingService = DependencyResolver.Current.GetService<ISettingService>();
            int sessionId = int.Parse(System.Web.HttpContext.Current.User.Identity.Name.Split('-')[0]);
            string content = settingService.GetValue(sessionId, name);
            try
            {
                return content.ConvertTo<T>();
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        public static bool HasPermission(this WebViewPage wvp, RoleAccessType roleAccessType, PermissionList code)
        {
            string username = wvp.GetCurrentUsername();
            string permissionCode = code.ToString();
            return DependencyResolver.Current.GetService<IUserService>().HasPermission(username, roleAccessType, permissionCode); ;
        }
    }
}