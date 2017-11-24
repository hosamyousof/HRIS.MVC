using HRIS.Data;
using HRIS.Model.Configuration;
using HRIS.Service.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Configuration
{
    public class PayrollGroupService : BaseService, IPayrollGroupService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<mf_PayrollGroup> _repoPayrollGroup;
        private readonly IUnitOfWork _unitOfWork;

        public PayrollGroupService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<mf_PayrollGroup> repoPayrollGroup)
        {
            this._unitOfWork = unitOfWork;
            this._enumReferenceService = enumReferenceService;
            this._repoPayrollGroup = repoPayrollGroup;
        }

        public void Create(PayrollGroupModel model, out int payrollGroupId)
        {
            if (this._repoPayrollGroup.Query().Filter(x => x.code == model.code ).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }
            int currentUserId = this.GetCurrentUserId();
            var ins = this._repoPayrollGroup.Insert(new mf_PayrollGroup()
            {
                code = model.code,
                description = model.description,
                updatedBy = currentUserId,
            });
            this._unitOfWork.Save();
            payrollGroupId = ins.id;
        }

        public void Delete(int payrollGroupId)
        {
            var data = this._repoPayrollGroup.Find(payrollGroupId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoPayrollGroup.Update(data);
            this._unitOfWork.Save();
        }

        public PayrollGroupModel GetById(int payrollGroupId)
        {
            return this.GetQuery().First(x => x.id == payrollGroupId);
        }

        public IQueryable<PayrollGroupModel> GetQuery()
        {
            var data = this._repoPayrollGroup
                .Query().Filter(x => x.deleted == false)
                .Get()
                .Select(x => new PayrollGroupModel()
                {
                    id = x.id,
                    code = x.code,
                    description = x.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void Update(PayrollGroupModel model)
        {
            var upt = this._repoPayrollGroup.Find(model.id);
            if (upt.code != model.code)
            {
                if (this._repoPayrollGroup.Query().Filter(x => x.code == model.code ).Get().Any())
                {
                    throw new Exception(model.code + " is already exists");
                }
                upt.code = model.code;
            }
            upt.description = model.description;
            upt.updatedBy = this.GetCurrentUserId();
            upt.updatedDate = DateTime.Now;
            this._repoPayrollGroup.Update(upt);
            this._unitOfWork.Save();
        }
    }
}
