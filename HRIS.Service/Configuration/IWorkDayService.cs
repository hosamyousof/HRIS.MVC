using System.Linq;
using HRIS.Model.Configuration;
using System;

namespace HRIS.Service.Configuration
{
    public interface IWorkDayService
    {
        void Create(WorkDayModel model, out Guid WorkDayId);
        void Delete(Guid WorkDayId);
        WorkDayModel GetById(Guid WorkDayId);
        IQueryable<WorkDayModel> GetQuery();
        void Update(WorkDayModel model);
    }
}