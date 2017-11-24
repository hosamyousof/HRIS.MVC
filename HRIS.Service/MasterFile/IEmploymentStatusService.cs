using HRIS.Model.MasterFile;
using System;
using System.Linq;

namespace HRIS.Service.MasterFile
{
    public interface IEmploymentStatusService
    {
        void Create(EmploymentStatusModel model, out Guid employmentStatusId);

        void Delete(Guid employmentStatusId);

        EmploymentStatusModel GetById(Guid employmentStatusId);

        IQueryable<EmploymentStatusModel> GetQuery();

        void Update(EmploymentStatusModel model);
    }
}