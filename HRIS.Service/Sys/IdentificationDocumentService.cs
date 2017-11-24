using HRIS.Data.Entity;
using HRIS.Model.Sys;
using Repository;
using System;
using System.Linq;

namespace HRIS.Service.Sys
{
    public class IdentificationDocumentService : BaseService, IIdentificationDocumentService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<sys_IdentificationDocument> _repoIdentificationDocument;
        private readonly IUnitOfWork _unitOfWork;

        public IdentificationDocumentService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<sys_IdentificationDocument> repoIdentificationDocument)
        {
            this._unitOfWork = unitOfWork;
            this._enumReferenceService = enumReferenceService;
            this._repoIdentificationDocument = repoIdentificationDocument;
        }

        public void Create(IdentificationDocumentModel model, out Guid identificationDocumentId)
        {
            if (this._repoIdentificationDocument.Query().Filter(x => x.code == model.code).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            var currentUserId = this.GetCurrentUserId();
            var ins = this._repoIdentificationDocument.Insert(new sys_IdentificationDocument()
            {
                code = model.code,
                description = model.description,
                updatedBy = currentUserId,
            });
            this._unitOfWork.Save();
            identificationDocumentId = ins.id;
        }

        public void Delete(Guid identificationDocumentId)
        {
            var data = this._repoIdentificationDocument.Find(identificationDocumentId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoIdentificationDocument.Update(data);
            this._unitOfWork.Save();
        }

        public IdentificationDocumentModel GetById(Guid identificationDocumentId)
        {
            return this.GetQuery().First(x => x.id == identificationDocumentId);
        }

        public IQueryable<IdentificationDocumentModel> GetQuery()
        {
            Guid companyId = this.GetCurrentCompanyId();
            var data = this._repoIdentificationDocument
                .Query().Filter(x => x.deleted == false)
                .Get()
                .JoinSystemUser(x => x.updatedBy)
                .Select(x => new IdentificationDocumentModel()
                {
                    id = x.Source.id,
                    code = x.Source.code,
                    description = x.Source.description,
                    updatedBy = x.User.username,
                    updatedDate = x.Source.updatedDate,
                });
            return data;
        }

        public void Update(IdentificationDocumentModel model)
        {
            var upt = this._repoIdentificationDocument.Find(model.id);
            if (upt.code != model.code)
            {
                if (this._repoIdentificationDocument.Query().Filter(x => x.code == model.code).Get().Any())
                {
                    throw new Exception(model.code + " is already exists");
                }
                upt.code = model.code;
            }
            upt.description = model.description;
            upt.updatedBy = this.GetCurrentUserId();
            upt.updatedDate = DateTime.Now;
            this._repoIdentificationDocument.Update(upt);
            this._unitOfWork.Save();
        }
    }
}