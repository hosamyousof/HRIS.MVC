using HRIS.Model.MasterFile;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HRIS.Service.MasterFile
{
    public interface IEmployeeService
    {
        void AllowanceDelete(Guid employeeAllowanceId);

        IQueryable<EmployeeAllowanceModel> AllowanceList(Guid employeeId);

        void AllowanceUpdate(Guid employeeId, EmployeeAllowanceModel model);

        void BalanceLeaveDelete(Guid employeeBalanceLeaveId);

        IQueryable<EmployeeBalanceLeaveModel> BalanceLeaveList(Guid employeeId);

        void BalanceLeaveUpdate(Guid employeeId, EmployeeBalanceLeaveModel model);

        void BasicInfoCreate(EmployeeBasicInfoModel model, out Guid employeeId);

        EmployeeBasicInfoModel BasicInfoGetByEmployeeId(Guid employeeId);

        void BasicInfoUpdate(Guid employeeId, EmployeeBasicInfoModel model);

        void BasicPayDelete(Guid employeeBasicPayId);

        IQueryable<EmployeeBasicPayModel> BasicPayList(Guid employeeId);

        void BasicPayUpdate(Guid employeeId, EmployeeBasicPayModel model);

        void DeductionDelete(Guid employeeDeductionId);

        IQueryable<EmployeeDeductionModel> DeductionList(Guid employeeId);

        void DeductionUpdate(Guid employeeId, EmployeeDeductionModel model);

        void Delete(Guid employeeId);

        Employee201Model Employee201FileGetByEmployeeId(Guid employeeId);

        void Employee201Update(Guid employeeId, Employee201Model model);

        IQueryable<EmployeeListModel> EmployeeAllGetQuery();

        IQueryable<EmployeeListModel> EmployeeConfidentialGetQuery();

        bool EmployeeIsConfidential(Guid id);

        IQueryable<EmployeeListModel> EmployeeNonConfidentialGetQuery();

        void IdentificationDocumentDelete(Guid employeeIdentificationDocumentId);

        IQueryable<EmployeeIdentificationDocumentModel> IdentificationDocumentList(Guid employeeId);

        void IdentificationDocumentUpdate(Guid employeeId, EmployeeIdentificationDocumentModel model);

        void OffenseDelete(Guid employeeOffenseId);

        IQueryable<EmployeeOffenseModel> OffenseList(Guid employeeId);

        void OffenseUpdate(Guid employeeId, EmployeeOffenseModel model);

        void QuickUpdateEmployee(EmployeeQuickUpdateModel model);

        IQueryable<EmployeeQuickUpdateModel> QuickUpdateEmployeeList();

        void SkillDelete(Guid employeeId, Guid skillId);

        IQueryable<EmployeeSkillModel> SkillList(Guid employeeId);

        void SkillUpdate(Guid employeeId, EmployeeSkillModel model);

        void TrainingDelete(Guid employeeId, Guid trainingId);

        IQueryable<EmployeeTrainingModel> TrainingList(Guid employeeId);

        void TrainingUpdate(Guid employeeId, EmployeeTrainingModel model);

        void WorkDayAdd(Guid employeeId, Guid workDayId);

        void WorkDayDelete(Guid employeeId, Guid workDayId);

        IEnumerable<EmployeeWorkDayModel> WorkDayList(Guid employeeId);

        void WorkHistoryCreate(Guid employeeId, EmployeeWorkHistoryModel model, out Guid workHistoryId);

        void WorkHistoryDelete(Guid employeeId, Guid workHistoryId);

        IQueryable<EmployeeWorkHistoryModel> WorkHistoryList(Guid employeeId);

        void WorkHistoryUpdate(Guid employeeId, EmployeeWorkHistoryModel model);
    }
}