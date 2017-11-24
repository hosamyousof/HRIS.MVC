using HRIS.Model.LeaveMgmt;
using System;
using System.Linq;

namespace HRIS.Service.LeaveMgmt
{
    public interface IApplicationRequestService
    {
        void RequestTypeAdd(ApplicationRequestModel model);

        IQueryable<ApplicationRequestModel> GetById(Guid id);
    }
}