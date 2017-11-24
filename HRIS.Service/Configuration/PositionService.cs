using HRIS.Data;
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
    public class PositionService : BaseService, IPositionService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<mf_Position> _repoPosition;
        private readonly IUnitOfWork _unitOfWork;

        public PositionService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<mf_Position> repoPosition)
        {
            this._unitOfWork = unitOfWork;
            this._enumReferenceService = enumReferenceService;
            this._repoPosition = repoPosition;
        }

        public void Create(PositionModel model, out int positionId)
        {
            if (this._repoPosition.Query().Filter(x => x.code == model.code).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            int currentUserId = this.GetCurrentUserId();
            var ins = this._repoPosition.Insert(new mf_Position()
            {
                code = model.code,
                description = model.description,
                companyId = this.GetCurrentCompanyId(),
                updatedBy = currentUserId,
            });
            this._unitOfWork.Save();
            positionId = ins.id;
        }

        public void Delete(int positionId)
        {
            var data = this._repoPosition.Find(positionId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoPosition.Update(data);
            this._unitOfWork.Save();
        }

        public PositionModel GetById(int positionId)
        {
            return this.GetQuery().First(x => x.id == positionId);
        }

        public IQueryable<PositionModel> GetQuery()
        {
            int companyId = this.GetCurrentCompanyId();

            var data = this._repoPosition
                .Query().FilterCurrentCompany()
                .Get()
                .Select(x => new PositionModel()
                {
                    id = x.id,
                    code = x.code,
                    description = x.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void Update(PositionModel model)
        {
            var upt = this._repoPosition.Find(model.id);
            if (upt.code != model.code)
            {
                if (this._repoPosition.Query().FilterCurrentCompany().Filter(x => x.code == model.code).Get().Any())
                {
                    throw new Exception(model.code + " is already exists");
                }
                upt.code = model.code;
            }
            upt.description = model.description;
            upt.updatedBy = this.GetCurrentUserId();
            upt.updatedDate = DateTime.Now;
            this._repoPosition.Update(upt);
            this._unitOfWork.Save();
        }
    }
}
