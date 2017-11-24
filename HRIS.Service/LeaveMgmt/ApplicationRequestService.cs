using HRIS.Data;
using HRIS.Model.LeaveMgmt;
using Repository;
using System.Linq;

namespace HRIS.Service.LeaveMgmt
{
    public class ApplicationRequestService : BaseService, IApplicationRequestService
    {
        private readonly IRepository<ta_ApplicationRequest> _repoApplicationRequest;
        private readonly IUnitOfWork _unitOfWork;

        public ApplicationRequestService(IUnitOfWork unitOfWork, IRepository<ta_ApplicationRequest> repoApplicationRequest)
        {
            this._repoApplicationRequest = repoApplicationRequest;
            this._unitOfWork = unitOfWork;                
        }

        public void RequestTypeAdd(ApplicationRequestModel model)
        {
            int userId = this.GetCurrentUserId();
            var ins = this._repoApplicationRequest.Insert(new ta_ApplicationRequest()
            {
                id = model.id??0,
                applicationRequestTypeId = model.applicationRequestTypeId??0,
                note = model.note,
                status = model.status,
                assignTo = model.assignTo,
                requestedBy = userId,
                updatedBy = userId,
            });
            _unitOfWork.Save();
            model.id = ins.id;
       }

        public IQueryable<ApplicationRequestModel> GetByID(int id)
        {

            var result = _repoApplicationRequest.Query().Filter(x => x.id == id).Get().Select(model => new ApplicationRequestModel
            {
                id = model.id,
                applicationRequestTypeId = model.applicationRequestTypeId,
                note = model.note,
                status = model.status,
                assignTo = model.assignTo,
                requestedBy = model.requestedBy,
                updatedBy = model.updatedBy
            });
            return result;
        }
    }
}
