using System.Linq;
using HRIS.Model.Configuration;

namespace HRIS.Service.Configuration
{
    public interface IPenaltyTypeService
    {
        void Create(PenaltyTypeModel model, out int PenaltyTypeId);
        void Delete(int PenaltyTypeId);
        PenaltyTypeModel GetById(int PenaltyTypeId);
        IQueryable<PenaltyTypeModel> GetQuery();
        void Update(PenaltyTypeModel model);
    }
}