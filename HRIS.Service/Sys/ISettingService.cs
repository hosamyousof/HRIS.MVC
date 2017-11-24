using System;
using System.Linq;
using HRIS.Model.Sys;

namespace HRIS.Service.Sys
{
    public interface ISettingService
    {
        IQueryable<SettingModel> GetSettingList();
        string GetValue(Guid companyId, string settingName);
        T GetValue<T>(Guid companyId, string settingName) where T : struct;
        void Update(Guid settingId, string value);
    }
}