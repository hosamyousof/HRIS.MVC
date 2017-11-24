using System.Linq;
using HRIS.Model.Sys;

namespace HRIS.Service.Sys
{
    public interface IIdentificationDocumentService
    {
        void Create(IdentificationDocumentModel model, out int IdentificationDocumentId);
        void Delete(int IdentificationDocumentId);
        IdentificationDocumentModel GetById(int IdentificationDocumentId);
        IQueryable<IdentificationDocumentModel> GetQuery();
        void Update(IdentificationDocumentModel model);
    }
}