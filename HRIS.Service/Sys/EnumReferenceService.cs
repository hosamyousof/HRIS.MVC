using HRIS.Data;
using HRIS.Model;
using HRIS.Model.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Sys
{
    public class EnumReferenceService : BaseService, IEnumReferenceService
    {
        private readonly IRepository<sys_EnumReference> _repoEnumReference;

        public EnumReferenceService(IRepository<sys_EnumReference> repoEnumReference)
        {
            this._repoEnumReference = repoEnumReference;
        }

        public IQueryable<sys_EnumReference> GetEntityListByName(ReferenceList name)
        {
            int companyId = this.GetCurrentCompanyId();

            string _name = name.ToString();
            return this._repoEnumReference
               .Query().Filter(x => x.name == _name && x.companyId == companyId)
               .Get()
               .OrderBy(x => x.displayOrder);
        }

        public IQueryable<ReferenceModel> GetQuery(ReferenceList name)
        {
            int companyId = this.GetCurrentCompanyId();

            string _name = name.ToString();

            return this._repoEnumReference
                .Query().Filter(x => x.name == _name && x.companyId == companyId)
                .Get()
                .OrderBy(x => x.displayOrder)
                .ThenBy(x => x.value)
                .Select(x => new ReferenceModel()
                {
                    value = x.value,
                    description = x.description
                });
        }
    }
}