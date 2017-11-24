using System.Linq;
using HRIS.Model.Configuration;

namespace HRIS.Service.Configuration
{
    public interface IDepartmentService
    {
        void Create(DepartmentModel model, out int departmentId);
        void Delete(int departmentId);
        DepartmentModel GetById(int departmentId);
        IQueryable<DepartmentModel> GetQuery();
        void SectionCreate(DepartmentSectionModel model, out int departmentSectionId);
        void SectionDelete(int departmentSectionId);
        DepartmentSectionModel SectionGetById(int departmentSectionId);
        IQueryable<DepartmentSectionModel> SectionGetQuery();
        void SectionUpdate(DepartmentSectionModel model);
        void Update(DepartmentModel model);
    }
}