using HRIS.Data.Entity;
using HRIS.Model;
using HRIS.Model.Sys;
using System.Linq;

namespace HRIS.Service.Sys
{
    public interface IEnumReferenceService
    {
        IQueryable<sys_EnumReference> GetEntityListByName(ReferenceList name);

        IQueryable<ReferenceModel> GetQuery(ReferenceList name);
    }
}