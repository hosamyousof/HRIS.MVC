using HRIS.Model.Configuration;
using System;
using System.Linq;

namespace HRIS.Service.Configuration
{
    public interface IDepartmentService
    {
        void Create(DepartmentModel model, out Guid departmentId);

        void Delete(Guid departmentId);

        DepartmentModel GetById(Guid departmentId);

        IQueryable<DepartmentModel> GetQuery();

        void SectionCreate(DepartmentSectionModel model, out Guid departmentSectionId);

        void SectionDelete(Guid departmentSectionId);

        DepartmentSectionModel SectionGetById(Guid departmentSectionId);

        IQueryable<DepartmentSectionModel> SectionGetQuery();

        void SectionUpdate(DepartmentSectionModel model);

        void Update(DepartmentModel model);
    }
}