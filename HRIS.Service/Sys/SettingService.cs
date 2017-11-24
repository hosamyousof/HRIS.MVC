using HRIS.Data.Entity;
using HRIS.Model.Sys;
using Repository;
using System;
using System.Linq;

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

        //public string GenerateFormat(Guid companyId, string settingFormatName, string settingCurrentNoName)
        //{
        //    string format = this.GetValue(companyId, settingFormatName);
        //    int current_no = this.GetValue<int>(companyId, settingCurrentNoName);

        //    string generatedFormat = current_no.ToString(format);

        //    this.UpdateValue(companyId, settingCurrentNoName, current_no);
        //    return generatedFormat;
        //}

        public IQueryable<SettingModel> GetSettingList()
        {
            Guid companyId = this.GetCurrentCompanyId();
            var companySetting = this._repoCompanySetting.Query().Filter(x => x.companyId == companyId).Get();

            var data = this._repoSetting.Query().Get()
                .GroupJoin(companySetting, s => s.id, cs => cs.settingId, (setting, companySettingList) => new { setting, companySettingList })
                .SelectMany(x => x.companySettingList.DefaultIfEmpty(), (scs, compSet) => new { scs, compSet })
                .JoinSystemUser(x => x.compSet.updatedBy)
                .Select(x => new SettingModel()
                {
                    settingId = x.Source.scs.setting.id,
                    description = x.Source.scs.setting.description,
                    name = x.Source.scs.setting.name,
                    updatedBy = x.User.username,
                    updatedDate = x.Source.compSet.updatedDate,
                    value = x.Source.compSet.value,
                })
                ;

            return data;
        }

        public T GetValue<T>(Guid companyId, string settingName) where T : struct
        {
            return GetValue(companyId, settingName).ConvertTo<T>();
        }

        public string GetValue(Guid companyId, string settingName)
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

        public void Update(Guid settingId, string value)
        {
            Guid companyId = this.GetCurrentCompanyId();
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