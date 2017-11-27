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

            var user_admin = new sys_User() { username = "admin", password = "JYZAJ9KCpK80FCErnsksqw==", hashKey = "29b373cae1fb59b32052386063fb100", vector = "R9_XFXT2U7CaaP_5", email = "mynrd@live.com", status = 1, superAdmin = true, };
            repo.User.Insert(user_admin);
            unitOfWork.Save();

            philippines.updatedBy = user_admin.id;
            repo.Country.Update(philippines);

            user_admin.updatedBy = user_admin.id;
            repo.User.Update(user_admin);
            unitOfWork.Save();

            var company = new sys_Company() { code = "TEST-001", businessName = "Test Company", updatedBy = user_admin.id, };
            repo.Company.Insert(company);
            unitOfWork.Save();

            repo.CompanySetting.Insert(new sys_CompanySetting() { companyId = company.id, settingId = settingDefaultPass.id, value = "P@ssw0rd", updatedBy = user_admin.id });
            repo.CompanySetting.Insert(new sys_CompanySetting() { companyId = company.id, settingId = settingHashsha.id, value = "HRIS_KEY1", updatedBy = user_admin.id });
            unitOfWork.Save();

            user_admin.companyId = company.id;
            repo.User.Update(user_admin);
            unitOfWork.Save();

            AddEnumReference(unitOfWork, context, company.id);
            PreparePermission(unitOfWork, context, company.id, user_admin.id);
            PrepareRole(unitOfWork, context, company.id, user_admin.id);
        }

        private void PrepareRole(UnitOfWork unitOfWork, HRISContext context, Guid companyId, Guid adminUserId)
        {
            var repoRole = new Repository<sys_Role>(context);
            var repoUserRole = new Repository<sys_UserRole>(context);
            var role = repoRole.Insert(new sys_Role() { code = "ADMIN", description = "Administrators", companyId = companyId, updatedBy = adminUserId });
            unitOfWork.Save();

            repoUserRole.Insert(new sys_UserRole() { roleId = role.id, userId = adminUserId, updatedBy = adminUserId, });
            unitOfWork.Save();

            PrepareMenu(unitOfWork, context, role.id, adminUserId);
        }

        private void PreparePermission(UnitOfWork unitOfWork, HRISContext context, Guid companyId, Guid adminUserId)
        {
            var repo = new Repository<sys_Permission>(context);
            repo.Insert(new sys_Permission() { code = "VIEW_CONFIDENTIAL_EMPLOYEE", description = "View Confidential Employee", companyId = companyId, updatedBy = adminUserId });
            repo.Insert(new sys_Permission() { code = "VIEW_EMPLOYEE_SALARY", description = "View Employee Salary", companyId = companyId, updatedBy = adminUserId });
            repo.Insert(new sys_Permission() { code = "VIEW_ADMIN_PANEL", description = "View Admin Panel", companyId = companyId, updatedBy = adminUserId });
            repo.Insert(new sys_Permission() { code = "EMPLOYEE_QUICK_UPDATE", description = "EMPLOYEE_QUICK_UPDATE", companyId = companyId, updatedBy = adminUserId });
            repo.Insert(new sys_Permission() { code = "DEVELOPER", description = "DEVELOPER", companyId = companyId, updatedBy = adminUserId });
            repo.Insert(new sys_Permission() { code = "EMPLOYEE_MAINTENANCE", description = "EMPLOYEE_MAINTENANCE", companyId = companyId, updatedBy = adminUserId });

            unitOfWork.Save();
        }

        private void PrepareMenu(UnitOfWork unitOfWork, HRISContext context, Guid roleId, Guid adminUserId)
        {
            var repoMenu = new Repository<sys_Menu>(context);
            var repoRoleMenu = new Repository<sys_RoleMenu>(context);

            var freeMenu = repoMenu.Insert(CreateMenu("-- Free Text Menu --", null, null, adminUserId));
            var home = repoMenu.Insert(CreateMenu("Home", "Home", "Index", adminUserId));
            var empQuickUpdate = repoMenu.Insert(CreateMenu("Employee Quick update", "Employee", "QuickUpdate", adminUserId));
            var empListConfi = repoMenu.Insert(CreateMenu("Employee List (Confidential)", "Employee", "EmployeeConfi", adminUserId));
            var empListNonConfi = repoMenu.Insert(CreateMenu("Employee List (Non-Confidential)", "Employee", "EmployeeNonConfi", adminUserId));
            var empAttendance = repoMenu.Insert(CreateMenu("Employee Attendance", "Attendance", "Index", adminUserId));
            var user = repoMenu.Insert(CreateMenu("User", "Account", "UserMaintenance", adminUserId));
            var role = repoMenu.Insert(CreateMenu("Role", "Role", "Index", adminUserId));
            var permission = repoMenu.Insert(CreateMenu("Permission", "Permission", "Index", adminUserId));
            var company = repoMenu.Insert(CreateMenu("Company Information", "Company", "Index", adminUserId));
            var location = repoMenu.Insert(CreateMenu("Location", "Location", "Index", adminUserId));
            var appApprover = repoMenu.Insert(CreateMenu("Application Approver", "ApplicationRequest", "DepartmentSectionApprover", adminUserId));
            var workDays = repoMenu.Insert(CreateMenu("Work Days", "WorkDay", "Index", adminUserId));
            var holidayType = repoMenu.Insert(CreateMenu("Holiday Type", "HolidayType", "Index", adminUserId));
            var holidays = repoMenu.Insert(CreateMenu("Holidays", "Holiday", "Index", adminUserId));
            var payrollGroup = repoMenu.Insert(CreateMenu("Payroll Group", "PayrollGroup", "Index", adminUserId));
            var empStatus = repoMenu.Insert(CreateMenu("Employment Status", "EmploymentStatus", "Index", adminUserId));
            var empType = repoMenu.Insert(CreateMenu("Employment Type", "EmploymentType", "Index", adminUserId));
            var identificationDoc = repoMenu.Insert(CreateMenu("Identification Document", "IdentificationDocument", "Index", adminUserId));
            var department = repoMenu.Insert(CreateMenu("Department", "Department", "Index", adminUserId));
            var position = repoMenu.Insert(CreateMenu("Position", "Position", "Index", adminUserId));
            var allowance = repoMenu.Insert(CreateMenu("Allowance", "Allowance", "Index", adminUserId));
            var offence = repoMenu.Insert(CreateMenu("Offense", "Offense", "Index", adminUserId));
            var penaltyType = repoMenu.Insert(CreateMenu("Penalty Type", "PenaltyType", "Index", adminUserId));
            var updateWorkDayAtt = repoMenu.Insert(CreateMenu("Update WorkDay Attendance", "Attendance", "UpdateWorkDayAttendance", adminUserId));
            var departmentSection = repoMenu.Insert(CreateMenu("Department Section", "Department", "Section", adminUserId));
            var cutOffAttendance = repoMenu.Insert(CreateMenu("Cut Off Attendance", "Attendance", "CutOffAttendance", adminUserId));
            var myApproval = repoMenu.Insert(CreateMenu("My Approval", "ApplicationRequest", "MyApproval", adminUserId));
            var requestLeave = repoMenu.Insert(CreateMenu("Request Leave", "ApplicationRequest", "RequestLeave", adminUserId));
            var deduction = repoMenu.Insert(CreateMenu("Deduction", "Deduction", "Index", adminUserId));
            unitOfWork.Save();

            repoRoleMenu.Insert(CreateRoleMenu(roleId, home.id, "Home", 1, adminUserId));

            repoRoleMenu.Insert(CreateRoleMenu(roleId, freeMenu.id, "Employees", 2, adminUserId))
                    .AddChild(repoRoleMenu, c_employees =>
                    {
                        c_employees.AddListReturnValue(CreateRoleMenu(roleId, freeMenu.id, "Employee List", 1, adminUserId))
                            .AddChild(repoRoleMenu, empList =>
                            {
                                empList.Add(CreateRoleMenu(roleId, empListConfi.id, "Employee List (Confidential)", 1, adminUserId));
                                empList.Add(CreateRoleMenu(roleId, empListNonConfi.id, "Employee List (Non-Confidential)", 2, adminUserId));
                                empList.Add(CreateRoleMenu(roleId, empQuickUpdate.id, "Employee Quick Update", 3, adminUserId));
                            });
                    });

            repoRoleMenu.Insert(CreateRoleMenu(roleId, freeMenu.id, "Time and Attendance", 3, adminUserId))
                .AddChild(repoRoleMenu, c_timeAndAttendance =>
                {
                    c_timeAndAttendance.Add(CreateRoleMenu(roleId, empAttendance.id, "Employee Attendance", 1, adminUserId));
                    c_timeAndAttendance.Add(CreateRoleMenu(roleId, updateWorkDayAtt.id, "Update Work Day Attendance", 2, adminUserId));
                    c_timeAndAttendance.Add(CreateRoleMenu(roleId, cutOffAttendance.id, "Cut Off Attenance", 3, adminUserId));
                });

            repoRoleMenu.Insert(CreateRoleMenu(roleId, freeMenu.id, "Company Configuration", 4, adminUserId))
                .AddChild(repoRoleMenu, c_companyConfig =>
                {
                    c_companyConfig.Add(CreateRoleMenu(roleId, company.id, "Company Information", 1, adminUserId));

                    c_companyConfig.AddListReturnValue(CreateRoleMenu(roleId, freeMenu.id, "Account", 2, adminUserId))
                        .AddChild(repoRoleMenu, c_account =>
                        {
                            c_account.Add(CreateRoleMenu(roleId, user.id, "User", 1, adminUserId));
                            c_account.Add(CreateRoleMenu(roleId, role.id, "Role", 2, adminUserId));
                            c_account.Add(CreateRoleMenu(roleId, permission.id, "Permission", 3, adminUserId));
                        });

                    c_companyConfig.AddListReturnValue(CreateRoleMenu(roleId, freeMenu.id, "Organizational Structure", 3, adminUserId))
                        .AddChild(repoRoleMenu, c_employee =>
                        {
                            c_employee.Add(CreateRoleMenu(roleId, empStatus.id, "Employment Status", 1, adminUserId));
                            c_employee.Add(CreateRoleMenu(roleId, empType.id, "Employment Type", 2, adminUserId));
                            c_employee.Add(CreateRoleMenu(roleId, payrollGroup.id, "Payroll Group", 3, adminUserId));
                            c_employee.Add(CreateRoleMenu(roleId, position.id, "Position", 4, adminUserId));
                            c_employee.Add(CreateRoleMenu(roleId, allowance.id, "Allowance", 5, adminUserId));
                            c_employee.Add(CreateRoleMenu(roleId, identificationDoc.id, "Identification Document", 6, adminUserId));
                            c_employee.Add(CreateRoleMenu(roleId, deduction.id, "Deduction", 7, adminUserId));
                            c_employee.AddListReturnValue(CreateRoleMenu(roleId, freeMenu.id, "Offense Configuration", 8, adminUserId))
                                     .AddChild(repoRoleMenu, c_offenseConfig =>
                                     {
                                         c_offenseConfig.Add(CreateRoleMenu(roleId, offence.id, "Offense", 1, adminUserId));
                                         c_offenseConfig.Add(CreateRoleMenu(roleId, penaltyType.id, "Penalty Type", 2, adminUserId));
                                     });

                            c_employee.AddListReturnValue(CreateRoleMenu(roleId, freeMenu.id, "Department Configuration", 9, adminUserId))
                                .AddChild(repoRoleMenu, c_departmentConfig =>
                                {
                                    c_departmentConfig.Add(CreateRoleMenu(roleId, department.id, "Department", 1, adminUserId));
                                    c_departmentConfig.Add(CreateRoleMenu(roleId, appApprover.id, "Application Approver", 2, adminUserId));
                                    c_departmentConfig.Add(CreateRoleMenu(roleId, departmentSection.id, "Department Section", 3, adminUserId));
                                });
                        })
                        ;

                    c_companyConfig.AddListReturnValue(CreateRoleMenu(roleId, freeMenu.id, "Time and Attendance", 4, adminUserId))
                        .AddChild(repoRoleMenu, c_timeAndAttendance =>
                        {
                            c_timeAndAttendance.Add(CreateRoleMenu(roleId, workDays.id, "Work Days", 1, adminUserId));
                            c_timeAndAttendance.Add(CreateRoleMenu(roleId, holidays.id, "Holidays", 2, adminUserId));
                            c_timeAndAttendance.Add(CreateRoleMenu(roleId, holidayType.id, "Holiday Type", 3, adminUserId));
                        });
                });

            unitOfWork.Save();
        }

        private sys_RoleMenu CreateRoleMenu(Guid roleId, Guid sourceMenuId, string description, int displayOrder, Guid adminUserId, Guid? parentRoleMenuId = null)
        {
            return new sys_RoleMenu()
            {
                roleId = roleId,
                sourceMenuId = sourceMenuId,
                description = description,
                displayOrder = displayOrder,
                parentRoleMenuId = parentRoleMenuId,
                updatedBy = adminUserId
            };
        }

        private sys_Menu CreateMenu(string description, string controllerName, string actionName, Guid adminUserId)
        {
            return new sys_Menu()
            {
                description = description,
                controllerName = controllerName,
                actionName = actionName,
                updatedBy = adminUserId,
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