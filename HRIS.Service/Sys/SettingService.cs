using HRIS.Data;
using HRIS.Model.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Sys
{
    public class SettingService : BaseService, ISettingService
    {
        private readonly IRepository<sys_Setting> _repoSetting;
        private readonly IRepository<sys_CompanySetting> _repoCompanySetting;
        private readonly IUnitOfWork _unitOfWork;

        public SettingService(IUnitOfWork unitOfWork
            , IRepository<sys_CompanySetting> repoCompanySetting
            , IRepository<sys_Setting> repoSetting)
        {
            this._repoCompanySetting = repoCompanySetting;
            this._repoSetting = repoSetting;
            this._unitOfWork = unitOfWork;
        }

        //public string GenerateFormat(int companyId, string settingFormatName, string settingCurrentNoName)
        //{
        //    string format = this.GetValue(companyId, settingFormatName);
        //    int current_no = this.GetValue<int>(companyId, settingCurrentNoName);

        //    string generatedFormat = current_no.ToString(format);

        //    this.UpdateValue(companyId, settingCurrentNoName, current_no);
        //    return generatedFormat;
        //}

        public IQueryable<SettingModel> GetSettingList()
        {
            int companyId = this.GetCurrentCompanyId();

            var data = from s in this._repoSetting.Query().Get()
                       join cs in this._repoCompanySetting.Query().Filter(x => x.companyId == companyId).Get() on s.id equals cs.settingId into css
                       from cs in css.DefaultIfEmpty()
                       select new SettingModel()
                       {
                           settingId = s.id,
                           description = s.description,
                           name = s.name,
                           updatedBy = cs.sys_User.username,
                           updatedDate = cs.updatedDate,
                           value = cs.value,
                       };

            return data;
        }

        public T GetValue<T>(int companyId, string settingName) where T : struct
        {
            return GetValue(companyId, settingName).ConvertTo<T>();
        }

        public string GetValue(int companyId, string settingName)
        {
            string name = settingName.ToString();
            var data = this._repoCompanySetting
                .Query()
                .Filter(x => x.sys_Setting.name == name && x.companyId == companyId)
                .Get()
                .Select(x => x.value)
                .FirstOrDefault();

            return data ?? "";
        }

        public void Update(int settingId, string value)
        {
            int companyId = this.GetCurrentCompanyId();
            var data = this._repoCompanySetting.Query().Filter(x => x.companyId == companyId && x.settingId == settingId).Get().FirstOrDefault();

            if (data == null)
            {
                this._repoCompanySetting.Insert(new sys_CompanySetting()
                {
                    settingId = settingId,
                    companyId = companyId,
                    updatedBy = this.GetCurrentUserId(),
                    updatedDate = DateTime.Now,
                    value = value,
                });
            }
            else
            {
                data.value = value;
                this._repoCompanySetting.Update(data);
            }
            this._unitOfWork.Save();
        }

    }
}
