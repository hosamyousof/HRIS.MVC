using System.Linq;
using HRIS.Model.MasterFile;

namespace HRIS.Service.MasterFile
{
    public interface IEmploymentTypeService
    {
        void Create(EmploymentTypeModel model, out int employmentTypeId);
        void Delete(int employmentTypeId);
        EmploymentTypeModel GetById(int employmentTypeId);
        IQueryable<EmploymentTypeModel> GetQuery();
        void Update(EmploymentTypeModel model);
    }
}