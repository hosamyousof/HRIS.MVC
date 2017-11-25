namespace HRIS.Data.Migrations
{
    using HRIS.Data.Entity;
    using Repository;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<HRIS.Data.HRISContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HRIS.Data.HRISContext context)
        {
            var hris = new HRISContext();
            var unitOfWork = new UnitOfWork(hris);

            var repo = new
            {
                Country = new Repository<mf_Country>(hris),
                Company = new Repository<sys_Company>(hris),
                User = new Repository<sys_User>(hris),
                Setting = new Repository<sys_Setting>(hris),
                CompanySetting = new Repository<sys_CompanySetting>(hris),
            };

            var settingDefaultPass = repo.Setting.Insert(new sys_Setting() { name = "DEFAULT_PASSWORD", description = "Default Password for New and Reset User" });
            var settingHashsha = repo.Setting.Insert(new sys_Setting() { name = "HRIS_HASHSHA_KEY", description = "HRIS_HASHSHA_KEY" });

            var philippines = new mf_Country() { code = "PH", description = "Philippines" };
            repo.Country.Insert(philippines);

            var user_admin = new sys_User()
            {
                username = "admin",
                password = "JYZAJ9KCpK80FCErnsksqw==",
                hashKey = "29b373cae1fb59b32052386063fb100",
                vector = "R9_XFXT2U7CaaP_5",
                email = "mynrd@live.com",
                status = 1,
            };
            repo.User.Insert(user_admin);
            unitOfWork.Save();

            philippines.updatedBy = user_admin.id;
            repo.Country.Update(philippines);

            user_admin.updatedBy = user_admin.id;
            repo.User.Update(user_admin);
            unitOfWork.Save();

            var company = new sys_Company()
            {
                code = "TEST-001",
                businessName = "Test Company",
                updatedBy = user_admin.id,
            };
            repo.Company.Insert(company);
            unitOfWork.Save();

            repo.CompanySetting.Insert(new sys_CompanySetting() { companyId = company.id, settingId = settingDefaultPass.id, value = "P@ssw0rd", updatedBy = user_admin.id });
            repo.CompanySetting.Insert(new sys_CompanySetting() { companyId = company.id, settingId = settingHashsha.id, value = "HRIS_KEY1", updatedBy = user_admin.id });
            unitOfWork.Save();

            user_admin.companyId = company.id;
            repo.User.Update(user_admin);
            unitOfWork.Save();

            AddEnumReference(unitOfWork, context, company.id);
            PrepareMenu(unitOfWork, context, user_admin.id);
            PreparePermission(unitOfWork, context, company.id, user_admin.id);
            PrepareRole(unitOfWork, context, company.id, user_admin.id);
        }

        private void PrepareRole(UnitOfWork unitOfWork, HRISContext context, Guid companyId, Guid userId)
        {
            var repo = new Repository<sys_Role>(context);
            repo.Insert(new sys_Role() { code = "ADMIN", description = "Administrators", companyId = companyId, updatedBy = userId });
            unitOfWork.Save();
        }

        private void PreparePermission(UnitOfWork unitOfWork, HRISContext context, Guid companyId, Guid userId)
        {
            var repo = new Repository<sys_Permission>(context);
            repo.Insert(new sys_Permission() { code = "VIEW_CONFIDENTIAL_EMPLOYEE", description = "View Confidential Employee", companyId = companyId, updatedBy = userId });
            repo.Insert(new sys_Permission() { code = "VIEW_EMPLOYEE_SALARY", description = "View Employee Salary", companyId = companyId, updatedBy = userId });
            repo.Insert(new sys_Permission() { code = "VIEW_ADMIN_PANEL", description = "View Admin Panel", companyId = companyId, updatedBy = userId });
            repo.Insert(new sys_Permission() { code = "EMPLOYEE_QUICK_UPDATE", description = "EMPLOYEE_QUICK_UPDATE", companyId = companyId, updatedBy = userId });
            repo.Insert(new sys_Permission() { code = "DEVELOPER", description = "DEVELOPER", companyId = companyId, updatedBy = userId });
            repo.Insert(new sys_Permission() { code = "EMPLOYEE_MAINTENANCE", description = "EMPLOYEE_MAINTENANCE", companyId = companyId, updatedBy = userId });

            unitOfWork.Save();
        }

        private void PrepareMenu(UnitOfWork unitOfWork, HRISContext context, Guid id)
        {
            var repo = new Repository<sys_Menu>(context);

            repo.Insert(CreateMenu("-- Free Text Menu --", null, null, id));
            CreateMenu("Home", "Home", "Index", id);
            CreateMenu("Employee Quick update", "Employee", "QuickUpdate", id);
            CreateMenu("Employee List (Confidential)", "Employee", "EmployeeConfi", id);
            CreateMenu("Employee List (Non-Confidential)", "Employee", "EmployeeNonConfi", id);
            CreateMenu("Employee Attendance", "Attendance", "Index", id);
            CreateMenu("User", "Account", "UserMaintenance", id);
            CreateMenu("Role", "Role", "Index", id);
            CreateMenu("Permission", "Permission", "Index", id);
            CreateMenu("Company Information", "Company", "Index", id);
            CreateMenu("Location", "Location", "Index", id);
            CreateMenu("Application Approver", "ApplicationRequest", "DepartmentSectionApprover", id);
            CreateMenu("Work Days", "WorkDay", "Index", id);
            CreateMenu("Holiday Type", "HolidayType", "Index", id);
            CreateMenu("Holidays", "Holiday", "Index", id);
            CreateMenu("Payroll Group", "PayrollGroup", "Index", id);
            CreateMenu("Employment Status", "EmploymentStatus", "Index", id);
            CreateMenu("Employment Type", "EmploymentType", "Index", id);
            CreateMenu("Identification Document", "IdentificationDocument", "Index", id);
            CreateMenu("Department", "Department", "Index", id);
            CreateMenu("Position", "Position", "Index", id);
            CreateMenu("Allowance", "Allowance", "Index", id);
            CreateMenu("Offense", "Offense", "Index", id);
            CreateMenu("Penalty Type", "PenaltyType", "Index", id);
            CreateMenu("Update WorkDay Attendance", "Attendance", "UpdateWorkDayAttendance", id);
            CreateMenu("Section", "Department", "Section", id);
            CreateMenu("Cut Off Attendance", "Attendance", "CutOffAttendance", id);
            CreateMenu("My Approval", "ApplicationRequest", "MyApproval", id);
            CreateMenu("Request Leave", "ApplicationRequest", "RequestLeave", id);
            CreateMenu("Deduction", "Deduction", "Index", id);

            unitOfWork.Save();
        }

        private sys_Menu CreateMenu(string description, string controllerName, string actionName, Guid updatedBy)
        {
            return new sys_Menu()
            {
                description = description,
                controllerName = controllerName,
                actionName = actionName,
                updatedBy = updatedBy,
            };
        }

        private void AddEnumReference(UnitOfWork unitOfWork, HRISContext context, Guid companyId)
        {
            var repo = new Repository<sys_EnumReference>(context);
            repo.Insert(new sys_EnumReference() { name = "USER_STATUS", value = 1, description = "Active", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "USER_STATUS", value = 2, description = "Disabled", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "USER_STATUS", value = 3, description = "Locked", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "USER_STATUS", value = 4, description = "Reset Password", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MARITAL_STATUS", value = 1, description = "Single", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MARITAL_STATUS", value = 2, description = "Married", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MARITAL_STATUS", value = 3, description = "Separated", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MARITAL_STATUS", value = 4, description = "Widowed", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MARITAL_STATUS", value = 5, description = "Divorced", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "GENDER", value = 1, description = "Male", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "GENDER", value = 2, description = "Female", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "POSITION_LEVEL", value = 1, description = "Junior", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "POSITION_LEVEL", value = 2, description = "Senior", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "POSITION_LEVEL", value = 3, description = "Team Lead", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "POSITION_LEVEL", value = 4, description = "Manager", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "POSITION_LEVEL", value = 5, description = "Executive", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "SKILL_PROFICIENCY_LEVEL", value = 1, description = "Beginner", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "SKILL_PROFICIENCY_LEVEL", value = 2, description = "Awareness", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "SKILL_PROFICIENCY_LEVEL", value = 3, description = "Knowledge", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "SKILL_PROFICIENCY_LEVEL", value = 4, description = "Expert", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MONTH_LIST", value = 1, description = "January", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MONTH_LIST", value = 2, description = "February", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MONTH_LIST", value = 3, description = "March", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MONTH_LIST", value = 4, description = "April", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MONTH_LIST", value = 5, description = "May", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MONTH_LIST", value = 6, description = "June", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MONTH_LIST", value = 7, description = "July", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MONTH_LIST", value = 8, description = "August", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MONTH_LIST", value = 9, description = "September", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MONTH_LIST", value = 10, description = "October", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MONTH_LIST", value = 11, description = "November", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "MONTH_LIST", value = 12, description = "December", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PAY_RATE_TYPE", value = 1, description = "Daily", displayOrder = 2, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PAY_RATE_TYPE", value = 2, description = "Monthly", displayOrder = 4, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TAX_STATUS", value = 1, description = "Single", displayOrder = 1, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TAX_STATUS", value = 2, description = "Single - 1 Dependent", displayOrder = 2, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TAX_STATUS", value = 3, description = "Single - 2 Dependents", displayOrder = 3, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TAX_STATUS", value = 4, description = "Single - 3 Dependents", displayOrder = 4, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TAX_STATUS", value = 5, description = "Single - 4 Dependents", displayOrder = 5, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TAX_STATUS", value = 6, description = "Married", displayOrder = 6, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TAX_STATUS", value = 7, description = "Married - 1 Dependent", displayOrder = 7, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TAX_STATUS", value = 8, description = "Married - 2 Dependents", displayOrder = 8, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TAX_STATUS", value = 9, description = "Married - 3 Dependents", displayOrder = 9, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TAX_STATUS", value = 10, description = "Married - 4 Dependents", displayOrder = 10, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TAX_STATUS", value = 11, description = "No Exemption (Z)", displayOrder = 11, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 0, description = "12 AM", displayOrder = 1, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 1, description = "1 AM", displayOrder = 2, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 2, description = "2 AM", displayOrder = 3, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 3, description = "3 AM", displayOrder = 4, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 4, description = "4 AM", displayOrder = 5, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 5, description = "5 AM", displayOrder = 6, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 6, description = "6 AM", displayOrder = 7, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 7, description = "7 AM", displayOrder = 8, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 8, description = "8 AM", displayOrder = 9, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 9, description = "9 AM", displayOrder = 10, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 10, description = "10 AM", displayOrder = 11, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 11, description = "11 AM", displayOrder = 12, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 12, description = "12 PM", displayOrder = 13, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 13, description = "1 PM", displayOrder = 14, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 14, description = "2 PM", displayOrder = 15, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 15, description = "3 PM", displayOrder = 16, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 16, description = "4 PM", displayOrder = 17, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 17, description = "5 PM", displayOrder = 18, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 18, description = "6 PM", displayOrder = 19, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 19, description = "7 PM", displayOrder = 20, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 20, description = "8 PM", displayOrder = 21, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 21, description = "9 PM", displayOrder = 22, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 22, description = "10 PM", displayOrder = 23, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "HOUR", value = 23, description = "11 PM", displayOrder = 24, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TIME_LOG_TYPE", value = 0, description = "Duty On", displayOrder = 1, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TIME_LOG_TYPE", value = 1, description = "Duty Off", displayOrder = 2, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TIME_LOG_TYPE", value = 2, description = "Overtime Begin", displayOrder = 3, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TIME_LOG_TYPE", value = 3, description = "Overtime End", displayOrder = 4, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PENALTY_DEGREE", value = 1, description = "Minor", displayOrder = 1, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PENALTY_DEGREE", value = 2, description = "Moderate", displayOrder = 2, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PENALTY_DEGREE", value = 3, description = "Serious", displayOrder = 3, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "CUT_OFF_ATTENDANCE", value = 1, description = "Draft", displayOrder = 1, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "CUT_OFF_ATTENDANCE", value = 2, description = "Submitted", displayOrder = 2, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "CUT_OFF_ATTENDANCE", value = 3, description = "Accept", displayOrder = 3, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TIME_LOG_TYPE", value = 4, description = "Lock Out", displayOrder = 5, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "TIME_LOG_TYPE", value = 5, description = "Lock In", displayOrder = 6, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "ERROR_TYPE", value = 1, description = "User Error", displayOrder = 2, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "ERROR_TYPE", value = 2, description = "System Error", displayOrder = 2, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "CUT_OFF_ATTENDANCE", value = 4, description = "Reject", displayOrder = 4, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "CUT_OFF_ATTENDANCE", value = 5, description = "Posted", displayOrder = 5, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "CUT_OFF_ATTENDANCE", value = 6, description = "Cancel", displayOrder = 6, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PAYROLL_STATUS", value = 1, description = "New", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PAYROLL_STATUS", value = 2, description = "Verify", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PAYROLL_STATUS", value = 3, description = "Posted", displayOrder = 0, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PAY_RATE_TYPE", value = 3, description = "Hourly", displayOrder = 1, field1 = "", field2 = "", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PAYSLIP_DETAILS", value = 1, description = "No Of Days", displayOrder = 0, field1 = "INFO", field2 = "True", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PAYSLIP_DETAILS", value = 2, description = "No. Of Abesences/Tardiness", displayOrder = 0, field1 = "INFO", field2 = "True", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PAYSLIP_DETAILS", value = 3, description = "No. Of Overtime Hours", displayOrder = 0, field1 = "INFO", field2 = "True", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PAYSLIP_DETAILS", value = 4, description = "Daily/Monthly Rate", displayOrder = 0, field1 = "INFO", field2 = "True", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PAYSLIP_DETAILS", value = 5, description = "Basic Pay", displayOrder = 0, field1 = "INFO", field2 = "True", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PAYSLIP_DETAILS", value = 6, description = "Overtime Pay", displayOrder = 0, field1 = "EARNINGS", field2 = "True", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PAYSLIP_DETAILS", value = 7, description = "W/HoldingTask", displayOrder = 0, field1 = "DEDUCTION", field2 = "True", companyId = companyId });
            repo.Insert(new sys_EnumReference() { name = "PAY_RATE_TYPE", value = 4, description = "Semi-Monthly", displayOrder = 3, field1 = "", field2 = "", companyId = companyId });
            unitOfWork.Save();
        }
    }
}