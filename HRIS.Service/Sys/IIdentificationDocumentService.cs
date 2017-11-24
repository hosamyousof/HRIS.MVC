using HRIS.Model.Sys;
using System;
using System.Linq;

namespace HRIS.Service.Sys
{
    public interface IIdentificationDocumentService
    {
        void Create(IdentificationDocumentModel model, out Guid identificationDocumentId);

        void Delete(Guid identificationDocumentId);

        IdentificationDocumentModel GetById(Guid identificationDocumentId);

        IQueryable<IdentificationDocumentModel> GetQuery();

        void Update(IdentificationDocumentModel model);
    }
}