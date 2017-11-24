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

        public void Create(OffenseModel model, out int offenseId)
        {
            if (this._repoOffense.Query().Filter(x => x.code == model.code).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            int currentUserId = this.GetCurrentUserId();
            var ins = this._repoOffense.Insert(new mf_Offense()
            {
                code = model.code,
                description = model.description,
                updatedBy = currentUserId,
            });
            this._unitOfWork.Save();
            offenseId = ins.id;
        }

        public void Delete(int offenseId)
        {
            var data = this._repoOffense.Find(offenseId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoOffense.Update(data);
            this._unitOfWork.Save();
        }

        public OffenseModel GetById(int offenseId)
        {
            return this.GetQuery().First(x => x.id == offenseId);
        }

        public IQueryable<OffenseModel> GetQuery()
        {
            var data = this._repoOffense
                .Query().Filter(x => x.deleted == false)
                .Get()
                .Select(x => new OffenseModel()
                {
                    id = x.id,
                    code = x.code,
                    description = x.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
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
