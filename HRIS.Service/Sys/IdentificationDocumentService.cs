using HRIS.Data;
using HRIS.Model.Sys;
using HRIS.Service.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Create(IdentificationDocumentModel model, out int IdentificationDocumentId)
        {
            if (this._repoIdentificationDocument.Query().Filter(x => x.code == model.code).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            int currentUserId = this.GetCurrentUserId();
            var ins = this._repoIdentificationDocument.Insert(new sys_IdentificationDocument()
            {
                code = model.code,
                description = model.description,
                updatedBy = currentUserId,
            });
            this._unitOfWork.Save();
            IdentificationDocumentId = ins.id;
        }

        public void Delete(int IdentificationDocumentId)
        {
            var data = this._repoIdentificationDocument.Find(IdentificationDocumentId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoIdentificationDocument.Update(data);
            this._unitOfWork.Save();
        }

        public IdentificationDocumentModel GetById(int IdentificationDocumentId)
        {
            return this.GetQuery().First(x => x.id == IdentificationDocumentId);
        }

        public IQueryable<IdentificationDocumentModel> GetQuery()
        {
            int companyId = this.GetCurrentCompanyId();
            var data = this._repoIdentificationDocument
                .Query().Filter(x => x.deleted == false)
                .Get()
                .Select(x => new IdentificationDocumentModel()
                {
                    id = x.id,
                    code = x.code,
                    description = x.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
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
