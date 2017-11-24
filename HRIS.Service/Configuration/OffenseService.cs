using HRIS.Data.Entity;
using HRIS.Model.Configuration;
using HRIS.Service.Sys;
using Repository;
using System;
using System.Linq;

namespace HRIS.Service.Configuration
{
    public class OffenseService : BaseService, IOffenseService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<mf_Offense> _repoOffense;
        private readonly IUnitOfWork _unitOfWork;

        public OffenseService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<mf_Offense> repoOffense)
        {
            this._unitOfWork = unitOfWork;
            this._enumReferenceService = enumReferenceService;
            this._repoOffense = repoOffense;
        }

        public void Create(OffenseModel model, out Guid offenseId)
        {
            if (this._repoOffense.Query().Filter(x => x.code == model.code).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            var currentUserId = this.GetCurrentUserId();
            var ins = this._repoOffense.Insert(new mf_Offense()
            {
                code = model.code,
                description = model.description,
                updatedBy = currentUserId,
            });
            this._unitOfWork.Save();
            offenseId = ins.id;
        }

        public void Delete(Guid offenseId)
        {
            var data = this._repoOffense.Find(offenseId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoOffense.Update(data);
            this._unitOfWork.Save();
        }

        public OffenseModel GetById(Guid offenseId)
        {
            return this.GetQuery().First(x => x.id == offenseId);
        }

        public IQueryable<OffenseModel> GetQuery()
        {
            var data = this._repoOffense
                .Query().Filter(x => x.deleted == false)
                .Get()
                .JoinSystemUser(x => x.updatedBy)
                .Select(x => new OffenseModel()
                {
                    id = x.Source.id,
                    code = x.Source.code,
                    description = x.Source.description,
                    updatedBy = x.User.username,
                    updatedDate = x.Source.updatedDate,
                });
            return data;
        }

        public void Update(OffenseModel model)
        {
            var upt = this._repoOffense.Find(model.id);
            if (upt.code != model.code)
            {
                if (this._repoOffense.Query().Filter(x => x.code == model.code).Get().Any())
                {
                    throw new Exception(model.code + " is already exists");
                }
                upt.code = model.code;
            }
            upt.description = model.description;
            upt.updatedBy = this.GetCurrentUserId();
            upt.updatedDate = DateTime.Now;
            this._repoOffense.Update(upt);
            this._unitOfWork.Save();
        }
    }
}