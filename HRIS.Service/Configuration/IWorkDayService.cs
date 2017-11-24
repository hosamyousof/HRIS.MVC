using HRIS.Model.Configuration;
using System;
using System.Linq;

namespace HRIS.Service.Configuration
{
    public interface IWorkDayService
    {
        void Create(WorkDayModel model, out Guid workDayId);

        void Delete(Guid workDayId);

        WorkDayModel GetById(Guid workDayId);

        IQueryable<WorkDayModel> GetQuery();

        void Update(WorkDayModel model);
    }
}