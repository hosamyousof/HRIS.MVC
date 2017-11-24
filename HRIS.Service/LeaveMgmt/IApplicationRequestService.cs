using HRIS.Model.LeaveMgmt;
using System.Linq;

namespace HRIS.Service.LeaveMgmt
{
    public interface IApplicationRequestService
    {
        void RequestTypeAdd(ApplicationRequestModel model);
        IQueryable<ApplicationRequestModel> GetByID(int id);
    }
}
