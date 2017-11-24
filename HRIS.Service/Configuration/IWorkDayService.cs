using System.Linq;
using HRIS.Model.Configuration;

namespace HRIS.Service.Configuration
{
    public interface IWorkDayService
    {
        void Create(WorkDayModel model, out int WorkDayId);
        void Delete(int WorkDayId);
        WorkDayModel GetById(int WorkDayId);
        IQueryable<WorkDayModel> GetQuery();
        void Update(WorkDayModel model);
    }
}