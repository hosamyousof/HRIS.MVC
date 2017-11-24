using HRIS.Data;
using HRIS.Model;
using HRIS.Model.MasterFile;
using HRIS.Model.Sys;
using HRIS.Service.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Transactions;

namespace HRIS.Service.MasterFile
{
    public class EmployeeService : BaseService, IEmployeeService
    {
        private readonly IEnumReferenceService _enumReferenceService;
        private readonly IRepository<mf_Employee> _repoEmployee;
        private readonly IRepository<mf_Employee201> _repoEmployee201;
        private readonly IRepository<mf_EmployeeAddress> _repoEmployeeAddress;
        private readonly IRepository<mf_EmployeeAllowance> _repoEmployeeAllowance;
        private readonly IRepository<mf_EmployeeDeduction> _repoEmployeeDeduction;
        private readonly IRepository<mf_EmployeeIdentificationDocument> _repoEmployeeIdentificationDocument;
        private readonly IRepository<mf_EmployeeOffense> _repoEmployeeOffense;
        private readonly IRepository<mf_EmployeeSkill> _repoEmployeeSkill;
        private readonly IRepository<mf_EmployeeTraining> _repoEmployeeTraining;
        private readonly IRepository<mf_EmployeeWorkDay> _repoEmployeeWorkDay;
        private readonly IRepository<mf_EmployeeWorkHistory> _repoEmployeeWorkHistory;
        private readonly IRepository<mf_EmployeeBasicPay> _repoEmployeeBasicPay;
        private readonly IRepository<mf_EmployeeBalanceLeave> _repoEmployeeBalanceLeave;
        private readonly IRepository<mf_ApplicationRequestType> _repoApplicationRequestType;
        private readonly IRepository<mf_Offense> _repoOffense;
        private readonly IRepository<mf_WorkDay> _repoWorkDay;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(
            IEnumReferenceService enumReferenceService
            , IRepository<mf_ApplicationRequestType> repoApplicationRequestType
            , IRepository<mf_Employee> repoEmployee
            , IRepository<mf_Employee201> repoEmployee201
            , IRepository<mf_EmployeeAddress> repoEmployeeAddress
            , IRepository<mf_EmployeeAllowance> repoEmployeeAllowance
            , IRepository<mf_EmployeeBalanceLeave> repoEmployeeBalanceLeave
            , IRepository<mf_EmployeeBasicPay> repoEmployeeBasicPay
            , IRepository<mf_EmployeeDeduction> repoEmployeeDeduction
            , IRepository<mf_EmployeeIdentificationDocument> repoEmployeeIdentificationDocument
            , IRepository<mf_EmployeeOffense> repoEmployeeOffense
            , IRepository<mf_EmployeeSkill> repoEmployeeSkill
            , IRepository<mf_EmployeeTraining> repoEmployeeTraining
            , IRepository<mf_EmployeeWorkDay> repoEmployeeWorkDay
            , IRepository<mf_EmployeeWorkHistory> repoEmployeeWorkHistory
            , IRepository<mf_Offense> repoOffense
            , IRepository<mf_WorkDay> repoWorkDay
            , IUnitOfWork unitOfWork
            )
        {
            this._enumReferenceService = enumReferenceService;
            this._repoApplicationRequestType = repoApplicationRequestType;
            this._repoEmployee = repoEmployee;
            this._repoEmployee201 = repoEmployee201;
            this._repoEmployeeAddress = repoEmployeeAddress;
            this._repoEmployeeAllowance = repoEmployeeAllowance;
            this._repoEmployeeBalanceLeave = repoEmployeeBalanceLeave;
            this._repoEmployeeBasicPay = repoEmployeeBasicPay;
            this._repoEmployeeDeduction = repoEmployeeDeduction;
            this._repoEmployeeIdentificationDocument = repoEmployeeIdentificationDocument;
            this._repoEmployeeOffense = repoEmployeeOffense;
            this._repoEmployeeSkill = repoEmployeeSkill;
            this._repoEmployeeTraining = repoEmployeeTraining;
            this._repoEmployeeWorkDay = repoEmployeeWorkDay;
            this._repoEmployeeWorkHistory = repoEmployeeWorkHistory;
            this._repoOffense = repoOffense;
            this._repoWorkDay = repoWorkDay;
            this._unitOfWork = unitOfWork;
        }

        #region Quick Update

        public void QuickUpdateEmployee(EmployeeQuickUpdateModel model)
        {
            int employeeId = model.id;
            var _201 = this._repoEmployee201.Query().Filter(x => x.mf_Employees.Any(e => e.id == employeeId)).Get().FirstOrDefault();
            if (_201 != null)
            {
                var userId = this.GetCurrentUserId();
                _201.employeeCode = model.employeeCode;
                _201.positionId = model.position == null ? (int?)null : model.position.value;
                _201.departmentId = model.department == null ? (int?)null : model.department.value;
                _201.employmentStatusId = model.employmentStatus == null ? (int?)null : model.employmentStatus.value;
                _201.employmentTypeId = model.employmentType == null ? (int?)null : model.employmentType.value;
                _201.positionLevel = model.positionLevel == null ? (int?)null : model.positionLevel.value;
                _201.updatedBy = userId;
                _201.updatedDate = DateTime.Now;
                this._repoEmployee201.Update(_201);
                this._unitOfWork.Save();
            }
        }

        public IQueryable<EmployeeQuickUpdateModel> QuickUpdateEmployeeList()
        {
            var positionLevel = this._enumReferenceService.GetQuery(ReferenceList.POSITION_LEVEL);
            var data = this._repoEmployee
                .Query()
                .Get()
                .GroupJoin(positionLevel, e => e.id, pl => pl.value, (Emp, PosLevel) => new { Emp, PosLevel })
                .SelectMany(x => x.PosLevel.DefaultIfEmpty(), (emp, posLevel) => new { Emp = emp.Emp, PosLevel = posLevel })
                .Select(x => new { Emp = x.Emp, Emp201 = x.Emp.mf_Employee201, x.PosLevel })
                .Select(x => new EmployeeQuickUpdateModel()
                {
                    id = x.Emp.id,
                    employeeCode = x.Emp201.employeeCode,
                    position = x.Emp201.positionId.HasValue ? (new ReferenceModel()
                    {
                        value = x.Emp201.mf_Position.id,
                        description = x.Emp201.mf_Position.description,
                    }) : null,
                    department = x.Emp201.departmentId.HasValue ? (new ReferenceModel()
                    {
                        value = x.Emp201.mf_Department.id,
                        description = x.Emp201.mf_Department.description,
                    }) : null,
                    employmentStatus = x.Emp201.employmentStatusId.HasValue ? (new ReferenceModel()
                    {
                        value = x.Emp201.mf_EmploymentStatu.id,
                        description = x.Emp201.mf_EmploymentStatu.description,
                    }) : null,
                    employmentType = x.Emp201.employmentTypeId.HasValue ? (new ReferenceModel()
                    {
                        value = x.Emp201.mf_EmploymentType.id,
                        description = x.Emp201.mf_EmploymentType.description,
                    }) : null,
                    positionLevel = x.PosLevel,
                });

            return data;
        }

        #endregion Quick Update

        public void BasicInfoCreate(EmployeeBasicInfoModel model, out int employeeId)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                int userId = this.GetCurrentUserId();

                var addr = this._repoEmployeeAddress.Insert(new mf_EmployeeAddress()
                {
                    ObjectState = ObjectState.Added,
                    address1 = model.address1,
                    address2 = model.address2,
                    address3 = model.address3,
                    countryId = model.countryId,
                    city = model.city,
                    postalCode = model.postalCode,
                    updatedBy = userId,
                });
                var _201 = this._repoEmployee201.Insert(new mf_Employee201()
                {
                    employeeCode = "-",
                    updatedBy = userId,
                    confidential = model.confidential,
                });
                this._unitOfWork.Save();

                var emp = this._repoEmployee
                    .Insert(new mf_Employee()
                    {
                        companyId = this.GetCurrentCompanyId(),
                        firstName = model.firstName,
                        middleName = model.middleName,
                        lastName = model.lastName,
                        birthDate = model.birthDate,
                        maritalStatus = model.maritalStatus,
                        gender = model.gender,
                        email = model.email,
                        contact1 = model.contact1,
                        contact2 = model.contact2,
                        contact3 = model.contact3,
                        updatedBy = userId,
                        employeeAddressId = addr.id,
                        employee201Id = _201.id,
                    });

                this._unitOfWork.Save();
                employeeId = emp.id;
                ts.Complete();
            }
        }

        public EmployeeBasicInfoModel BasicInfoGetByEmployeeId(int employeeId)
        {
            var data = this._repoEmployee
                .Query().Filter(x => x.id == employeeId)
                .Get()
                .Select(x => new EmployeeBasicInfoModel()
                {
                    id = x.id,
                    firstName = x.firstName,
                    lastName = x.lastName,
                    middleName = x.middleName,
                    birthDate = x.birthDate,
                    email = x.email,
                    gender = x.gender,
                    maritalStatus = x.maritalStatus,
                    contact1 = x.contact1,
                    contact2 = x.contact2,
                    contact3 = x.contact3,

                    pictureExtension = x.pictureExtension,

                    address1 = x.mf_EmployeeAddress.address1,
                    address2 = x.mf_EmployeeAddress.address2,
                    address3 = x.mf_EmployeeAddress.address3,
                    countryId = x.mf_EmployeeAddress.countryId,
                    city = x.mf_EmployeeAddress.city,
                    postalCode = x.mf_EmployeeAddress.postalCode,
                })
                .FirstOrDefault();
            return data;
        }

        public void BasicInfoUpdate(int employeeId, EmployeeBasicInfoModel model)
        {
            var data = this._repoEmployee.Query()
                     .Include(x => x.mf_EmployeeAddress)
                     .Filter(x => x.id == employeeId).Get()
                     .FirstOrDefault();

            string serverPath = System.Web.HttpContext.Current.Server.MapPath("~/ProfilePicture");
            if (!Directory.Exists(serverPath)) Directory.CreateDirectory(serverPath);

            if (model.image != null)
            {
                IDictionary<string, string> validImageFiles = new Dictionary<string, string>();
                validImageFiles.Add(".bmp", "BMP");
                validImageFiles.Add(".jpg", "Jpeg");
                validImageFiles.Add(".jpeg", "Jpeg");
                validImageFiles.Add(".gif", "GIF");

                string extenstion = Path.GetExtension(model.image.FileName);

                if (!validImageFiles.ContainsKey((extenstion ?? "").ToLower()))
                    throw new Exception("Invalid File Picture");

                if (File.Exists(Path.Combine(serverPath, employeeId + extenstion))) File.Delete(Path.Combine(serverPath, employeeId + extenstion));

                model.image.SaveAs(Path.Combine(serverPath, employeeId + extenstion));

                data.pictureExtension = extenstion;
            }
            else
            {
                if (model.clearImage == "true")
                {
                    if (File.Exists(Path.Combine(serverPath, employeeId + model.pictureExtension))) File.Delete(Path.Combine(serverPath, employeeId + model.pictureExtension));
                    data.pictureExtension = "";
                }
            }

            var userId = this.GetCurrentUserId();

            data.firstName = model.firstName;
            data.lastName = model.lastName;
            data.middleName = model.middleName;
            data.birthDate = model.birthDate;
            data.email = model.email;
            data.maritalStatus = model.maritalStatus;

            data.contact1 = model.contact1;
            data.contact2 = model.contact2;
            data.contact3 = model.contact3;

            if (data.mf_EmployeeAddress == null)
            {
                data.mf_EmployeeAddress = new mf_EmployeeAddress() { ObjectState = ObjectState.Added };
            }
            else
            {
                data.mf_EmployeeAddress.ObjectState = ObjectState.Modified;
            }

            data.mf_EmployeeAddress.address1 = model.address1;
            data.mf_EmployeeAddress.address2 = model.address2;
            data.mf_EmployeeAddress.address3 = model.address3;
            data.mf_EmployeeAddress.countryId = model.countryId;
            data.mf_EmployeeAddress.city = model.city;
            data.mf_EmployeeAddress.postalCode = model.postalCode;

            data.mf_EmployeeAddress.updatedBy = userId;
            data.mf_EmployeeAddress.updatedDate = DateTime.Now;

            data.updatedBy = userId;
            data.updatedDate = DateTime.Now;

            this._repoEmployee.Update(data);
            this._unitOfWork.Save();
            model.pictureExtension = data.pictureExtension;
        }

        public void Delete(int employeeId)
        {
            var data = this._repoEmployee.Find(employeeId);

            data.deleted = true;
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;

            this._repoEmployee.Update(data);
            this._unitOfWork.Save();
        }

        public Employee201Model Employee201FileGetByEmployeeId(int employeeId)
        {
            var data = this._repoEmployee.Query().Filter(x => x.id == employeeId)
                .Get()
                .Select(x => x.mf_Employee201)
                .Select(x => new Employee201Model()
                {
                    id = x.id,
                    employeeId = employeeId,
                    employeeCode = x.employeeCode,
                    departmentId = x.departmentId,
                    departmentSectionId = x.departmentSectionId,
                    positionId = x.positionId,
                    email = x.email,
                    employmentTypeId = x.employmentTypeId,
                    positionLevel = x.positionLevel,
                    dateHired = x.dateHired,
                    resignedDate = x.resignedDate,
                    employmentStatusId = x.employmentStatusId,
                    agencyId = x.agencyId,

                    payrollGroupId = x.payrollGroupId,
                    taxStatus = x.taxStatus,

                    timeSheetRequired = x.timeSheetRequired,
                    entitledUnworkRegularHoliday = x.entitledUnworkRegularHoliday,
                    entitledUnworkSpecialHoliday = x.entitledUnworkSpecialHoliday,
                    entitledOvertime = x.entitledOvertime,
                    entitledHolidayPay = x.entitledHolidayPay,
                    confidential = x.confidential,
                })
                .FirstOrDefault();

            return data;
        }

        public void Employee201Update(int employeeId, Employee201Model model)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                var emp = this._repoEmployee.Query().Filter(x => x.id == employeeId).Include(x => x.mf_Employee201).Get().FirstOrDefault();
                var data = emp.mf_Employee201;
                int userId = this.GetCurrentUserId();

                UpdateEntity<Employee201Model, mf_Employee201> uptEnt;

                if (data == null)
                {
                    uptEnt = this._repoEmployee201.PrepareEntity(model);
                    uptEnt.Insert();
                }
                else
                {
                    uptEnt = this._repoEmployee201.UpdateFromModel(data, model);
                    uptEnt.Update();
                }

                uptEnt.MatchAllDataField()
                    .SetValue(x => x.updatedBy, userId)
                    .SetValue(x => x.updatedDate, DateTime.Now);

                var entity = uptEnt.GetEntity();
                this._unitOfWork.Save();
                emp.employee201Id = entity.id;
                this._repoEmployee.Update(emp);
                this._unitOfWork.Save();

                ts.Complete();
            }
        }

        public IQueryable<EmployeeListModel> EmployeeAllGetQuery()
        {
            int companyId = this.GetCurrentCompanyId();
            var data = this._repoEmployee
                .Query().Filter(x => x.deleted == false && x.companyId == companyId)
                .Get()
                .Select(x => new EmployeeListModel()
                {
                    id = x.id,
                    name = x.lastName + ", " + x.firstName,
                    employeeCode = x.mf_Employee201.employeeCode,
                    department = x.mf_Employee201.mf_Department.description,
                    position = x.mf_Employee201.mf_Position.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public IQueryable<EmployeeListModel> EmployeeConfidentialGetQuery()
        {
            int companyId = this.GetCurrentCompanyId();
            var data = this._repoEmployee
                .Query().Filter(x => x.deleted == false && x.companyId == companyId && x.mf_Employee201.confidential)
                .Get()
                .Select(x => new EmployeeListModel()
                {
                    id = x.id,
                    name = x.lastName + ", " + x.firstName,
                    employeeCode = x.mf_Employee201.employeeCode,
                    department = x.mf_Employee201.mf_Department.description,
                    position = x.mf_Employee201.mf_Position.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public bool EmployeeIsConfidential(int id)
        {
            var data = this._repoEmployee.Query().Filter(x => x.id == id).Get().Select(x => x.mf_Employee201).FirstOrDefault();
            if (data == null) return false;
            return data.confidential;
        }

        public IQueryable<EmployeeListModel> EmployeeNonConfidentialGetQuery()
        {
            int companyId = this.GetCurrentCompanyId();
            var data = this._repoEmployee
                .Query().Filter(x => x.deleted == false && x.companyId == companyId && x.mf_Employee201.confidential == false)
                .Get()
                .Select(x => new EmployeeListModel()
                {
                    id = x.id,
                    name = x.lastName + ", " + x.firstName,
                    employeeCode = x.mf_Employee201.employeeCode,
                    department = x.mf_Employee201.mf_Department.description,
                    position = x.mf_Employee201.mf_Position.description,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        #region Work Days

        public void WorkDayAdd(int employeeId, int workDayId)
        {
            bool exists = this._repoEmployeeWorkDay.Query().Filter(x => x.employeeId == employeeId && x.workDayId == workDayId && !x.deleted).Get().Any();
            if (!exists)
            {
                int userId = this.GetCurrentUserId();
                this._repoEmployeeWorkDay.Insert(new mf_EmployeeWorkDay()
                {
                    employeeId = employeeId,
                    workDayId = workDayId,
                    updatedBy = userId,
                });
                this._unitOfWork.Save();
            }
        }

        public void WorkDayDelete(int employeeId, int workDayId)
        {
            this._repoEmployeeWorkDay.Query().Filter(x => x.employeeId == employeeId && x.workDayId == workDayId && !x.deleted).Get().ToList().ForEach(data =>
            {
                data.updatedBy = this.GetCurrentUserId();
                data.updatedDate = DateTime.Now;
                data.deleted = true;
                this._repoEmployeeWorkDay.Update(data);
            });
            this._unitOfWork.Save();
        }

        public IEnumerable<EmployeeWorkDayModel> WorkDayList(int employeeId)
        {
            var data = this._repoWorkDay
                .Query()
                .Get()
                .Select(x => new
                {
                    workDay = x,
                    hasWorkDay = x.mf_EmployeeWorkDays.Any(ewd => ewd.employeeId == employeeId && !ewd.deleted)
                })
                .ToList()
                .Select(x => new EmployeeWorkDayModel()
                {
                    workDayId = x.workDay.id,
                    name = x.workDay.code + " - " + x.workDay.description,
                    time = new DateTime(2016, 1, 1, x.workDay.fromTimeHour, x.workDay.fromTimeMinute, 0).ToString("hh:mm tt") +
                        " - " +
                        new DateTime(2016, 1, 1, x.workDay.toTimeHour, x.workDay.toTimeMinute, 0).ToString("hh:mm tt"),
                    description = string.Join(" - ", (new[] {
                        (x.workDay.monday ? "Mon" : ""),
                        (x.workDay.tuesday ? "Tue" : ""),
                        (x.workDay.wednesday ? "Wed" : ""),
                        (x.workDay.thursday ? "Thu" : ""),
                        (x.workDay.friday ? "Fri" : ""),
                        (x.workDay.saturday ? "Sat" : ""),
                        (x.workDay.sunday ? "Sun" : ""),
                    }).Where(d => !string.IsNullOrEmpty(d))),
                    hasWorkDay = x.hasWorkDay
                });
            return data;
        }

        #endregion Work Days

        #region Skill

        public void SkillDelete(int employeeId, int skillId)
        {
            var data = this._repoEmployeeSkill.Query().Filter(x => x.employeeId == employeeId && x.id == skillId).Get().FirstOrDefault();
            if (data != null)
            {
                this._repoEmployeeSkill.Delete(data);
                this._unitOfWork.Save();
            }
        }

        public IQueryable<EmployeeSkillModel> SkillList(int employeeId)
        {
            var data = this._repoEmployeeSkill.Query().Filter(x => x.employeeId == employeeId)
                .Get()
                .Join(this._enumReferenceService.GetQuery(ReferenceList.SKILL_PROFICIENCY_LEVEL), s => s.skillProficiencyLevel, p => p.value, (s, p) => new { Skill = s, PL = p })
                .Select(x => new EmployeeSkillModel()
                {
                    id = x.Skill.id,
                    skillName = x.Skill.skillName,
                    skillProficiencyLevel = x.PL,
                    updatedBy = x.Skill.sys_User.username,
                    updatedDate = x.Skill.updatedDate,
                });
            return data;
        }

        public void SkillUpdate(int employeeId, EmployeeSkillModel model)
        {
            int userId = this.GetCurrentUserId();
            if ((model.id ?? 0) != 0)
            {
                this._repoEmployeeSkill.FindAndUpdateFromModel(model, model.id.Value)
                    .SetValue(x => x.skillName, model.skillName)
                    .SetValue(x => x.skillProficiencyLevel, model.skillProficiencyLevel.value)
                    .SetValue(x => x.updatedBy, userId)
                    .SetValue(x => x.updatedDate, DateTime.Now)
                    .Update();
                this._unitOfWork.Save();
            }
            else
            {
                var ins = this._repoEmployeeSkill.Insert(new mf_EmployeeSkill()
                {
                    employeeId = employeeId,
                    skillName = model.skillName,
                    skillProficiencyLevel = model.skillProficiencyLevel.value,
                    updatedBy = userId,
                });
                this._unitOfWork.Save();
                model.id = ins.id;
            }
        }

        #endregion Skill

        #region Training

        public void TrainingDelete(int employeeId, int traningId)
        {
            var data = this._repoEmployeeTraining.Query().Filter(x => x.employeeId == employeeId && x.id == traningId).Get().FirstOrDefault();
            if (data != null)
            {
                this._repoEmployeeTraining.Delete(data);
                this._unitOfWork.Save();
            }
        }

        public IQueryable<EmployeeTrainingModel> TrainingList(int employeeId)
        {
            var data = this._repoEmployeeTraining.Query().Filter(x => x.employeeId == employeeId)
                .Get()
                .Select(x => new EmployeeTrainingModel()
                {
                    id = x.id,
                    trainingDate = x.trainingDate,
                    trainingName = x.trainingName,
                    description = x.description,
                    startDate = x.startDate,
                    endDate = x.endDate,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void TrainingUpdate(int employeeId, EmployeeTrainingModel model)
        {
            int userId = this.GetCurrentUserId();

            UpdateEntity<EmployeeTrainingModel, mf_EmployeeTraining> ue;

            if ((model.id ?? 0) != 0)
            {
                ue = this._repoEmployeeTraining.FindAndUpdateFromModel(model, model.id.Value);
                ue.Update();
            }
            else
            {
                ue = this._repoEmployeeTraining.PrepareEntity(model);
                ue.SetValue(x => x.employeeId, employeeId);
                ue.Insert();
            }

            ue.IgnoreErrorSetValue()
                .MatchAllDataField()
                .SetValue(x => x.updatedBy, userId)
                .SetValue(x => x.updatedDate, DateTime.Now);

            var ent = ue.GetEntity();
            this._unitOfWork.Save();
            model.id = ent.id;
        }

        #endregion Training

        #region Work History

        public void WorkHistoryCreate(int employeeId, EmployeeWorkHistoryModel model, out int workHistoryId)
        {
            int userId = this.GetCurrentUserId();
            var ins = this._repoEmployeeWorkHistory.PrepareEntity(model)
                .MatchAllDataField()
                .SetValue(x => x.employeeId, employeeId)
                .SetValue(x => x.updatedBy, userId)
                .Insert()
                .GetEntity();
            this._unitOfWork.Save();
            workHistoryId = ins.id;
        }

        public void WorkHistoryDelete(int employeeId, int workHistoryId)
        {
            int userId = this.GetCurrentUserId();
            var upt = this._repoEmployeeWorkHistory.Query().Filter(x => x.id == workHistoryId && x.employeeId == employeeId).Get().FirstOrDefault();

            upt.deleted = true;
            upt.updatedBy = userId;
            upt.updatedDate = DateTime.Now;
            this._repoEmployeeWorkHistory.Update(upt);

            this._unitOfWork.Save();
        }

        public IQueryable<EmployeeWorkHistoryModel> WorkHistoryList(int employeeId)
        {
            var data = this._repoEmployeeWorkHistory
                .Query().Filter(x => x.employeeId == employeeId)
                .Get()
                .Select(x => new EmployeeWorkHistoryModel()
                {
                    id = x.id,
                    companyName = x.companyName,
                    position = x.position,
                    joined = x.joinedMonth + "/" + x.joinedYear,
                    until = x.isPresent == true ? "Present" : (x.resignedMonth + "/" + x.resignedYear),
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                    isPresent = x.isPresent,
                    joinedMonth = x.joinedMonth,
                    joinedYear = x.joinedYear,
                    resignedMonth = x.resignedMonth,
                    resignedYear = x.resignedYear,
                });
            return data;
        }

        public void WorkHistoryUpdate(int employeeId, EmployeeWorkHistoryModel model)
        {
            int userId = this.GetCurrentUserId();
            var upt = this._repoEmployeeWorkHistory.Query().Filter(x => x.id == model.id && x.employeeId == employeeId).Get().FirstOrDefault();

            var data = this._repoEmployeeWorkHistory.UpdateFromModel(upt, model)
                .MatchAllDataField()
                .SetValue(x => x.updatedBy, userId)
                .SetValue(x => x.updatedDate, DateTime.Now)
                .Update();
            this._unitOfWork.Save();
        }

        #endregion Work History

        #region Identification Document

        public void IdentificationDocumentDelete(int employeeIdentificationDocumentId)
        {
            var data = this._repoEmployeeIdentificationDocument.Find(employeeIdentificationDocumentId);
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            data.deleted = true;
            this._repoEmployeeIdentificationDocument.Update(data);
            this._unitOfWork.Save();
        }

        public IQueryable<EmployeeIdentificationDocumentModel> IdentificationDocumentList(int employeeId)
        {
            var data = this._repoEmployeeIdentificationDocument.Query().Filter(x => x.employeeId == employeeId && !x.deleted)
                .Get()
                .Select(x => new EmployeeIdentificationDocumentModel()
                {
                    id = x.id,
                    IdentificationDocument = new Model.Sys.ReferenceModel()
                    {
                        value = x.sys_IdentificationDocument.id,
                        description = x.sys_IdentificationDocument.code + ": " + x.sys_IdentificationDocument.description,
                    },
                    idNumber = x.idNumber,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });
            return data;
        }

        public void IdentificationDocumentUpdate(int employeeId, EmployeeIdentificationDocumentModel model)
        {
            int userId = this.GetCurrentUserId();
            if ((model.id ?? 0) != 0)
            {
                this._repoEmployeeIdentificationDocument.FindAndUpdateFromModel(model, model.id.Value)
                    .SetValue(x => x.identificationDocumentId, model.IdentificationDocument.value)
                    .SetValue(x => x.idNumber, model.idNumber)
                    .SetValue(x => x.updatedBy, userId)
                    .SetValue(x => x.updatedDate, DateTime.Now)
                    .Update();
                this._unitOfWork.Save();
            }
            else
            {
                var ins = this._repoEmployeeIdentificationDocument.Insert(new mf_EmployeeIdentificationDocument()
                {
                    employeeId = employeeId,
                    idNumber = model.idNumber,
                    identificationDocumentId = model.IdentificationDocument.value,
                    updatedBy = userId,
                });
                this._unitOfWork.Save();
                model.id = ins.id;
            }
        }

        #endregion Identification Document

        #region Offenses

        public void OffenseDelete(int employeeOffenseId)
        {
            var data = this._repoEmployeeOffense.Find(employeeOffenseId);
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            data.deleted = true;
            this._repoEmployeeOffense.Update(data);
            this._unitOfWork.Save();
        }

        public IQueryable<EmployeeOffenseModel> OffenseList(int employeeId)
        {
            var query = from eo in this._repoEmployeeOffense.Query().Filter(x => x.employeeId == employeeId && !x.deleted).Get()
                        join pd in this._enumReferenceService.GetQuery(ReferenceList.PENALTY_DEGREE) on eo.degree equals pd.value
                        select new EmployeeOffenseModel()
                        {
                            id = eo.id,
                            Offense = new ReferenceModel()
                            {
                                value = eo.mf_Offense.id,
                                description = eo.mf_Offense.description,
                            },
                            offenseDate = eo.offenseDate,
                            memoDate = eo.memoDate,
                            degree = pd,
                            penaltyType = new ReferenceModel()
                            {
                                value = eo.mf_PenaltyType.id,
                                description = eo.mf_PenaltyType.description
                            },
                            frequency = eo.frequency,
                            startDate = eo.startDate,
                            endDate = eo.endDate,
                            remarks = eo.remarks,
                            updatedBy = eo.sys_User.username,
                            updatedDate = eo.updatedDate,
                        };

            return query;
        }

        public void OffenseUpdate(int employeeId, EmployeeOffenseModel model)
        {
            int userId = this.GetCurrentUserId();

            UpdateEntity<EmployeeOffenseModel, mf_EmployeeOffense> ue;

            if ((model.id ?? 0) != 0)
            {
                ue = this._repoEmployeeOffense.FindAndUpdateFromModel(model, model.id.Value);
                ue.Update();
            }
            else
            {
                ue = this._repoEmployeeOffense.PrepareEntity(model);
                ue.Insert();
            }

            ue.IgnoreErrorSetValue()
                .MatchAllDataField()
                .SetValue(x => x.employeeId, employeeId)
                .SetValue(x => x.offenseId, model.Offense.value)
                .SetValue(x => x.penaltyTypeId, model.penaltyType.value)
                .SetValue(x => x.degree, model.degree.value)
                .SetValue(x => x.updatedBy, userId)
                .SetValue(x => x.updatedDate, DateTime.Now);

            var ent = ue.GetEntity();
            this._unitOfWork.Save();
            model.id = ent.id;
        }

        #endregion Offenses

        #region Allowances

        public void AllowanceDelete(int employeeAllowanceId)
        {
            var data = this._repoEmployeeAllowance.Find(employeeAllowanceId);
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            data.deleted = true;
            this._repoEmployeeAllowance.Update(data);
            this._unitOfWork.Save();
        }

        public IQueryable<EmployeeAllowanceModel> AllowanceList(int employeeId)
        {
            var query = this._repoEmployeeAllowance.Query().Filter(x => x.employeeId == employeeId && !x.deleted && !x.mf_Allowance.deleted)
                .Select(x => new EmployeeAllowanceModel()
                {
                    id = x.id,
                    Allowance = new ReferenceModel()
                    {
                        value = x.mf_Allowance.id,
                        description = x.mf_Allowance.description,
                    },
                    amount = x.amount,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });

            return query;
        }

        public void AllowanceUpdate(int employeeId, EmployeeAllowanceModel model)
        {
            int userId = this.GetCurrentUserId();

            UpdateEntity<EmployeeAllowanceModel, mf_EmployeeAllowance> ue;

            if ((model.id ?? 0) != 0)
            {
                ue = this._repoEmployeeAllowance.FindAndUpdateFromModel(model, model.id.Value);
                ue.Update();
            }
            else
            {
                ue = this._repoEmployeeAllowance.PrepareEntity(model);
                ue.Insert();
            }

            ue.IgnoreErrorSetValue()
                .MatchAllDataField()
                .SetValue(x => x.employeeId, employeeId)
                .SetValue(x => x.allowanceId, model.Allowance.value)
                .SetValue(x => x.updatedBy, userId)
                .SetValue(x => x.updatedDate, DateTime.Now);

            var ent = ue.GetEntity();
            this._unitOfWork.Save();
            model.id = ent.id;
        }

        #endregion Allowances

        #region Deductions

        public void DeductionDelete(int employeeDeductionId)
        {
            var data = this._repoEmployeeDeduction.Find(employeeDeductionId);
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            data.deleted = true;
            this._repoEmployeeDeduction.Update(data);
            this._unitOfWork.Save();
        }

        public IQueryable<EmployeeDeductionModel> DeductionList(int employeeId)
        {
            var query = this._repoEmployeeDeduction.Query().Filter(x => x.employeeId == employeeId && !x.deleted && !x.mf_Deduction.deleted)
                .Select(x => new EmployeeDeductionModel()
                {
                    id = x.id,
                    Deduction = new ReferenceModel()
                    {
                        value = x.mf_Deduction.id,
                        description = x.mf_Deduction.description,
                    },
                    amount = x.amount,
                    updatedBy = x.sys_User.username,
                    updatedDate = x.updatedDate,
                });

            return query;
        }

        public void DeductionUpdate(int employeeId, EmployeeDeductionModel model)
        {
            int userId = this.GetCurrentUserId();

            UpdateEntity<EmployeeDeductionModel, mf_EmployeeDeduction> ue;

            if ((model.id ?? 0) != 0)
            {
                ue = this._repoEmployeeDeduction.FindAndUpdateFromModel(model, model.id.Value);
                ue.Update();
            }
            else
            {
                ue = this._repoEmployeeDeduction.PrepareEntity(model);
                ue.Insert();
            }

            ue.IgnoreErrorSetValue()
                .MatchAllDataField()
                .SetValue(x => x.employeeId, employeeId)
                .SetValue(x => x.deductionId, model.Deduction.value)
                .SetValue(x => x.updatedBy, userId)
                .SetValue(x => x.updatedDate, DateTime.Now);

            var ent = ue.GetEntity();
            this._unitOfWork.Save();
            model.id = ent.id;
        }

        #endregion Deductions

        #region BasicPay

        public void BasicPayDelete(int employeeBasicPayId)
        {
            var data = this._repoEmployeeBasicPay.Find(employeeBasicPayId);
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            data.deleted = true;
            this._repoEmployeeBasicPay.Update(data);
            this._unitOfWork.Save();
        }

        public IQueryable<EmployeeBasicPayModel> BasicPayList(int employeeId)
        {
            var payRateType = this._enumReferenceService.GetQuery(ReferenceList.PAY_RATE_TYPE);
            var query = from bp in this._repoEmployeeBasicPay.Query().Filter(x => x.employeeId == employeeId).Get()
                        join prt in payRateType on bp.rateType equals prt.value
                        select new EmployeeBasicPayModel()
                        {
                            id = bp.id,
                            basicPay = bp.basicPay,
                            rateType = prt,
                            updatedBy = bp.sys_User.username,
                            updatedDate = bp.updatedDate,
                        };

            return query;
        }

        public void BasicPayUpdate(int employeeId, EmployeeBasicPayModel model)
        {
            int userId = this.GetCurrentUserId();

            UpdateEntity<EmployeeBasicPayModel, mf_EmployeeBasicPay> ue;

            if ((model.id ?? 0) != 0)
            {
                ue = this._repoEmployeeBasicPay.FindAndUpdateFromModel(model, model.id.Value);
                ue.Update();
            }
            else
            {
                ue = this._repoEmployeeBasicPay.PrepareEntity(model);
                ue.Insert();
            }

            ue.IgnoreErrorSetValue()
                .SetValue(x => x.employeeId, employeeId)
                .SetValue(x => x.basicPay, model.basicPay)
                .SetValue(x => x.rateType, model.rateType.value)
                .SetValue(x => x.updatedBy, userId)
                .SetValue(x => x.updatedDate, DateTime.Now);

            var ent = ue.GetEntity();
            this._unitOfWork.Save();
            model.id = ent.id;
        }

        #endregion BasicPay

        #region BalanceLeave

        public void BalanceLeaveDelete(int employeeBalanceLeaveId)
        {
            var data = this._repoEmployeeBalanceLeave.Find(employeeBalanceLeaveId);
            data.updatedBy = this.GetCurrentUserId();
            data.updatedDate = DateTime.Now;
            data.deleted = true;
            this._repoEmployeeBalanceLeave.Update(data);
            this._unitOfWork.Save();
        }

        public IQueryable<EmployeeBalanceLeaveModel> BalanceLeaveList(int employeeId)
        {
            var leaveType = this._repoApplicationRequestType.Query().Filter(x => x.requiredLeavePoints)
                .Select(x => new ReferenceModel()
                {
                    value = x.id,
                    description = x.description,
                });

            var query = from bp in this._repoEmployeeBalanceLeave.Query().Filter(x => x.employeeId == employeeId).Get()
                        join prt in leaveType on bp.applicationRequestTypeId equals prt.value
                        select new EmployeeBalanceLeaveModel()
                        {
                            id = bp.id,
                            balance = bp.balance,
                            leaveType = prt,
                            updatedBy = bp.sys_User.username,
                            updatedDate = bp.updatedDate,
                        };

            return query;
        }

        public void BalanceLeaveUpdate(int employeeId, EmployeeBalanceLeaveModel model)
        {
            int userId = this.GetCurrentUserId();

            UpdateEntity<EmployeeBalanceLeaveModel, mf_EmployeeBalanceLeave> ue;

            if ((model.id ?? 0) != 0)
            {
                ue = this._repoEmployeeBalanceLeave.FindAndUpdateFromModel(model, model.id.Value);
                ue.Update();
            }
            else
            {
                ue = this._repoEmployeeBalanceLeave.PrepareEntity(model);
                ue.Insert();
            }

            ue.IgnoreErrorSetValue()
                .SetValue(x => x.employeeId, employeeId)
                .SetValue(x => x.balance, model.balance)
                .SetValue(x => x.applicationRequestTypeId, model.leaveType.value)
                .SetValue(x => x.updatedBy, userId)
                .SetValue(x => x.updatedDate, DateTime.Now);

            var ent = ue.GetEntity();
            this._unitOfWork.Save();
            model.id = ent.id;
        }

        #endregion BalanceLeave
    }
}