using HRIS.Model.Configuration;
using System;
using System.Linq;

namespace HRIS.Service.Configuration
{
    public interface IPenaltyTypeService
    {
        void Create(PenaltyTypeModel model, out Guid penaltyTypeId);

        void Delete(Guid penaltyTypeId);

        PenaltyTypeModel GetById(Guid penaltyTypeId);

        IQueryable<PenaltyTypeModel> GetQuery();

        void Update(PenaltyTypeModel model);
    }
}