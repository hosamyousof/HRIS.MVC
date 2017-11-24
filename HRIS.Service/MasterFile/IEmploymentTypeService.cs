using HRIS.Model.MasterFile;
using System;
using System.Linq;

namespace HRIS.Service.MasterFile
{
    public interface IEmploymentTypeService
    {
        void Create(EmploymentTypeModel model, out Guid employmentTypeId);

        void Delete(Guid employmentTypeId);

        EmploymentTypeModel GetById(Guid employmentTypeId);

        IQueryable<EmploymentTypeModel> GetQuery();

        void Update(EmploymentTypeModel model);
    }
}