using HRIS.Model.MasterFile;
using System.Collections.Generic;
using System.Linq;

namespace HRIS.Service.MasterFile
{
    public interface IEmployeeService
    {
        void AllowanceDelete(int employeeAllowanceId);

        IQueryable<EmployeeAllowanceModel> AllowanceList(int employeeId);

        void AllowanceUpdate(int employeeId, EmployeeAllowanceModel model);

        void BalanceLeaveDelete(int employeeBalanceLeaveId);

        IQueryable<EmployeeBalanceLeaveModel> BalanceLeaveList(int employeeId);

        void BalanceLeaveUpdate(int employeeId, EmployeeBalanceLeaveModel model);

        void BasicInfoCreate(EmployeeBasicInfoModel model, out int employeeId);

        EmployeeBasicInfoModel BasicInfoGetByEmployeeId(int employeeId);

        void BasicInfoUpdate(int employeeId, EmployeeBasicInfoModel model);

        void BasicPayDelete(int employeeBasicPayId);

        IQueryable<EmployeeBasicPayModel> BasicPayList(int employeeId);

        void BasicPayUpdate(int employeeId, EmployeeBasicPayModel model);

        void DeductionDelete(int employeeDeductionId);

        IQueryable<EmployeeDeductionModel> DeductionList(int employeeId);

        void DeductionUpdate(int employeeId, EmployeeDeductionModel model);

        void Delete(int employeeId);

        Employee201Model Employee201FileGetByEmployeeId(int employeeId);

        void Employee201Update(int employeeId, Employee201Model model);

        IQueryable<EmployeeListModel> EmployeeAllGetQuery();

        IQueryable<EmployeeListModel> EmployeeConfidentialGetQuery();

        bool EmployeeIsConfidential(int id);

        IQueryable<EmployeeListModel> EmployeeNonConfidentialGetQuery();

        void IdentificationDocumentDelete(int employeeIdentificationDocumentId);

        IQueryable<EmployeeIdentificationDocumentModel> IdentificationDocumentList(int employeeId);

        void IdentificationDocumentUpdate(int employeeId, EmployeeIdentificationDocumentModel model);

        void OffenseDelete(int employeeOffenseId);

        IQueryable<EmployeeOffenseModel> OffenseList(int employeeId);

        void OffenseUpdate(int employeeId, EmployeeOffenseModel model);

        void QuickUpdateEmployee(EmployeeQuickUpdateModel model);

        IQueryable<EmployeeQuickUpdateModel> QuickUpdateEmployeeList();

        void SkillDelete(int employeeId, int skillId);

        IQueryable<EmployeeSkillModel> SkillList(int employeeId);

        void SkillUpdate(int employeeId, EmployeeSkillModel model);

        void TrainingDelete(int employeeId, int trainingId);

        IQueryable<EmployeeTrainingModel> TrainingList(int employeeId);

        void TrainingUpdate(int employeeId, EmployeeTrainingModel model);

        void WorkDayAdd(int employeeId, int workDayId);

        void WorkDayDelete(int employeeId, int workDayId);

        IEnumerable<EmployeeWorkDayModel> WorkDayList(int employeeId);

        void WorkHistoryCreate(int employeeId, EmployeeWorkHistoryModel model, out int workHistoryId);

        void WorkHistoryDelete(int employeeId, int workHistoryId);

        IQueryable<EmployeeWorkHistoryModel> WorkHistoryList(int employeeId);

        void WorkHistoryUpdate(int employeeId, EmployeeWorkHistoryModel model);
    }
}