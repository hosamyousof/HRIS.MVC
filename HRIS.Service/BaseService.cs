using HRIS.Service.Sys;
using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace HRIS.Service
{
    public class BaseService
    {
        protected void Log(Exception ex, EventLogEntryType entryType = EventLogEntryType.Warning)
        {
            try
            {
                string source = "HRIS";
                if (!EventLog.SourceExists(source))
                    EventLog.CreateEventSource(source, "Application");

                string errorMessage = string.Format("Message: {0}", ex.Message);
                if (ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message))
                {
                    errorMessage += string.Format("\nInnerException: {0}", ex.InnerException.Message);
                }

                EventLog.WriteEntry(source, errorMessage, entryType);
            }
            catch { }
        }

        protected void Log(string msg, EventLogEntryType entryType = EventLogEntryType.Warning)
        {
            this.Log(new Exception(msg));
        }

        protected void Log(string msg, EventLogEntryType entryType = EventLogEntryType.Warning, params object[] args)
        {
            this.Log(new Exception(string.Format(msg, args)));
        }

        public Guid GetCurrentCompanyId()
        {
            Guid sessionId = Guid.Parse(System.Web.HttpContext.Current.User.Identity.Name.Split('|')[0]);
            Guid companyId = DependencyResolver.Current.GetService<IUserService>().GetCompanyIdBySessionId(sessionId);
            return companyId;
        }

        protected void ExecuteSql(string sql)
        {
            DependencyResolver.Current.GetService<Data.HRISContext>().Database.ExecuteSqlCommand(sql);
        }

        protected Guid GetCurrentSessionId()
        {
            Guid sessionId = Guid.Parse(System.Web.HttpContext.Current.User.Identity.Name.Split('|')[0]);
            return sessionId;
        }

        public Guid GetCurrentUserId()
        {
            string username = System.Web.HttpContext.Current.User.Identity.Name.Split('|')[1];
            return DependencyResolver.Current.GetService<IUserService>().GetUserIdByUsername(username);
        }

        protected string GetSettingValue(string settingName)
        {
            Guid companyId = GetCurrentCompanyId();
            return DependencyResolver.Current.GetService<ISettingService>().GetValue(companyId, settingName);
        }

        protected string GetSettingValue(Guid companyId, string settingName)
        {
            return DependencyResolver.Current.GetService<ISettingService>().GetValue(companyId, settingName);
        }

        protected string GetUsername(Guid userId)
        {
            return DependencyResolver.Current.GetService<IUserService>().GetUsernameByUserId(userId);
        }
    }
}