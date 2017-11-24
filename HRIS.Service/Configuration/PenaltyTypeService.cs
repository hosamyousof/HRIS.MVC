﻿using HRIS.Data;
using HRIS.Data.Entity;
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
    public class PenaltyTypeService : BaseService, IPenaltyTypeService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<mf_PenaltyType> _repoPenaltyType;
        private readonly IUnitOfWork _unitOfWork;

        public PenaltyTypeService(IUnitOfWork unitOfWork
            , IEnumReferenceService enumReferenceService
            , IRepository<mf_PenaltyType> repoPenaltyType)
        {
            this._unitOfWork = unitOfWork;
            this._enumReferenceService = enumReferenceService;
            this._repoPenaltyType = repoPenaltyType;
        }

        public void Create(PenaltyTypeModel model, out Guid penaltyTypeId)
        {
            if (this._repoPenaltyType.Query().Filter(x => x.code == model.code).Get().Any())
            {
                throw new Exception(model.code + " is already exists");
            }

            var currentUserId = this.GetCurrentUserId();
            var ins = this._repoPenaltyType
                .NewEntity(ue =>
                {
                    ue.SetValue(x => x.code, model.code)
                        .SetValue(x => x.description, model.description)
                        .SetCurrentCompany()
                        .SetCurrentUserTo(x => x.updatedBy);
                });

            this._unitOfWork.Save();
            penaltyTypeId = ins.id;
        }

        public void Delete(Guid penaltyTypeId)
        {
            var data = this._repoPenaltyType.Find(penaltyTypeId);
            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            this._repoPenaltyType.Update(data);
            this._unitOfWork.Save();
        }

        public PenaltyTypeModel GetById(Guid penaltyTypeId)
        {
            return this.GetQuery().First(x => x.id == penaltyTypeId);
        }

        public IQueryable<PenaltyTypeModel> GetQuery()
        {
            var data = this._repoPenaltyType
                .Query().FilterCurrentCompany()
                .Get()
                .JoinSystemUser(x=> x.updatedBy)
                .Select(x => new PenaltyTypeModel()
                {
                    id = x.Source.id,
                    code = x.Source.code,
                    description = x.Source.description,
                    updatedBy = x.User.username,
                    updatedDate = x.Source.updatedDate,
                });
            return data;
        }

        public void Update(PenaltyTypeModel model)
        {
            var upt = this._repoPenaltyType.Find(model.id);
            if (upt.code != model.code)
            {
                if (this._repoPenaltyType.Query().FilterCurrentCompany().Filter(x => x.code == model.code).Get().Any())
                {
                    throw new Exception(model.code + " is already exists");
                }
                upt.code = model.code;
            }
            upt.description = model.description;
            upt.updatedBy = this.GetCurrentUserId();
            upt.updatedDate = DateTime.Now;
            this._repoPenaltyType.Update(upt);
            this._unitOfWork.Save();
        }
    }
}
