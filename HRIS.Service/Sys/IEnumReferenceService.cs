using System.Linq;
using HRIS.Model.Sys;
using HRIS.Model;
using HRIS.Data;
using HRIS.Data.Entity;

namespace HRIS.Service.Sys
{
    public interface IEnumReferenceService
    {
        IQueryable<sys_EnumReference> GetEntityListByName(ReferenceList name);
        IQueryable<ReferenceModel> GetQuery(ReferenceList name);
    }
}