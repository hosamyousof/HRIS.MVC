using HRIS.Data;
using HRIS.Model;
using HRIS.Model.Configuration;
using HRIS.Service.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Configuration
{
    public class WorkDayService : BaseService, IWorkDayService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<mf_WorkDay> _repoWorkDay;
        private readonly IUnitOfWork _unitOfWork;

        public WorkDayService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<mf_WorkDay> repoWorkDay)
        {
            this._unitOfWork = unitOfWork;
            this._enumReferenceService = enumReferenceService;
            this._repoWorkDay = repoWorkDay;
        }

        public void Create(WorkDayModel model, out int WorkDayId)
        {
            if (this._repoWorkDay.Query().FilterCurrentCompany().Filter(x => x.code == model.code).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            int currentUserId = this.GetCurrentUserId();
            var ins = this._repoWorkDay.PrepareEntity(model)
                .MatchAllDataField()
                .SetCurrentCompany()
                .SetCurrentUserTo(x => x.updatedBy)
                .Insert()
                .GetEntity();
            this._unitOfWork.Save();
            WorkDayId = ins.id;
        }

        public void Delete(int WorkDayId)
        {
            var data = this._repoWorkDay.Find(WorkDayId);

            this._repoWorkDay.PrepareEntity(data)
                .SetValue(x => x.deleted, true)
                .SetCurrentUserTo(x => x.updatedBy)
                .SetCurrentDateTo(x => x.updatedDate);
               //.Update(); - Deleted by Sem Villar 10/12/2016 - Causes error in updating data due to required fields;    
            this._repoWorkDay.Update(data);
            this._unitOfWork.Save();
        }

        public WorkDayModel GetById(int WorkDayId)
        {
            return this.GetQuery().First(x => x.id == WorkDayId);
        }

        public IQueryable<WorkDayModel> GetQuery()
        {
            var data = from wd in this._repoWorkDay.Query().FilterCurrentCompany().Get()
                       join h1 in this._enumReferenceService.GetQuery(ReferenceList.HOUR) on wd.fromTimeHour equals h1.value
                       join h2 in this._enumReferenceService.GetQuery(ReferenceList.HOUR) on wd.toTimeHour equals h2.value
                       select new WorkDayModel()
                       {
                           id = wd.id,
                           code = wd.code,
                           description = wd.description,
                           monday = wd.monday,
                           tuesday = wd.tuesday,
                           wednesday = wd.wednesday,
                           thursday = wd.thursday,
                           friday = wd.friday,
                           saturday = wd.saturday,
                           sunday = wd.sunday,
                           FromTimeHour = h1,
                           fromTimeMinute = wd.fromTimeMinute,
                           ToTimeHour = h2,
                           toTimeMinute = wd.toTimeMinute,
                           breakHours = wd.breakHours,
                           updatedBy = wd.sys_User.username,
                           updatedDate = wd.updatedDate,
                            
                       };

            return data;
        }

        public void Update(WorkDayModel model)
        {
            var upt = this._repoWorkDay.Find(model.id);
            if (upt.code != model.code)
            {
                if (this._repoWorkDay.Query().FilterCurrentCompany().Filter(x => x.code == model.code).Get().Any())
                {
                    throw new Exception(model.code + " is already exists");
                }
                upt.code = model.code;
            }
            upt.description = model.description;

            upt.monday = model.monday;
            upt.tuesday = model.tuesday;
            upt.wednesday = model.wednesday;
            upt.thursday = model.thursday;
            upt.friday = model.friday;
            upt.saturday = model.saturday;
            upt.sunday = model.sunday;
            upt.fromTimeHour = model.FromTimeHour.value;
            upt.fromTimeMinute = model.fromTimeMinute;
            
            upt.toTimeHour = model.ToTimeHour.value;
            upt.toTimeMinute = model.toTimeMinute;

            upt.breakHours = model.breakHours;

            upt.updatedBy = this.GetCurrentUserId();
            upt.updatedDate = DateTime.Now;
            this._repoWorkDay.Update(upt);
            this._unitOfWork.Save();
        }
    }
}