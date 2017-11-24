using System;
using System.Linq;
using HRIS.Model.Sys;

namespace HRIS.Service.Sys
{
    public interface ISettingService
    {
        IQueryable<SettingModel> GetSettingList();
        string GetValue(int companyId, string settingName);
        T GetValue<T>(int companyId, string settingName) where T : struct;
        void Update(int settingId, string value);
    }
}