using System.Linq;
using HRIS.Model.MasterFile;

namespace HRIS.Service.MasterFile
{
    public interface IEmploymentStatusService
    {
        void Create(EmploymentStatusModel model, out int employmentStatusId);
        void Delete(int employmentStatusId);
        EmploymentStatusModel GetById(int employmentStatusId);
        IQueryable<EmploymentStatusModel> GetQuery();
        void Update(EmploymentStatusModel model);
    }
}