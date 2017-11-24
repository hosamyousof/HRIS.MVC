using HRIS.Data;
using HRIS.Model.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Sys
{
    public class CompanyService : BaseService, ICompanyService
    {
        private readonly IRepository<sys_Company> _repoCompany;
        private readonly IUnitOfWork _unitOfWork;

        public CompanyService(IUnitOfWork unitOfWork
            , IRepository<sys_Company> repoCompany)
        {
            this._unitOfWork = unitOfWork;
            this._repoCompany = repoCompany;
        }

        public void UpdateCurrentCompany(CompanyModel model)
        {
            int companyId = this.GetCurrentCompanyId();
            this._repoCompany.FindAndUpdateFromModel(model, companyId)
                .MatchAllDataField()
                .SetValue(x => x.updatedBy, this.GetCurrentUserId())
                .SetValue(x => x.updatedDate, DateTime.Now)
                .Update();
            this._unitOfWork.Save();
        }

        public CompanyModel GetCurrentCompany()
        {
            int companyId = this.GetCurrentCompanyId();
            var data = this._repoCompany
                .Query().Filter(x => x.id == companyId)
                .Get()
                .Select(x => new CompanyModel()
                {
                    code = x.code,
                    businessName = x.businessName,
                    address1 = x.address1,
                    address2 = x.address2,
                    address3 = x.address3,
                    countryId = x.countryId,
                    city = x.city,
                    postalCode = x.postalCode,
                    email = x.email,
                    telephone = x.telephone,
                    mobile = x.mobile,
                    fax = x.fax,
                })
                .FirstOrDefault()
                ;

            return data;
        }

        public bool IsMoreThanOneCompany()
        {
            return this._repoCompany.Query().Filter(x => x.deleted == false).Get().Count() > 1;
        }

        public IQueryable<CompanyModel> GetQuery()
        {
            return this._repoCompany
                .Query()
                .Filter(x=> x.deleted == false)
                .Get()
                .Select(x => new CompanyModel()
                {
                    address1 = x.address1,
                    address2 = x.address2,
                    address3 = x.address3,
                    businessName = x.businessName,
                    city = x.city,
                    code = x.code,
                    countryId = x.countryId,
                    email = x.email,
                    fax = x.fax,
                    mobile = x.mobile,
                    postalCode = x.postalCode,
                    telephone = x.telephone,
                });
        }

        public IEnumerable<ValueText> GetList()
        {
            return this._repoCompany
                .Query()
                .Get()
                .Select(x => new ValueText()
                {
                    Value = x.id.ToString(),
                    Text = x.code + " - " + x.businessName
                })
                .ToList();
        }
    }
}