USE [HRIS]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_EmployeeAttendance_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_EmployeeAttendance]'))
ALTER TABLE [dbo].[ta_EmployeeAttendance] DROP CONSTRAINT [FK_ta_EmployeeAttendance_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_EmployeeAttendance_mf_WorkDays]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_EmployeeAttendance]'))
ALTER TABLE [dbo].[ta_EmployeeAttendance] DROP CONSTRAINT [FK_ta_EmployeeAttendance_mf_WorkDays]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_EmployeeAttendance_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_EmployeeAttendance]'))
ALTER TABLE [dbo].[ta_EmployeeAttendance] DROP CONSTRAINT [FK_ta_EmployeeAttendance_mf_Employee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummaryDetail_ta_CutOffAttendanceSummary]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummaryDetail]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummaryDetail] DROP CONSTRAINT [FK_ta_CutOffAttendanceSummaryDetail_ta_CutOffAttendanceSummary]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummaryDetail_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummaryDetail]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummaryDetail] DROP CONSTRAINT [FK_ta_CutOffAttendanceSummaryDetail_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummaryDetail_mf_HolidayType]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummaryDetail]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummaryDetail] DROP CONSTRAINT [FK_ta_CutOffAttendanceSummaryDetail_mf_HolidayType]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummary_ta_CutOffAttendance]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummary]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummary] DROP CONSTRAINT [FK_ta_CutOffAttendanceSummary_ta_CutOffAttendance]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummary_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummary]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummary] DROP CONSTRAINT [FK_ta_CutOffAttendanceSummary_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummary_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummary]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummary] DROP CONSTRAINT [FK_ta_CutOffAttendanceSummary_mf_Employee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendance_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendance]'))
ALTER TABLE [dbo].[ta_CutOffAttendance] DROP CONSTRAINT [FK_ta_CutOffAttendance_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendance_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendance]'))
ALTER TABLE [dbo].[ta_CutOffAttendance] DROP CONSTRAINT [FK_ta_CutOffAttendance_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendance_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendance]'))
ALTER TABLE [dbo].[ta_CutOffAttendance] DROP CONSTRAINT [FK_ta_CutOffAttendance_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendance_mf_PayrollGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendance]'))
ALTER TABLE [dbo].[ta_CutOffAttendance] DROP CONSTRAINT [FK_ta_CutOffAttendance_mf_PayrollGroup]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequestLeave_ta_ApplicationRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestLeave]'))
ALTER TABLE [dbo].[ta_ApplicationRequestLeave] DROP CONSTRAINT [FK_ta_ApplicationRequestLeave_ta_ApplicationRequest]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequestGatePass_ta_ApplicationRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestGatePass]'))
ALTER TABLE [dbo].[ta_ApplicationRequestGatePass] DROP CONSTRAINT [FK_ta_ApplicationRequestGatePass_ta_ApplicationRequest]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequestApprover_ta_ApplicationRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestApprover]'))
ALTER TABLE [dbo].[ta_ApplicationRequestApprover] DROP CONSTRAINT [FK_ta_ApplicationRequestApprover_ta_ApplicationRequest]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequestApprover_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestApprover]'))
ALTER TABLE [dbo].[ta_ApplicationRequestApprover] DROP CONSTRAINT [FK_ta_ApplicationRequestApprover_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequestApprover_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestApprover]'))
ALTER TABLE [dbo].[ta_ApplicationRequestApprover] DROP CONSTRAINT [FK_ta_ApplicationRequestApprover_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequest_sys_User2]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequest]'))
ALTER TABLE [dbo].[ta_ApplicationRequest] DROP CONSTRAINT [FK_ta_ApplicationRequest_sys_User2]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequest_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequest]'))
ALTER TABLE [dbo].[ta_ApplicationRequest] DROP CONSTRAINT [FK_ta_ApplicationRequest_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequest_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequest]'))
ALTER TABLE [dbo].[ta_ApplicationRequest] DROP CONSTRAINT [FK_ta_ApplicationRequest_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequest_mf_ApplicationRequestType]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequest]'))
ALTER TABLE [dbo].[ta_ApplicationRequest] DROP CONSTRAINT [FK_ta_ApplicationRequest_mf_ApplicationRequestType]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_UserSession_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_UserSession]'))
ALTER TABLE [dbo].[sys_UserSession] DROP CONSTRAINT [FK_sys_UserSession_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_UserSession_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_UserSession]'))
ALTER TABLE [dbo].[sys_UserSession] DROP CONSTRAINT [FK_sys_UserSession_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_UserRole_sys_User2]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_UserRole]'))
ALTER TABLE [dbo].[sys_UserRole] DROP CONSTRAINT [FK_sys_UserRole_sys_User2]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_UserRole_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_UserRole]'))
ALTER TABLE [dbo].[sys_UserRole] DROP CONSTRAINT [FK_sys_UserRole_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_UserRole_sys_Role]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_UserRole]'))
ALTER TABLE [dbo].[sys_UserRole] DROP CONSTRAINT [FK_sys_UserRole_sys_Role]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_User_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_User]'))
ALTER TABLE [dbo].[sys_User] DROP CONSTRAINT [FK_sys_User_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_User_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_User]'))
ALTER TABLE [dbo].[sys_User] DROP CONSTRAINT [FK_sys_User_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_User_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_User]'))
ALTER TABLE [dbo].[sys_User] DROP CONSTRAINT [FK_sys_User_mf_Employee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RolePermission_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RolePermission]'))
ALTER TABLE [dbo].[sys_RolePermission] DROP CONSTRAINT [FK_sys_RolePermission_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RolePermission_sys_Role]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RolePermission]'))
ALTER TABLE [dbo].[sys_RolePermission] DROP CONSTRAINT [FK_sys_RolePermission_sys_Role]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RolePermission_sys_Permission]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RolePermission]'))
ALTER TABLE [dbo].[sys_RolePermission] DROP CONSTRAINT [FK_sys_RolePermission_sys_Permission]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RoleMenu_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RoleMenu]'))
ALTER TABLE [dbo].[sys_RoleMenu] DROP CONSTRAINT [FK_sys_RoleMenu_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RoleMenu_sys_RoleMenu]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RoleMenu]'))
ALTER TABLE [dbo].[sys_RoleMenu] DROP CONSTRAINT [FK_sys_RoleMenu_sys_RoleMenu]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RoleMenu_sys_Role]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RoleMenu]'))
ALTER TABLE [dbo].[sys_RoleMenu] DROP CONSTRAINT [FK_sys_RoleMenu_sys_Role]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RoleMenu_sys_Menu]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RoleMenu]'))
ALTER TABLE [dbo].[sys_RoleMenu] DROP CONSTRAINT [FK_sys_RoleMenu_sys_Menu]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Role_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Role]'))
ALTER TABLE [dbo].[sys_Role] DROP CONSTRAINT [FK_sys_Role_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Role_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Role]'))
ALTER TABLE [dbo].[sys_Role] DROP CONSTRAINT [FK_sys_Role_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Permission_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Permission]'))
ALTER TABLE [dbo].[sys_Permission] DROP CONSTRAINT [FK_sys_Permission_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Permission_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Permission]'))
ALTER TABLE [dbo].[sys_Permission] DROP CONSTRAINT [FK_sys_Permission_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Menu_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Menu]'))
ALTER TABLE [dbo].[sys_Menu] DROP CONSTRAINT [FK_sys_Menu_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Location_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Location]'))
ALTER TABLE [dbo].[sys_Location] DROP CONSTRAINT [FK_sys_Location_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Location_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Location]'))
ALTER TABLE [dbo].[sys_Location] DROP CONSTRAINT [FK_sys_Location_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_IdentificationDocument_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_IdentificationDocument]'))
ALTER TABLE [dbo].[sys_IdentificationDocument] DROP CONSTRAINT [FK_sys_IdentificationDocument_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_ErrorLogs_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_ErrorLogs]'))
ALTER TABLE [dbo].[sys_ErrorLogs] DROP CONSTRAINT [FK_sys_ErrorLogs_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_EnumReference_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_EnumReference]'))
ALTER TABLE [dbo].[sys_EnumReference] DROP CONSTRAINT [FK_sys_EnumReference_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_CompanySetting_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_CompanySetting]'))
ALTER TABLE [dbo].[sys_CompanySetting] DROP CONSTRAINT [FK_sys_CompanySetting_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_CompanySetting_sys_Setting]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_CompanySetting]'))
ALTER TABLE [dbo].[sys_CompanySetting] DROP CONSTRAINT [FK_sys_CompanySetting_sys_Setting]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_CompanySetting_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_CompanySetting]'))
ALTER TABLE [dbo].[sys_CompanySetting] DROP CONSTRAINT [FK_sys_CompanySetting_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Company_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Company]'))
ALTER TABLE [dbo].[sys_Company] DROP CONSTRAINT [FK_sys_Company_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Company_mf_Country]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Company]'))
ALTER TABLE [dbo].[sys_Company] DROP CONSTRAINT [FK_sys_Company_mf_Country]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployeeEarnings_pr_PayrollEmployee]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeEarnings]'))
ALTER TABLE [dbo].[pr_PayrollEmployeeEarnings] DROP CONSTRAINT [FK_pr_PayrollEmployeeEarnings_pr_PayrollEmployee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployeeEarnings_mf_Allowance]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeEarnings]'))
ALTER TABLE [dbo].[pr_PayrollEmployeeEarnings] DROP CONSTRAINT [FK_pr_PayrollEmployeeEarnings_mf_Allowance]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployeeDeductions_pr_PayrollEmployee]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeDeductions]'))
ALTER TABLE [dbo].[pr_PayrollEmployeeDeductions] DROP CONSTRAINT [FK_pr_PayrollEmployeeDeductions_pr_PayrollEmployee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployeeDeductions_mf_Deduction]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeDeductions]'))
ALTER TABLE [dbo].[pr_PayrollEmployeeDeductions] DROP CONSTRAINT [FK_pr_PayrollEmployeeDeductions_mf_Deduction]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployee_pr_Payroll]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployee]'))
ALTER TABLE [dbo].[pr_PayrollEmployee] DROP CONSTRAINT [FK_pr_PayrollEmployee_pr_Payroll]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployee_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployee]'))
ALTER TABLE [dbo].[pr_PayrollEmployee] DROP CONSTRAINT [FK_pr_PayrollEmployee_mf_Employee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_Payroll_ta_CutOffAttendance]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_Payroll]'))
ALTER TABLE [dbo].[pr_Payroll] DROP CONSTRAINT [FK_pr_Payroll_ta_CutOffAttendance]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_Payroll_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_Payroll]'))
ALTER TABLE [dbo].[pr_Payroll] DROP CONSTRAINT [FK_pr_Payroll_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_Payroll_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_Payroll]'))
ALTER TABLE [dbo].[pr_Payroll] DROP CONSTRAINT [FK_pr_Payroll_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_Payroll_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_Payroll]'))
ALTER TABLE [dbo].[pr_Payroll] DROP CONSTRAINT [FK_pr_Payroll_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_WorkDays_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_WorkDays]'))
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [FK_mf_WorkDays_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_WorkDays_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_WorkDays]'))
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [FK_mf_WorkDays_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Position_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Position]'))
ALTER TABLE [dbo].[mf_Position] DROP CONSTRAINT [FK_mf_Position_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Position_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Position]'))
ALTER TABLE [dbo].[mf_Position] DROP CONSTRAINT [FK_mf_Position_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_PenaltyType_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_PenaltyType]'))
ALTER TABLE [dbo].[mf_PenaltyType] DROP CONSTRAINT [FK_mf_PenaltyType_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_PenaltyType_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_PenaltyType]'))
ALTER TABLE [dbo].[mf_PenaltyType] DROP CONSTRAINT [FK_mf_PenaltyType_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_PayrollGroup_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_PayrollGroup]'))
ALTER TABLE [dbo].[mf_PayrollGroup] DROP CONSTRAINT [FK_mf_PayrollGroup_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Offense_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Offense]'))
ALTER TABLE [dbo].[mf_Offense] DROP CONSTRAINT [FK_mf_Offense_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Offense_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Offense]'))
ALTER TABLE [dbo].[mf_Offense] DROP CONSTRAINT [FK_mf_Offense_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_HolidayType_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_HolidayType]'))
ALTER TABLE [dbo].[mf_HolidayType] DROP CONSTRAINT [FK_mf_HolidayType_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Holidays_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Holidays]'))
ALTER TABLE [dbo].[mf_Holidays] DROP CONSTRAINT [FK_mf_Holidays_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Holidays_mf_HolidayType]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Holidays]'))
ALTER TABLE [dbo].[mf_Holidays] DROP CONSTRAINT [FK_mf_Holidays_mf_HolidayType]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmploymentType_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmploymentType]'))
ALTER TABLE [dbo].[mf_EmploymentType] DROP CONSTRAINT [FK_mf_EmploymentType_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmploymentStatus_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmploymentStatus]'))
ALTER TABLE [dbo].[mf_EmploymentStatus] DROP CONSTRAINT [FK_mf_EmploymentStatus_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeWorkHistory_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkHistory]'))
ALTER TABLE [dbo].[mf_EmployeeWorkHistory] DROP CONSTRAINT [FK_mf_EmployeeWorkHistory_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeWorkHistory_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkHistory]'))
ALTER TABLE [dbo].[mf_EmployeeWorkHistory] DROP CONSTRAINT [FK_mf_EmployeeWorkHistory_mf_Employee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeWorkDays_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkDays]'))
ALTER TABLE [dbo].[mf_EmployeeWorkDays] DROP CONSTRAINT [FK_mf_EmployeeWorkDays_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeWorkDays_mf_WorkDays]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkDays]'))
ALTER TABLE [dbo].[mf_EmployeeWorkDays] DROP CONSTRAINT [FK_mf_EmployeeWorkDays_mf_WorkDays]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeWorkDays_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkDays]'))
ALTER TABLE [dbo].[mf_EmployeeWorkDays] DROP CONSTRAINT [FK_mf_EmployeeWorkDays_mf_Employee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeTraining_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeTraining]'))
ALTER TABLE [dbo].[mf_EmployeeTraining] DROP CONSTRAINT [FK_mf_EmployeeTraining_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeTraining_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeTraining]'))
ALTER TABLE [dbo].[mf_EmployeeTraining] DROP CONSTRAINT [FK_mf_EmployeeTraining_mf_Employee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeSkill_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeSkill]'))
ALTER TABLE [dbo].[mf_EmployeeSkill] DROP CONSTRAINT [FK_mf_EmployeeSkill_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeSkill_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeSkill]'))
ALTER TABLE [dbo].[mf_EmployeeSkill] DROP CONSTRAINT [FK_mf_EmployeeSkill_mf_Employee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeOffense_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeOffense]'))
ALTER TABLE [dbo].[mf_EmployeeOffense] DROP CONSTRAINT [FK_mf_EmployeeOffense_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeOffense_mf_PenaltyType]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeOffense]'))
ALTER TABLE [dbo].[mf_EmployeeOffense] DROP CONSTRAINT [FK_mf_EmployeeOffense_mf_PenaltyType]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeOffense_mf_Offense]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeOffense]'))
ALTER TABLE [dbo].[mf_EmployeeOffense] DROP CONSTRAINT [FK_mf_EmployeeOffense_mf_Offense]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeOffense_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeOffense]'))
ALTER TABLE [dbo].[mf_EmployeeOffense] DROP CONSTRAINT [FK_mf_EmployeeOffense_mf_Employee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeIdentificationDocument_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeIdentificationDocument]'))
ALTER TABLE [dbo].[mf_EmployeeIdentificationDocument] DROP CONSTRAINT [FK_mf_EmployeeIdentificationDocument_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeIdentificationDocument_sys_IdentificationDocument]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeIdentificationDocument]'))
ALTER TABLE [dbo].[mf_EmployeeIdentificationDocument] DROP CONSTRAINT [FK_mf_EmployeeIdentificationDocument_sys_IdentificationDocument]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeIdentificationDocument_mf_Employee1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeIdentificationDocument]'))
ALTER TABLE [dbo].[mf_EmployeeIdentificationDocument] DROP CONSTRAINT [FK_mf_EmployeeIdentificationDocument_mf_Employee1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeEducation_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeEducation]'))
ALTER TABLE [dbo].[mf_EmployeeEducation] DROP CONSTRAINT [FK_mf_EmployeeEducation_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeEducation_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeEducation]'))
ALTER TABLE [dbo].[mf_EmployeeEducation] DROP CONSTRAINT [FK_mf_EmployeeEducation_mf_Employee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeDeduction_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeDeduction]'))
ALTER TABLE [dbo].[mf_EmployeeDeduction] DROP CONSTRAINT [FK_mf_EmployeeDeduction_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeDeduction_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeDeduction]'))
ALTER TABLE [dbo].[mf_EmployeeDeduction] DROP CONSTRAINT [FK_mf_EmployeeDeduction_mf_Employee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeDeduction_mf_Deduction]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeDeduction]'))
ALTER TABLE [dbo].[mf_EmployeeDeduction] DROP CONSTRAINT [FK_mf_EmployeeDeduction_mf_Deduction]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeBasicPay_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBasicPay]'))
ALTER TABLE [dbo].[mf_EmployeeBasicPay] DROP CONSTRAINT [FK_mf_EmployeeBasicPay_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeBasicPay_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBasicPay]'))
ALTER TABLE [dbo].[mf_EmployeeBasicPay] DROP CONSTRAINT [FK_mf_EmployeeBasicPay_mf_Employee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeBalanceLeave_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBalanceLeave]'))
ALTER TABLE [dbo].[mf_EmployeeBalanceLeave] DROP CONSTRAINT [FK_mf_EmployeeBalanceLeave_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeBalanceLeave_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBalanceLeave]'))
ALTER TABLE [dbo].[mf_EmployeeBalanceLeave] DROP CONSTRAINT [FK_mf_EmployeeBalanceLeave_mf_Employee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeBalanceLeave_mf_ApplicationRequestType]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBalanceLeave]'))
ALTER TABLE [dbo].[mf_EmployeeBalanceLeave] DROP CONSTRAINT [FK_mf_EmployeeBalanceLeave_mf_ApplicationRequestType]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeAllowance_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAllowance]'))
ALTER TABLE [dbo].[mf_EmployeeAllowance] DROP CONSTRAINT [FK_mf_EmployeeAllowance_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeAllowance_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAllowance]'))
ALTER TABLE [dbo].[mf_EmployeeAllowance] DROP CONSTRAINT [FK_mf_EmployeeAllowance_mf_Employee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeAllowance_mf_Allowance]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAllowance]'))
ALTER TABLE [dbo].[mf_EmployeeAllowance] DROP CONSTRAINT [FK_mf_EmployeeAllowance_mf_Allowance]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeAddress_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAddress]'))
ALTER TABLE [dbo].[mf_EmployeeAddress] DROP CONSTRAINT [FK_mf_EmployeeAddress_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeAddress_mf_Country]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAddress]'))
ALTER TABLE [dbo].[mf_EmployeeAddress] DROP CONSTRAINT [FK_mf_EmployeeAddress_mf_Country]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] DROP CONSTRAINT [FK_mf_Employee201_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_Position]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] DROP CONSTRAINT [FK_mf_Employee201_mf_Position]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_PayrollGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] DROP CONSTRAINT [FK_mf_Employee201_mf_PayrollGroup]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_EmploymentType]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] DROP CONSTRAINT [FK_mf_Employee201_mf_EmploymentType]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_EmploymentStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] DROP CONSTRAINT [FK_mf_Employee201_mf_EmploymentStatus]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_DepartmentSection]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] DROP CONSTRAINT [FK_mf_Employee201_mf_DepartmentSection]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_Department]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] DROP CONSTRAINT [FK_mf_Employee201_mf_Department]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_Agency]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] DROP CONSTRAINT [FK_mf_Employee201_mf_Agency]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee]'))
ALTER TABLE [dbo].[mf_Employee] DROP CONSTRAINT [FK_mf_Employee_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee]'))
ALTER TABLE [dbo].[mf_Employee] DROP CONSTRAINT [FK_mf_Employee_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee_mf_EmployeeAddress]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee]'))
ALTER TABLE [dbo].[mf_Employee] DROP CONSTRAINT [FK_mf_Employee_mf_EmployeeAddress]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee_mf_Employee201]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee]'))
ALTER TABLE [dbo].[mf_Employee] DROP CONSTRAINT [FK_mf_Employee_mf_Employee201]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSectionRequestApprover_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSectionRequestApprover]'))
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover] DROP CONSTRAINT [FK_mf_DepartmentSectionRequestApprover_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSectionRequestApprover_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSectionRequestApprover]'))
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover] DROP CONSTRAINT [FK_mf_DepartmentSectionRequestApprover_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSectionRequestApprover_mf_DepartmentSection]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSectionRequestApprover]'))
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover] DROP CONSTRAINT [FK_mf_DepartmentSectionRequestApprover_mf_DepartmentSection]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSectionRequestApprover_mf_ApplicationRequestType]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSectionRequestApprover]'))
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover] DROP CONSTRAINT [FK_mf_DepartmentSectionRequestApprover_mf_ApplicationRequestType]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSection_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSection]'))
ALTER TABLE [dbo].[mf_DepartmentSection] DROP CONSTRAINT [FK_mf_DepartmentSection_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSection_mf_Department]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSection]'))
ALTER TABLE [dbo].[mf_DepartmentSection] DROP CONSTRAINT [FK_mf_DepartmentSection_mf_Department]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Department_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Department]'))
ALTER TABLE [dbo].[mf_Department] DROP CONSTRAINT [FK_mf_Department_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Department_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Department]'))
ALTER TABLE [dbo].[mf_Department] DROP CONSTRAINT [FK_mf_Department_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Deduction_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Deduction]'))
ALTER TABLE [dbo].[mf_Deduction] DROP CONSTRAINT [FK_mf_Deduction_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Deduction_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Deduction]'))
ALTER TABLE [dbo].[mf_Deduction] DROP CONSTRAINT [FK_mf_Deduction_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Country_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Country]'))
ALTER TABLE [dbo].[mf_Country] DROP CONSTRAINT [FK_mf_Country_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_ApplicationRequestType_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_ApplicationRequestType]'))
ALTER TABLE [dbo].[mf_ApplicationRequestType] DROP CONSTRAINT [FK_mf_ApplicationRequestType_sys_User1]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Allowance_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Allowance]'))
ALTER TABLE [dbo].[mf_Allowance] DROP CONSTRAINT [FK_mf_Allowance_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Allowance_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Allowance]'))
ALTER TABLE [dbo].[mf_Allowance] DROP CONSTRAINT [FK_mf_Allowance_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Agency_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Agency]'))
ALTER TABLE [dbo].[mf_Agency] DROP CONSTRAINT [FK_mf_Agency_sys_User]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Agency_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Agency]'))
ALTER TABLE [dbo].[mf_Agency] DROP CONSTRAINT [FK_mf_Agency_sys_Company]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_EmployeeAttendance_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_EmployeeAttendance] DROP CONSTRAINT [DF_ta_EmployeeAttendance_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_EmployeeAttendance_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_EmployeeAttendance] DROP CONSTRAINT [DF_ta_EmployeeAttendance_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendanceSummaryDetail_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendanceSummaryDetail] DROP CONSTRAINT [DF_ta_CutOffAttendanceSummaryDetail_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendanceSummaryDetail_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendanceSummaryDetail] DROP CONSTRAINT [DF_ta_CutOffAttendanceSummaryDetail_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendanceSummaryDetail_absent]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendanceSummaryDetail] DROP CONSTRAINT [DF_ta_CutOffAttendanceSummaryDetail_absent]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendanceSummary_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendanceSummary] DROP CONSTRAINT [DF_ta_CutOffAttendanceSummary_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendanceSummary_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendanceSummary] DROP CONSTRAINT [DF_ta_CutOffAttendanceSummary_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendance_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendance] DROP CONSTRAINT [DF_ta_CutOffAttendance_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendance_updatedDate1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendance] DROP CONSTRAINT [DF_ta_CutOffAttendance_updatedDate1]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendance_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendance] DROP CONSTRAINT [DF_ta_CutOffAttendance_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendance_generatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendance] DROP CONSTRAINT [DF_ta_CutOffAttendance_generatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_ApplicationRequestLeave_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_ApplicationRequestLeave] DROP CONSTRAINT [DF_ta_ApplicationRequestLeave_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_ApplicationRequestGatePass_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_ApplicationRequestGatePass] DROP CONSTRAINT [DF_ta_ApplicationRequestGatePass_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_ApplicationRequestApprover_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_ApplicationRequestApprover] DROP CONSTRAINT [DF_ta_ApplicationRequestApprover_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_ApplicationRequest_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_ApplicationRequest] DROP CONSTRAINT [DF_ta_ApplicationRequest_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_ApplicationRequest_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_ApplicationRequest] DROP CONSTRAINT [DF_ta_ApplicationRequest_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_ApplicationRequest_createdDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_ApplicationRequest] DROP CONSTRAINT [DF_ta_ApplicationRequest_createdDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_UserSession_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_UserSession] DROP CONSTRAINT [DF_sys_UserSession_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_UserRole_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_UserRole] DROP CONSTRAINT [DF_sys_UserRole_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_UserRole_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_UserRole] DROP CONSTRAINT [DF_sys_UserRole_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_User_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_User] DROP CONSTRAINT [DF_sys_User_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_User_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_User] DROP CONSTRAINT [DF_sys_User_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Setting_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Setting] DROP CONSTRAINT [DF_sys_Setting_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RolePermission_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RolePermission] DROP CONSTRAINT [DF_sys_RolePermission_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RolePermission_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RolePermission] DROP CONSTRAINT [DF_sys_RolePermission_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RolePermission_printAccess]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RolePermission] DROP CONSTRAINT [DF_sys_RolePermission_printAccess]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RolePermission_deleteAccess]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RolePermission] DROP CONSTRAINT [DF_sys_RolePermission_deleteAccess]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RolePermission_updateAccess]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RolePermission] DROP CONSTRAINT [DF_sys_RolePermission_updateAccess]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RolePermission_createAccess]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RolePermission] DROP CONSTRAINT [DF_sys_RolePermission_createAccess]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RolePermission_viewAccess]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RolePermission] DROP CONSTRAINT [DF_sys_RolePermission_viewAccess]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RoleMenu_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RoleMenu] DROP CONSTRAINT [DF_sys_RoleMenu_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RoleMenu_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RoleMenu] DROP CONSTRAINT [DF_sys_RoleMenu_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RoleMenu_displayOrder]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RoleMenu] DROP CONSTRAINT [DF_sys_RoleMenu_displayOrder]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Role_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Role] DROP CONSTRAINT [DF_sys_Role_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Role_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Role] DROP CONSTRAINT [DF_sys_Role_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Permission_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Permission] DROP CONSTRAINT [DF_sys_Permission_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Permission_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Permission] DROP CONSTRAINT [DF_sys_Permission_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Menu_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Menu] DROP CONSTRAINT [DF_sys_Menu_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Menu_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Menu] DROP CONSTRAINT [DF_sys_Menu_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Location_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Location] DROP CONSTRAINT [DF_sys_Location_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Location_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Location] DROP CONSTRAINT [DF_sys_Location_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_IdentificationDocument_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_IdentificationDocument] DROP CONSTRAINT [DF_sys_IdentificationDocument_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_IdentificationDocument_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_IdentificationDocument] DROP CONSTRAINT [DF_sys_IdentificationDocument_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_ErrorLogs_createdDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_ErrorLogs] DROP CONSTRAINT [DF_sys_ErrorLogs_createdDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_EnumReference_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_EnumReference] DROP CONSTRAINT [DF_sys_EnumReference_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_EnumReference_hidden]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_EnumReference] DROP CONSTRAINT [DF_sys_EnumReference_hidden]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_EnumReference_displayOrder]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_EnumReference] DROP CONSTRAINT [DF_sys_EnumReference_displayOrder]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_CompanySetting_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_CompanySetting] DROP CONSTRAINT [DF_sys_CompanySetting_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_CompanySetting_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_CompanySetting] DROP CONSTRAINT [DF_sys_CompanySetting_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Company_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Company] DROP CONSTRAINT [DF_sys_Company_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Company_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Company] DROP CONSTRAINT [DF_sys_Company_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_pr_PayrollEmployee_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[pr_PayrollEmployee] DROP CONSTRAINT [DF_pr_PayrollEmployee_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_pr_PayrollEmployee_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[pr_PayrollEmployee] DROP CONSTRAINT [DF_pr_PayrollEmployee_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_pr_Payroll_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[pr_Payroll] DROP CONSTRAINT [DF_pr_Payroll_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_pr_Payroll_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[pr_Payroll] DROP CONSTRAINT [DF_pr_Payroll_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_pr_Payroll_generatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[pr_Payroll] DROP CONSTRAINT [DF_pr_Payroll_generatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [DF_mf_WorkDays_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [DF_mf_WorkDays_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_breakHours]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [DF_mf_WorkDays_breakHours]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_toTimeMinute]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [DF_mf_WorkDays_toTimeMinute]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_toTimeHour]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [DF_mf_WorkDays_toTimeHour]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_fromTimeMinute]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [DF_mf_WorkDays_fromTimeMinute]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_fromTimeHour]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [DF_mf_WorkDays_fromTimeHour]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_sunday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [DF_mf_WorkDays_sunday]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_saturday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [DF_mf_WorkDays_saturday]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_friday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [DF_mf_WorkDays_friday]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_thursday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [DF_mf_WorkDays_thursday]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_wednesday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [DF_mf_WorkDays_wednesday]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_tuesday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [DF_mf_WorkDays_tuesday]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_monday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] DROP CONSTRAINT [DF_mf_WorkDays_monday]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Position_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Position] DROP CONSTRAINT [DF_mf_Position_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Position_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Position] DROP CONSTRAINT [DF_mf_Position_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_PenaltyType_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_PenaltyType] DROP CONSTRAINT [DF_mf_PenaltyType_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_PenaltyType_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_PenaltyType] DROP CONSTRAINT [DF_mf_PenaltyType_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_PayrollGroup_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_PayrollGroup] DROP CONSTRAINT [DF_mf_PayrollGroup_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_PayrollGroup_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_PayrollGroup] DROP CONSTRAINT [DF_mf_PayrollGroup_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Offense_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Offense] DROP CONSTRAINT [DF_mf_Offense_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Offense_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Offense] DROP CONSTRAINT [DF_mf_Offense_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_HolidayType_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_HolidayType] DROP CONSTRAINT [DF_mf_HolidayType_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_HolidayType_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_HolidayType] DROP CONSTRAINT [DF_mf_HolidayType_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_HolidayType_rateWork]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_HolidayType] DROP CONSTRAINT [DF_mf_HolidayType_rateWork]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_HolidayType_rateNotWork]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_HolidayType] DROP CONSTRAINT [DF_mf_HolidayType_rateNotWork]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Holidays_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Holidays] DROP CONSTRAINT [DF_mf_Holidays_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Holidays_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Holidays] DROP CONSTRAINT [DF_mf_Holidays_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmploymentType_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmploymentType] DROP CONSTRAINT [DF_mf_EmploymentType_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmploymentType_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmploymentType] DROP CONSTRAINT [DF_mf_EmploymentType_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmploymentStatus_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmploymentStatus] DROP CONSTRAINT [DF_mf_EmploymentStatus_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmploymentStatus_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmploymentStatus] DROP CONSTRAINT [DF_mf_EmploymentStatus_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmploymentStatus_allowProcessPayroll]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmploymentStatus] DROP CONSTRAINT [DF_mf_EmploymentStatus_allowProcessPayroll]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeWorkHistory_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeWorkHistory] DROP CONSTRAINT [DF_mf_EmployeeWorkHistory_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeWorkHistory_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeWorkHistory] DROP CONSTRAINT [DF_mf_EmployeeWorkHistory_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeWorkDays_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeWorkDays] DROP CONSTRAINT [DF_mf_EmployeeWorkDays_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeWorkDays_createdDate1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeWorkDays] DROP CONSTRAINT [DF_mf_EmployeeWorkDays_createdDate1]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeTraining_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeTraining] DROP CONSTRAINT [DF_mf_EmployeeTraining_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeTraining_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeTraining] DROP CONSTRAINT [DF_mf_EmployeeTraining_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeSkill_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeSkill] DROP CONSTRAINT [DF_mf_EmployeeSkill_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeSkill_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeSkill] DROP CONSTRAINT [DF_mf_EmployeeSkill_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeOffense_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeOffense] DROP CONSTRAINT [DF_mf_EmployeeOffense_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeOffense_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeOffense] DROP CONSTRAINT [DF_mf_EmployeeOffense_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeIdentificationDocument_deleted_1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeIdentificationDocument] DROP CONSTRAINT [DF_mf_EmployeeIdentificationDocument_deleted_1]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeIdentificationDocument_updatedDate_1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeIdentificationDocument] DROP CONSTRAINT [DF_mf_EmployeeIdentificationDocument_updatedDate_1]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeEducation_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeEducation] DROP CONSTRAINT [DF_mf_EmployeeEducation_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeEducation_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeEducation] DROP CONSTRAINT [DF_mf_EmployeeEducation_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeEducation_createdDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeEducation] DROP CONSTRAINT [DF_mf_EmployeeEducation_createdDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeDeduction_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeDeduction] DROP CONSTRAINT [DF_mf_EmployeeDeduction_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeDeduction_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeDeduction] DROP CONSTRAINT [DF_mf_EmployeeDeduction_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeBasicPay_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeBasicPay] DROP CONSTRAINT [DF_mf_EmployeeBasicPay_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeBasicPay_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeBasicPay] DROP CONSTRAINT [DF_mf_EmployeeBasicPay_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeBalanceLeave_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeBalanceLeave] DROP CONSTRAINT [DF_mf_EmployeeBalanceLeave_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeBalanceLeave_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeBalanceLeave] DROP CONSTRAINT [DF_mf_EmployeeBalanceLeave_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeAllowance_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeAllowance] DROP CONSTRAINT [DF_mf_EmployeeAllowance_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeAllowance_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeAllowance] DROP CONSTRAINT [DF_mf_EmployeeAllowance_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeAddress_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeAddress] DROP CONSTRAINT [DF_mf_EmployeeAddress_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeAddress_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeAddress] DROP CONSTRAINT [DF_mf_EmployeeAddress_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee201_confidential]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee201] DROP CONSTRAINT [DF_mf_Employee201_confidential]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee201_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee201] DROP CONSTRAINT [DF_mf_Employee201_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee201_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee201] DROP CONSTRAINT [DF_mf_Employee201_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee201_entitledUnworkSpecialHoliday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee201] DROP CONSTRAINT [DF_mf_Employee201_entitledUnworkSpecialHoliday]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee201_entitledUnworkRegularHoliday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee201] DROP CONSTRAINT [DF_mf_Employee201_entitledUnworkRegularHoliday]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee201_timeSheetRequired]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee201] DROP CONSTRAINT [DF_mf_Employee201_timeSheetRequired]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee] DROP CONSTRAINT [DF_mf_Employee_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee] DROP CONSTRAINT [DF_mf_Employee_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_DepartmentSectionRequestApprover_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover] DROP CONSTRAINT [DF_mf_DepartmentSectionRequestApprover_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_DepartmentSectionRequestApprover_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover] DROP CONSTRAINT [DF_mf_DepartmentSectionRequestApprover_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_DepartmentSectionRequestApprover_orderNo]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover] DROP CONSTRAINT [DF_mf_DepartmentSectionRequestApprover_orderNo]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_DepartmentSection_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_DepartmentSection] DROP CONSTRAINT [DF_mf_DepartmentSection_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_DepartmentSection_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_DepartmentSection] DROP CONSTRAINT [DF_mf_DepartmentSection_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Department_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Department] DROP CONSTRAINT [DF_mf_Department_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Department_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Department] DROP CONSTRAINT [DF_mf_Department_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Deduction_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Deduction] DROP CONSTRAINT [DF_mf_Deduction_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Deduction_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Deduction] DROP CONSTRAINT [DF_mf_Deduction_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Country_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Country] DROP CONSTRAINT [DF_mf_Country_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Country_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Country] DROP CONSTRAINT [DF_mf_Country_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_ApplicationRequestType_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_ApplicationRequestType] DROP CONSTRAINT [DF_mf_ApplicationRequestType_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_ApplicationRequestType_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_ApplicationRequestType] DROP CONSTRAINT [DF_mf_ApplicationRequestType_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_ApplicationRequestType_hasLeavePoints]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_ApplicationRequestType] DROP CONSTRAINT [DF_mf_ApplicationRequestType_hasLeavePoints]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Allowance_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Allowance] DROP CONSTRAINT [DF_mf_Allowance_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Allowance_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Allowance] DROP CONSTRAINT [DF_mf_Allowance_updatedDate]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Allowance_isTaxable]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Allowance] DROP CONSTRAINT [DF_mf_Allowance_isTaxable]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Agency_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Agency] DROP CONSTRAINT [DF_mf_Agency_deleted]
END

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Agency_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Agency] DROP CONSTRAINT [DF_mf_Agency_updatedDate]
END

GO
/****** Object:  Table [dbo].[ta_EmployeeAttendance]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_EmployeeAttendance]') AND type in (N'U'))
DROP TABLE [dbo].[ta_EmployeeAttendance]
GO
/****** Object:  Table [dbo].[ta_CutOffAttendanceSummaryDetail]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummaryDetail]') AND type in (N'U'))
DROP TABLE [dbo].[ta_CutOffAttendanceSummaryDetail]
GO
/****** Object:  Table [dbo].[ta_CutOffAttendanceSummary]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummary]') AND type in (N'U'))
DROP TABLE [dbo].[ta_CutOffAttendanceSummary]
GO
/****** Object:  Table [dbo].[ta_CutOffAttendance]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendance]') AND type in (N'U'))
DROP TABLE [dbo].[ta_CutOffAttendance]
GO
/****** Object:  Table [dbo].[ta_ApplicationRequestLeave]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestLeave]') AND type in (N'U'))
DROP TABLE [dbo].[ta_ApplicationRequestLeave]
GO
/****** Object:  Table [dbo].[ta_ApplicationRequestGatePass]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestGatePass]') AND type in (N'U'))
DROP TABLE [dbo].[ta_ApplicationRequestGatePass]
GO
/****** Object:  Table [dbo].[ta_ApplicationRequestApprover]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestApprover]') AND type in (N'U'))
DROP TABLE [dbo].[ta_ApplicationRequestApprover]
GO
/****** Object:  Table [dbo].[ta_ApplicationRequest]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequest]') AND type in (N'U'))
DROP TABLE [dbo].[ta_ApplicationRequest]
GO
/****** Object:  Table [dbo].[sys_UserSession]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_UserSession]') AND type in (N'U'))
DROP TABLE [dbo].[sys_UserSession]
GO
/****** Object:  Table [dbo].[sys_UserRole]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_UserRole]') AND type in (N'U'))
DROP TABLE [dbo].[sys_UserRole]
GO
/****** Object:  Table [dbo].[sys_User]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_User]') AND type in (N'U'))
DROP TABLE [dbo].[sys_User]
GO
/****** Object:  Table [dbo].[sys_Setting]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Setting]') AND type in (N'U'))
DROP TABLE [dbo].[sys_Setting]
GO
/****** Object:  Table [dbo].[sys_RolePermission]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_RolePermission]') AND type in (N'U'))
DROP TABLE [dbo].[sys_RolePermission]
GO
/****** Object:  Table [dbo].[sys_RoleMenu]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_RoleMenu]') AND type in (N'U'))
DROP TABLE [dbo].[sys_RoleMenu]
GO
/****** Object:  Table [dbo].[sys_Role]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Role]') AND type in (N'U'))
DROP TABLE [dbo].[sys_Role]
GO
/****** Object:  Table [dbo].[sys_Permission]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Permission]') AND type in (N'U'))
DROP TABLE [dbo].[sys_Permission]
GO
/****** Object:  Table [dbo].[sys_Menu]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Menu]') AND type in (N'U'))
DROP TABLE [dbo].[sys_Menu]
GO
/****** Object:  Table [dbo].[sys_Location]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Location]') AND type in (N'U'))
DROP TABLE [dbo].[sys_Location]
GO
/****** Object:  Table [dbo].[sys_IdentificationDocument]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_IdentificationDocument]') AND type in (N'U'))
DROP TABLE [dbo].[sys_IdentificationDocument]
GO
/****** Object:  Table [dbo].[sys_ErrorLogs]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_ErrorLogs]') AND type in (N'U'))
DROP TABLE [dbo].[sys_ErrorLogs]
GO
/****** Object:  Table [dbo].[sys_EnumReference]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_EnumReference]') AND type in (N'U'))
DROP TABLE [dbo].[sys_EnumReference]
GO
/****** Object:  Table [dbo].[sys_CompanySetting]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_CompanySetting]') AND type in (N'U'))
DROP TABLE [dbo].[sys_CompanySetting]
GO
/****** Object:  Table [dbo].[sys_Company]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Company]') AND type in (N'U'))
DROP TABLE [dbo].[sys_Company]
GO
/****** Object:  Table [dbo].[pr_PayrollEmployeeEarnings]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeEarnings]') AND type in (N'U'))
DROP TABLE [dbo].[pr_PayrollEmployeeEarnings]
GO
/****** Object:  Table [dbo].[pr_PayrollEmployeeDeductions]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeDeductions]') AND type in (N'U'))
DROP TABLE [dbo].[pr_PayrollEmployeeDeductions]
GO
/****** Object:  Table [dbo].[pr_PayrollEmployee]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployee]') AND type in (N'U'))
DROP TABLE [dbo].[pr_PayrollEmployee]
GO
/****** Object:  Table [dbo].[pr_Payroll]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_Payroll]') AND type in (N'U'))
DROP TABLE [dbo].[pr_Payroll]
GO
/****** Object:  Table [dbo].[mf_WorkDays]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_WorkDays]') AND type in (N'U'))
DROP TABLE [dbo].[mf_WorkDays]
GO
/****** Object:  Table [dbo].[mf_Position]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Position]') AND type in (N'U'))
DROP TABLE [dbo].[mf_Position]
GO
/****** Object:  Table [dbo].[mf_PenaltyType]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_PenaltyType]') AND type in (N'U'))
DROP TABLE [dbo].[mf_PenaltyType]
GO
/****** Object:  Table [dbo].[mf_PayrollGroup]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_PayrollGroup]') AND type in (N'U'))
DROP TABLE [dbo].[mf_PayrollGroup]
GO
/****** Object:  Table [dbo].[mf_Offense]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Offense]') AND type in (N'U'))
DROP TABLE [dbo].[mf_Offense]
GO
/****** Object:  Table [dbo].[mf_HolidayType]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_HolidayType]') AND type in (N'U'))
DROP TABLE [dbo].[mf_HolidayType]
GO
/****** Object:  Table [dbo].[mf_Holidays]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Holidays]') AND type in (N'U'))
DROP TABLE [dbo].[mf_Holidays]
GO
/****** Object:  Table [dbo].[mf_EmploymentType]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmploymentType]') AND type in (N'U'))
DROP TABLE [dbo].[mf_EmploymentType]
GO
/****** Object:  Table [dbo].[mf_EmploymentStatus]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmploymentStatus]') AND type in (N'U'))
DROP TABLE [dbo].[mf_EmploymentStatus]
GO
/****** Object:  Table [dbo].[mf_EmployeeWorkHistory]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkHistory]') AND type in (N'U'))
DROP TABLE [dbo].[mf_EmployeeWorkHistory]
GO
/****** Object:  Table [dbo].[mf_EmployeeWorkDays]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkDays]') AND type in (N'U'))
DROP TABLE [dbo].[mf_EmployeeWorkDays]
GO
/****** Object:  Table [dbo].[mf_EmployeeTraining]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeTraining]') AND type in (N'U'))
DROP TABLE [dbo].[mf_EmployeeTraining]
GO
/****** Object:  Table [dbo].[mf_EmployeeSkill]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeSkill]') AND type in (N'U'))
DROP TABLE [dbo].[mf_EmployeeSkill]
GO
/****** Object:  Table [dbo].[mf_EmployeeOffense]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeOffense]') AND type in (N'U'))
DROP TABLE [dbo].[mf_EmployeeOffense]
GO
/****** Object:  Table [dbo].[mf_EmployeeIdentificationDocument]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeIdentificationDocument]') AND type in (N'U'))
DROP TABLE [dbo].[mf_EmployeeIdentificationDocument]
GO
/****** Object:  Table [dbo].[mf_EmployeeEducation]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeEducation]') AND type in (N'U'))
DROP TABLE [dbo].[mf_EmployeeEducation]
GO
/****** Object:  Table [dbo].[mf_EmployeeDeduction]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeDeduction]') AND type in (N'U'))
DROP TABLE [dbo].[mf_EmployeeDeduction]
GO
/****** Object:  Table [dbo].[mf_EmployeeBasicPay]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBasicPay]') AND type in (N'U'))
DROP TABLE [dbo].[mf_EmployeeBasicPay]
GO
/****** Object:  Table [dbo].[mf_EmployeeBalanceLeave]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBalanceLeave]') AND type in (N'U'))
DROP TABLE [dbo].[mf_EmployeeBalanceLeave]
GO
/****** Object:  Table [dbo].[mf_EmployeeAllowance]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAllowance]') AND type in (N'U'))
DROP TABLE [dbo].[mf_EmployeeAllowance]
GO
/****** Object:  Table [dbo].[mf_EmployeeAddress]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAddress]') AND type in (N'U'))
DROP TABLE [dbo].[mf_EmployeeAddress]
GO
/****** Object:  Table [dbo].[mf_Employee201]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Employee201]') AND type in (N'U'))
DROP TABLE [dbo].[mf_Employee201]
GO
/****** Object:  Table [dbo].[mf_Employee]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Employee]') AND type in (N'U'))
DROP TABLE [dbo].[mf_Employee]
GO
/****** Object:  Table [dbo].[mf_DepartmentSectionRequestApprover]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSectionRequestApprover]') AND type in (N'U'))
DROP TABLE [dbo].[mf_DepartmentSectionRequestApprover]
GO
/****** Object:  Table [dbo].[mf_DepartmentSection]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSection]') AND type in (N'U'))
DROP TABLE [dbo].[mf_DepartmentSection]
GO
/****** Object:  Table [dbo].[mf_Department]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Department]') AND type in (N'U'))
DROP TABLE [dbo].[mf_Department]
GO
/****** Object:  Table [dbo].[mf_Deduction]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Deduction]') AND type in (N'U'))
DROP TABLE [dbo].[mf_Deduction]
GO
/****** Object:  Table [dbo].[mf_Country]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Country]') AND type in (N'U'))
DROP TABLE [dbo].[mf_Country]
GO
/****** Object:  Table [dbo].[mf_ApplicationRequestType]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_ApplicationRequestType]') AND type in (N'U'))
DROP TABLE [dbo].[mf_ApplicationRequestType]
GO
/****** Object:  Table [dbo].[mf_Allowance]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Allowance]') AND type in (N'U'))
DROP TABLE [dbo].[mf_Allowance]
GO
/****** Object:  Table [dbo].[mf_Agency]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Agency]') AND type in (N'U'))
DROP TABLE [dbo].[mf_Agency]
GO
/****** Object:  UserDefinedFunction [dbo].[RemoveSpecialCharacters]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RemoveSpecialCharacters]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[RemoveSpecialCharacters]
GO
/****** Object:  UserDefinedFunction [dbo].[RemoveNonAlphaCharacters]    Script Date: 1/3/2017 4:42:20 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RemoveNonAlphaCharacters]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[RemoveNonAlphaCharacters]
GO
/****** Object:  UserDefinedFunction [dbo].[RemoveNonAlphaCharacters]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RemoveNonAlphaCharacters]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[RemoveNonAlphaCharacters](@Temp VarChar(1000))
Returns VarChar(1000)
AS
Begin

    Declare @KeepValues as varchar(50)
    Set @KeepValues = ''%[^a-z]%''
    While PatIndex(@KeepValues, @Temp) > 0
        Set @Temp = Stuff(@Temp, PatIndex(@KeepValues, @Temp), 1, '''')

    Return @Temp
End
' 
END

GO
/****** Object:  UserDefinedFunction [dbo].[RemoveSpecialCharacters]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RemoveSpecialCharacters]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE Function [dbo].[RemoveSpecialCharacters](@Temp VarChar(1000))
Returns VarChar(1000)
AS
Begin

    Declare @KeepValues as varchar(50)
    Set @KeepValues = ''%[^a-z0-9]%''
    While PatIndex(@KeepValues, @Temp) > 0
        Set @Temp = Stuff(@Temp, PatIndex(@KeepValues, @Temp), 1, '''')

    Return @Temp
End
' 
END

GO
/****** Object:  Table [dbo].[mf_Agency]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Agency]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_Agency](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[companyId] [int] NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_Agency] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_Allowance]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Allowance]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_Allowance](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[companyId] [int] NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[isTaxable] [bit] NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_Allowance] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_ApplicationRequestType]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_ApplicationRequestType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_ApplicationRequestType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[requiredLeavePoints] [bit] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_ApplicationRequestType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_Country]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Country]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_Country](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_Country] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_Deduction]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Deduction]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_Deduction](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[companyId] [int] NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_Deduction] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_Department]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Department]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_Department](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[companyId] [int] NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_Department] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_DepartmentSection]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSection]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_DepartmentSection](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[departmentId] [int] NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_DepartmentSection] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_DepartmentSectionRequestApprover]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSectionRequestApprover]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_DepartmentSectionRequestApprover](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[approverId] [int] NOT NULL,
	[departmentSectionId] [int] NOT NULL,
	[applicationRequestTypeId] [int] NOT NULL,
	[orderNo] [int] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_DepartmentSectionRequestApprover] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_Employee]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Employee]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_Employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[companyId] [int] NOT NULL,
	[firstName] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[middleName] [nvarchar](50) NULL,
	[birthDate] [datetime] NULL,
	[email] [nvarchar](100) NULL,
	[gender] [int] NULL,
	[maritalStatus] [int] NULL,
	[contact1] [nvarchar](50) NULL,
	[contact2] [nvarchar](50) NULL,
	[contact3] [nvarchar](50) NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
	[employeeAddressId] [int] NULL,
	[employee201Id] [int] NULL,
	[pictureExtension] [nvarchar](50) NULL,
 CONSTRAINT [PK_mf_Employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_Employee201]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Employee201]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_Employee201](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeCode] [nvarchar](250) NOT NULL,
	[departmentId] [int] NULL,
	[departmentSectionId] [int] NULL,
	[positionId] [int] NULL,
	[email] [nvarchar](150) NULL,
	[employmentTypeId] [int] NULL,
	[employmentStatusId] [int] NULL,
	[positionLevel] [int] NULL,
	[dateHired] [datetime] NULL,
	[resignedDate] [datetime] NULL,
	[taxStatus] [int] NULL,
	[timeSheetRequired] [bit] NULL,
	[entitledUnworkRegularHoliday] [bit] NULL,
	[entitledUnworkSpecialHoliday] [bit] NULL,
	[entitledOvertime] [bit] NULL,
	[entitledHolidayPay] [bit] NULL,
	[payrollGroupId] [int] NULL,
	[agencyId] [int] NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
	[confidential] [bit] NOT NULL,
 CONSTRAINT [PK_mf_Employee201] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_EmployeeAddress]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAddress]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_EmployeeAddress](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[address1] [nvarchar](max) NULL,
	[address2] [nvarchar](max) NULL,
	[address3] [nvarchar](max) NULL,
	[countryId] [int] NOT NULL,
	[city] [nvarchar](150) NULL,
	[postalCode] [nvarchar](50) NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_EmployeeAddress] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_EmployeeAllowance]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAllowance]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_EmployeeAllowance](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeId] [int] NOT NULL,
	[allowanceId] [int] NOT NULL,
	[amount] [float] NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_EmployeeAllowance] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_EmployeeBalanceLeave]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBalanceLeave]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_EmployeeBalanceLeave](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeId] [int] NOT NULL,
	[balance] [float] NOT NULL,
	[applicationRequestTypeId] [int] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_EmployeeBalanceLeave] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_EmployeeBasicPay]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBasicPay]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_EmployeeBasicPay](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeId] [int] NOT NULL,
	[basicPay] [float] NOT NULL,
	[rateType] [int] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_EmployeeBasicPay] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_EmployeeDeduction]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeDeduction]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_EmployeeDeduction](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeId] [int] NOT NULL,
	[deductionId] [int] NOT NULL,
	[amount] [float] NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_EmployeeDeduction] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_EmployeeEducation]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeEducation]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_EmployeeEducation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeId] [int] NOT NULL,
	[schoolName] [nvarchar](250) NOT NULL,
	[fromYear] [int] NULL,
	[toYear] [int] NULL,
	[isGraduated] [bit] NULL,
	[course] [nvarchar](250) NULL,
	[createdBy] [int] NOT NULL,
	[createdDate] [datetime] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_EmployeeEducation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_EmployeeIdentificationDocument]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeIdentificationDocument]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_EmployeeIdentificationDocument](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeId] [int] NOT NULL,
	[identificationDocumentId] [int] NOT NULL,
	[idNumber] [nvarchar](150) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_EmployeeIdentificationDocument_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_EmployeeOffense]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeOffense]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_EmployeeOffense](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeId] [int] NOT NULL,
	[offenseId] [int] NOT NULL,
	[offenseDate] [datetime] NOT NULL,
	[memoDate] [datetime] NULL,
	[penaltyTypeId] [int] NOT NULL,
	[frequency] [int] NOT NULL,
	[degree] [int] NOT NULL,
	[startDate] [datetime] NULL,
	[endDate] [datetime] NULL,
	[remarks] [nvarchar](max) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_EmployeeOffense] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_EmployeeSkill]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeSkill]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_EmployeeSkill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeId] [int] NOT NULL,
	[skillName] [nvarchar](250) NOT NULL,
	[skillProficiencyLevel] [int] NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_EmployeeSkill] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_EmployeeTraining]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeTraining]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_EmployeeTraining](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeId] [int] NOT NULL,
	[trainingDate] [datetime] NOT NULL,
	[trainingName] [nvarchar](250) NOT NULL,
	[description] [nvarchar](max) NULL,
	[startDate] [datetime] NULL,
	[endDate] [datetime] NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_EmployeeTraining] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_EmployeeWorkDays]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkDays]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_EmployeeWorkDays](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeId] [int] NOT NULL,
	[workDayId] [int] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_EmployeeWorkDays] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_EmployeeWorkHistory]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkHistory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_EmployeeWorkHistory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeId] [int] NOT NULL,
	[companyName] [nvarchar](250) NOT NULL,
	[position] [nvarchar](250) NULL,
	[joinedMonth] [int] NOT NULL,
	[joinedYear] [int] NOT NULL,
	[resignedMonth] [int] NULL,
	[resignedYear] [int] NULL,
	[isPresent] [bit] NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_EmployeeWorkHistory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_EmploymentStatus]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmploymentStatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_EmploymentStatus](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[allowProcessPayroll] [bit] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_EmploymentStatus] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_EmploymentType]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_EmploymentType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_EmploymentType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_EmploymentType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_Holidays]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Holidays]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_Holidays](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[holidayDate] [datetime] NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[holidayTypeId] [int] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_Holidays] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_HolidayType]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_HolidayType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_HolidayType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[rateNotWork] [float] NOT NULL,
	[rateWork] [float] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_HolidayType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_Offense]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Offense]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_Offense](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[companyId] [int] NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_Offense] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_PayrollGroup]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_PayrollGroup]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_PayrollGroup](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_PayrollGroup] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_PenaltyType]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_PenaltyType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_PenaltyType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[companyId] [int] NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_PenaltyType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_Position]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_Position]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_Position](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[companyId] [int] NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_Position] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[mf_WorkDays]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mf_WorkDays]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mf_WorkDays](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[companyId] [int] NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[monday] [bit] NOT NULL,
	[tuesday] [bit] NOT NULL,
	[wednesday] [bit] NOT NULL,
	[thursday] [bit] NOT NULL,
	[friday] [bit] NOT NULL,
	[saturday] [bit] NOT NULL,
	[sunday] [bit] NOT NULL,
	[fromTimeHour] [int] NOT NULL,
	[fromTimeMinute] [int] NOT NULL,
	[toTimeHour] [int] NOT NULL,
	[toTimeMinute] [int] NOT NULL,
	[breakHours] [float] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_mf_WorkDays] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[pr_Payroll]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_Payroll]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[pr_Payroll](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[companyId] [int] NOT NULL,
	[cutOffAttendanceId] [int] NOT NULL,
	[status] [int] NOT NULL,
	[includeLegalDeduction] [bit] NOT NULL,
	[generatedBy] [int] NOT NULL,
	[generatedDate] [datetime] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_pr_Payroll] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[pr_PayrollEmployee]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployee]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[pr_PayrollEmployee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[payrollId] [int] NOT NULL,
	[employeeId] [int] NOT NULL,
	[noOfDays] [float] NOT NULL,
	[totalHours] [float] NOT NULL,
	[hourlyRates] [float] NOT NULL,
	[payRateType] [int] NOT NULL,
	[basicRate] [float] NOT NULL,
	[totalDeduction] [float] NOT NULL,
	[totalIncome] [float] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_pr_PayrollEmployee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[pr_PayrollEmployeeDeductions]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeDeductions]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[pr_PayrollEmployeeDeductions](
	[id] [int] NOT NULL,
	[payrollEmployeeId] [int] NOT NULL,
	[deductionId] [int] NULL,
	[paySlipDetail] [int] NULL,
	[value] [float] NOT NULL,
 CONSTRAINT [PK_pr_PayrollEmployeeDeductions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[pr_PayrollEmployeeEarnings]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeEarnings]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[pr_PayrollEmployeeEarnings](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[payrollEmployeeId] [int] NOT NULL,
	[allowanceId] [int] NULL,
	[paySlipDetail] [int] NULL,
	[value] [float] NOT NULL,
 CONSTRAINT [PK_pr_PayrollEmployeeEarnings] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[sys_Company]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Company]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_Company](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[businessName] [nvarchar](250) NOT NULL,
	[address1] [nvarchar](max) NULL,
	[address2] [nvarchar](max) NULL,
	[address3] [nvarchar](max) NULL,
	[countryId] [int] NOT NULL,
	[city] [nvarchar](150) NULL,
	[postalCode] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[telephone] [nvarchar](50) NULL,
	[mobile] [nvarchar](50) NULL,
	[fax] [nvarchar](50) NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_sys_Company] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[sys_CompanySetting]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_CompanySetting]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_CompanySetting](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[settingId] [int] NOT NULL,
	[companyId] [int] NULL,
	[value] [nvarchar](max) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_sys_CompanySetting] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[sys_EnumReference]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_EnumReference]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_EnumReference](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[companyId] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[value] [int] NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[displayOrder] [int] NOT NULL,
	[hidden] [bit] NOT NULL,
	[deleted] [bit] NOT NULL,
	[field1] [nvarchar](250) NULL,
	[field2] [nvarchar](250) NULL,
	[field3] [nvarchar](250) NULL,
	[field4] [nvarchar](250) NULL,
	[field5] [nvarchar](250) NULL,
 CONSTRAINT [PK_sys_EnumReference] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[sys_ErrorLogs]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_ErrorLogs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_ErrorLogs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[message] [nvarchar](max) NULL,
	[innerException] [nvarchar](max) NULL,
	[loggedType] [int] NOT NULL,
	[controllerName] [nvarchar](250) NULL,
	[actionName] [nvarchar](250) NULL,
	[areaName] [nvarchar](250) NULL,
	[createdBy] [int] NULL,
	[createdDate] [datetime] NOT NULL,
 CONSTRAINT [PK_sys_ErrorLogs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[sys_IdentificationDocument]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_IdentificationDocument]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_IdentificationDocument](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_sys_IdentificationDocument] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[sys_Location]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Location]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_Location](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[companyId] [int] NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_sys_Location] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[sys_Menu]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Menu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_Menu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[controllerName] [nvarchar](250) NULL,
	[actionName] [nvarchar](150) NULL,
	[areaName] [nvarchar](150) NULL,
	[parameter] [nvarchar](250) NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_sys_Menu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[sys_Permission]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Permission]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_Permission](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[companyId] [int] NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_sys_Permission] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[sys_Role]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Role]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_Role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[companyId] [int] NOT NULL,
	[code] [nvarchar](50) NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_sys_Role] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[sys_RoleMenu]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_RoleMenu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_RoleMenu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[roleId] [int] NOT NULL,
	[sourceMenuId] [int] NOT NULL,
	[description] [nvarchar](250) NOT NULL,
	[parentRoleMenuId] [int] NULL,
	[displayOrder] [int] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_sys_RoleMenu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[sys_RolePermission]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_RolePermission]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_RolePermission](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[roleId] [int] NOT NULL,
	[permissionId] [int] NOT NULL,
	[viewAccess] [bit] NOT NULL,
	[createAccess] [bit] NOT NULL,
	[updateAccess] [bit] NOT NULL,
	[deleteAccess] [bit] NOT NULL,
	[printAccess] [bit] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_sys_RolePermission] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[sys_Setting]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_Setting]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_Setting](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](150) NOT NULL,
	[description] [nvarchar](500) NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_sys_Setting] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[sys_User]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_User]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[companyId] [int] NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](max) NULL,
	[hashKey] [nvarchar](max) NULL,
	[vector] [nvarchar](max) NULL,
	[email] [nvarchar](50) NULL,
	[employeeId] [int] NULL,
	[status] [int] NOT NULL,
	[updatedBy] [int] NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_sys_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[sys_UserRole]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_UserRole]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_UserRole](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[roleId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_sys_UserRole] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[sys_UserSession]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sys_UserSession]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sys_UserSession](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[companyId] [int] NOT NULL,
	[loggedDate] [datetime] NOT NULL,
	[ipAddress] [nvarchar](50) NOT NULL,
	[expiredDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_sys_UserSession] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ta_ApplicationRequest]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequest]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ta_ApplicationRequest](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[applicationRequestTypeId] [int] NOT NULL,
	[note] [nvarchar](max) NOT NULL,
	[status] [int] NOT NULL,
	[assignTo] [int] NOT NULL,
	[requestedBy] [int] NOT NULL,
	[requestedDate] [datetime] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_ta_ApplicationRequest] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ta_ApplicationRequestApprover]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestApprover]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ta_ApplicationRequestApprover](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[applicationRequestId] [int] NOT NULL,
	[approverId] [int] NOT NULL,
	[status] [int] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_ta_ApplicationRequestApprover] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ta_ApplicationRequestGatePass]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestGatePass]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ta_ApplicationRequestGatePass](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[applicationRequestId] [int] NOT NULL,
	[startDateTime] [datetime] NOT NULL,
	[endDateTime] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_ta_ApplicationRequestGatePass] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ta_ApplicationRequestLeave]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestLeave]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ta_ApplicationRequestLeave](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[applicationRequestId] [int] NOT NULL,
	[startDate] [datetime] NOT NULL,
	[endDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_ta_ApplicationRequestLeave] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ta_CutOffAttendance]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendance]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ta_CutOffAttendance](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[payrollGroupId] [int] NOT NULL,
	[companyId] [int] NOT NULL,
	[generatedDate] [datetime] NOT NULL,
	[startDate] [datetime] NOT NULL,
	[endDate] [datetime] NOT NULL,
	[status] [int] NOT NULL,
	[remarks] [nvarchar](max) NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[changeStatusBy] [int] NOT NULL,
	[changeStatusDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_ta_CutOffAttendance] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ta_CutOffAttendanceSummary]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummary]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ta_CutOffAttendanceSummary](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cutOffAttendanceId] [int] NOT NULL,
	[employeeId] [int] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_ta_CutOffAttendanceSummary] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ta_CutOffAttendanceSummaryDetail]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummaryDetail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ta_CutOffAttendanceSummaryDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cutOffAttendanceSummaryId] [int] NOT NULL,
	[workDate] [datetime] NOT NULL,
	[workHours] [float] NOT NULL,
	[undertimeHours] [float] NOT NULL,
	[lateHours] [float] NOT NULL,
	[overtimeHours] [float] NOT NULL,
	[workHolidayHours] [float] NULL,
	[holidayTypeId] [int] NULL,
	[absent] [bit] NOT NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_ta_CutOffAttendanceSummaryDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ta_EmployeeAttendance]    Script Date: 1/3/2017 4:42:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ta_EmployeeAttendance]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ta_EmployeeAttendance](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeId] [int] NOT NULL,
	[timeLogType] [int] NOT NULL,
	[workDate] [datetime] NOT NULL,
	[timeLog] [datetime] NOT NULL,
	[workDayId] [int] NULL,
	[remarks] [nvarchar](max) NULL,
	[updatedBy] [int] NOT NULL,
	[updatedDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_ta_EmployeeAttendance] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[mf_Country] ON 

GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (1, N'AD', N'Andorra', 1, CAST(N'2016-04-24T12:58:26.823' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (2, N'AE', N'United Arab Emirates', 1, CAST(N'2016-04-24T12:48:46.213' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (3, N'AF', N'Afghanistan', 1, CAST(N'2016-04-24T12:48:46.250' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (4, N'AG', N'Antigua and Barbuda', 1, CAST(N'2016-04-24T12:48:46.283' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (5, N'AI', N'Anguilla', 1, CAST(N'2016-04-24T12:48:46.320' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (6, N'AL', N'Albania', 1, CAST(N'2016-04-24T12:48:46.353' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (7, N'AM', N'Armenia', 1, CAST(N'2016-04-24T12:48:46.383' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (8, N'AN', N'Netherlands Antilles', 1, CAST(N'2016-04-24T12:48:46.410' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (9, N'AO', N'Angola', 1, CAST(N'2016-04-24T12:48:46.440' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (10, N'AQ', N'Antarctica', 1, CAST(N'2016-04-24T12:48:46.473' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (11, N'AR', N'Argentina', 1, CAST(N'2016-04-24T12:48:46.503' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (12, N'ARPA', N'Old style Arpanet', 1, CAST(N'2016-04-24T12:48:46.537' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (13, N'AS', N'American Samoa', 1, CAST(N'2016-04-24T12:48:46.567' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (14, N'AT', N'Austria', 1, CAST(N'2016-04-24T12:48:46.597' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (15, N'AU', N'Australia', 1, CAST(N'2016-04-24T12:48:46.627' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (16, N'AW', N'Aruba', 1, CAST(N'2016-04-24T12:48:46.657' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (17, N'AZ', N'Azerbaidjan', 1, CAST(N'2016-04-24T12:48:46.687' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (18, N'BA', N'Bosnia-Herzegovina', 1, CAST(N'2016-04-24T12:48:46.717' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (19, N'BB', N'Barbados', 1, CAST(N'2016-04-24T12:48:46.747' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (20, N'BD', N'Bangladesh', 1, CAST(N'2016-04-24T12:48:46.777' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (21, N'BE', N'Belgium', 1, CAST(N'2016-04-24T12:48:46.807' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (22, N'BF', N'Burkina Faso', 1, CAST(N'2016-04-24T12:48:46.833' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (23, N'BG', N'Bulgaria', 1, CAST(N'2016-04-24T12:48:46.867' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (24, N'BH', N'Bahrain', 1, CAST(N'2016-04-24T12:48:46.920' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (25, N'BI', N'Burundi', 1, CAST(N'2016-04-24T12:48:46.950' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (26, N'BJ', N'Benin', 1, CAST(N'2016-04-24T12:48:46.980' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (27, N'BM', N'Bermuda', 1, CAST(N'2016-04-24T12:48:47.010' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (28, N'BN', N'Brunei Darussalam', 1, CAST(N'2016-04-24T12:48:47.043' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (29, N'BO', N'Bolivia', 1, CAST(N'2016-04-24T12:48:47.073' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (30, N'BR', N'Brazil', 1, CAST(N'2016-04-24T12:48:47.107' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (31, N'BS', N'Bahamas', 1, CAST(N'2016-04-24T12:48:47.137' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (32, N'BT', N'Bhutan', 1, CAST(N'2016-04-24T12:48:47.163' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (33, N'BV', N'Bouvet Island', 1, CAST(N'2016-04-24T12:48:47.197' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (34, N'BW', N'Botswana', 1, CAST(N'2016-04-24T12:48:47.223' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (35, N'BY', N'Belarus', 1, CAST(N'2016-04-24T12:48:47.253' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (36, N'BZ', N'Belize', 1, CAST(N'2016-04-24T12:48:47.283' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (37, N'CA', N'Canada', 1, CAST(N'2016-04-24T12:48:47.310' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (38, N'CC', N'Cocos (Keeling) Islands', 1, CAST(N'2016-04-24T12:48:47.343' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (39, N'CF', N'Central African Republic', 1, CAST(N'2016-04-24T12:48:47.373' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (40, N'CG', N'Congo', 1, CAST(N'2016-04-24T12:48:47.403' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (41, N'CH', N'Switzerland', 1, CAST(N'2016-04-24T12:48:47.433' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (42, N'CI', N'Ivory Coast (Cote D''Ivoire)', 1, CAST(N'2016-04-24T12:48:47.463' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (43, N'CK', N'Cook Islands', 1, CAST(N'2016-04-24T12:48:47.493' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (44, N'CL', N'Chile', 1, CAST(N'2016-04-24T12:48:47.520' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (45, N'CM', N'Cameroon', 1, CAST(N'2016-04-24T12:48:47.550' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (46, N'CN', N'China', 1, CAST(N'2016-04-24T12:48:47.580' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (47, N'CO', N'Colombia', 1, CAST(N'2016-04-24T12:48:47.610' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (48, N'COM', N'Commercial', 1, CAST(N'2016-04-24T12:48:47.640' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (49, N'CR', N'Costa Rica', 1, CAST(N'2016-04-24T12:48:47.670' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (50, N'CS', N'Former Czechoslovakia', 1, CAST(N'2016-04-24T12:48:47.700' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (51, N'CU', N'Cuba', 1, CAST(N'2016-04-24T12:48:47.733' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (52, N'CV', N'Cape Verde', 1, CAST(N'2016-04-24T12:48:47.760' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (53, N'CX', N'Christmas Island', 1, CAST(N'2016-04-24T12:48:47.793' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (54, N'CY', N'Cyprus', 1, CAST(N'2016-04-24T12:48:47.820' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (55, N'CZ', N'Czech Republic', 1, CAST(N'2016-04-24T12:48:47.850' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (56, N'DE', N'Germany', 1, CAST(N'2016-04-24T12:48:47.880' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (57, N'DJ', N'Djibouti', 1, CAST(N'2016-04-24T12:48:47.910' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (58, N'DK', N'Denmark', 1, CAST(N'2016-04-24T12:48:47.940' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (59, N'DM', N'Dominica', 1, CAST(N'2016-04-24T12:48:47.967' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (60, N'DO', N'Dominican Republic', 1, CAST(N'2016-04-24T12:48:47.997' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (61, N'DZ', N'Algeria', 1, CAST(N'2016-04-24T12:48:48.030' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (62, N'EC', N'Ecuador', 1, CAST(N'2016-04-24T12:48:48.060' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (63, N'EDU', N'USA Educational', 1, CAST(N'2016-04-24T12:48:48.090' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (64, N'EE', N'Estonia', 1, CAST(N'2016-04-24T12:48:48.120' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (65, N'EG', N'Egypt', 1, CAST(N'2016-04-24T12:48:48.147' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (66, N'EH', N'Western Sahara', 1, CAST(N'2016-04-24T12:48:48.177' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (67, N'ER', N'Eritrea', 1, CAST(N'2016-04-24T12:48:48.207' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (68, N'ES', N'Spain', 1, CAST(N'2016-04-24T12:48:48.237' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (69, N'ET', N'Ethiopia', 1, CAST(N'2016-04-24T12:48:48.263' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (70, N'FI', N'Finland', 1, CAST(N'2016-04-24T12:48:48.293' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (71, N'FJ', N'Fiji', 1, CAST(N'2016-04-24T12:48:48.323' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (72, N'FK', N'Falkland Islands', 1, CAST(N'2016-04-24T12:48:48.350' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (73, N'FM', N'Micronesia', 1, CAST(N'2016-04-24T12:48:48.380' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (74, N'FO', N'Faroe Islands', 1, CAST(N'2016-04-24T12:48:48.410' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (75, N'FR', N'France', 1, CAST(N'2016-04-24T12:48:48.440' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (76, N'FX', N'France (European Territory)', 1, CAST(N'2016-04-24T12:48:48.467' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (77, N'GA', N'Gabon', 1, CAST(N'2016-04-24T12:48:48.497' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (78, N'GB', N'Great Britain', 1, CAST(N'2016-04-24T12:48:48.527' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (79, N'GD', N'Grenada', 1, CAST(N'2016-04-24T12:48:48.553' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (80, N'GE', N'Georgia', 1, CAST(N'2016-04-24T12:48:48.583' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (81, N'GF', N'French Guyana', 1, CAST(N'2016-04-24T12:48:48.613' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (82, N'GH', N'Ghana', 1, CAST(N'2016-04-24T12:48:48.640' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (83, N'GI', N'Gibraltar', 1, CAST(N'2016-04-24T12:48:48.670' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (84, N'GL', N'Greenland', 1, CAST(N'2016-04-24T12:48:48.697' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (85, N'GM', N'Gambia', 1, CAST(N'2016-04-24T12:48:48.727' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (86, N'GN', N'Guinea', 1, CAST(N'2016-04-24T12:48:48.757' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (87, N'GOV', N'USA Government', 1, CAST(N'2016-04-24T12:48:48.787' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (88, N'GP', N'Guadeloupe (French)', 1, CAST(N'2016-04-24T12:48:48.817' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (89, N'GQ', N'Equatorial Guinea', 1, CAST(N'2016-04-24T12:48:48.847' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (90, N'GR', N'Greece', 1, CAST(N'2016-04-24T12:48:48.873' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (91, N'GS', N'S. Georgia & S. Sandwich Isls.', 1, CAST(N'2016-04-24T12:48:48.907' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (92, N'GT', N'Guatemala', 1, CAST(N'2016-04-24T12:48:48.937' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (93, N'GU', N'Guam (USA)', 1, CAST(N'2016-04-24T12:48:48.967' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (94, N'GW', N'Guinea Bissau', 1, CAST(N'2016-04-24T12:48:48.993' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (95, N'GY', N'Guyana', 1, CAST(N'2016-04-24T12:48:49.023' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (96, N'HK', N'Hong Kong', 1, CAST(N'2016-04-24T12:48:49.053' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (97, N'HM', N'Heard and McDonald Islands', 1, CAST(N'2016-04-24T12:48:49.083' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (98, N'HN', N'Honduras', 1, CAST(N'2016-04-24T12:48:49.113' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (99, N'HR', N'Croatia', 1, CAST(N'2016-04-24T12:48:49.143' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (100, N'HT', N'Haiti', 1, CAST(N'2016-04-24T12:48:49.203' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (101, N'HU', N'Hungary', 1, CAST(N'2016-04-24T12:48:49.233' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (102, N'ID', N'Indonesia', 1, CAST(N'2016-04-24T12:48:49.263' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (103, N'IE', N'Ireland', 1, CAST(N'2016-04-24T12:48:49.290' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (104, N'IL', N'Israel', 1, CAST(N'2016-04-24T12:48:49.320' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (105, N'IN', N'India', 1, CAST(N'2016-04-24T12:48:49.350' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (106, N'INT', N'International', 1, CAST(N'2016-04-24T12:48:49.380' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (107, N'IO', N'British Indian Ocean Territory', 1, CAST(N'2016-04-24T12:48:49.410' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (108, N'IQ', N'Iraq', 1, CAST(N'2016-04-24T12:48:49.440' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (109, N'IR', N'Iran', 1, CAST(N'2016-04-24T12:48:49.470' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (110, N'IS', N'Iceland', 1, CAST(N'2016-04-24T12:48:49.500' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (111, N'IT', N'Italy', 1, CAST(N'2016-04-24T12:48:49.530' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (112, N'JM', N'Jamaica', 1, CAST(N'2016-04-24T12:48:49.560' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (113, N'JO', N'Jordan', 1, CAST(N'2016-04-24T12:48:49.597' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (114, N'JP', N'Japan', 1, CAST(N'2016-04-24T12:48:49.650' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (115, N'KE', N'Kenya', 1, CAST(N'2016-04-24T12:48:49.680' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (116, N'KG', N'Kyrgyzstan', 1, CAST(N'2016-04-24T12:48:49.710' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (117, N'KH', N'Cambodia', 1, CAST(N'2016-04-24T12:48:49.740' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (118, N'KI', N'Kiribati', 1, CAST(N'2016-04-24T12:48:49.770' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (119, N'KM', N'Comoros', 1, CAST(N'2016-04-24T12:48:49.800' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (120, N'KN', N'Saint Kitts & Nevis Anguilla', 1, CAST(N'2016-04-24T12:48:49.827' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (121, N'KP', N'North Korea', 1, CAST(N'2016-04-24T12:48:49.857' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (122, N'KR', N'South Korea', 1, CAST(N'2016-04-24T12:48:49.887' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (123, N'KW', N'Kuwait', 1, CAST(N'2016-04-24T12:48:49.913' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (124, N'KY', N'Cayman Islands', 1, CAST(N'2016-04-24T12:48:49.943' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (125, N'KZ', N'Kazakhstan', 1, CAST(N'2016-04-24T12:48:49.973' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (126, N'LA', N'Laos', 1, CAST(N'2016-04-24T12:48:50.003' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (127, N'LB', N'Lebanon', 1, CAST(N'2016-04-24T12:48:50.030' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (128, N'LC', N'Saint Lucia', 1, CAST(N'2016-04-24T12:48:50.060' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (129, N'LI', N'Liechtenstein', 1, CAST(N'2016-04-24T12:48:50.090' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (130, N'LK', N'Sri Lanka', 1, CAST(N'2016-04-24T12:48:50.120' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (131, N'LR', N'Liberia', 1, CAST(N'2016-04-24T12:48:50.147' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (132, N'LS', N'Lesotho', 1, CAST(N'2016-04-24T12:48:50.177' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (133, N'LT', N'Lithuania', 1, CAST(N'2016-04-24T12:48:50.210' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (134, N'LU', N'Luxembourg', 1, CAST(N'2016-04-24T12:48:50.240' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (135, N'LV', N'Latvia', 1, CAST(N'2016-04-24T12:48:50.270' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (136, N'LY', N'Libya', 1, CAST(N'2016-04-24T12:48:50.303' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (137, N'MA', N'Morocco', 1, CAST(N'2016-04-24T12:48:50.333' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (138, N'MC', N'Monaco', 1, CAST(N'2016-04-24T12:48:50.373' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (139, N'MD', N'Moldavia', 1, CAST(N'2016-04-24T12:48:50.403' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (140, N'MG', N'Madagascar', 1, CAST(N'2016-04-24T12:48:50.433' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (141, N'MH', N'Marshall Islands', 1, CAST(N'2016-04-24T12:48:50.463' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (142, N'MIL', N'USA Military', 1, CAST(N'2016-04-24T12:48:50.493' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (143, N'MK', N'Macedonia', 1, CAST(N'2016-04-24T12:48:50.523' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (144, N'ML', N'Mali', 1, CAST(N'2016-04-24T12:48:50.553' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (145, N'MM', N'Myanmar', 1, CAST(N'2016-04-24T12:48:50.580' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (146, N'MN', N'Mongolia', 1, CAST(N'2016-04-24T12:48:50.610' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (147, N'MO', N'Macau', 1, CAST(N'2016-04-24T12:48:50.637' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (148, N'MP', N'Northern Mariana Islands', 1, CAST(N'2016-04-24T12:48:50.667' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (149, N'MQ', N'Martinique (French)', 1, CAST(N'2016-04-24T12:48:50.697' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (150, N'MR', N'Mauritania', 1, CAST(N'2016-04-24T12:48:50.723' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (151, N'MS', N'Montserrat', 1, CAST(N'2016-04-24T12:48:50.753' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (152, N'MT', N'Malta', 1, CAST(N'2016-04-24T12:48:50.780' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (153, N'MU', N'Mauritius', 1, CAST(N'2016-04-24T12:48:50.810' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (154, N'MV', N'Maldives', 1, CAST(N'2016-04-24T12:48:50.840' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (155, N'MW', N'Malawi', 1, CAST(N'2016-04-24T12:48:50.867' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (156, N'MX', N'Mexico', 1, CAST(N'2016-04-24T12:48:50.893' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (157, N'MY', N'Malaysia', 1, CAST(N'2016-04-24T12:48:50.923' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (158, N'MZ', N'Mozambique', 1, CAST(N'2016-04-24T12:48:50.953' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (159, N'NA', N'Namibia', 1, CAST(N'2016-04-24T12:48:50.980' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (160, N'NATO', N'NATO (this was purged in 1996 - see hq.nato.int)', 1, CAST(N'2016-04-24T12:48:51.010' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (161, N'NC', N'New Caledonia (French)', 1, CAST(N'2016-04-24T12:48:51.047' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (162, N'NE', N'Niger', 1, CAST(N'2016-04-24T12:48:51.077' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (163, N'NET', N'Network', 1, CAST(N'2016-04-24T12:48:51.110' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (164, N'NF', N'Norfolk Island', 1, CAST(N'2016-04-24T12:48:51.140' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (165, N'NG', N'Nigeria', 1, CAST(N'2016-04-24T12:48:51.170' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (166, N'NI', N'Nicaragua', 1, CAST(N'2016-04-24T12:48:51.207' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (167, N'NL', N'Netherlands', 1, CAST(N'2016-04-24T12:48:51.237' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (168, N'NO', N'Norway', 1, CAST(N'2016-04-24T12:48:51.267' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (169, N'NP', N'Nepal', 1, CAST(N'2016-04-24T12:48:51.297' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (170, N'NR', N'Nauru', 1, CAST(N'2016-04-24T12:48:51.323' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (171, N'NT', N'Neutral Zone', 1, CAST(N'2016-04-24T12:48:51.353' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (172, N'NU', N'Niue', 1, CAST(N'2016-04-24T12:48:51.380' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (173, N'NZ', N'New Zealand', 1, CAST(N'2016-04-24T12:48:51.410' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (174, N'OM', N'Oman', 1, CAST(N'2016-04-24T12:48:51.440' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (175, N'ORG', N'Non-Profit Making Organisations (sic)', 1, CAST(N'2016-04-24T12:48:51.470' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (176, N'PA', N'Panama', 1, CAST(N'2016-04-24T12:48:51.503' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (177, N'PE', N'Peru', 1, CAST(N'2016-04-24T12:48:51.533' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (178, N'PF', N'Polynesia (French)', 1, CAST(N'2016-04-24T12:48:51.563' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (179, N'PG', N'Papua New Guinea', 1, CAST(N'2016-04-24T12:48:51.593' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (180, N'PH', N'Philippines', 1, CAST(N'2016-04-24T12:48:51.623' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (181, N'PK', N'Pakistan', 1, CAST(N'2016-04-24T12:48:51.653' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (182, N'PL', N'Poland', 1, CAST(N'2016-04-24T12:48:51.683' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (183, N'PM', N'Saint Pierre and Miquelon', 1, CAST(N'2016-04-24T12:48:51.713' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (184, N'PN', N'Pitcairn Island', 1, CAST(N'2016-04-24T12:48:51.747' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (185, N'PR', N'Puerto Rico', 1, CAST(N'2016-04-24T12:48:51.777' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (186, N'PT', N'Portugal', 1, CAST(N'2016-04-24T12:48:51.807' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (187, N'PW', N'Palau', 1, CAST(N'2016-04-24T12:48:51.833' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (188, N'PY', N'Paraguay', 1, CAST(N'2016-04-24T12:48:51.863' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (189, N'QA', N'Qatar', 1, CAST(N'2016-04-24T12:48:51.893' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (190, N'RE', N'Reunion (French)', 1, CAST(N'2016-04-24T12:48:51.920' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (191, N'RO', N'Romania', 1, CAST(N'2016-04-24T12:48:51.950' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (192, N'RU', N'Russian Federation', 1, CAST(N'2016-04-24T12:48:52.000' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (193, N'RW', N'Rwanda', 1, CAST(N'2016-04-24T12:48:52.030' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (194, N'SA', N'Saudi Arabia', 1, CAST(N'2016-04-24T12:48:52.060' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (195, N'SB', N'Solomon Islands', 1, CAST(N'2016-04-24T12:48:52.090' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (196, N'SC', N'Seychelles', 1, CAST(N'2016-04-24T12:48:52.120' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (197, N'SD', N'Sudan', 1, CAST(N'2016-04-24T12:48:52.147' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (198, N'SE', N'Sweden', 1, CAST(N'2016-04-24T12:48:52.177' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (199, N'SG', N'Singapore', 1, CAST(N'2016-04-24T12:48:52.207' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (200, N'SH', N'Saint Helena', 1, CAST(N'2016-04-24T12:48:52.233' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (201, N'SI', N'Slovenia', 1, CAST(N'2016-04-24T12:48:52.263' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (202, N'SJ', N'Svalbard and Jan Mayen Islands', 1, CAST(N'2016-04-24T12:48:52.290' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (203, N'SK', N'Slovak Republic', 1, CAST(N'2016-04-24T12:48:52.320' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (204, N'SL', N'Sierra Leone', 1, CAST(N'2016-04-24T12:48:52.350' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (205, N'SM', N'San Marino', 1, CAST(N'2016-04-24T12:48:52.380' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (206, N'SN', N'Senegal', 1, CAST(N'2016-04-24T12:48:52.410' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (207, N'SO', N'Somalia', 1, CAST(N'2016-04-24T12:48:52.437' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (208, N'SR', N'Suriname', 1, CAST(N'2016-04-24T12:48:52.467' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (209, N'ST', N'Saint Tome (Sao Tome) and Principe', 1, CAST(N'2016-04-24T12:48:52.497' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (210, N'SU', N'Former USSR', 1, CAST(N'2016-04-24T12:48:52.527' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (211, N'SV', N'El Salvador', 1, CAST(N'2016-04-24T12:48:52.557' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (212, N'SY', N'Syria', 1, CAST(N'2016-04-24T12:48:52.583' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (213, N'SZ', N'Swaziland', 1, CAST(N'2016-04-24T12:48:52.613' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (214, N'TC', N'Turks and Caicos Islands', 1, CAST(N'2016-04-24T12:48:52.643' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (215, N'TD', N'Chad', 1, CAST(N'2016-04-24T12:48:52.673' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (216, N'TF', N'French Southern Territories', 1, CAST(N'2016-04-24T12:48:52.703' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (217, N'TG', N'Togo', 1, CAST(N'2016-04-24T12:48:52.730' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (218, N'TH', N'Thailand', 1, CAST(N'2016-04-24T12:48:52.760' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (219, N'TJ', N'Tadjikistan', 1, CAST(N'2016-04-24T12:48:52.790' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (220, N'TK', N'Tokelau', 1, CAST(N'2016-04-24T12:48:52.817' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (221, N'TM', N'Turkmenistan', 1, CAST(N'2016-04-24T12:48:52.847' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (222, N'TN', N'Tunisia', 1, CAST(N'2016-04-24T12:48:52.873' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (223, N'TO', N'Tonga', 1, CAST(N'2016-04-24T12:48:52.903' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (224, N'TP', N'East Timor', 1, CAST(N'2016-04-24T12:48:52.933' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (225, N'TR', N'Turkey', 1, CAST(N'2016-04-24T12:48:52.963' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (226, N'TT', N'Trinidad and Tobago', 1, CAST(N'2016-04-24T12:48:52.990' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (227, N'TV', N'Tuvalu', 1, CAST(N'2016-04-24T12:48:53.020' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (228, N'TW', N'Taiwan', 1, CAST(N'2016-04-24T12:48:53.050' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (229, N'TZ', N'Tanzania', 1, CAST(N'2016-04-24T12:48:53.080' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (230, N'UA', N'Ukraine', 1, CAST(N'2016-04-24T12:48:53.110' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (231, N'UG', N'Uganda', 1, CAST(N'2016-04-24T12:48:53.137' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (232, N'UK', N'United Kingdom', 1, CAST(N'2016-04-24T12:48:53.167' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (233, N'UM', N'USA Minor Outlying Islands', 1, CAST(N'2016-04-24T12:48:53.193' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (234, N'US', N'United States', 1, CAST(N'2016-04-24T12:48:53.227' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (235, N'UY', N'Uruguay', 1, CAST(N'2016-04-24T12:48:53.253' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (236, N'UZ', N'Uzbekistan', 1, CAST(N'2016-04-24T12:48:53.283' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (237, N'VA', N'Vatican City State', 1, CAST(N'2016-04-24T12:48:53.310' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (238, N'VC', N'Saint Vincent & Grenadines', 1, CAST(N'2016-04-24T12:48:53.340' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (239, N'VE', N'Venezuela', 1, CAST(N'2016-04-24T12:48:53.370' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (240, N'VG', N'Virgin Islands (British)', 1, CAST(N'2016-04-24T12:48:53.397' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (241, N'VI', N'Virgin Islands (USA)', 1, CAST(N'2016-04-24T12:48:53.430' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (242, N'VN', N'Vietnam', 1, CAST(N'2016-04-24T12:48:53.457' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (243, N'VU', N'Vanuatu', 1, CAST(N'2016-04-24T12:48:53.483' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (244, N'WF', N'Wallis and Futuna Islands', 1, CAST(N'2016-04-24T12:48:53.513' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (245, N'WS', N'Samoa', 1, CAST(N'2016-04-24T12:48:53.540' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (246, N'YE', N'Yemen', 1, CAST(N'2016-04-24T12:48:53.570' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (247, N'YT', N'Mayotte', 1, CAST(N'2016-04-24T12:48:53.600' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (248, N'YU', N'Yugoslavia', 1, CAST(N'2016-04-24T12:48:53.627' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (249, N'ZA', N'South Africa', 1, CAST(N'2016-04-24T12:48:53.657' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (250, N'ZM', N'Zambia', 1, CAST(N'2016-04-24T12:48:53.683' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (251, N'ZR', N'Zaire', 1, CAST(N'2016-04-24T12:48:53.713' AS DateTime), 0)
GO
INSERT [dbo].[mf_Country] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (252, N'ZW', N'Zimbabwe', 1, CAST(N'2016-04-24T12:48:53.747' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[mf_Country] OFF
GO
SET IDENTITY_INSERT [dbo].[mf_Deduction] ON 

GO
INSERT [dbo].[mf_Deduction] ([id], [companyId], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (1, 1, N'SSS', N'SSS', 1, CAST(N'2016-10-10T21:47:30.180' AS DateTime), 0)
GO
INSERT [dbo].[mf_Deduction] ([id], [companyId], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (2, 1, N'TAX', N'TAX', 1, CAST(N'2016-10-10T21:47:34.130' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[mf_Deduction] OFF
GO
SET IDENTITY_INSERT [dbo].[mf_EmploymentStatus] ON 

GO
INSERT [dbo].[mf_EmploymentStatus] ([id], [code], [description], [allowProcessPayroll], [updatedBy], [updatedDate], [deleted]) VALUES (1, N'Active', N'Active', 1, 1, CAST(N'2016-10-10T11:07:39.047' AS DateTime), 0)
GO
INSERT [dbo].[mf_EmploymentStatus] ([id], [code], [description], [allowProcessPayroll], [updatedBy], [updatedDate], [deleted]) VALUES (2, N'Resigned', N'Resigned', 0, 1, CAST(N'2016-06-17T13:03:30.017' AS DateTime), 0)
GO
INSERT [dbo].[mf_EmploymentStatus] ([id], [code], [description], [allowProcessPayroll], [updatedBy], [updatedDate], [deleted]) VALUES (3, N'Terminated', N'Terminated', 0, 1, CAST(N'2016-06-17T13:03:30.017' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[mf_EmploymentStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[mf_EmploymentType] ON 

GO
INSERT [dbo].[mf_EmploymentType] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (1, N'Probation', N'Probation', 1, CAST(N'2016-06-21T09:17:00.257' AS DateTime), 0)
GO
INSERT [dbo].[mf_EmploymentType] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (2, N'Contractual', N'Contractual', 1, CAST(N'2016-06-21T09:17:00.257' AS DateTime), 0)
GO
INSERT [dbo].[mf_EmploymentType] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (3, N'Regular', N'Regular', 1, CAST(N'2016-06-21T09:17:00.257' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[mf_EmploymentType] OFF
GO
SET IDENTITY_INSERT [dbo].[mf_HolidayType] ON 

GO
INSERT [dbo].[mf_HolidayType] ([id], [code], [description], [rateNotWork], [rateWork], [updatedBy], [updatedDate], [deleted]) VALUES (1, N'RH', N'Regular Holiday', 100, 200, 1, CAST(N'2016-04-28T11:46:42.123' AS DateTime), 0)
GO
INSERT [dbo].[mf_HolidayType] ([id], [code], [description], [rateNotWork], [rateWork], [updatedBy], [updatedDate], [deleted]) VALUES (2, N'SNWD', N'Special non-working day', 0, 130, 1, CAST(N'2016-04-28T11:47:20.627' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[mf_HolidayType] OFF
GO
SET IDENTITY_INSERT [dbo].[mf_WorkDays] ON 

GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (45, 1, N'001', N'Regular Shift (1:00 PM - 10:00 PM)', 1, 1, 1, 1, 1, 1, 1, 13, 0, 22, 0, 1, 1, CAST(N'2016-10-10T10:41:36.870' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (46, 1, N'002', N'Regular Shift (1:00 PM - 09:30 PM)', 1, 1, 1, 1, 1, 1, 1, 13, 0, 21, 30, 0, 1, CAST(N'2016-06-18T12:03:33.107' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (47, 1, N'005A', N'Regular Shift (1:00 PM - 06:00 PM)', 1, 1, 1, 1, 1, 1, 1, 13, 0, 18, 0, 0, 1, CAST(N'2016-06-18T17:30:43.187' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (48, 1, N'003', N'Regular Shift (1:00 AM - 10:00 AM)', 1, 1, 1, 1, 1, 1, 1, 1, 0, 10, 0, 0, 1, CAST(N'2016-06-18T17:31:49.693' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (49, 1, N'004', N'Regular Shift (1:00 AM - 9:30 AM)', 1, 1, 1, 1, 1, 1, 1, 1, 0, 9, 30, 0, 1, CAST(N'2016-06-18T17:32:19.773' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (50, 1, N'005B', N'Regular Shift (7:00 PM - 10:00 PM)', 1, 1, 1, 1, 1, 1, 1, 19, 0, 22, 0, 0, 1, CAST(N'2016-06-18T17:32:32.480' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (51, 1, N'006A', N'Regular Shift (01:00 AM - 06:00 AM', 1, 1, 1, 1, 1, 1, 1, 1, 0, 6, 0, 0, 1, CAST(N'2016-06-18T17:36:25.067' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (52, 1, N'006B', N'Regular Shift (07:00 AM - 10:00 AM)', 1, 1, 1, 1, 1, 1, 1, 7, 0, 10, 0, 0, 1, CAST(N'2016-06-18T17:37:47.903' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (53, 1, N'007A', N'Regular Shift (01:00 AM - 06:00 AM)', 1, 1, 1, 1, 1, 1, 1, 1, 0, 6, 0, 0, 1, CAST(N'2016-06-18T17:39:25.650' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (54, 1, N'007B', N'Regular Shift (06:30 AM - 9:30 AM)', 1, 1, 1, 1, 1, 1, 1, 6, 30, 9, 30, 0, 1, CAST(N'2016-06-18T17:40:53.150' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (55, 1, N'008A', N'Regular Shift (01:00 PM - 06:00 PM)', 1, 1, 1, 1, 1, 1, 1, 13, 0, 18, 0, 0, 1, CAST(N'2016-06-18T17:42:16.650' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (56, 1, N'008B', N'Regular Shift (06:30 PM - 09:30 PM)', 1, 1, 1, 1, 1, 1, 1, 18, 30, 21, 30, 0, 1, CAST(N'2016-06-18T17:43:42.100' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (57, 1, N'009', N'Regular Shift (02:00 AM - 10:30 AM)', 1, 1, 1, 1, 1, 1, 1, 2, 0, 10, 30, 0, 1, CAST(N'2016-06-18T17:45:48.070' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (58, 1, N'010', N'Regular Shift (02:00 AM - 11:00 AM)', 1, 1, 1, 1, 1, 1, 1, 2, 0, 11, 0, 0, 1, CAST(N'2016-06-18T17:47:05.353' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (59, 1, N'011', N'Regular Shift (02:00 PM - 10:30 PM)', 1, 1, 1, 1, 1, 1, 1, 14, 0, 22, 30, 0, 1, CAST(N'2016-06-18T17:48:26.327' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (60, 1, N'012', N'Regular Shift (02:00 PM - 11:00 PM)', 1, 1, 1, 1, 1, 1, 1, 14, 0, 23, 0, 0, 1, CAST(N'2016-06-18T17:49:51.350' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (61, 1, N'013A', N'Regular Shift (02:00 AM - 06:00 AM)', 1, 1, 1, 1, 1, 1, 1, 2, 0, 6, 0, 0, 1, CAST(N'2016-06-18T17:51:00.463' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (62, 1, N'013B', N'Regular  Shift (06:30 AM - 10:30 AM)', 1, 1, 1, 1, 1, 1, 1, 6, 30, 10, 30, 0, 1, CAST(N'2016-06-18T17:52:35.550' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (63, 1, N'014A', N'Regular Shift (02:00 AM - 06:00 AM)', 1, 1, 1, 1, 1, 1, 1, 2, 0, 6, 0, 0, 1, CAST(N'2016-06-18T17:53:45.467' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (64, 1, N'014B', N'Regular Shift (07:00 AM - 11:00 AM)', 1, 1, 1, 1, 1, 1, 1, 7, 0, 11, 0, 0, 1, CAST(N'2016-06-18T17:54:46.073' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (65, 1, N'015A', N'Regular Shift (02:00 PM - 06:00 PM)', 1, 1, 1, 1, 1, 1, 1, 14, 0, 18, 0, 0, 1, CAST(N'2016-06-18T17:56:44.043' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (66, 1, N'015B', N'Regular Shift (06:30 PM - 10:30 PM)', 1, 1, 1, 1, 1, 1, 1, 18, 30, 22, 30, 0, 1, CAST(N'2016-06-18T17:58:23.567' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (67, 1, N'016A', N'Regular Shift (02:00 PM - 06:00 PM', 1, 1, 1, 1, 1, 1, 1, 14, 0, 18, 0, 0, 1, CAST(N'2016-06-18T18:00:02.650' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (68, 1, N'016B', N'Regular Shift (07:00 PM - 11:00 PM)', 1, 1, 1, 1, 1, 1, 1, 19, 0, 23, 0, 0, 1, CAST(N'2016-06-18T18:01:17.980' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (69, 1, N'017', N'Regular Shift (03:00 AM - 11:30 AM)', 1, 1, 1, 1, 1, 1, 1, 3, 0, 11, 30, 0, 1, CAST(N'2016-06-18T18:02:44.593' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (70, 1, N'018', N'Regular Shift (03:00 PM - 11:30 PM)', 1, 1, 1, 1, 1, 1, 1, 15, 0, 23, 30, 0, 1, CAST(N'2016-06-18T18:03:49.470' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (71, 1, N'019', N'Regular Shift (03:00 AM - 12:00 PM)', 1, 1, 1, 1, 1, 1, 1, 3, 0, 12, 0, 0, 1, CAST(N'2016-06-18T18:07:18.227' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (72, 1, N'020', N'Regular Shift (03:00 PM - 12:00 AM)', 1, 1, 1, 1, 1, 1, 1, 15, 0, 0, 0, 0, 1, CAST(N'2016-06-18T18:08:22.787' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (73, 1, N'021A', N'Regular Shift (03:00 PM - 07:00 PM)', 1, 1, 1, 1, 1, 1, 1, 15, 0, 19, 0, 0, 1, CAST(N'2016-06-18T18:10:24.117' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (74, 1, N'021B', N'Regular Shift (08:00 PM - 12:00 AM)', 1, 1, 1, 1, 1, 1, 1, 20, 0, 0, 0, 0, 1, CAST(N'2016-06-18T18:11:39.773' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (75, 1, N'022A', N'Regular Shift (03:00 AM - 07:00 AM)', 1, 1, 1, 1, 1, 1, 1, 3, 0, 7, 0, 0, 1, CAST(N'2016-06-18T18:12:40.187' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (76, 1, N'022B', N'Regular Shift (08:00 AM - 12:00 PM)', 1, 1, 1, 1, 1, 1, 1, 8, 0, 12, 0, 0, 1, CAST(N'2016-06-18T18:14:12.520' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (77, 1, N'023A', N'Regular Shift (03:00 PM - 07:00 PM)', 1, 1, 1, 1, 1, 1, 1, 15, 0, 19, 0, 0, 1, CAST(N'2016-06-18T18:15:23.787' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (78, 1, N'023B', N'Regular Shift (07:30 PM - 11:30 PM)', 1, 1, 1, 1, 1, 1, 1, 19, 30, 23, 30, 0, 1, CAST(N'2016-06-18T18:17:44.567' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (79, 1, N'024A', N'Regular Shift (03:00 AM - 07:00 AM)', 1, 1, 1, 1, 1, 1, 1, 3, 0, 7, 0, 0, 1, CAST(N'2016-06-18T18:18:49.187' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (80, 1, N'024B', N'Regular Shift (07:30 AM - 11:30 AM)', 1, 1, 1, 1, 1, 1, 1, 7, 30, 11, 30, 0, 1, CAST(N'2016-06-18T18:20:04.437' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (81, 1, N'025', N'Regular Shift (04:00 AM - 12:30 PM)', 1, 1, 1, 1, 1, 1, 1, 4, 0, 12, 30, 0, 1, CAST(N'2016-06-18T18:21:34.963' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (82, 1, N'026', N'Regular Shift (04:00 AM - 01:00 PM)', 1, 1, 1, 1, 1, 1, 1, 4, 0, 13, 0, 0, 1, CAST(N'2016-06-18T18:22:37.810' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (83, 1, N'027', N'Regular Shift (04:00 PM - 12:30 AM)', 1, 1, 1, 1, 1, 1, 1, 16, 0, 0, 30, 0, 1, CAST(N'2016-06-18T18:23:55.857' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (84, 1, N'028', N'Regular Shift (04:00 PM - 01:00 AM)', 1, 1, 1, 1, 1, 1, 1, 16, 0, 1, 0, 0, 1, CAST(N'2016-06-18T18:24:53.853' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (85, 1, N'029A', N'Regular Shift (04:00 AM - 08:00 AM)', 1, 1, 1, 1, 1, 1, 1, 4, 0, 8, 0, 0, 1, CAST(N'2016-06-18T18:26:09.913' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (86, 1, N'029B', N'Regular Shift (08:30 AM - 12:30 PM)', 1, 1, 1, 1, 1, 1, 1, 8, 30, 12, 30, 0, 1, CAST(N'2016-06-18T18:27:21.083' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (87, 1, N'030A', N'Regular Shift (04:00 AM - 08:00 AM)', 1, 1, 1, 1, 1, 1, 1, 4, 0, 8, 0, 0, 1, CAST(N'2016-06-18T18:28:38.140' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (88, 1, N'030B', N'Regular Shift (09:00 AM - 01:00 PM)', 1, 1, 1, 1, 1, 1, 1, 9, 0, 13, 0, 0, 1, CAST(N'2016-06-18T18:31:07.607' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (89, 1, N'031A', N'Regular Shift (04:00 PM - 08:00 PM)', 1, 1, 1, 1, 1, 1, 1, 16, 0, 20, 0, 0, 1, CAST(N'2016-06-18T18:32:05.727' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (90, 1, N'031B', N'Regular Shift (08:30 PM - 12:30 AM)', 1, 1, 1, 1, 1, 1, 1, 20, 30, 0, 30, 0, 1, CAST(N'2016-06-18T18:35:03.513' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (91, 1, N'032A', N'Regular Shift (04:00 AM - 08:00 AM)', 1, 1, 1, 1, 1, 1, 1, 4, 0, 8, 0, 0, 1, CAST(N'2016-06-18T18:36:28.730' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (92, 1, N'032B', N'Regular Shift (09:00 AM - 01:00 PM)', 1, 1, 1, 1, 1, 1, 1, 9, 0, 13, 0, 0, 1, CAST(N'2016-06-18T18:37:33.027' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (93, 1, N'033', N'Regular Shift (05:00 AM - 01:30 PM)', 1, 1, 1, 1, 1, 1, 1, 5, 0, 13, 30, 0, 1, CAST(N'2016-06-18T18:40:10.557' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (94, 1, N'034', N'Regular Shift (05:00 AM - 02:00 PM)', 1, 1, 1, 1, 1, 1, 1, 5, 0, 14, 0, 0, 1, CAST(N'2016-06-18T18:41:30.337' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (95, 1, N'035', N'Regular Shift (05:00 PM - 01:30 AM)', 1, 1, 1, 1, 1, 1, 1, 17, 0, 1, 30, 0, 1, CAST(N'2016-06-18T18:42:41.967' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (96, 1, N'036', N'Regular Shift (05:00 PM - 02:00 AM)', 1, 1, 1, 1, 1, 1, 1, 17, 0, 2, 0, 0, 1, CAST(N'2016-06-18T18:43:47.673' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (97, 1, N'037A', N'Regular Shift (05:00 AM - 09:00 AM)', 1, 1, 1, 1, 1, 1, 1, 5, 0, 9, 0, 0, 1, CAST(N'2016-06-18T18:45:56.817' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (98, 1, N'037B', N'Regular Shift (09:30 AM - 01:30 PM)', 1, 1, 1, 1, 1, 1, 1, 9, 30, 13, 30, 0, 1, CAST(N'2016-06-18T18:47:02.000' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (99, 1, N'038A', N'Regular Shift (05:00 AM - 09:00 AM)', 1, 1, 1, 1, 1, 1, 1, 5, 0, 9, 0, 0, 1, CAST(N'2016-06-18T18:48:05.180' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (100, 1, N'038B', N'Regular Shift (10:30 AM - 02:00 PM)', 1, 1, 1, 1, 1, 1, 1, 10, 30, 14, 0, 0, 1, CAST(N'2016-06-18T18:49:15.310' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (101, 1, N'039A', N'Regular Shift (05:00 PM - 09:00 PM)', 1, 1, 1, 1, 1, 1, 1, 17, 0, 21, 0, 0, 1, CAST(N'2016-06-18T18:50:24.690' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (102, 1, N'039B', N'Regular Shift (09:30 PM - 01:30 AM)', 1, 1, 1, 1, 1, 1, 1, 21, 30, 1, 30, 0, 1, CAST(N'2016-06-18T18:51:26.367' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (103, 1, N'040A', N'Regular Shift (05:00 PM - 09:00 PM)', 1, 1, 1, 1, 1, 1, 1, 17, 0, 21, 0, 0, 1, CAST(N'2016-06-18T18:52:55.747' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (104, 1, N'040B', N'Regular Shift (10:00 PM - 02:00 AM)', 1, 1, 1, 1, 1, 1, 1, 22, 0, 2, 0, 0, 1, CAST(N'2016-06-18T18:53:51.183' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (105, 1, N'041', N'Regular Shift (06:00 AM - 02:30 PM)', 1, 1, 1, 1, 1, 1, 1, 6, 0, 14, 30, 0, 1, CAST(N'2016-06-18T18:56:27.333' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (106, 1, N'042', N'Regular Shift (06:00 AM - 03:00 PM)', 1, 1, 1, 1, 1, 1, 1, 6, 0, 15, 0, 0, 1, CAST(N'2016-06-18T18:57:24.623' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (107, 1, N'043', N'Regular Shift (06:00 PM - 02:30 AM)', 1, 1, 1, 1, 1, 1, 1, 18, 0, 2, 30, 0, 1, CAST(N'2016-06-18T18:58:29.437' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (108, 1, N'044', N'Regular Shift (06:00 PM - 03:00 AM)', 1, 1, 1, 1, 1, 1, 1, 18, 0, 3, 0, 0, 1, CAST(N'2016-06-18T19:11:14.357' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (109, 1, N'045A', N'Regular Shift (06:00 AM - 10:00 AM)', 1, 1, 1, 1, 1, 1, 1, 6, 0, 10, 0, 0, 1, CAST(N'2016-06-18T19:12:13.257' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (110, 1, N'045B', N'Regular Shift (10:30 AM - 02:30 PM)', 1, 1, 1, 1, 1, 1, 1, 10, 30, 14, 30, 0, 1, CAST(N'2016-06-18T19:13:22.593' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (111, 1, N'046A', N'Regular Shift (06:00 AM - 10:00 AM)', 1, 1, 1, 1, 1, 1, 1, 6, 0, 10, 0, 0, 1, CAST(N'2016-06-18T19:14:19.723' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (112, 1, N'046B', N'Regular Shift (11:00 AM - 03:00 PM)', 1, 1, 1, 1, 1, 1, 1, 1, 0, 15, 0, 0, 1, CAST(N'2016-06-18T19:15:25.930' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (113, 1, N'047A', N'Regular Shift (06:00 PM - 10:00 PM)', 1, 1, 1, 1, 1, 1, 1, 18, 0, 10, 0, 0, 1, CAST(N'2016-06-18T19:17:15.267' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (114, 1, N'047B', N'Regular Shift (10:30 PM - 02:30 AM)', 1, 1, 1, 1, 1, 1, 1, 22, 30, 2, 30, 0, 1, CAST(N'2016-06-18T19:18:18.310' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (115, 1, N'048A', N'Regular Shift (06:00 PM - 10:00 PM)', 1, 1, 1, 1, 1, 1, 1, 18, 0, 22, 0, 0, 1, CAST(N'2016-06-18T19:19:38.633' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (116, 1, N'048B', N'Regular Shift (11:00 PM - 03:00 AM)', 1, 1, 1, 1, 1, 1, 1, 23, 0, 3, 0, 0, 1, CAST(N'2016-06-18T19:20:33.027' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (117, 1, N'049', N'Regular Shift (07:00 AM - 03:30 PM)', 1, 1, 1, 1, 1, 1, 1, 7, 0, 15, 30, 0, 1, CAST(N'2016-06-18T19:21:50.347' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (118, 1, N'050', N'Regular Shift (07:00 AM - 04:00 PM)', 1, 1, 1, 1, 1, 1, 1, 7, 0, 16, 0, 0, 1, CAST(N'2016-06-18T19:23:11.177' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (119, 1, N'051', N'Regular Shift (07:00 PM - 03:30 AM)', 1, 1, 1, 1, 1, 1, 1, 19, 0, 3, 30, 0, 1, CAST(N'2016-06-18T19:24:20.637' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (120, 1, N'052', N'Regular Shift (07:00 PM - 04:00 AM', 1, 1, 1, 1, 1, 1, 1, 19, 0, 4, 0, 0, 1, CAST(N'2016-06-18T19:25:15.037' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (121, 1, N'053A', N'Regular Shift (07:00 AM - 11:00 AM)', 1, 1, 1, 1, 1, 1, 1, 7, 0, 11, 0, 0, 1, CAST(N'2016-06-18T19:26:28.853' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (122, 1, N'053B', N'Regular Shift (11:30 AM - 03:30 PM)', 1, 1, 1, 1, 1, 1, 1, 11, 30, 15, 30, 0, 1, CAST(N'2016-06-18T19:27:21.450' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (123, 1, N'054A', N'Regular Shift (07:00 AM - 11:00 AM)', 1, 1, 1, 1, 1, 1, 1, 7, 0, 11, 0, 0, 1, CAST(N'2016-06-18T19:28:23.713' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (124, 1, N'054B', N'Regular Shift (12:00 PM - 04:00 PM)', 1, 1, 1, 1, 1, 1, 1, 12, 0, 16, 0, 0, 1, CAST(N'2016-06-18T19:29:42.680' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (125, 1, N'055A', N'Regular Shift (07:00 PM - 11:00 PM)', 1, 1, 1, 1, 1, 1, 1, 19, 0, 23, 0, 0, 1, CAST(N'2016-06-18T19:30:49.907' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (126, 1, N'055B', N'Regular Shift (11:30 PM - 03:30 AM)', 1, 1, 1, 1, 1, 1, 1, 23, 30, 3, 30, 0, 1, CAST(N'2016-06-18T19:32:08.900' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (127, 1, N'056A', N'Regular Shift (07:00 PM - 11:00 PM)', 1, 1, 1, 1, 1, 1, 1, 19, 0, 23, 0, 0, 1, CAST(N'2016-06-18T19:33:10.303' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (128, 1, N'056B', N'Regular Shift (12:00 AM - 04:00 AM)', 1, 1, 1, 1, 1, 1, 1, 0, 0, 4, 0, 0, 1, CAST(N'2016-06-18T19:34:03.907' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (129, 1, N'057', N'Regular Shift (08:00 AM - 04:30 PM)', 1, 1, 1, 1, 1, 1, 1, 8, 0, 16, 30, 0, 1, CAST(N'2016-06-18T19:35:10.287' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (130, 1, N'058', N'Regular Shift (08:00 AM - 05:00 PM)', 1, 1, 1, 1, 1, 1, 1, 8, 0, 17, 0, 0, 1, CAST(N'2016-06-18T19:36:11.487' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (131, 1, N'059', N'Regular Shift (08:00 PM - 04:30 AM)', 1, 1, 1, 1, 1, 1, 1, 8, 0, 4, 30, 0, 1, CAST(N'2016-06-18T19:37:23.253' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (132, 1, N'060', N'Regular Shift (08:00 PM - 05:00 AM)', 1, 1, 1, 1, 1, 1, 1, 20, 0, 5, 0, 0, 1, CAST(N'2016-06-18T19:38:18.237' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (133, 1, N'061A', N'Regular Shift (08:00 AM - 12:00 PM)', 1, 1, 1, 1, 1, 1, 1, 8, 0, 12, 0, 0, 1, CAST(N'2016-06-18T19:42:03.587' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (134, 1, N'061B', N'Regular Shift (12:30 PM - 04:30 PM)', 1, 1, 1, 1, 1, 1, 1, 12, 30, 16, 30, 0, 1, CAST(N'2016-06-18T19:43:43.603' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (135, 1, N'062A', N'Regular Shift (08:00 AM - 12:00 PM)', 1, 1, 1, 1, 1, 1, 1, 8, 0, 12, 0, 0, 1, CAST(N'2016-06-18T19:44:55.547' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (136, 1, N'062B', N'Regular Shift (01:00 PM - 05:00 PM)', 1, 1, 1, 1, 1, 1, 1, 13, 0, 17, 0, 0, 1, CAST(N'2016-06-18T19:45:52.037' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (137, 1, N'063A', N'Regular Shift (08:00 PM - 12:00 AM)', 1, 1, 1, 1, 1, 1, 1, 20, 0, 0, 0, 0, 1, CAST(N'2016-06-18T19:46:36.303' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (138, 1, N'063B', N'Regular Shift (12:30 AM - 04:30 AM)', 1, 1, 1, 1, 1, 1, 1, 0, 30, 4, 30, 0, 1, CAST(N'2016-06-18T19:47:41.877' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (139, 1, N'064A', N'Regular Shift (08:00 PM - 12:00 AM)', 1, 1, 1, 1, 1, 1, 1, 20, 0, 0, 0, 0, 1, CAST(N'2016-06-18T19:48:35.513' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (140, 1, N'064B', N'Regular Shift (01:00 AM - 05:00 AM)', 1, 1, 1, 1, 1, 1, 1, 1, 0, 5, 0, 0, 1, CAST(N'2016-06-18T19:49:37.260' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (141, 1, N'065', N'Regular Shift (09:00 AM - 05:30 PM)', 1, 1, 1, 1, 1, 1, 1, 9, 0, 17, 30, 0, 1, CAST(N'2016-06-18T19:50:42.987' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (142, 1, N'066', N'Regular Shift (09:00 AM - 06:00 PM)', 1, 1, 1, 1, 1, 1, 1, 9, 0, 18, 0, 0, 1, CAST(N'2016-06-18T19:51:29.753' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (143, 1, N'067', N'Regular Shift (09:00 PM - 05:30 AM)', 1, 1, 1, 1, 1, 1, 1, 21, 0, 5, 30, 0, 1, CAST(N'2016-06-18T19:52:39.400' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (144, 1, N'068', N'Regular Shift (09:00 PM - 06:00 AM)', 1, 1, 1, 1, 1, 1, 1, 21, 0, 6, 0, 0, 1, CAST(N'2016-06-18T19:53:40.540' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (145, 1, N'069A', N'Regular Shift (09:00 AM - 12:00 PM)', 1, 1, 1, 1, 1, 1, 1, 9, 0, 12, 0, 0, 1, CAST(N'2016-06-18T19:54:39.580' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (146, 1, N'069B', N'Regular Shift (12:30 PM - 05:30 PM)', 1, 1, 1, 1, 1, 1, 1, 12, 30, 17, 30, 0, 1, CAST(N'2016-06-18T19:55:58.957' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (147, 1, N'070A', N'Regular Shift (09:00 AM - 12:00 PM)', 1, 1, 1, 1, 1, 1, 1, 9, 0, 12, 0, 0, 1, CAST(N'2016-06-18T19:57:50.740' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (148, 1, N'070B', N'Regular Shift (01:00 PM - 06:00 PM)', 1, 1, 1, 1, 1, 1, 1, 13, 0, 18, 0, 0, 1, CAST(N'2016-06-18T19:59:03.380' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (149, 1, N'071A', N'Regular Shift (09:00 PM - 12:00 AM)', 1, 1, 1, 1, 1, 1, 1, 21, 0, 0, 0, 0, 1, CAST(N'2016-06-18T20:00:03.167' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (150, 1, N'071B', N'Regular Shift (12:30 AM - 05:30 AM)', 1, 1, 1, 1, 1, 1, 1, 0, 30, 5, 30, 0, 1, CAST(N'2016-06-18T20:01:11.310' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (151, 1, N'072A', N'Regular Shift (09:00 PM - 12:00 AM)', 1, 1, 1, 1, 1, 1, 1, 21, 0, 0, 0, 0, 1, CAST(N'2016-06-18T20:02:02.563' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (152, 1, N'072B', N'Regular Shift (01:00 AM - 06:00 AM)', 1, 1, 1, 1, 1, 1, 1, 1, 0, 6, 0, 0, 1, CAST(N'2016-06-18T20:02:51.203' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (153, 1, N'073', N'Regular Shift (10:00 AM - 06:30 PM)', 1, 1, 1, 1, 1, 1, 1, 10, 0, 18, 30, 0, 1, CAST(N'2016-06-18T20:06:31.880' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (154, 1, N'074', N'Regular Shift (10:00 AM - 07:00 PM)', 1, 1, 1, 1, 1, 1, 1, 10, 0, 19, 0, 0, 1, CAST(N'2016-06-18T20:05:12.867' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (155, 1, N'075', N'Regular Shift (10:00 PM - 06:30 AM)', 1, 1, 1, 1, 1, 1, 1, 22, 0, 6, 30, 0, 1, CAST(N'2016-06-18T20:06:17.797' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (156, 1, N'076', N'Regular Shift (10:00 PM - 07:00 AM)', 1, 1, 1, 1, 1, 1, 1, 22, 0, 7, 0, 0, 1, CAST(N'2016-06-18T20:07:41.520' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (157, 1, N'077A', N'Regular  Shift (10:00 AM - 12:00 PM)', 1, 1, 1, 1, 1, 1, 1, 10, 0, 12, 0, 0, 1, CAST(N'2016-06-18T20:08:49.513' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (158, 1, N'077B', N'Regular Shift (12:30 PM - 06:30 PM)', 1, 1, 1, 1, 1, 1, 1, 12, 30, 18, 30, 0, 1, CAST(N'2016-06-18T20:09:59.790' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (159, 1, N'078A', N'Regular Shift (10:00 AM - 12:00 PM)', 1, 1, 1, 1, 1, 1, 1, 10, 0, 12, 0, 0, 1, CAST(N'2016-06-18T20:11:14.223' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (160, 1, N'078B', N'Regular Shift (01:00 PM - 07:00 PM)', 1, 1, 1, 1, 1, 1, 1, 13, 0, 19, 0, 0, 1, CAST(N'2016-06-18T20:12:34.327' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (161, 1, N'079A', N'Regular Shift (10:00 PM - 12:00 AM)', 1, 1, 1, 1, 1, 1, 1, 22, 0, 0, 0, 0, 1, CAST(N'2016-06-18T20:13:27.303' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (162, 1, N'079B', N'Regular Shift (12:30 AM - 06:30 AM)', 1, 1, 1, 1, 1, 1, 1, 0, 30, 6, 30, 0, 1, CAST(N'2016-06-18T20:14:20.683' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (163, 1, N'080A', N'Regular Shift (10:00 PM - 12:00 AM )', 1, 1, 1, 1, 1, 1, 1, 22, 0, 0, 0, 0, 1, CAST(N'2016-06-18T20:15:28.437' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (164, 1, N'080B', N'Regular Shift (01:00 AM - 07:00 AM)', 1, 1, 1, 1, 1, 1, 1, 1, 0, 7, 0, 0, 1, CAST(N'2016-06-18T20:16:17.403' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (165, 1, N'081', N'Regular Shift (11:00 AM - 07:30 PM)', 1, 1, 1, 1, 1, 1, 1, 11, 0, 19, 30, 0, 1, CAST(N'2016-06-18T20:17:28.870' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (166, 1, N'082', N'Regular Shift (11:00 AM - 08:00 PM)', 1, 1, 1, 1, 1, 1, 1, 11, 0, 20, 0, 0, 1, CAST(N'2016-06-18T20:18:28.387' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (167, 1, N'083', N'Regular Shift (11:00 PM - 07:30 AM)', 1, 1, 1, 1, 1, 1, 1, 23, 0, 7, 30, 0, 1, CAST(N'2016-06-18T20:19:42.900' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (168, 1, N'084', N'Regular Shift (11:00 PM - 08:00 AM)', 1, 1, 1, 1, 1, 1, 1, 23, 0, 8, 0, 0, 1, CAST(N'2016-06-18T20:20:47.260' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (169, 1, N'085A', N'Regular Shift (11:00 AM - 03:00 PM)', 1, 1, 1, 1, 1, 1, 1, 11, 0, 15, 0, 0, 1, CAST(N'2016-06-18T20:22:00.440' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (170, 1, N'085B', N'Regular Shift (03:30 PM - 07:30 PM)', 1, 1, 1, 1, 1, 1, 1, 15, 30, 19, 30, 0, 1, CAST(N'2016-06-18T20:22:55.057' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (171, 1, N'086A', N'Regular Shift (11:00 AM - 03:00 PM', 1, 1, 1, 1, 1, 1, 1, 11, 0, 15, 0, 0, 1, CAST(N'2016-06-18T20:23:54.667' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (172, 1, N'086B', N'Regular Shift (04:00 PM - 08:00 PM)', 1, 1, 1, 1, 1, 1, 1, 16, 0, 20, 0, 0, 1, CAST(N'2016-06-18T20:25:10.860' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (173, 1, N'087A', N'Regular Shift (11:00 PM - 03:00 AM)', 1, 1, 1, 1, 1, 1, 1, 23, 0, 3, 0, 0, 1, CAST(N'2016-06-18T20:25:59.307' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (174, 1, N'087B', N'Regular Shift (03:30 AM - 07:30 AM)', 1, 1, 1, 1, 1, 1, 1, 3, 30, 7, 30, 0, 1, CAST(N'2016-06-18T20:27:01.820' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (175, 1, N'088A', N'Regular Shift (11:00 PM - 03:00 AM)', 1, 1, 1, 1, 1, 1, 1, 23, 0, 3, 0, 0, 1, CAST(N'2016-06-18T20:27:56.163' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (176, 1, N'088B', N'Regular Shift (04:00 AM - 08:00 AM)', 1, 1, 1, 1, 1, 1, 1, 4, 0, 8, 0, 0, 1, CAST(N'2016-06-18T20:28:47.680' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (177, 1, N'089', N'Regular Shift (12:00 PM - 08:30 PM)', 1, 1, 1, 1, 1, 1, 1, 12, 0, 20, 30, 0, 1, CAST(N'2016-06-18T20:30:20.183' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (178, 1, N'090', N'Regular Shift (12:00 PM - 09:00 PM)', 1, 1, 1, 1, 1, 1, 1, 12, 0, 21, 0, 0, 1, CAST(N'2016-06-18T20:31:15.727' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (179, 1, N'091', N'Regular Shift (12:00 AM - 08:30 AM)', 1, 1, 1, 1, 1, 1, 1, 0, 0, 8, 30, 0, 1, CAST(N'2016-06-18T20:32:44.133' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (180, 1, N'092', N'Regular Shift (12:00 AM - 09:00 AM)', 1, 1, 1, 1, 1, 1, 1, 0, 0, 9, 0, 0, 1, CAST(N'2016-06-18T20:33:33.077' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (181, 1, N'093A', N'Regular Shift (12:00 PM - 04:00 PM)', 1, 1, 1, 1, 1, 1, 1, 12, 0, 16, 0, 0, 1, CAST(N'2016-06-18T20:34:38.397' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (182, 1, N'093B', N'Regular Shift (04:30 PM - 08:30 PM)', 1, 1, 1, 1, 1, 1, 1, 16, 30, 20, 30, 0, 1, CAST(N'2016-06-18T20:35:32.520' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (183, 1, N'094A', N'Regular Shift (12:00 PM - 04:00 PM)', 1, 1, 1, 1, 1, 1, 1, 12, 0, 16, 0, 0, 1, CAST(N'2016-06-18T20:37:20.463' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (184, 1, N'094B', N'Regular Shift (05:00 PM - 09:00 PM)', 1, 1, 1, 1, 1, 1, 1, 17, 0, 21, 0, 0, 1, CAST(N'2016-06-18T20:38:24.527' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (185, 1, N'095A', N'Regular Shift (12:00 AM - 04:00 AM)', 1, 1, 1, 1, 1, 1, 1, 0, 0, 4, 0, 0, 1, CAST(N'2016-06-18T20:39:14.977' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (186, 1, N'095B', N'Regular Shift (04:30 AM - 08:30 AM)', 1, 1, 1, 1, 1, 1, 1, 4, 30, 8, 30, 0, 1, CAST(N'2016-06-18T20:40:11.017' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (187, 1, N'096A', N'Regular Shift (12:00 AM - 04:00 AM)', 1, 1, 1, 1, 1, 1, 1, 0, 0, 4, 0, 0, 1, CAST(N'2016-06-18T20:41:07.163' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (188, 1, N'096B', N'Regular Shift (05:00 AM - 09:00 AM)', 1, 1, 1, 1, 1, 1, 1, 5, 0, 9, 0, 0, 1, CAST(N'2016-06-18T20:42:36.903' AS DateTime), 0)
GO
INSERT [dbo].[mf_WorkDays] ([id], [companyId], [code], [description], [monday], [tuesday], [wednesday], [thursday], [friday], [saturday], [sunday], [fromTimeHour], [fromTimeMinute], [toTimeHour], [toTimeMinute], [breakHours], [updatedBy], [updatedDate], [deleted]) VALUES (189, 1, N'TEST', N'Normal', 1, 1, 1, 1, 1, 0, 0, 8, 30, 17, 30, 1, 1, CAST(N'2016-10-10T11:09:49.367' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[mf_WorkDays] OFF
GO
SET IDENTITY_INSERT [dbo].[sys_Company] ON 

GO
INSERT [dbo].[sys_Company] ([id], [code], [businessName], [address1], [address2], [address3], [countryId], [city], [postalCode], [email], [telephone], [mobile], [fax], [updatedBy], [updatedDate], [deleted]) VALUES (1, N'SIH', N'SARROSA INTERNATIONAL HOTEL & RESIDENTIAL SUITES', N'F. CABAHUG ST. COR. PRES. QUIRINO ST., KASAMBAGAN CEBU CITY', NULL, NULL, 180, N'Cebu City', N'6000', N'reservations@sarrosahote.com', N'(+63)(32)232-5811 to 18 ', N'(+63)(32)919-9316814 and (+63)(32)927-407-1635', N'(+63)(32)232-5819', 1, CAST(N'2016-06-11T13:32:30.000' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[sys_Company] OFF
GO
SET IDENTITY_INSERT [dbo].[sys_CompanySetting] ON 

GO
INSERT [dbo].[sys_CompanySetting] ([id], [settingId], [companyId], [value], [updatedBy], [updatedDate], [deleted]) VALUES (1, 1, 1, N'P@ssw0rd', 1, CAST(N'2016-04-26T20:57:09.707' AS DateTime), 0)
GO
INSERT [dbo].[sys_CompanySetting] ([id], [settingId], [companyId], [value], [updatedBy], [updatedDate], [deleted]) VALUES (2, 2, 1, N'HRIS_KEY1', 1, CAST(N'2016-04-26T20:58:25.310' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[sys_CompanySetting] OFF
GO
SET IDENTITY_INSERT [dbo].[sys_EnumReference] ON 

GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (1, 1, N'USER_STATUS', 1, N'Active', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (2, 1, N'USER_STATUS', 2, N'Disabled', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (3, 1, N'USER_STATUS', 3, N'Locked', 0, 1, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (4, 1, N'USER_STATUS', 4, N'Reset Password', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (5, 1, N'MARITAL_STATUS', 1, N'Single', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (6, 1, N'MARITAL_STATUS', 2, N'Married', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (7, 1, N'MARITAL_STATUS', 3, N'Separated', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (8, 1, N'MARITAL_STATUS', 4, N'Widowed', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (9, 1, N'MARITAL_STATUS', 5, N'Divorced', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (10, 1, N'GENDER', 1, N'Male', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (11, 1, N'GENDER', 2, N'Female', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (12, 1, N'POSITION_LEVEL', 1, N'Junior', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (13, 1, N'POSITION_LEVEL', 2, N'Senior', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (14, 1, N'POSITION_LEVEL', 3, N'Team Lead', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (15, 1, N'POSITION_LEVEL', 4, N'Manager', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (16, 1, N'POSITION_LEVEL', 5, N'Executive', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (20, 1, N'SKILL_PROFICIENCY_LEVEL', 1, N'Beginner', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (21, 1, N'SKILL_PROFICIENCY_LEVEL', 2, N'Awareness', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (22, 1, N'SKILL_PROFICIENCY_LEVEL', 3, N'Knowledge', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (23, 1, N'SKILL_PROFICIENCY_LEVEL', 4, N'Expert', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (24, 1, N'MONTH_LIST', 1, N'January', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (25, 1, N'MONTH_LIST', 2, N'February', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (26, 1, N'MONTH_LIST', 3, N'March', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (27, 1, N'MONTH_LIST', 4, N'April', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (28, 1, N'MONTH_LIST', 5, N'May', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (29, 1, N'MONTH_LIST', 6, N'June', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (30, 1, N'MONTH_LIST', 7, N'July', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (31, 1, N'MONTH_LIST', 8, N'August', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (32, 1, N'MONTH_LIST', 9, N'September', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (33, 1, N'MONTH_LIST', 10, N'October', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (34, 1, N'MONTH_LIST', 11, N'November', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (35, 1, N'MONTH_LIST', 12, N'December', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (36, 1, N'PAY_RATE_TYPE', 1, N'Daily', 2, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (37, 1, N'PAY_RATE_TYPE', 2, N'Monthly', 4, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (38, 1, N'TAX_STATUS', 1, N'Single', 1, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (39, 1, N'TAX_STATUS', 2, N'Single - 1 Dependent', 2, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (40, 1, N'TAX_STATUS', 3, N'Single - 2 Dependents', 3, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (41, 1, N'TAX_STATUS', 4, N'Single - 3 Dependents', 4, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (42, 1, N'TAX_STATUS', 5, N'Single - 4 Dependents', 5, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (43, 1, N'TAX_STATUS', 6, N'Married', 6, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (44, 1, N'TAX_STATUS', 7, N'Married - 1 Dependent', 7, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (45, 1, N'TAX_STATUS', 8, N'Married - 2 Dependents', 8, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (46, 1, N'TAX_STATUS', 9, N'Married - 3 Dependents', 9, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (47, 1, N'TAX_STATUS', 10, N'Married - 4 Dependents', 10, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (48, 1, N'TAX_STATUS', 11, N'No Exemption (Z)', 11, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (49, 1, N'HOUR', 0, N'12 AM', 1, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (50, 1, N'HOUR', 1, N'1 AM', 2, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (51, 1, N'HOUR', 2, N'2 AM', 3, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (52, 1, N'HOUR', 3, N'3 AM', 4, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (53, 1, N'HOUR', 4, N'4 AM', 5, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (54, 1, N'HOUR', 5, N'5 AM', 6, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (55, 1, N'HOUR', 6, N'6 AM', 7, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (56, 1, N'HOUR', 7, N'7 AM', 8, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (57, 1, N'HOUR', 8, N'8 AM', 9, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (58, 1, N'HOUR', 9, N'9 AM', 10, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (59, 1, N'HOUR', 10, N'10 AM', 11, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (60, 1, N'HOUR', 11, N'11 AM', 12, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (61, 1, N'HOUR', 12, N'12 PM', 13, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (62, 1, N'HOUR', 13, N'1 PM', 14, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (63, 1, N'HOUR', 14, N'2 PM', 15, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (64, 1, N'HOUR', 15, N'3 PM', 16, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (65, 1, N'HOUR', 16, N'4 PM', 17, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (66, 1, N'HOUR', 17, N'5 PM', 18, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (67, 1, N'HOUR', 18, N'6 PM', 19, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (68, 1, N'HOUR', 19, N'7 PM', 20, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (69, 1, N'HOUR', 20, N'8 PM', 21, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (70, 1, N'HOUR', 21, N'9 PM', 22, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (71, 1, N'HOUR', 22, N'10 PM', 23, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (72, 1, N'HOUR', 23, N'11 PM', 24, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (73, 1, N'TIME_LOG_TYPE', 0, N'Duty On', 1, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (74, 1, N'TIME_LOG_TYPE', 1, N'Duty Off', 2, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (75, 1, N'TIME_LOG_TYPE', 2, N'Overtime Begin', 3, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (76, 1, N'TIME_LOG_TYPE', 3, N'Overtime End', 4, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (80, 1, N'PENALTY_DEGREE', 1, N'Minor', 1, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (81, 1, N'PENALTY_DEGREE', 2, N'Moderate', 2, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (82, 1, N'PENALTY_DEGREE', 3, N'Serious', 3, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (83, 1, N'CUT_OFF_ATTENDANCE', 1, N'Draft', 1, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (84, 1, N'CUT_OFF_ATTENDANCE', 2, N'Submitted', 2, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (85, 1, N'CUT_OFF_ATTENDANCE', 3, N'Accept', 3, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (91, 1, N'TIME_LOG_TYPE', 4, N'Lock Out', 5, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (92, 1, N'TIME_LOG_TYPE', 5, N'Lock In', 6, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (93, 1, N'ERROR_TYPE', 1, N'User Error', 2, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (94, 1, N'ERROR_TYPE', 2, N'System Error', 2, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (98, 1, N'CUT_OFF_ATTENDANCE', 4, N'Reject', 4, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (99, 1, N'CUT_OFF_ATTENDANCE', 5, N'Posted', 5, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (100, 1, N'CUT_OFF_ATTENDANCE', 6, N'Cancel', 6, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (101, 1, N'PAYROLL_STATUS', 1, N'New', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (102, 1, N'PAYROLL_STATUS', 2, N'Verify', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (103, 1, N'PAYROLL_STATUS', 3, N'Posted', 0, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (104, 1, N'PAY_RATE_TYPE', 3, N'Hourly', 1, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (106, 1, N'PAYSLIP_DETAILS', 1, N'No Of Days', 0, 0, 0, N'INFO', N'True', NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (107, 1, N'PAYSLIP_DETAILS', 2, N'No. Of Abesences/Tardiness', 0, 0, 0, N'INFO', N'True', NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (108, 1, N'PAYSLIP_DETAILS', 3, N'No. Of Overtime Hours', 0, 0, 0, N'INFO', N'True', NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (109, 1, N'PAYSLIP_DETAILS', 4, N'Daily/Monthly Rate', 0, 0, 0, N'INFO', N'True', NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (110, 1, N'PAYSLIP_DETAILS', 5, N'Basic Pay', 0, 0, 0, N'INFO', N'True', NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (111, 1, N'PAYSLIP_DETAILS', 6, N'Overtime Pay', 0, 0, 0, N'EARNINGS', N'True', NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (112, 1, N'PAYSLIP_DETAILS', 7, N'W/HoldingTask', 0, 0, 0, N'DEDUCTION', N'True', NULL, NULL, NULL)
GO
INSERT [dbo].[sys_EnumReference] ([id], [companyId], [name], [value], [description], [displayOrder], [hidden], [deleted], [field1], [field2], [field3], [field4], [field5]) VALUES (113, 1, N'PAY_RATE_TYPE', 4, N'Semi-Monthly', 3, 0, 0, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[sys_EnumReference] OFF
GO
SET IDENTITY_INSERT [dbo].[sys_IdentificationDocument] ON 

GO
INSERT [dbo].[sys_IdentificationDocument] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (1, N'SSS', N'Social Security System', 1, CAST(N'2016-04-26T21:31:29.677' AS DateTime), 0)
GO
INSERT [dbo].[sys_IdentificationDocument] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (2, N'POSTALID', N'Postal ID', 1, CAST(N'2016-05-23T13:40:02.700' AS DateTime), 1)
GO
INSERT [dbo].[sys_IdentificationDocument] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (3, N'GSIS', N'Government Service Insurance System', 1, CAST(N'2016-05-23T13:40:02.700' AS DateTime), 1)
GO
INSERT [dbo].[sys_IdentificationDocument] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (4, N'BIRID', N'Bureau of Internal Revenue (BIR) Taxpayer’s ID', 1, CAST(N'2016-05-23T13:40:02.700' AS DateTime), 1)
GO
INSERT [dbo].[sys_IdentificationDocument] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (5, N'PHEALTH', N'Philippine Health Insurance', 1, CAST(N'2016-05-23T11:40:57.363' AS DateTime), 0)
GO
INSERT [dbo].[sys_IdentificationDocument] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (6, N'HDMF', N'Home Development Mutual Fund', 1, CAST(N'2016-05-23T11:40:57.363' AS DateTime), 0)
GO
INSERT [dbo].[sys_IdentificationDocument] ([id], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (7, N'TIN', N'Taxpayer Identification Number', 1, CAST(N'2016-05-23T11:40:57.367' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[sys_IdentificationDocument] OFF
GO
SET IDENTITY_INSERT [dbo].[sys_Location] ON 

GO
INSERT [dbo].[sys_Location] ([id], [companyId], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (1, 1, N'CEBU', N'CEBU', 1, CAST(N'2016-04-26T18:07:44.683' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[sys_Location] OFF
GO
SET IDENTITY_INSERT [dbo].[sys_Menu] ON 

GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (1, N'-- Free Text Menu --', NULL, NULL, NULL, NULL, 1, CAST(N'2016-05-02T18:30:51.000' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (2, N'Home', N'Home', N'Index', NULL, NULL, 1, CAST(N'2016-05-02T18:30:51.000' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (3, N'Employee Quick update', N'Employee', N'QuickUpdate', NULL, NULL, 1, CAST(N'2016-07-27T09:42:37.000' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (4, N'Employee List (Confidential)', N'Employee', N'EmployeeConfi', NULL, NULL, 1, CAST(N'2016-07-27T09:42:37.000' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (5, N'Employee List (Non-Confidential)', N'Employee', N'EmployeeNonConfi', NULL, NULL, 1, CAST(N'2016-07-27T18:26:40.000' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (6, N'Employee Attendance', N'Attendance', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:05:12.517' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (7, N'User', N'Account', N'UserMaintenance', NULL, NULL, 1, CAST(N'2016-07-27T11:05:27.930' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (8, N'Role', N'Role', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:05:41.667' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (9, N'Permission', N'Permission', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:05:46.213' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (10, N'Company Information', N'Company', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:06:38.893' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (11, N'Location', N'Location', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:06:48.383' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (12, N'Application Approver', N'ApplicationRequest', N'DepartmentSectionApprover', NULL, NULL, 1, CAST(N'2016-07-28T10:35:14.000' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (13, N'Work Days', N'WorkDay', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:07:17.013' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (14, N'Holiday Type', N'HolidayType', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:07:34.940' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (15, N'Holidays', N'Holiday', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:07:53.503' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (17, N'Payroll Group', N'PayrollGroup', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:08:25.670' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (18, N'Employment Status', N'EmploymentStatus', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:08:37.177' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (19, N'Employment Type', N'EmploymentType', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:08:47.307' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (20, N'Identification Document', N'IdentificationDocument', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:31:24.780' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (21, N'Department', N'Department', N'Index', NULL, NULL, 1, CAST(N'2016-07-29T18:52:50.000' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (22, N'Position', N'Position', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:31:39.687' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (23, N'Allowance', N'Allowance', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:31:45.940' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (24, N'Offense', N'Offense', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:31:58.200' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (25, N'Penalty Type', N'PenaltyType', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:32:13.210' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (26, N'Update WorkDay Attendance', N'Attendance', N'UpdateWorkDayAttendance', NULL, NULL, 1, CAST(N'2016-07-28T09:47:39.000' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (27, N'Section', N'Department', N'Section', NULL, NULL, 1, CAST(N'2016-07-28T09:58:49.253' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (28, N'Cut Off Attendance', N'Attendance', N'CutOffAttendance', NULL, NULL, 1, CAST(N'2016-07-29T17:44:24.000' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (29, N'My Approval', N'ApplicationRequest', N'MyApproval', NULL, NULL, 1, CAST(N'2016-07-29T18:32:29.077' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (30, N'Request Leave', N'ApplicationRequest', N'RequestLeave', NULL, NULL, 1, CAST(N'2016-07-29T18:33:19.537' AS DateTime), 0)
GO
INSERT [dbo].[sys_Menu] ([id], [description], [controllerName], [actionName], [areaName], [parameter], [updatedBy], [updatedDate], [deleted]) VALUES (31, N'Deduction', N'Deduction', N'Index', NULL, NULL, 1, CAST(N'2016-07-27T11:31:45.940' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[sys_Menu] OFF
GO
SET IDENTITY_INSERT [dbo].[sys_Permission] ON 

GO
INSERT [dbo].[sys_Permission] ([id], [companyId], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (1, 1, N'VIEW_CONFIDENTIAL_EMPLOYEE', N'View Confidential Employee', 1, CAST(N'2016-06-23T14:26:52.330' AS DateTime), 0)
GO
INSERT [dbo].[sys_Permission] ([id], [companyId], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (2, 1, N'VIEW_EMPLOYEE_SALARY', N'View Employee Salary', 1, CAST(N'2016-07-04T14:14:34.853' AS DateTime), 0)
GO
INSERT [dbo].[sys_Permission] ([id], [companyId], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (3, 1, N'VIEW_ADMIN_PANEL', N'View Admin Panel', 1, CAST(N'2016-07-04T14:14:34.853' AS DateTime), 0)
GO
INSERT [dbo].[sys_Permission] ([id], [companyId], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (4, 1, N'EMPLOYEE_QUICK_UPDATE', N'EMPLOYEE_QUICK_UPDATE', 1, CAST(N'2016-07-12T13:24:02.533' AS DateTime), 0)
GO
INSERT [dbo].[sys_Permission] ([id], [companyId], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (5, 1, N'DEVELOPER', N'DEVELOPER', 1, CAST(N'2016-07-12T13:24:02.543' AS DateTime), 0)
GO
INSERT [dbo].[sys_Permission] ([id], [companyId], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (6, 1, N'EMPLOYEE_MAINTENANCE', N'EMPLOYEE_MAINTENANCE', 1, CAST(N'2016-07-12T13:29:23.923' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[sys_Permission] OFF
GO
SET IDENTITY_INSERT [dbo].[sys_Role] ON 

GO
INSERT [dbo].[sys_Role] ([id], [companyId], [code], [description], [updatedBy], [updatedDate], [deleted]) VALUES (1, 1, N'ADMIN', N'Administrators', 1, CAST(N'2016-04-29T21:23:23.217' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[sys_Role] OFF
GO
SET IDENTITY_INSERT [dbo].[sys_RoleMenu] ON 

GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (1, 1, 2, N'Home', NULL, 1, 1, CAST(N'2016-07-25T14:13:15.870' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (2, 1, 1, N'Employee Maintenance', NULL, 3, 1, CAST(N'2016-07-29T18:31:56.073' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (3, 1, 4, N'Employee List (Confidential)', 2, 1, 1, CAST(N'2016-07-25T14:27:42.373' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (4, 1, 5, N'Employee List (Non-Confidential)', 2, 2, 1, CAST(N'2016-07-27T10:29:14.997' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (5, 1, 1, N'Administrator', NULL, 6, 1, CAST(N'2016-10-10T14:38:36.673' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (6, 1, 3, N'Employee Quick Update', 2, 3, 1, CAST(N'2016-07-27T11:01:21.030' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (7, 1, 1, N'Time and Attendance', NULL, 4, 1, CAST(N'2016-08-01T10:14:01.973' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (8, 1, 1, N'Maintenance', 7, 3, 1, CAST(N'2016-07-27T18:31:22.523' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (9, 1, 13, N'Work Days', 8, 1, 1, CAST(N'2016-07-27T11:19:14.457' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (10, 1, 15, N'Holidays', 8, 1, 1, CAST(N'2016-07-27T11:19:21.417' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (11, 1, 14, N'Holiday Type', 8, 1, 1, CAST(N'2016-07-27T11:19:24.607' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (12, 1, 1, N'Maintenance', 2, 4, 1, CAST(N'2016-07-27T11:19:43.433' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (13, 1, 18, N'Employment Status', 12, 1, 1, CAST(N'2016-07-27T11:19:53.723' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (14, 1, 19, N'Employment Type', 12, 1, 1, CAST(N'2016-07-27T11:19:58.783' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (16, 1, 17, N'Payroll Group', 12, 4, 1, CAST(N'2016-07-27T11:20:33.613' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (17, 1, 1, N'Department Configuration', 12, 88, 1, CAST(N'2016-07-28T13:48:59.957' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (18, 1, 22, N'Position', 12, 1, 1, CAST(N'2016-07-27T11:32:47.880' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (19, 1, 23, N'Allowance', 12, 1, 1, CAST(N'2016-10-10T20:16:39.517' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (20, 1, 24, N'Offense', 22, 1, 1, CAST(N'2016-07-27T11:32:56.337' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (21, 1, 25, N'Penalty Type', 22, 1, 1, CAST(N'2016-07-27T11:33:03.680' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (22, 1, 1, N'Offense Configuration', 12, 88, 1, CAST(N'2016-07-27T11:33:40.500' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (23, 1, 20, N'Identification Document', 12, 1, 1, CAST(N'2016-07-27T11:33:53.193' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (24, 1, 1, N'Account Maintenance', 5, 2, 1, CAST(N'2016-07-29T13:36:30.983' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (25, 1, 7, N'User', 24, 1, 1, CAST(N'2016-07-27T13:50:02.210' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (26, 1, 8, N'Role', 24, 2, 1, CAST(N'2016-07-27T13:50:33.843' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (27, 1, 9, N'Permission', 24, 3, 1, CAST(N'2016-07-27T13:50:17.347' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (28, 1, 6, N'Employee Attendance', 7, 1, 1, CAST(N'2016-07-27T18:29:14.247' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (29, 1, 26, N'Update Work Day Attendance', 7, 2, 1, CAST(N'2016-07-27T18:30:54.037' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (30, 1, 21, N'Department', 17, 1, 1, CAST(N'2016-07-28T09:58:00.670' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (31, 1, 12, N'Application Approver', 17, 1, 1, CAST(N'2016-07-28T09:58:14.467' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (32, 1, 27, N'Section', 17, 1, 1, CAST(N'2016-07-28T09:59:03.240' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (33, 1, 28, N'Cut Off Attendance', 7, 1, 1, CAST(N'2016-07-29T17:45:11.613' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (34, 1, 1, N'System', 5, 1, 1, CAST(N'2016-07-29T13:36:26.690' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (35, 1, 10, N'Company Information', 34, 1, 1, CAST(N'2016-07-29T13:36:37.293' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (36, 1, 1, N'Application Request', NULL, 2, 1, CAST(N'2016-07-29T18:31:52.337' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (37, 1, 1, N'Payroll', NULL, 5, 1, CAST(N'2016-10-10T14:38:53.157' AS DateTime), 0)
GO
INSERT [dbo].[sys_RoleMenu] ([id], [roleId], [sourceMenuId], [description], [parentRoleMenuId], [displayOrder], [updatedBy], [updatedDate], [deleted]) VALUES (38, 1, 31, N'Deduction', 12, 1, 1, CAST(N'2016-10-10T20:17:29.557' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[sys_RoleMenu] OFF
GO
SET IDENTITY_INSERT [dbo].[sys_RolePermission] ON 

GO
INSERT [dbo].[sys_RolePermission] ([id], [roleId], [permissionId], [viewAccess], [createAccess], [updateAccess], [deleteAccess], [printAccess], [updatedBy], [updatedDate], [deleted]) VALUES (1, 1, 1, 1, 0, 0, 0, 0, 1, CAST(N'2016-07-04T14:15:40.943' AS DateTime), 0)
GO
INSERT [dbo].[sys_RolePermission] ([id], [roleId], [permissionId], [viewAccess], [createAccess], [updateAccess], [deleteAccess], [printAccess], [updatedBy], [updatedDate], [deleted]) VALUES (2, 1, 3, 1, 0, 0, 0, 0, 1, CAST(N'2016-07-04T14:15:40.947' AS DateTime), 0)
GO
INSERT [dbo].[sys_RolePermission] ([id], [roleId], [permissionId], [viewAccess], [createAccess], [updateAccess], [deleteAccess], [printAccess], [updatedBy], [updatedDate], [deleted]) VALUES (3, 1, 2, 1, 0, 0, 0, 0, 1, CAST(N'2016-07-08T13:32:45.843' AS DateTime), 0)
GO
INSERT [dbo].[sys_RolePermission] ([id], [roleId], [permissionId], [viewAccess], [createAccess], [updateAccess], [deleteAccess], [printAccess], [updatedBy], [updatedDate], [deleted]) VALUES (4, 1, 4, 1, 0, 0, 0, 0, 1, CAST(N'2016-07-12T13:24:38.747' AS DateTime), 0)
GO
INSERT [dbo].[sys_RolePermission] ([id], [roleId], [permissionId], [viewAccess], [createAccess], [updateAccess], [deleteAccess], [printAccess], [updatedBy], [updatedDate], [deleted]) VALUES (5, 1, 5, 1, 0, 0, 0, 0, 1, CAST(N'2016-07-12T13:24:38.747' AS DateTime), 0)
GO
INSERT [dbo].[sys_RolePermission] ([id], [roleId], [permissionId], [viewAccess], [createAccess], [updateAccess], [deleteAccess], [printAccess], [updatedBy], [updatedDate], [deleted]) VALUES (6, 1, 6, 1, 1, 1, 0, 0, 1, CAST(N'2016-07-12T13:37:17.850' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[sys_RolePermission] OFF
GO
SET IDENTITY_INSERT [dbo].[sys_Setting] ON 

GO
INSERT [dbo].[sys_Setting] ([id], [name], [description], [deleted]) VALUES (1, N'DEFAULT_PASSWORD', N'Default Password for New and Reset User', 0)
GO
INSERT [dbo].[sys_Setting] ([id], [name], [description], [deleted]) VALUES (2, N'HRIS_HASHSHA_KEY', N'HRIS_HASHSHA_KEY', 0)
GO
SET IDENTITY_INSERT [dbo].[sys_Setting] OFF
GO
SET IDENTITY_INSERT [dbo].[sys_User] ON 

GO
INSERT [dbo].[sys_User] ([id], [companyId], [username], [password], [hashKey], [vector], [email], [employeeId], [status], [updatedBy], [updatedDate], [deleted]) VALUES (1, 1, N'admin', N'JYZAJ9KCpK80FCErnsksqw==', N'29b373cae1fb59b32052386063fb100', N'R9_XFXT2U7CaaP_5', N'mynrd@live.com', NULL, 1, 1, CAST(N'2016-04-28T21:47:32.597' AS DateTime), 0)
GO
INSERT [dbo].[sys_User] ([id], [companyId], [username], [password], [hashKey], [vector], [email], [employeeId], [status], [updatedBy], [updatedDate], [deleted]) VALUES (2, 1, N'mynrd', N'RwGjGtKvukxGTEaXfO1YtQ==', N'e3b0c44298fc1c149afbf4c8996fb92', NULL, NULL, NULL, 1, 1, CAST(N'2016-04-29T11:57:30.063' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[sys_User] OFF
GO
SET IDENTITY_INSERT [dbo].[sys_UserRole] ON 

GO
INSERT [dbo].[sys_UserRole] ([id], [roleId], [userId], [updatedBy], [updatedDate], [deleted]) VALUES (1, 1, 2, 1, CAST(N'2016-04-29T21:31:55.317' AS DateTime), 1)
GO
INSERT [dbo].[sys_UserRole] ([id], [roleId], [userId], [updatedBy], [updatedDate], [deleted]) VALUES (2, 1, 1, 1, CAST(N'2016-04-29T21:31:48.663' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserRole] ([id], [roleId], [userId], [updatedBy], [updatedDate], [deleted]) VALUES (3, 1, 2, 1, CAST(N'2016-04-29T21:32:04.237' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[sys_UserRole] OFF
GO
SET IDENTITY_INSERT [dbo].[sys_UserSession] ON 

GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (1, 1, 1, CAST(N'2016-04-21T13:12:14.647' AS DateTime), N'::1', CAST(N'2016-04-21T13:18:45.287' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (2, 1, 1, CAST(N'2016-04-21T13:50:22.013' AS DateTime), N'::1', CAST(N'2016-04-21T13:55:22.143' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (3, 1, 1, CAST(N'2016-04-23T23:00:36.120' AS DateTime), N'::1', CAST(N'2016-04-23T23:06:30.580' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (4, 1, 1, CAST(N'2016-04-23T23:28:52.857' AS DateTime), N'::1', CAST(N'2016-04-23T23:34:53.180' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (5, 1, 1, CAST(N'2016-04-23T23:50:06.443' AS DateTime), N'::1', CAST(N'2016-04-23T23:59:55.473' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (6, 1, 1, CAST(N'2016-04-24T00:00:27.903' AS DateTime), N'::1', CAST(N'2016-04-24T00:16:59.470' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (7, 1, 1, CAST(N'2016-04-24T00:40:23.223' AS DateTime), N'::1', CAST(N'2016-04-24T01:05:35.930' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (8, 1, 1, CAST(N'2016-04-24T01:23:52.700' AS DateTime), N'::1', CAST(N'2016-04-24T01:42:32.247' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (9, 1, 1, CAST(N'2016-04-24T12:57:52.413' AS DateTime), N'::1', CAST(N'2016-04-24T13:03:29.463' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (10, 1, 1, CAST(N'2016-04-24T13:09:34.083' AS DateTime), N'::1', CAST(N'2016-04-24T13:15:32.350' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (11, 1, 1, CAST(N'2016-04-24T13:17:32.473' AS DateTime), N'::1', CAST(N'2016-04-24T15:49:19.317' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (12, 1, 1, CAST(N'2016-04-24T17:29:34.117' AS DateTime), N'::1', CAST(N'2016-04-24T19:33:07.450' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (13, 1, 1, CAST(N'2016-04-24T23:58:52.137' AS DateTime), N'::1', CAST(N'2016-04-25T01:40:34.307' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (14, 1, 1, CAST(N'2016-04-25T10:18:45.807' AS DateTime), N'::1', CAST(N'2016-04-25T11:20:37.133' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (15, 1, 1, CAST(N'2016-04-25T11:31:36.360' AS DateTime), N'::1', CAST(N'2016-04-25T12:58:38.173' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (16, 1, 1, CAST(N'2016-04-25T20:50:58.557' AS DateTime), N'::1', CAST(N'2016-04-25T22:09:09.783' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (17, 1, 1, CAST(N'2016-04-26T11:10:15.310' AS DateTime), N'::1', CAST(N'2016-04-26T12:11:31.130' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (18, 1, 1, CAST(N'2016-04-26T12:30:16.883' AS DateTime), N'::1', CAST(N'2016-04-26T14:23:56.633' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (21, 1, 1, CAST(N'2016-04-26T14:54:14.833' AS DateTime), N'::1', CAST(N'2016-04-26T16:01:39.743' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (22, 1, 1, CAST(N'2016-04-26T15:03:52.697' AS DateTime), N'::1', CAST(N'2016-04-26T16:03:52.727' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (23, 1, 1, CAST(N'2016-04-26T18:01:15.533' AS DateTime), N'::1', CAST(N'2016-04-26T20:00:16.047' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (24, 1, 1, CAST(N'2016-04-26T20:35:43.473' AS DateTime), N'::1', CAST(N'2016-04-26T22:32:35.247' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (25, 1, 1, CAST(N'2016-04-27T11:22:44.590' AS DateTime), N'::1', CAST(N'2016-04-27T13:19:11.897' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (26, 1, 1, CAST(N'2016-04-27T14:15:27.337' AS DateTime), N'::1', CAST(N'2016-04-27T15:16:02.590' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (27, 1, 1, CAST(N'2016-04-27T14:16:13.307' AS DateTime), N'::1', CAST(N'2016-04-27T15:22:54.693' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (28, 1, 1, CAST(N'2016-04-27T15:58:05.867' AS DateTime), N'::1', CAST(N'2016-04-27T17:28:59.263' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (29, 1, 1, CAST(N'2016-04-27T16:31:06.503' AS DateTime), N'::1', CAST(N'2016-04-27T17:31:20.870' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (30, 1, 1, CAST(N'2016-04-27T16:31:25.560' AS DateTime), N'::1', CAST(N'2016-04-27T17:31:29.300' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (31, 1, 1, CAST(N'2016-04-27T16:31:32.697' AS DateTime), N'::1', CAST(N'2016-04-27T17:31:47.057' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (32, 1, 1, CAST(N'2016-04-27T16:31:50.823' AS DateTime), N'::1', CAST(N'2016-04-27T17:31:50.833' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (33, 1, 1, CAST(N'2016-04-27T18:11:56.823' AS DateTime), N'::1', CAST(N'2016-04-27T19:47:57.860' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (34, 1, 1, CAST(N'2016-04-27T20:57:56.407' AS DateTime), N'::1', CAST(N'2016-04-27T22:56:29.483' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (35, 1, 1, CAST(N'2016-04-27T23:25:15.100' AS DateTime), N'::1', CAST(N'2016-04-28T00:28:37.840' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (36, 1, 1, CAST(N'2016-04-28T10:58:21.240' AS DateTime), N'::1', CAST(N'2016-04-28T13:08:07.697' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (37, 1, 1, CAST(N'2016-04-28T14:22:22.160' AS DateTime), N'::1', CAST(N'2016-04-28T18:31:43.673' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (38, 1, 1, CAST(N'2016-04-28T21:13:45.853' AS DateTime), N'::1', CAST(N'2016-04-28T22:49:23.667' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (39, 1, 1, CAST(N'2016-04-29T11:22:16.807' AS DateTime), N'::1', CAST(N'2016-04-29T13:13:49.520' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (40, 1, 1, CAST(N'2016-04-29T13:33:39.773' AS DateTime), N'::1', CAST(N'2016-04-29T14:46:04.827' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (41, 1, 1, CAST(N'2016-04-29T16:43:59.337' AS DateTime), N'::1', CAST(N'2016-04-29T17:56:10.913' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (42, 1, 1, CAST(N'2016-04-29T21:10:02.787' AS DateTime), N'::1', CAST(N'2016-04-29T23:08:43.740' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (43, 1, 1, CAST(N'2016-04-30T09:44:54.590' AS DateTime), N'::1', CAST(N'2016-04-30T11:53:58.553' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (44, 1, 1, CAST(N'2016-04-30T20:11:05.597' AS DateTime), N'::1', CAST(N'2016-04-30T22:09:41.823' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (45, 1, 1, CAST(N'2016-05-01T09:57:02.963' AS DateTime), N'::1', CAST(N'2016-05-01T10:59:30.257' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (46, 1, 1, CAST(N'2016-05-02T18:10:14.950' AS DateTime), N'::1', CAST(N'2016-05-02T19:39:47.510' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (47, 1, 1, CAST(N'2016-05-17T13:47:41.693' AS DateTime), N'192.168.1.109', CAST(N'2016-05-17T14:52:44.637' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (48, 1, 1, CAST(N'2016-05-18T15:31:48.737' AS DateTime), N'192.168.1.9', CAST(N'2016-05-18T16:31:50.970' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (49, 1, 1, CAST(N'2016-05-18T15:32:16.433' AS DateTime), N'192.168.1.100', CAST(N'2016-05-18T16:45:34.343' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (50, 1, 1, CAST(N'2016-05-18T15:32:44.827' AS DateTime), N'192.168.1.104', CAST(N'2016-05-18T17:03:57.230' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (51, 1, 1, CAST(N'2016-05-18T16:05:25.450' AS DateTime), N'192.168.1.106', CAST(N'2016-05-18T17:06:23.020' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (52, 1, 1, CAST(N'2016-05-18T16:12:52.990' AS DateTime), N'::1', CAST(N'2016-05-18T17:17:21.130' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (53, 1, 1, CAST(N'2016-05-21T12:29:56.767' AS DateTime), N'192.168.1.112', CAST(N'2016-05-21T13:29:58.660' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (54, 1, 1, CAST(N'2016-05-21T16:45:47.320' AS DateTime), N'192.168.1.106', CAST(N'2016-05-21T18:15:26.657' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (55, 1, 1, CAST(N'2016-05-21T16:53:29.573' AS DateTime), N'192.168.1.9', CAST(N'2016-05-21T17:54:44.200' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (56, 1, 1, CAST(N'2016-05-23T10:11:28.457' AS DateTime), N'192.168.1.106', CAST(N'2016-05-23T19:12:39.437' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (57, 1, 1, CAST(N'2016-05-23T11:22:37.640' AS DateTime), N'192.168.1.9', CAST(N'2016-05-23T12:22:54.633' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (58, 1, 1, CAST(N'2016-05-24T10:26:41.783' AS DateTime), N'192.168.1.106', CAST(N'2016-05-24T18:28:34.997' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (59, 1, 1, CAST(N'2016-05-24T10:43:47.170' AS DateTime), N'192.168.1.9', CAST(N'2016-05-24T11:56:46.580' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (60, 1, 1, CAST(N'2016-05-24T10:59:58.067' AS DateTime), N'192.168.1.107', CAST(N'2016-05-24T14:17:46.027' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (61, 1, 1, CAST(N'2016-05-24T11:08:06.993' AS DateTime), N'192.168.1.102', CAST(N'2016-05-24T14:18:03.050' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (62, 1, 1, CAST(N'2016-05-24T11:54:43.507' AS DateTime), N'192.168.1.9', CAST(N'2016-05-24T12:54:43.540' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (63, 1, 1, CAST(N'2016-05-25T09:23:00.920' AS DateTime), N'192.168.1.102', CAST(N'2016-05-25T15:05:28.707' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (64, 1, 1, CAST(N'2016-05-25T09:26:55.150' AS DateTime), N'192.168.1.107', CAST(N'2016-05-25T11:56:21.213' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (65, 1, 1, CAST(N'2016-05-25T09:40:29.233' AS DateTime), N'192.168.1.106', CAST(N'2016-05-25T14:58:02.970' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (66, 1, 1, CAST(N'2016-05-25T15:09:41.167' AS DateTime), N'192.168.1.106', CAST(N'2016-05-25T18:23:17.297' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (67, 1, 1, CAST(N'2016-05-26T08:51:24.457' AS DateTime), N'192.168.1.107', CAST(N'2016-05-26T09:51:32.010' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (68, 1, 1, CAST(N'2016-05-26T08:51:33.270' AS DateTime), N'192.168.1.102', CAST(N'2016-05-26T16:09:33.463' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (69, 1, 1, CAST(N'2016-05-26T09:52:49.423' AS DateTime), N'192.168.1.107', CAST(N'2016-05-26T11:08:14.770' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (70, 1, 1, CAST(N'2016-05-26T11:15:48.663' AS DateTime), N'192.168.1.107', CAST(N'2016-05-26T14:52:22.630' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (71, 1, 1, CAST(N'2016-05-26T11:18:43.623' AS DateTime), N'192.168.1.106', CAST(N'2016-05-26T16:45:01.067' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (72, 1, 1, CAST(N'2016-05-27T11:46:47.690' AS DateTime), N'192.168.1.6', CAST(N'2016-05-27T13:38:18.173' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (73, 1, 1, CAST(N'2016-05-27T13:35:17.543' AS DateTime), N'192.168.1.3', CAST(N'2016-05-27T17:16:26.237' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (74, 1, 1, CAST(N'2016-05-27T14:37:49.820' AS DateTime), N'192.168.1.6', CAST(N'2016-05-27T16:34:19.507' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (75, 1, 1, CAST(N'2016-05-27T14:40:38.060' AS DateTime), N'192.168.1.2', CAST(N'2016-05-27T16:29:30.417' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (76, 1, 1, CAST(N'2016-05-27T17:22:20.727' AS DateTime), N'192.168.1.3', CAST(N'2016-05-27T18:44:06.587' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (77, 1, 1, CAST(N'2016-05-28T09:41:21.977' AS DateTime), N'192.168.1.3', CAST(N'2016-05-28T13:03:43.690' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (78, 1, 1, CAST(N'2016-05-28T14:04:39.600' AS DateTime), N'192.168.1.3', CAST(N'2016-05-28T16:59:20.130' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (79, 1, 1, CAST(N'2016-05-30T10:20:12.820' AS DateTime), N'192.168.1.107', CAST(N'2016-05-30T11:20:15.010' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (80, 1, 1, CAST(N'2016-05-31T09:02:31.357' AS DateTime), N'192.168.1.112', CAST(N'2016-05-31T10:09:26.217' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (81, 1, 1, CAST(N'2016-06-11T13:12:08.863' AS DateTime), N'192.168.1.109', CAST(N'2016-06-11T14:36:43.657' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (82, 1, 1, CAST(N'2016-06-11T13:16:54.027' AS DateTime), N'192.168.1.100', CAST(N'2016-06-11T15:02:27.650' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (83, 1, 1, CAST(N'2016-06-11T14:10:49.697' AS DateTime), N'192.168.1.100', CAST(N'2016-06-11T15:47:13.180' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (84, 1, 1, CAST(N'2016-06-11T14:38:41.713' AS DateTime), N'192.168.1.233', CAST(N'2016-06-11T19:27:51.010' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (85, 1, 1, CAST(N'2016-06-11T14:47:56.517' AS DateTime), N'192.168.1.109', CAST(N'2016-06-11T19:46:44.757' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (86, 1, 1, CAST(N'2016-06-11T15:13:31.673' AS DateTime), N'192.168.1.100', CAST(N'2016-06-11T17:33:31.670' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (87, 1, 1, CAST(N'2016-06-11T15:59:20.737' AS DateTime), N'192.168.1.106', CAST(N'2016-06-11T19:38:44.120' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (88, 1, 1, CAST(N'2016-06-11T16:42:11.003' AS DateTime), N'192.168.1.104', CAST(N'2016-06-11T17:45:23.420' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (89, 1, 1, CAST(N'2016-06-13T07:56:19.127' AS DateTime), N'192.168.1.109', CAST(N'2016-06-13T21:58:24.557' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (90, 1, 1, CAST(N'2016-06-13T09:01:33.067' AS DateTime), N'192.168.1.101', CAST(N'2016-06-13T19:49:35.737' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (91, 1, 1, CAST(N'2016-06-13T09:48:43.123' AS DateTime), N'192.168.1.105', CAST(N'2016-06-13T10:54:11.797' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (92, 1, 1, CAST(N'2016-06-13T10:09:25.113' AS DateTime), N'192.168.1.106', CAST(N'2016-06-13T12:15:10.280' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (93, 1, 1, CAST(N'2016-06-13T12:02:38.907' AS DateTime), N'169.254.121.37', CAST(N'2016-06-13T13:02:38.923' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (94, 1, 1, CAST(N'2016-06-13T13:03:34.497' AS DateTime), N'169.254.121.37', CAST(N'2016-06-13T22:07:43.647' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (95, 1, 1, CAST(N'2016-06-13T15:05:44.840' AS DateTime), N'192.168.1.105', CAST(N'2016-06-13T17:44:40.480' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (96, 1, 1, CAST(N'2016-06-13T15:40:24.030' AS DateTime), N'192.168.1.107', CAST(N'2016-06-13T17:19:00.383' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (97, 1, 1, CAST(N'2016-06-13T17:32:57.120' AS DateTime), N'192.168.1.107', CAST(N'2016-06-13T18:33:00.747' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (98, 1, 1, CAST(N'2016-06-14T08:07:33.473' AS DateTime), N'192.168.1.109', CAST(N'2016-06-14T10:17:25.593' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (99, 1, 1, CAST(N'2016-06-14T08:53:54.867' AS DateTime), N'192.168.1.233', CAST(N'2016-06-14T13:21:50.720' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (100, 1, 1, CAST(N'2016-06-14T09:53:34.857' AS DateTime), N'192.168.1.105', CAST(N'2016-06-14T16:04:49.993' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (101, 1, 1, CAST(N'2016-06-14T10:57:51.020' AS DateTime), N'192.168.1.18', CAST(N'2016-06-14T19:10:13.290' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (102, 1, 1, CAST(N'2016-06-14T13:10:32.310' AS DateTime), N'192.168.1.104', CAST(N'2016-06-14T14:22:29.610' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (103, 1, 1, CAST(N'2016-06-14T13:28:43.090' AS DateTime), N'192.168.1.233', CAST(N'2016-06-14T19:56:39.450' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (104, 1, 1, CAST(N'2016-06-14T17:12:07.567' AS DateTime), N'192.168.1.105', CAST(N'2016-06-14T19:54:06.503' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (105, 1, 1, CAST(N'2016-06-15T08:00:27.127' AS DateTime), N'192.168.1.109', CAST(N'2016-06-15T09:00:29.417' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (106, 1, 1, CAST(N'2016-06-15T08:52:48.387' AS DateTime), N'192.168.1.18', CAST(N'2016-06-15T09:52:50.283' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (107, 1, 1, CAST(N'2016-06-15T09:01:41.443' AS DateTime), N'192.168.1.18', CAST(N'2016-06-15T10:01:41.487' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (108, 1, 1, CAST(N'2016-06-15T09:06:43.147' AS DateTime), N'192.168.1.18', CAST(N'2016-06-15T16:03:18.647' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (109, 1, 1, CAST(N'2016-06-15T09:26:23.997' AS DateTime), N'192.168.1.233', CAST(N'2016-06-15T14:49:09.230' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (110, 1, 1, CAST(N'2016-06-15T13:20:58.980' AS DateTime), N'192.168.1.109', CAST(N'2016-06-15T18:02:15.600' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (111, 1, 1, CAST(N'2016-06-16T08:32:27.280' AS DateTime), N'192.168.1.109', CAST(N'2016-06-16T09:37:25.267' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (112, 1, 1, CAST(N'2016-06-16T11:21:36.817' AS DateTime), N'192.168.1.109', CAST(N'2016-06-16T14:18:16.107' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (113, 1, 1, CAST(N'2016-06-16T12:47:11.273' AS DateTime), N'192.168.1.105', CAST(N'2016-06-16T22:39:50.237' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (114, 1, 1, CAST(N'2016-06-16T13:20:21.730' AS DateTime), N'192.168.1.18', CAST(N'2016-06-16T22:36:41.587' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (115, 1, 1, CAST(N'2016-06-16T21:42:04.047' AS DateTime), N'192.168.1.109', CAST(N'2016-06-16T22:42:18.297' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (116, 1, 1, CAST(N'2016-06-17T08:34:56.133' AS DateTime), N'192.168.1.18', CAST(N'2016-06-17T11:52:17.200' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (117, 1, 1, CAST(N'2016-06-17T08:53:47.197' AS DateTime), N'192.168.1.109', CAST(N'2016-06-17T12:04:38.630' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (118, 1, 1, CAST(N'2016-06-17T09:17:05.360' AS DateTime), N'192.168.1.233', CAST(N'2016-06-17T14:29:55.287' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (119, 1, 1, CAST(N'2016-06-17T11:18:16.997' AS DateTime), N'192.168.1.105', CAST(N'2016-06-17T15:08:32.923' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (120, 1, 1, CAST(N'2016-06-17T15:31:52.733' AS DateTime), N'192.168.1.105', CAST(N'2016-06-17T20:20:58.153' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (121, 1, 1, CAST(N'2016-06-17T15:34:01.900' AS DateTime), N'192.168.1.102', CAST(N'2016-06-17T18:02:47.570' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (122, 1, 1, CAST(N'2016-06-17T15:52:45.903' AS DateTime), N'192.168.1.233', CAST(N'2016-06-17T18:16:22.967' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (123, 1, 1, CAST(N'2016-06-17T18:17:17.743' AS DateTime), N'192.168.1.102', CAST(N'2016-06-17T20:05:10.023' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (124, 1, 1, CAST(N'2016-06-17T18:33:06.190' AS DateTime), N'192.168.1.109', CAST(N'2016-06-17T20:52:18.250' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (125, 1, 1, CAST(N'2016-06-18T08:31:07.487' AS DateTime), N'192.168.1.109', CAST(N'2016-06-18T11:50:04.060' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (126, 1, 1, CAST(N'2016-06-18T10:29:18.853' AS DateTime), N'192.168.1.102', CAST(N'2016-06-18T23:01:42.417' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (127, 1, 1, CAST(N'2016-06-18T11:41:32.623' AS DateTime), N'192.168.1.109', CAST(N'2016-06-18T12:45:51.780' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (128, 1, 1, CAST(N'2016-06-18T11:52:03.177' AS DateTime), N'192.168.1.109', CAST(N'2016-06-18T13:03:43.110' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (129, 1, 1, CAST(N'2016-06-18T12:07:13.683' AS DateTime), N'192.168.1.109', CAST(N'2016-06-18T13:07:13.723' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (130, 1, 1, CAST(N'2016-06-18T13:04:23.403' AS DateTime), N'192.168.1.109', CAST(N'2016-06-18T14:10:34.810' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (131, 1, 1, CAST(N'2016-06-18T17:25:19.513' AS DateTime), N'192.168.1.109', CAST(N'2016-06-18T23:09:24.900' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (132, 1, 1, CAST(N'2016-06-20T08:46:44.327' AS DateTime), N'192.168.1.109', CAST(N'2016-06-20T10:03:41.440' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (133, 1, 1, CAST(N'2016-06-20T08:56:22.930' AS DateTime), N'192.168.1.115', CAST(N'2016-06-20T10:10:23.993' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (134, 1, 1, CAST(N'2016-06-20T09:49:20.313' AS DateTime), N'192.168.1.102', CAST(N'2016-06-20T13:21:16.113' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (135, 1, 1, CAST(N'2016-06-20T10:35:35.963' AS DateTime), N'192.168.1.109', CAST(N'2016-06-20T11:36:12.167' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (136, 1, 1, CAST(N'2016-06-20T11:36:51.440' AS DateTime), N'192.168.1.115', CAST(N'2016-06-20T13:46:48.217' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (137, 1, 1, CAST(N'2016-06-20T12:58:52.287' AS DateTime), N'192.168.1.109', CAST(N'2016-06-20T16:21:51.200' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (138, 1, 1, CAST(N'2016-06-20T13:57:10.707' AS DateTime), N'192.168.1.102', CAST(N'2016-06-20T15:12:21.527' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (139, 1, 1, CAST(N'2016-06-20T15:33:05.523' AS DateTime), N'192.168.1.102', CAST(N'2016-06-20T17:05:15.877' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (140, 1, 1, CAST(N'2016-06-20T15:35:11.297' AS DateTime), N'192.168.1.115', CAST(N'2016-06-20T16:35:26.853' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (141, 1, 1, CAST(N'2016-06-20T15:35:26.903' AS DateTime), N'192.168.1.115', CAST(N'2016-06-20T16:51:48.203' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (142, 1, 1, CAST(N'2016-06-20T17:21:10.823' AS DateTime), N'192.168.1.109', CAST(N'2016-06-20T20:52:15.930' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (143, 1, 1, CAST(N'2016-06-20T19:08:48.820' AS DateTime), N'192.168.1.115', CAST(N'2016-06-20T20:54:34.470' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (144, 1, 1, CAST(N'2016-06-21T09:27:54.473' AS DateTime), N'192.168.1.102', CAST(N'2016-06-21T11:59:44.023' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (145, 1, 1, CAST(N'2016-06-21T09:44:02.267' AS DateTime), N'192.168.1.106', CAST(N'2016-06-21T11:05:18.180' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (146, 1, 1, CAST(N'2016-06-21T11:39:05.510' AS DateTime), N'192.168.1.106', CAST(N'2016-06-21T14:08:33.177' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (147, 1, 1, CAST(N'2016-06-21T12:24:39.810' AS DateTime), N'192.168.1.115', CAST(N'2016-06-21T17:18:28.607' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (148, 1, 1, CAST(N'2016-06-21T16:48:43.177' AS DateTime), N'192.168.1.106', CAST(N'2016-06-21T17:49:42.880' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (149, 1, 1, CAST(N'2016-06-21T18:24:50.427' AS DateTime), N'192.168.1.109', CAST(N'2016-06-21T20:01:00.663' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (150, 1, 1, CAST(N'2016-06-21T18:24:49.553' AS DateTime), N'192.168.1.109', CAST(N'2016-06-21T18:29:49.553' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (151, 1, 1, CAST(N'2016-06-22T08:22:58.957' AS DateTime), N'192.168.1.109', CAST(N'2016-06-22T12:29:53.253' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (152, 1, 1, CAST(N'2016-06-22T09:29:24.430' AS DateTime), N'192.168.1.23', CAST(N'2016-06-22T12:59:16.070' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (153, 1, 1, CAST(N'2016-06-22T09:58:25.063' AS DateTime), N'192.168.1.199', CAST(N'2016-06-22T11:28:31.547' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (154, 1, 1, CAST(N'2016-06-22T10:47:47.183' AS DateTime), N'192.168.1.122', CAST(N'2016-06-22T14:18:18.867' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (155, 1, 1, CAST(N'2016-06-22T14:29:11.137' AS DateTime), N'192.168.1.23', CAST(N'2016-06-22T15:40:37.277' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (156, 1, 1, CAST(N'2016-06-22T16:17:13.260' AS DateTime), N'192.168.1.23', CAST(N'2016-06-22T17:19:40.023' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (157, 1, 1, CAST(N'2016-06-22T16:20:17.853' AS DateTime), N'192.168.1.109', CAST(N'2016-06-22T17:25:13.500' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (158, 1, 1, CAST(N'2016-06-22T16:26:50.823' AS DateTime), N'192.168.1.122', CAST(N'2016-06-22T18:30:03.153' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (159, 1, 1, CAST(N'2016-06-22T17:04:04.563' AS DateTime), N'192.168.1.106', CAST(N'2016-06-22T18:49:56.237' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (160, 1, 1, CAST(N'2016-06-22T17:31:49.507' AS DateTime), N'192.168.1.102', CAST(N'2016-06-22T20:52:11.007' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (161, 1, 1, CAST(N'2016-06-22T17:34:39.237' AS DateTime), N'192.168.1.23', CAST(N'2016-06-22T19:25:33.923' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (162, 1, 1, CAST(N'2016-06-22T17:37:21.193' AS DateTime), N'192.168.1.109', CAST(N'2016-06-22T21:21:26.890' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (163, 1, 1, CAST(N'2016-06-22T20:21:50.633' AS DateTime), N'192.168.1.109', CAST(N'2016-06-22T22:28:40.100' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (164, 1, 1, CAST(N'2016-06-22T21:43:17.500' AS DateTime), N'192.168.1.109', CAST(N'2016-06-22T22:47:30.717' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (165, 1, 1, CAST(N'2016-07-04T16:25:04.630' AS DateTime), N'192.168.1.109', CAST(N'2016-07-04T17:26:56.320' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (166, 1, 1, CAST(N'2016-07-11T08:30:49.020' AS DateTime), N'192.168.1.109', CAST(N'2016-07-11T09:31:19.563' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (167, 1, 1, CAST(N'2016-07-12T09:38:58.557' AS DateTime), N'192.168.1.109', CAST(N'2016-07-12T11:06:06.463' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (168, 1, 1, CAST(N'2016-07-12T18:20:53.517' AS DateTime), N'192.168.1.109', CAST(N'2016-07-12T19:21:41.607' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (169, 1, 1, CAST(N'2016-07-12T18:22:10.093' AS DateTime), N'192.168.1.109', CAST(N'2016-07-12T19:22:10.127' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (170, 1, 1, CAST(N'2016-07-13T09:15:02.860' AS DateTime), N'192.168.1.109', CAST(N'2016-07-13T10:27:59.690' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (171, 1, 1, CAST(N'2016-07-13T18:44:52.463' AS DateTime), N'192.168.1.109', CAST(N'2016-07-13T19:45:16.673' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (172, 1, 1, CAST(N'2016-07-13T19:00:44.087' AS DateTime), N'192.168.1.109', CAST(N'2016-07-13T20:01:00.653' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (173, 1, 1, CAST(N'2016-07-14T08:37:42.163' AS DateTime), N'192.168.1.109', CAST(N'2016-07-14T09:40:02.883' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (174, 1, 1, CAST(N'2016-07-14T08:37:42.163' AS DateTime), N'192.168.1.109', CAST(N'2016-07-14T08:42:42.163' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (175, 1, 1, CAST(N'2016-07-14T19:25:08.303' AS DateTime), N'192.168.1.109', CAST(N'2016-07-14T20:52:56.017' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (176, 1, 1, CAST(N'2016-07-14T19:38:15.257' AS DateTime), N'192.168.1.101', CAST(N'2016-07-14T20:43:04.133' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (177, 1, 1, CAST(N'2016-07-14T19:41:52.877' AS DateTime), N'192.168.1.25', CAST(N'2016-07-14T20:52:06.800' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (178, 1, 1, CAST(N'2016-08-02T18:56:01.693' AS DateTime), N'192.168.1.109', CAST(N'2016-08-02T19:58:33.873' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (179, 1, 1, CAST(N'2016-08-02T21:15:30.437' AS DateTime), N'192.168.1.109', CAST(N'2016-08-02T22:43:51.413' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (180, 1, 1, CAST(N'2016-08-02T21:33:24.037' AS DateTime), N'192.168.1.109', CAST(N'2016-08-02T22:41:59.260' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (181, 1, 1, CAST(N'2016-08-02T21:42:14.363' AS DateTime), N'192.168.1.109', CAST(N'2016-08-02T22:42:24.137' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (182, 1, 1, CAST(N'2016-08-03T17:24:43.610' AS DateTime), N'192.168.1.109', CAST(N'2016-08-03T18:25:38.530' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (183, 1, 1, CAST(N'2016-08-03T18:24:42.970' AS DateTime), N'192.168.1.8', CAST(N'2016-08-03T19:47:02.343' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (184, 1, 1, CAST(N'2016-08-03T18:26:30.330' AS DateTime), N'192.168.1.16', CAST(N'2016-08-03T20:13:04.597' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (185, 1, 1, CAST(N'2016-08-03T18:27:02.170' AS DateTime), N'192.168.1.17', CAST(N'2016-08-03T20:24:54.467' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (186, 1, 1, CAST(N'2016-08-03T18:27:57.987' AS DateTime), N'::1', CAST(N'2016-08-03T19:51:23.773' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (187, 1, 1, CAST(N'2016-08-03T18:43:17.750' AS DateTime), N'192.168.1.131', CAST(N'2016-08-03T19:49:26.803' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (188, 1, 1, CAST(N'2016-08-03T18:51:37.467' AS DateTime), N'::1', CAST(N'2016-08-03T19:52:53.340' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (189, 1, 1, CAST(N'2016-08-03T18:53:20.720' AS DateTime), N'192.168.1.109', CAST(N'2016-08-03T19:53:26.167' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (190, 1, 1, CAST(N'2016-08-03T19:35:15.053' AS DateTime), N'192.168.1.131', CAST(N'2016-08-03T23:03:38.990' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (191, 1, 1, CAST(N'2016-08-03T19:51:53.933' AS DateTime), N'192.168.1.17', CAST(N'2016-08-03T23:04:22.700' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (192, 1, 1, CAST(N'2016-08-03T22:03:59.163' AS DateTime), N'192.168.1.131', CAST(N'2016-08-03T23:04:44.277' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (193, 1, 1, CAST(N'2016-08-04T13:08:34.963' AS DateTime), N'192.168.1.131', CAST(N'2016-08-04T19:58:28.450' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (194, 1, 1, CAST(N'2016-08-04T13:26:41.453' AS DateTime), N'192.168.1.17', CAST(N'2016-08-04T20:54:44.747' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (195, 1, 1, CAST(N'2016-08-04T13:36:45.307' AS DateTime), N'192.168.1.16', CAST(N'2016-08-04T17:52:10.007' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (196, 1, 1, CAST(N'2016-08-04T14:57:25.667' AS DateTime), N'192.168.1.20', CAST(N'2016-08-04T20:13:29.463' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (197, 1, 1, CAST(N'2016-08-05T10:19:01.417' AS DateTime), N'192.168.1.109', CAST(N'2016-08-05T11:23:49.423' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (198, 1, 1, CAST(N'2016-08-05T12:44:44.633' AS DateTime), N'192.168.1.19', CAST(N'2016-08-05T17:41:51.427' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (199, 1, 1, CAST(N'2016-08-16T15:54:11.287' AS DateTime), N'192.168.1.109', CAST(N'2016-08-16T16:55:56.180' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (200, 1, 1, CAST(N'2016-10-10T10:39:56.773' AS DateTime), N'::1', CAST(N'2016-10-10T13:53:17.080' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (201, 1, 1, CAST(N'2016-10-10T14:14:58.307' AS DateTime), N'::1', CAST(N'2016-10-10T15:38:53.210' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (202, 1, 1, CAST(N'2016-10-10T15:39:36.753' AS DateTime), N'::1', CAST(N'2016-10-10T16:50:39.673' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (203, 1, 1, CAST(N'2016-10-10T17:59:44.733' AS DateTime), N'::1', CAST(N'2016-10-10T19:53:31.967' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (204, 1, 1, CAST(N'2016-10-10T20:10:01.557' AS DateTime), N'::1', CAST(N'2016-10-10T21:18:00.520' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (205, 1, 1, CAST(N'2016-10-10T21:47:10.933' AS DateTime), N'::1', CAST(N'2016-10-10T22:51:25.230' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (206, 1, 1, CAST(N'2016-12-20T19:27:51.437' AS DateTime), N'::1', CAST(N'2016-12-20T20:28:13.433' AS DateTime), 0)
GO
INSERT [dbo].[sys_UserSession] ([id], [userId], [companyId], [loggedDate], [ipAddress], [expiredDate], [deleted]) VALUES (207, 1, 1, CAST(N'2017-01-03T16:05:58.577' AS DateTime), N'::1', CAST(N'2017-01-03T17:35:38.417' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[sys_UserSession] OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Agency_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Agency] ADD  CONSTRAINT [DF_mf_Agency_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Agency_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Agency] ADD  CONSTRAINT [DF_mf_Agency_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Allowance_isTaxable]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Allowance] ADD  CONSTRAINT [DF_mf_Allowance_isTaxable]  DEFAULT ((0)) FOR [isTaxable]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Allowance_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Allowance] ADD  CONSTRAINT [DF_mf_Allowance_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Allowance_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Allowance] ADD  CONSTRAINT [DF_mf_Allowance_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_ApplicationRequestType_hasLeavePoints]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_ApplicationRequestType] ADD  CONSTRAINT [DF_mf_ApplicationRequestType_hasLeavePoints]  DEFAULT ((0)) FOR [requiredLeavePoints]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_ApplicationRequestType_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_ApplicationRequestType] ADD  CONSTRAINT [DF_mf_ApplicationRequestType_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_ApplicationRequestType_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_ApplicationRequestType] ADD  CONSTRAINT [DF_mf_ApplicationRequestType_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Country_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Country] ADD  CONSTRAINT [DF_mf_Country_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Country_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Country] ADD  CONSTRAINT [DF_mf_Country_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Deduction_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Deduction] ADD  CONSTRAINT [DF_mf_Deduction_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Deduction_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Deduction] ADD  CONSTRAINT [DF_mf_Deduction_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Department_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Department] ADD  CONSTRAINT [DF_mf_Department_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Department_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Department] ADD  CONSTRAINT [DF_mf_Department_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_DepartmentSection_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_DepartmentSection] ADD  CONSTRAINT [DF_mf_DepartmentSection_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_DepartmentSection_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_DepartmentSection] ADD  CONSTRAINT [DF_mf_DepartmentSection_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_DepartmentSectionRequestApprover_orderNo]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover] ADD  CONSTRAINT [DF_mf_DepartmentSectionRequestApprover_orderNo]  DEFAULT ((0)) FOR [orderNo]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_DepartmentSectionRequestApprover_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover] ADD  CONSTRAINT [DF_mf_DepartmentSectionRequestApprover_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_DepartmentSectionRequestApprover_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover] ADD  CONSTRAINT [DF_mf_DepartmentSectionRequestApprover_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee] ADD  CONSTRAINT [DF_mf_Employee_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee] ADD  CONSTRAINT [DF_mf_Employee_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee201_timeSheetRequired]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee201] ADD  CONSTRAINT [DF_mf_Employee201_timeSheetRequired]  DEFAULT ((1)) FOR [timeSheetRequired]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee201_entitledUnworkRegularHoliday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee201] ADD  CONSTRAINT [DF_mf_Employee201_entitledUnworkRegularHoliday]  DEFAULT ((1)) FOR [entitledUnworkRegularHoliday]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee201_entitledUnworkSpecialHoliday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee201] ADD  CONSTRAINT [DF_mf_Employee201_entitledUnworkSpecialHoliday]  DEFAULT ((1)) FOR [entitledUnworkSpecialHoliday]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee201_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee201] ADD  CONSTRAINT [DF_mf_Employee201_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee201_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee201] ADD  CONSTRAINT [DF_mf_Employee201_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Employee201_confidential]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Employee201] ADD  CONSTRAINT [DF_mf_Employee201_confidential]  DEFAULT ((0)) FOR [confidential]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeAddress_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeAddress] ADD  CONSTRAINT [DF_mf_EmployeeAddress_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeAddress_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeAddress] ADD  CONSTRAINT [DF_mf_EmployeeAddress_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeAllowance_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeAllowance] ADD  CONSTRAINT [DF_mf_EmployeeAllowance_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeAllowance_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeAllowance] ADD  CONSTRAINT [DF_mf_EmployeeAllowance_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeBalanceLeave_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeBalanceLeave] ADD  CONSTRAINT [DF_mf_EmployeeBalanceLeave_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeBalanceLeave_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeBalanceLeave] ADD  CONSTRAINT [DF_mf_EmployeeBalanceLeave_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeBasicPay_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeBasicPay] ADD  CONSTRAINT [DF_mf_EmployeeBasicPay_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeBasicPay_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeBasicPay] ADD  CONSTRAINT [DF_mf_EmployeeBasicPay_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeDeduction_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeDeduction] ADD  CONSTRAINT [DF_mf_EmployeeDeduction_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeDeduction_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeDeduction] ADD  CONSTRAINT [DF_mf_EmployeeDeduction_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeEducation_createdDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeEducation] ADD  CONSTRAINT [DF_mf_EmployeeEducation_createdDate]  DEFAULT (getdate()) FOR [createdDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeEducation_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeEducation] ADD  CONSTRAINT [DF_mf_EmployeeEducation_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeEducation_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeEducation] ADD  CONSTRAINT [DF_mf_EmployeeEducation_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeIdentificationDocument_updatedDate_1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeIdentificationDocument] ADD  CONSTRAINT [DF_mf_EmployeeIdentificationDocument_updatedDate_1]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeIdentificationDocument_deleted_1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeIdentificationDocument] ADD  CONSTRAINT [DF_mf_EmployeeIdentificationDocument_deleted_1]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeOffense_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeOffense] ADD  CONSTRAINT [DF_mf_EmployeeOffense_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeOffense_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeOffense] ADD  CONSTRAINT [DF_mf_EmployeeOffense_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeSkill_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeSkill] ADD  CONSTRAINT [DF_mf_EmployeeSkill_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeSkill_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeSkill] ADD  CONSTRAINT [DF_mf_EmployeeSkill_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeTraining_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeTraining] ADD  CONSTRAINT [DF_mf_EmployeeTraining_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeTraining_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeTraining] ADD  CONSTRAINT [DF_mf_EmployeeTraining_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeWorkDays_createdDate1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeWorkDays] ADD  CONSTRAINT [DF_mf_EmployeeWorkDays_createdDate1]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeWorkDays_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeWorkDays] ADD  CONSTRAINT [DF_mf_EmployeeWorkDays_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeWorkHistory_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeWorkHistory] ADD  CONSTRAINT [DF_mf_EmployeeWorkHistory_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmployeeWorkHistory_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmployeeWorkHistory] ADD  CONSTRAINT [DF_mf_EmployeeWorkHistory_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmploymentStatus_allowProcessPayroll]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmploymentStatus] ADD  CONSTRAINT [DF_mf_EmploymentStatus_allowProcessPayroll]  DEFAULT ((0)) FOR [allowProcessPayroll]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmploymentStatus_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmploymentStatus] ADD  CONSTRAINT [DF_mf_EmploymentStatus_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmploymentStatus_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmploymentStatus] ADD  CONSTRAINT [DF_mf_EmploymentStatus_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmploymentType_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmploymentType] ADD  CONSTRAINT [DF_mf_EmploymentType_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_EmploymentType_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_EmploymentType] ADD  CONSTRAINT [DF_mf_EmploymentType_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Holidays_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Holidays] ADD  CONSTRAINT [DF_mf_Holidays_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Holidays_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Holidays] ADD  CONSTRAINT [DF_mf_Holidays_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_HolidayType_rateNotWork]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_HolidayType] ADD  CONSTRAINT [DF_mf_HolidayType_rateNotWork]  DEFAULT ((0)) FOR [rateNotWork]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_HolidayType_rateWork]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_HolidayType] ADD  CONSTRAINT [DF_mf_HolidayType_rateWork]  DEFAULT ((0)) FOR [rateWork]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_HolidayType_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_HolidayType] ADD  CONSTRAINT [DF_mf_HolidayType_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_HolidayType_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_HolidayType] ADD  CONSTRAINT [DF_mf_HolidayType_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Offense_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Offense] ADD  CONSTRAINT [DF_mf_Offense_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Offense_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Offense] ADD  CONSTRAINT [DF_mf_Offense_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_PayrollGroup_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_PayrollGroup] ADD  CONSTRAINT [DF_mf_PayrollGroup_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_PayrollGroup_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_PayrollGroup] ADD  CONSTRAINT [DF_mf_PayrollGroup_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_PenaltyType_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_PenaltyType] ADD  CONSTRAINT [DF_mf_PenaltyType_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_PenaltyType_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_PenaltyType] ADD  CONSTRAINT [DF_mf_PenaltyType_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Position_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Position] ADD  CONSTRAINT [DF_mf_Position_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_Position_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_Position] ADD  CONSTRAINT [DF_mf_Position_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_monday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] ADD  CONSTRAINT [DF_mf_WorkDays_monday]  DEFAULT ((0)) FOR [monday]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_tuesday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] ADD  CONSTRAINT [DF_mf_WorkDays_tuesday]  DEFAULT ((0)) FOR [tuesday]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_wednesday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] ADD  CONSTRAINT [DF_mf_WorkDays_wednesday]  DEFAULT ((0)) FOR [wednesday]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_thursday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] ADD  CONSTRAINT [DF_mf_WorkDays_thursday]  DEFAULT ((0)) FOR [thursday]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_friday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] ADD  CONSTRAINT [DF_mf_WorkDays_friday]  DEFAULT ((0)) FOR [friday]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_saturday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] ADD  CONSTRAINT [DF_mf_WorkDays_saturday]  DEFAULT ((0)) FOR [saturday]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_sunday]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] ADD  CONSTRAINT [DF_mf_WorkDays_sunday]  DEFAULT ((0)) FOR [sunday]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_fromTimeHour]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] ADD  CONSTRAINT [DF_mf_WorkDays_fromTimeHour]  DEFAULT ((0)) FOR [fromTimeHour]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_fromTimeMinute]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] ADD  CONSTRAINT [DF_mf_WorkDays_fromTimeMinute]  DEFAULT ((0)) FOR [fromTimeMinute]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_toTimeHour]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] ADD  CONSTRAINT [DF_mf_WorkDays_toTimeHour]  DEFAULT ((0)) FOR [toTimeHour]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_toTimeMinute]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] ADD  CONSTRAINT [DF_mf_WorkDays_toTimeMinute]  DEFAULT ((0)) FOR [toTimeMinute]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_breakHours]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] ADD  CONSTRAINT [DF_mf_WorkDays_breakHours]  DEFAULT ((0)) FOR [breakHours]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] ADD  CONSTRAINT [DF_mf_WorkDays_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_mf_WorkDays_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[mf_WorkDays] ADD  CONSTRAINT [DF_mf_WorkDays_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_pr_Payroll_generatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[pr_Payroll] ADD  CONSTRAINT [DF_pr_Payroll_generatedDate]  DEFAULT (getdate()) FOR [generatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_pr_Payroll_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[pr_Payroll] ADD  CONSTRAINT [DF_pr_Payroll_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_pr_Payroll_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[pr_Payroll] ADD  CONSTRAINT [DF_pr_Payroll_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_pr_PayrollEmployee_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[pr_PayrollEmployee] ADD  CONSTRAINT [DF_pr_PayrollEmployee_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_pr_PayrollEmployee_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[pr_PayrollEmployee] ADD  CONSTRAINT [DF_pr_PayrollEmployee_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Company_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Company] ADD  CONSTRAINT [DF_sys_Company_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Company_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Company] ADD  CONSTRAINT [DF_sys_Company_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_CompanySetting_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_CompanySetting] ADD  CONSTRAINT [DF_sys_CompanySetting_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_CompanySetting_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_CompanySetting] ADD  CONSTRAINT [DF_sys_CompanySetting_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_EnumReference_displayOrder]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_EnumReference] ADD  CONSTRAINT [DF_sys_EnumReference_displayOrder]  DEFAULT ((0)) FOR [displayOrder]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_EnumReference_hidden]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_EnumReference] ADD  CONSTRAINT [DF_sys_EnumReference_hidden]  DEFAULT ((0)) FOR [hidden]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_EnumReference_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_EnumReference] ADD  CONSTRAINT [DF_sys_EnumReference_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_ErrorLogs_createdDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_ErrorLogs] ADD  CONSTRAINT [DF_sys_ErrorLogs_createdDate]  DEFAULT (getdate()) FOR [createdDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_IdentificationDocument_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_IdentificationDocument] ADD  CONSTRAINT [DF_sys_IdentificationDocument_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_IdentificationDocument_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_IdentificationDocument] ADD  CONSTRAINT [DF_sys_IdentificationDocument_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Location_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Location] ADD  CONSTRAINT [DF_sys_Location_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Location_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Location] ADD  CONSTRAINT [DF_sys_Location_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Menu_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Menu] ADD  CONSTRAINT [DF_sys_Menu_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Menu_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Menu] ADD  CONSTRAINT [DF_sys_Menu_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Permission_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Permission] ADD  CONSTRAINT [DF_sys_Permission_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Permission_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Permission] ADD  CONSTRAINT [DF_sys_Permission_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Role_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Role] ADD  CONSTRAINT [DF_sys_Role_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Role_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Role] ADD  CONSTRAINT [DF_sys_Role_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RoleMenu_displayOrder]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RoleMenu] ADD  CONSTRAINT [DF_sys_RoleMenu_displayOrder]  DEFAULT ((0)) FOR [displayOrder]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RoleMenu_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RoleMenu] ADD  CONSTRAINT [DF_sys_RoleMenu_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RoleMenu_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RoleMenu] ADD  CONSTRAINT [DF_sys_RoleMenu_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RolePermission_viewAccess]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RolePermission] ADD  CONSTRAINT [DF_sys_RolePermission_viewAccess]  DEFAULT ((0)) FOR [viewAccess]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RolePermission_createAccess]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RolePermission] ADD  CONSTRAINT [DF_sys_RolePermission_createAccess]  DEFAULT ((0)) FOR [createAccess]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RolePermission_updateAccess]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RolePermission] ADD  CONSTRAINT [DF_sys_RolePermission_updateAccess]  DEFAULT ((0)) FOR [updateAccess]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RolePermission_deleteAccess]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RolePermission] ADD  CONSTRAINT [DF_sys_RolePermission_deleteAccess]  DEFAULT ((0)) FOR [deleteAccess]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RolePermission_printAccess]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RolePermission] ADD  CONSTRAINT [DF_sys_RolePermission_printAccess]  DEFAULT ((0)) FOR [printAccess]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RolePermission_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RolePermission] ADD  CONSTRAINT [DF_sys_RolePermission_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_RolePermission_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_RolePermission] ADD  CONSTRAINT [DF_sys_RolePermission_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_Setting_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_Setting] ADD  CONSTRAINT [DF_sys_Setting_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_User_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_User] ADD  CONSTRAINT [DF_sys_User_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_User_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_User] ADD  CONSTRAINT [DF_sys_User_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_UserRole_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_UserRole] ADD  CONSTRAINT [DF_sys_UserRole_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_UserRole_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_UserRole] ADD  CONSTRAINT [DF_sys_UserRole_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_sys_UserSession_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[sys_UserSession] ADD  CONSTRAINT [DF_sys_UserSession_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_ApplicationRequest_createdDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_ApplicationRequest] ADD  CONSTRAINT [DF_ta_ApplicationRequest_createdDate]  DEFAULT (getdate()) FOR [requestedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_ApplicationRequest_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_ApplicationRequest] ADD  CONSTRAINT [DF_ta_ApplicationRequest_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_ApplicationRequest_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_ApplicationRequest] ADD  CONSTRAINT [DF_ta_ApplicationRequest_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_ApplicationRequestApprover_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_ApplicationRequestApprover] ADD  CONSTRAINT [DF_ta_ApplicationRequestApprover_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_ApplicationRequestGatePass_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_ApplicationRequestGatePass] ADD  CONSTRAINT [DF_ta_ApplicationRequestGatePass_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_ApplicationRequestLeave_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_ApplicationRequestLeave] ADD  CONSTRAINT [DF_ta_ApplicationRequestLeave_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendance_generatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendance] ADD  CONSTRAINT [DF_ta_CutOffAttendance_generatedDate]  DEFAULT (getdate()) FOR [generatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendance_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendance] ADD  CONSTRAINT [DF_ta_CutOffAttendance_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendance_updatedDate1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendance] ADD  CONSTRAINT [DF_ta_CutOffAttendance_updatedDate1]  DEFAULT (getdate()) FOR [changeStatusDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendance_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendance] ADD  CONSTRAINT [DF_ta_CutOffAttendance_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendanceSummary_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendanceSummary] ADD  CONSTRAINT [DF_ta_CutOffAttendanceSummary_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendanceSummary_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendanceSummary] ADD  CONSTRAINT [DF_ta_CutOffAttendanceSummary_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendanceSummaryDetail_absent]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendanceSummaryDetail] ADD  CONSTRAINT [DF_ta_CutOffAttendanceSummaryDetail_absent]  DEFAULT ((0)) FOR [absent]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendanceSummaryDetail_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendanceSummaryDetail] ADD  CONSTRAINT [DF_ta_CutOffAttendanceSummaryDetail_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_CutOffAttendanceSummaryDetail_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_CutOffAttendanceSummaryDetail] ADD  CONSTRAINT [DF_ta_CutOffAttendanceSummaryDetail_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_EmployeeAttendance_updatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_EmployeeAttendance] ADD  CONSTRAINT [DF_ta_EmployeeAttendance_updatedDate]  DEFAULT (getdate()) FOR [updatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_ta_EmployeeAttendance_deleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ta_EmployeeAttendance] ADD  CONSTRAINT [DF_ta_EmployeeAttendance_deleted]  DEFAULT ((0)) FOR [deleted]
END

GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Agency_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Agency]'))
ALTER TABLE [dbo].[mf_Agency]  WITH CHECK ADD  CONSTRAINT [FK_mf_Agency_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Agency_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Agency]'))
ALTER TABLE [dbo].[mf_Agency] CHECK CONSTRAINT [FK_mf_Agency_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Agency_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Agency]'))
ALTER TABLE [dbo].[mf_Agency]  WITH CHECK ADD  CONSTRAINT [FK_mf_Agency_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Agency_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Agency]'))
ALTER TABLE [dbo].[mf_Agency] CHECK CONSTRAINT [FK_mf_Agency_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Allowance_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Allowance]'))
ALTER TABLE [dbo].[mf_Allowance]  WITH CHECK ADD  CONSTRAINT [FK_mf_Allowance_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Allowance_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Allowance]'))
ALTER TABLE [dbo].[mf_Allowance] CHECK CONSTRAINT [FK_mf_Allowance_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Allowance_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Allowance]'))
ALTER TABLE [dbo].[mf_Allowance]  WITH CHECK ADD  CONSTRAINT [FK_mf_Allowance_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Allowance_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Allowance]'))
ALTER TABLE [dbo].[mf_Allowance] CHECK CONSTRAINT [FK_mf_Allowance_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_ApplicationRequestType_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_ApplicationRequestType]'))
ALTER TABLE [dbo].[mf_ApplicationRequestType]  WITH CHECK ADD  CONSTRAINT [FK_mf_ApplicationRequestType_sys_User1] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_ApplicationRequestType_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_ApplicationRequestType]'))
ALTER TABLE [dbo].[mf_ApplicationRequestType] CHECK CONSTRAINT [FK_mf_ApplicationRequestType_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Country_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Country]'))
ALTER TABLE [dbo].[mf_Country]  WITH CHECK ADD  CONSTRAINT [FK_mf_Country_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Country_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Country]'))
ALTER TABLE [dbo].[mf_Country] CHECK CONSTRAINT [FK_mf_Country_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Deduction_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Deduction]'))
ALTER TABLE [dbo].[mf_Deduction]  WITH CHECK ADD  CONSTRAINT [FK_mf_Deduction_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Deduction_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Deduction]'))
ALTER TABLE [dbo].[mf_Deduction] CHECK CONSTRAINT [FK_mf_Deduction_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Deduction_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Deduction]'))
ALTER TABLE [dbo].[mf_Deduction]  WITH CHECK ADD  CONSTRAINT [FK_mf_Deduction_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Deduction_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Deduction]'))
ALTER TABLE [dbo].[mf_Deduction] CHECK CONSTRAINT [FK_mf_Deduction_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Department_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Department]'))
ALTER TABLE [dbo].[mf_Department]  WITH CHECK ADD  CONSTRAINT [FK_mf_Department_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Department_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Department]'))
ALTER TABLE [dbo].[mf_Department] CHECK CONSTRAINT [FK_mf_Department_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Department_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Department]'))
ALTER TABLE [dbo].[mf_Department]  WITH CHECK ADD  CONSTRAINT [FK_mf_Department_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Department_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Department]'))
ALTER TABLE [dbo].[mf_Department] CHECK CONSTRAINT [FK_mf_Department_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSection_mf_Department]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSection]'))
ALTER TABLE [dbo].[mf_DepartmentSection]  WITH CHECK ADD  CONSTRAINT [FK_mf_DepartmentSection_mf_Department] FOREIGN KEY([departmentId])
REFERENCES [dbo].[mf_Department] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSection_mf_Department]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSection]'))
ALTER TABLE [dbo].[mf_DepartmentSection] CHECK CONSTRAINT [FK_mf_DepartmentSection_mf_Department]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSection_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSection]'))
ALTER TABLE [dbo].[mf_DepartmentSection]  WITH CHECK ADD  CONSTRAINT [FK_mf_DepartmentSection_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSection_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSection]'))
ALTER TABLE [dbo].[mf_DepartmentSection] CHECK CONSTRAINT [FK_mf_DepartmentSection_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSectionRequestApprover_mf_ApplicationRequestType]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSectionRequestApprover]'))
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover]  WITH CHECK ADD  CONSTRAINT [FK_mf_DepartmentSectionRequestApprover_mf_ApplicationRequestType] FOREIGN KEY([applicationRequestTypeId])
REFERENCES [dbo].[mf_ApplicationRequestType] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSectionRequestApprover_mf_ApplicationRequestType]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSectionRequestApprover]'))
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover] CHECK CONSTRAINT [FK_mf_DepartmentSectionRequestApprover_mf_ApplicationRequestType]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSectionRequestApprover_mf_DepartmentSection]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSectionRequestApprover]'))
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover]  WITH CHECK ADD  CONSTRAINT [FK_mf_DepartmentSectionRequestApprover_mf_DepartmentSection] FOREIGN KEY([departmentSectionId])
REFERENCES [dbo].[mf_DepartmentSection] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSectionRequestApprover_mf_DepartmentSection]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSectionRequestApprover]'))
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover] CHECK CONSTRAINT [FK_mf_DepartmentSectionRequestApprover_mf_DepartmentSection]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSectionRequestApprover_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSectionRequestApprover]'))
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover]  WITH CHECK ADD  CONSTRAINT [FK_mf_DepartmentSectionRequestApprover_sys_User] FOREIGN KEY([approverId])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSectionRequestApprover_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSectionRequestApprover]'))
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover] CHECK CONSTRAINT [FK_mf_DepartmentSectionRequestApprover_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSectionRequestApprover_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSectionRequestApprover]'))
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover]  WITH CHECK ADD  CONSTRAINT [FK_mf_DepartmentSectionRequestApprover_sys_User1] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_DepartmentSectionRequestApprover_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_DepartmentSectionRequestApprover]'))
ALTER TABLE [dbo].[mf_DepartmentSectionRequestApprover] CHECK CONSTRAINT [FK_mf_DepartmentSectionRequestApprover_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee_mf_Employee201]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee]'))
ALTER TABLE [dbo].[mf_Employee]  WITH CHECK ADD  CONSTRAINT [FK_mf_Employee_mf_Employee201] FOREIGN KEY([employee201Id])
REFERENCES [dbo].[mf_Employee201] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee_mf_Employee201]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee]'))
ALTER TABLE [dbo].[mf_Employee] CHECK CONSTRAINT [FK_mf_Employee_mf_Employee201]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee_mf_EmployeeAddress]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee]'))
ALTER TABLE [dbo].[mf_Employee]  WITH CHECK ADD  CONSTRAINT [FK_mf_Employee_mf_EmployeeAddress] FOREIGN KEY([employeeAddressId])
REFERENCES [dbo].[mf_EmployeeAddress] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee_mf_EmployeeAddress]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee]'))
ALTER TABLE [dbo].[mf_Employee] CHECK CONSTRAINT [FK_mf_Employee_mf_EmployeeAddress]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee]'))
ALTER TABLE [dbo].[mf_Employee]  WITH CHECK ADD  CONSTRAINT [FK_mf_Employee_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee]'))
ALTER TABLE [dbo].[mf_Employee] CHECK CONSTRAINT [FK_mf_Employee_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee]'))
ALTER TABLE [dbo].[mf_Employee]  WITH CHECK ADD  CONSTRAINT [FK_mf_Employee_sys_User1] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee]'))
ALTER TABLE [dbo].[mf_Employee] CHECK CONSTRAINT [FK_mf_Employee_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_Agency]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201]  WITH CHECK ADD  CONSTRAINT [FK_mf_Employee201_mf_Agency] FOREIGN KEY([agencyId])
REFERENCES [dbo].[mf_Agency] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_Agency]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] CHECK CONSTRAINT [FK_mf_Employee201_mf_Agency]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_Department]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201]  WITH CHECK ADD  CONSTRAINT [FK_mf_Employee201_mf_Department] FOREIGN KEY([departmentId])
REFERENCES [dbo].[mf_Department] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_Department]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] CHECK CONSTRAINT [FK_mf_Employee201_mf_Department]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_DepartmentSection]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201]  WITH CHECK ADD  CONSTRAINT [FK_mf_Employee201_mf_DepartmentSection] FOREIGN KEY([departmentSectionId])
REFERENCES [dbo].[mf_DepartmentSection] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_DepartmentSection]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] CHECK CONSTRAINT [FK_mf_Employee201_mf_DepartmentSection]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_EmploymentStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201]  WITH CHECK ADD  CONSTRAINT [FK_mf_Employee201_mf_EmploymentStatus] FOREIGN KEY([employmentStatusId])
REFERENCES [dbo].[mf_EmploymentStatus] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_EmploymentStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] CHECK CONSTRAINT [FK_mf_Employee201_mf_EmploymentStatus]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_EmploymentType]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201]  WITH CHECK ADD  CONSTRAINT [FK_mf_Employee201_mf_EmploymentType] FOREIGN KEY([employmentTypeId])
REFERENCES [dbo].[mf_EmploymentType] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_EmploymentType]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] CHECK CONSTRAINT [FK_mf_Employee201_mf_EmploymentType]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_PayrollGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201]  WITH CHECK ADD  CONSTRAINT [FK_mf_Employee201_mf_PayrollGroup] FOREIGN KEY([payrollGroupId])
REFERENCES [dbo].[mf_PayrollGroup] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_PayrollGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] CHECK CONSTRAINT [FK_mf_Employee201_mf_PayrollGroup]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_Position]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201]  WITH CHECK ADD  CONSTRAINT [FK_mf_Employee201_mf_Position] FOREIGN KEY([positionId])
REFERENCES [dbo].[mf_Position] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_mf_Position]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] CHECK CONSTRAINT [FK_mf_Employee201_mf_Position]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201]  WITH CHECK ADD  CONSTRAINT [FK_mf_Employee201_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Employee201_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Employee201]'))
ALTER TABLE [dbo].[mf_Employee201] CHECK CONSTRAINT [FK_mf_Employee201_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeAddress_mf_Country]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAddress]'))
ALTER TABLE [dbo].[mf_EmployeeAddress]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeAddress_mf_Country] FOREIGN KEY([countryId])
REFERENCES [dbo].[mf_Country] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeAddress_mf_Country]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAddress]'))
ALTER TABLE [dbo].[mf_EmployeeAddress] CHECK CONSTRAINT [FK_mf_EmployeeAddress_mf_Country]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeAddress_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAddress]'))
ALTER TABLE [dbo].[mf_EmployeeAddress]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeAddress_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeAddress_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAddress]'))
ALTER TABLE [dbo].[mf_EmployeeAddress] CHECK CONSTRAINT [FK_mf_EmployeeAddress_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeAllowance_mf_Allowance]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAllowance]'))
ALTER TABLE [dbo].[mf_EmployeeAllowance]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeAllowance_mf_Allowance] FOREIGN KEY([allowanceId])
REFERENCES [dbo].[mf_Allowance] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeAllowance_mf_Allowance]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAllowance]'))
ALTER TABLE [dbo].[mf_EmployeeAllowance] CHECK CONSTRAINT [FK_mf_EmployeeAllowance_mf_Allowance]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeAllowance_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAllowance]'))
ALTER TABLE [dbo].[mf_EmployeeAllowance]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeAllowance_mf_Employee] FOREIGN KEY([employeeId])
REFERENCES [dbo].[mf_Employee] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeAllowance_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAllowance]'))
ALTER TABLE [dbo].[mf_EmployeeAllowance] CHECK CONSTRAINT [FK_mf_EmployeeAllowance_mf_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeAllowance_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAllowance]'))
ALTER TABLE [dbo].[mf_EmployeeAllowance]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeAllowance_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeAllowance_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeAllowance]'))
ALTER TABLE [dbo].[mf_EmployeeAllowance] CHECK CONSTRAINT [FK_mf_EmployeeAllowance_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeBalanceLeave_mf_ApplicationRequestType]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBalanceLeave]'))
ALTER TABLE [dbo].[mf_EmployeeBalanceLeave]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeBalanceLeave_mf_ApplicationRequestType] FOREIGN KEY([applicationRequestTypeId])
REFERENCES [dbo].[mf_ApplicationRequestType] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeBalanceLeave_mf_ApplicationRequestType]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBalanceLeave]'))
ALTER TABLE [dbo].[mf_EmployeeBalanceLeave] CHECK CONSTRAINT [FK_mf_EmployeeBalanceLeave_mf_ApplicationRequestType]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeBalanceLeave_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBalanceLeave]'))
ALTER TABLE [dbo].[mf_EmployeeBalanceLeave]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeBalanceLeave_mf_Employee] FOREIGN KEY([employeeId])
REFERENCES [dbo].[mf_Employee] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeBalanceLeave_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBalanceLeave]'))
ALTER TABLE [dbo].[mf_EmployeeBalanceLeave] CHECK CONSTRAINT [FK_mf_EmployeeBalanceLeave_mf_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeBalanceLeave_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBalanceLeave]'))
ALTER TABLE [dbo].[mf_EmployeeBalanceLeave]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeBalanceLeave_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeBalanceLeave_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBalanceLeave]'))
ALTER TABLE [dbo].[mf_EmployeeBalanceLeave] CHECK CONSTRAINT [FK_mf_EmployeeBalanceLeave_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeBasicPay_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBasicPay]'))
ALTER TABLE [dbo].[mf_EmployeeBasicPay]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeBasicPay_mf_Employee] FOREIGN KEY([employeeId])
REFERENCES [dbo].[mf_Employee] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeBasicPay_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBasicPay]'))
ALTER TABLE [dbo].[mf_EmployeeBasicPay] CHECK CONSTRAINT [FK_mf_EmployeeBasicPay_mf_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeBasicPay_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBasicPay]'))
ALTER TABLE [dbo].[mf_EmployeeBasicPay]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeBasicPay_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeBasicPay_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeBasicPay]'))
ALTER TABLE [dbo].[mf_EmployeeBasicPay] CHECK CONSTRAINT [FK_mf_EmployeeBasicPay_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeDeduction_mf_Deduction]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeDeduction]'))
ALTER TABLE [dbo].[mf_EmployeeDeduction]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeDeduction_mf_Deduction] FOREIGN KEY([deductionId])
REFERENCES [dbo].[mf_Deduction] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeDeduction_mf_Deduction]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeDeduction]'))
ALTER TABLE [dbo].[mf_EmployeeDeduction] CHECK CONSTRAINT [FK_mf_EmployeeDeduction_mf_Deduction]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeDeduction_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeDeduction]'))
ALTER TABLE [dbo].[mf_EmployeeDeduction]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeDeduction_mf_Employee] FOREIGN KEY([employeeId])
REFERENCES [dbo].[mf_Employee] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeDeduction_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeDeduction]'))
ALTER TABLE [dbo].[mf_EmployeeDeduction] CHECK CONSTRAINT [FK_mf_EmployeeDeduction_mf_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeDeduction_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeDeduction]'))
ALTER TABLE [dbo].[mf_EmployeeDeduction]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeDeduction_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeDeduction_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeDeduction]'))
ALTER TABLE [dbo].[mf_EmployeeDeduction] CHECK CONSTRAINT [FK_mf_EmployeeDeduction_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeEducation_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeEducation]'))
ALTER TABLE [dbo].[mf_EmployeeEducation]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeEducation_mf_Employee] FOREIGN KEY([employeeId])
REFERENCES [dbo].[mf_Employee] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeEducation_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeEducation]'))
ALTER TABLE [dbo].[mf_EmployeeEducation] CHECK CONSTRAINT [FK_mf_EmployeeEducation_mf_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeEducation_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeEducation]'))
ALTER TABLE [dbo].[mf_EmployeeEducation]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeEducation_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeEducation_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeEducation]'))
ALTER TABLE [dbo].[mf_EmployeeEducation] CHECK CONSTRAINT [FK_mf_EmployeeEducation_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeIdentificationDocument_mf_Employee1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeIdentificationDocument]'))
ALTER TABLE [dbo].[mf_EmployeeIdentificationDocument]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeIdentificationDocument_mf_Employee1] FOREIGN KEY([employeeId])
REFERENCES [dbo].[mf_Employee] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeIdentificationDocument_mf_Employee1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeIdentificationDocument]'))
ALTER TABLE [dbo].[mf_EmployeeIdentificationDocument] CHECK CONSTRAINT [FK_mf_EmployeeIdentificationDocument_mf_Employee1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeIdentificationDocument_sys_IdentificationDocument]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeIdentificationDocument]'))
ALTER TABLE [dbo].[mf_EmployeeIdentificationDocument]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeIdentificationDocument_sys_IdentificationDocument] FOREIGN KEY([identificationDocumentId])
REFERENCES [dbo].[sys_IdentificationDocument] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeIdentificationDocument_sys_IdentificationDocument]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeIdentificationDocument]'))
ALTER TABLE [dbo].[mf_EmployeeIdentificationDocument] CHECK CONSTRAINT [FK_mf_EmployeeIdentificationDocument_sys_IdentificationDocument]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeIdentificationDocument_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeIdentificationDocument]'))
ALTER TABLE [dbo].[mf_EmployeeIdentificationDocument]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeIdentificationDocument_sys_User1] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeIdentificationDocument_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeIdentificationDocument]'))
ALTER TABLE [dbo].[mf_EmployeeIdentificationDocument] CHECK CONSTRAINT [FK_mf_EmployeeIdentificationDocument_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeOffense_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeOffense]'))
ALTER TABLE [dbo].[mf_EmployeeOffense]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeOffense_mf_Employee] FOREIGN KEY([employeeId])
REFERENCES [dbo].[mf_Employee] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeOffense_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeOffense]'))
ALTER TABLE [dbo].[mf_EmployeeOffense] CHECK CONSTRAINT [FK_mf_EmployeeOffense_mf_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeOffense_mf_Offense]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeOffense]'))
ALTER TABLE [dbo].[mf_EmployeeOffense]  WITH NOCHECK ADD  CONSTRAINT [FK_mf_EmployeeOffense_mf_Offense] FOREIGN KEY([offenseId])
REFERENCES [dbo].[mf_Offense] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeOffense_mf_Offense]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeOffense]'))
ALTER TABLE [dbo].[mf_EmployeeOffense] CHECK CONSTRAINT [FK_mf_EmployeeOffense_mf_Offense]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeOffense_mf_PenaltyType]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeOffense]'))
ALTER TABLE [dbo].[mf_EmployeeOffense]  WITH NOCHECK ADD  CONSTRAINT [FK_mf_EmployeeOffense_mf_PenaltyType] FOREIGN KEY([penaltyTypeId])
REFERENCES [dbo].[mf_PenaltyType] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeOffense_mf_PenaltyType]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeOffense]'))
ALTER TABLE [dbo].[mf_EmployeeOffense] CHECK CONSTRAINT [FK_mf_EmployeeOffense_mf_PenaltyType]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeOffense_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeOffense]'))
ALTER TABLE [dbo].[mf_EmployeeOffense]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeOffense_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeOffense_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeOffense]'))
ALTER TABLE [dbo].[mf_EmployeeOffense] CHECK CONSTRAINT [FK_mf_EmployeeOffense_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeSkill_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeSkill]'))
ALTER TABLE [dbo].[mf_EmployeeSkill]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeSkill_mf_Employee] FOREIGN KEY([employeeId])
REFERENCES [dbo].[mf_Employee] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeSkill_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeSkill]'))
ALTER TABLE [dbo].[mf_EmployeeSkill] CHECK CONSTRAINT [FK_mf_EmployeeSkill_mf_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeSkill_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeSkill]'))
ALTER TABLE [dbo].[mf_EmployeeSkill]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeSkill_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeSkill_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeSkill]'))
ALTER TABLE [dbo].[mf_EmployeeSkill] CHECK CONSTRAINT [FK_mf_EmployeeSkill_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeTraining_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeTraining]'))
ALTER TABLE [dbo].[mf_EmployeeTraining]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeTraining_mf_Employee] FOREIGN KEY([employeeId])
REFERENCES [dbo].[mf_Employee] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeTraining_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeTraining]'))
ALTER TABLE [dbo].[mf_EmployeeTraining] CHECK CONSTRAINT [FK_mf_EmployeeTraining_mf_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeTraining_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeTraining]'))
ALTER TABLE [dbo].[mf_EmployeeTraining]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeTraining_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeTraining_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeTraining]'))
ALTER TABLE [dbo].[mf_EmployeeTraining] CHECK CONSTRAINT [FK_mf_EmployeeTraining_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeWorkDays_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkDays]'))
ALTER TABLE [dbo].[mf_EmployeeWorkDays]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeWorkDays_mf_Employee] FOREIGN KEY([employeeId])
REFERENCES [dbo].[mf_Employee] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeWorkDays_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkDays]'))
ALTER TABLE [dbo].[mf_EmployeeWorkDays] CHECK CONSTRAINT [FK_mf_EmployeeWorkDays_mf_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeWorkDays_mf_WorkDays]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkDays]'))
ALTER TABLE [dbo].[mf_EmployeeWorkDays]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeWorkDays_mf_WorkDays] FOREIGN KEY([workDayId])
REFERENCES [dbo].[mf_WorkDays] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeWorkDays_mf_WorkDays]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkDays]'))
ALTER TABLE [dbo].[mf_EmployeeWorkDays] CHECK CONSTRAINT [FK_mf_EmployeeWorkDays_mf_WorkDays]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeWorkDays_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkDays]'))
ALTER TABLE [dbo].[mf_EmployeeWorkDays]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeWorkDays_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeWorkDays_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkDays]'))
ALTER TABLE [dbo].[mf_EmployeeWorkDays] CHECK CONSTRAINT [FK_mf_EmployeeWorkDays_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeWorkHistory_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkHistory]'))
ALTER TABLE [dbo].[mf_EmployeeWorkHistory]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeWorkHistory_mf_Employee] FOREIGN KEY([employeeId])
REFERENCES [dbo].[mf_Employee] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeWorkHistory_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkHistory]'))
ALTER TABLE [dbo].[mf_EmployeeWorkHistory] CHECK CONSTRAINT [FK_mf_EmployeeWorkHistory_mf_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeWorkHistory_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkHistory]'))
ALTER TABLE [dbo].[mf_EmployeeWorkHistory]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmployeeWorkHistory_sys_User1] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmployeeWorkHistory_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmployeeWorkHistory]'))
ALTER TABLE [dbo].[mf_EmployeeWorkHistory] CHECK CONSTRAINT [FK_mf_EmployeeWorkHistory_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmploymentStatus_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmploymentStatus]'))
ALTER TABLE [dbo].[mf_EmploymentStatus]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmploymentStatus_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmploymentStatus_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmploymentStatus]'))
ALTER TABLE [dbo].[mf_EmploymentStatus] CHECK CONSTRAINT [FK_mf_EmploymentStatus_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmploymentType_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmploymentType]'))
ALTER TABLE [dbo].[mf_EmploymentType]  WITH CHECK ADD  CONSTRAINT [FK_mf_EmploymentType_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_EmploymentType_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_EmploymentType]'))
ALTER TABLE [dbo].[mf_EmploymentType] CHECK CONSTRAINT [FK_mf_EmploymentType_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Holidays_mf_HolidayType]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Holidays]'))
ALTER TABLE [dbo].[mf_Holidays]  WITH CHECK ADD  CONSTRAINT [FK_mf_Holidays_mf_HolidayType] FOREIGN KEY([holidayTypeId])
REFERENCES [dbo].[mf_HolidayType] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Holidays_mf_HolidayType]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Holidays]'))
ALTER TABLE [dbo].[mf_Holidays] CHECK CONSTRAINT [FK_mf_Holidays_mf_HolidayType]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Holidays_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Holidays]'))
ALTER TABLE [dbo].[mf_Holidays]  WITH CHECK ADD  CONSTRAINT [FK_mf_Holidays_sys_User1] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Holidays_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Holidays]'))
ALTER TABLE [dbo].[mf_Holidays] CHECK CONSTRAINT [FK_mf_Holidays_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_HolidayType_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_HolidayType]'))
ALTER TABLE [dbo].[mf_HolidayType]  WITH CHECK ADD  CONSTRAINT [FK_mf_HolidayType_sys_User1] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_HolidayType_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_HolidayType]'))
ALTER TABLE [dbo].[mf_HolidayType] CHECK CONSTRAINT [FK_mf_HolidayType_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Offense_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Offense]'))
ALTER TABLE [dbo].[mf_Offense]  WITH CHECK ADD  CONSTRAINT [FK_mf_Offense_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Offense_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Offense]'))
ALTER TABLE [dbo].[mf_Offense] CHECK CONSTRAINT [FK_mf_Offense_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Offense_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Offense]'))
ALTER TABLE [dbo].[mf_Offense]  WITH CHECK ADD  CONSTRAINT [FK_mf_Offense_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Offense_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Offense]'))
ALTER TABLE [dbo].[mf_Offense] CHECK CONSTRAINT [FK_mf_Offense_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_PayrollGroup_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_PayrollGroup]'))
ALTER TABLE [dbo].[mf_PayrollGroup]  WITH CHECK ADD  CONSTRAINT [FK_mf_PayrollGroup_sys_User1] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_PayrollGroup_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_PayrollGroup]'))
ALTER TABLE [dbo].[mf_PayrollGroup] CHECK CONSTRAINT [FK_mf_PayrollGroup_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_PenaltyType_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_PenaltyType]'))
ALTER TABLE [dbo].[mf_PenaltyType]  WITH CHECK ADD  CONSTRAINT [FK_mf_PenaltyType_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_PenaltyType_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_PenaltyType]'))
ALTER TABLE [dbo].[mf_PenaltyType] CHECK CONSTRAINT [FK_mf_PenaltyType_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_PenaltyType_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_PenaltyType]'))
ALTER TABLE [dbo].[mf_PenaltyType]  WITH CHECK ADD  CONSTRAINT [FK_mf_PenaltyType_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_PenaltyType_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_PenaltyType]'))
ALTER TABLE [dbo].[mf_PenaltyType] CHECK CONSTRAINT [FK_mf_PenaltyType_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Position_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Position]'))
ALTER TABLE [dbo].[mf_Position]  WITH CHECK ADD  CONSTRAINT [FK_mf_Position_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Position_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Position]'))
ALTER TABLE [dbo].[mf_Position] CHECK CONSTRAINT [FK_mf_Position_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Position_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Position]'))
ALTER TABLE [dbo].[mf_Position]  WITH CHECK ADD  CONSTRAINT [FK_mf_Position_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_Position_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_Position]'))
ALTER TABLE [dbo].[mf_Position] CHECK CONSTRAINT [FK_mf_Position_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_WorkDays_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_WorkDays]'))
ALTER TABLE [dbo].[mf_WorkDays]  WITH CHECK ADD  CONSTRAINT [FK_mf_WorkDays_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_WorkDays_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_WorkDays]'))
ALTER TABLE [dbo].[mf_WorkDays] CHECK CONSTRAINT [FK_mf_WorkDays_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_WorkDays_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_WorkDays]'))
ALTER TABLE [dbo].[mf_WorkDays]  WITH CHECK ADD  CONSTRAINT [FK_mf_WorkDays_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mf_WorkDays_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[mf_WorkDays]'))
ALTER TABLE [dbo].[mf_WorkDays] CHECK CONSTRAINT [FK_mf_WorkDays_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_Payroll_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_Payroll]'))
ALTER TABLE [dbo].[pr_Payroll]  WITH CHECK ADD  CONSTRAINT [FK_pr_Payroll_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_Payroll_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_Payroll]'))
ALTER TABLE [dbo].[pr_Payroll] CHECK CONSTRAINT [FK_pr_Payroll_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_Payroll_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_Payroll]'))
ALTER TABLE [dbo].[pr_Payroll]  WITH CHECK ADD  CONSTRAINT [FK_pr_Payroll_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_Payroll_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_Payroll]'))
ALTER TABLE [dbo].[pr_Payroll] CHECK CONSTRAINT [FK_pr_Payroll_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_Payroll_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_Payroll]'))
ALTER TABLE [dbo].[pr_Payroll]  WITH CHECK ADD  CONSTRAINT [FK_pr_Payroll_sys_User1] FOREIGN KEY([generatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_Payroll_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_Payroll]'))
ALTER TABLE [dbo].[pr_Payroll] CHECK CONSTRAINT [FK_pr_Payroll_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_Payroll_ta_CutOffAttendance]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_Payroll]'))
ALTER TABLE [dbo].[pr_Payroll]  WITH CHECK ADD  CONSTRAINT [FK_pr_Payroll_ta_CutOffAttendance] FOREIGN KEY([cutOffAttendanceId])
REFERENCES [dbo].[ta_CutOffAttendance] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_Payroll_ta_CutOffAttendance]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_Payroll]'))
ALTER TABLE [dbo].[pr_Payroll] CHECK CONSTRAINT [FK_pr_Payroll_ta_CutOffAttendance]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployee_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployee]'))
ALTER TABLE [dbo].[pr_PayrollEmployee]  WITH CHECK ADD  CONSTRAINT [FK_pr_PayrollEmployee_mf_Employee] FOREIGN KEY([employeeId])
REFERENCES [dbo].[mf_Employee] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployee_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployee]'))
ALTER TABLE [dbo].[pr_PayrollEmployee] CHECK CONSTRAINT [FK_pr_PayrollEmployee_mf_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployee_pr_Payroll]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployee]'))
ALTER TABLE [dbo].[pr_PayrollEmployee]  WITH CHECK ADD  CONSTRAINT [FK_pr_PayrollEmployee_pr_Payroll] FOREIGN KEY([payrollId])
REFERENCES [dbo].[pr_Payroll] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployee_pr_Payroll]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployee]'))
ALTER TABLE [dbo].[pr_PayrollEmployee] CHECK CONSTRAINT [FK_pr_PayrollEmployee_pr_Payroll]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployeeDeductions_mf_Deduction]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeDeductions]'))
ALTER TABLE [dbo].[pr_PayrollEmployeeDeductions]  WITH CHECK ADD  CONSTRAINT [FK_pr_PayrollEmployeeDeductions_mf_Deduction] FOREIGN KEY([deductionId])
REFERENCES [dbo].[mf_Deduction] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployeeDeductions_mf_Deduction]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeDeductions]'))
ALTER TABLE [dbo].[pr_PayrollEmployeeDeductions] CHECK CONSTRAINT [FK_pr_PayrollEmployeeDeductions_mf_Deduction]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployeeDeductions_pr_PayrollEmployee]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeDeductions]'))
ALTER TABLE [dbo].[pr_PayrollEmployeeDeductions]  WITH CHECK ADD  CONSTRAINT [FK_pr_PayrollEmployeeDeductions_pr_PayrollEmployee] FOREIGN KEY([payrollEmployeeId])
REFERENCES [dbo].[pr_PayrollEmployee] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployeeDeductions_pr_PayrollEmployee]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeDeductions]'))
ALTER TABLE [dbo].[pr_PayrollEmployeeDeductions] CHECK CONSTRAINT [FK_pr_PayrollEmployeeDeductions_pr_PayrollEmployee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployeeEarnings_mf_Allowance]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeEarnings]'))
ALTER TABLE [dbo].[pr_PayrollEmployeeEarnings]  WITH CHECK ADD  CONSTRAINT [FK_pr_PayrollEmployeeEarnings_mf_Allowance] FOREIGN KEY([allowanceId])
REFERENCES [dbo].[mf_Allowance] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployeeEarnings_mf_Allowance]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeEarnings]'))
ALTER TABLE [dbo].[pr_PayrollEmployeeEarnings] CHECK CONSTRAINT [FK_pr_PayrollEmployeeEarnings_mf_Allowance]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployeeEarnings_pr_PayrollEmployee]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeEarnings]'))
ALTER TABLE [dbo].[pr_PayrollEmployeeEarnings]  WITH CHECK ADD  CONSTRAINT [FK_pr_PayrollEmployeeEarnings_pr_PayrollEmployee] FOREIGN KEY([payrollEmployeeId])
REFERENCES [dbo].[pr_PayrollEmployee] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pr_PayrollEmployeeEarnings_pr_PayrollEmployee]') AND parent_object_id = OBJECT_ID(N'[dbo].[pr_PayrollEmployeeEarnings]'))
ALTER TABLE [dbo].[pr_PayrollEmployeeEarnings] CHECK CONSTRAINT [FK_pr_PayrollEmployeeEarnings_pr_PayrollEmployee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Company_mf_Country]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Company]'))
ALTER TABLE [dbo].[sys_Company]  WITH CHECK ADD  CONSTRAINT [FK_sys_Company_mf_Country] FOREIGN KEY([countryId])
REFERENCES [dbo].[mf_Country] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Company_mf_Country]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Company]'))
ALTER TABLE [dbo].[sys_Company] CHECK CONSTRAINT [FK_sys_Company_mf_Country]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Company_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Company]'))
ALTER TABLE [dbo].[sys_Company]  WITH CHECK ADD  CONSTRAINT [FK_sys_Company_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Company_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Company]'))
ALTER TABLE [dbo].[sys_Company] CHECK CONSTRAINT [FK_sys_Company_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_CompanySetting_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_CompanySetting]'))
ALTER TABLE [dbo].[sys_CompanySetting]  WITH CHECK ADD  CONSTRAINT [FK_sys_CompanySetting_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_CompanySetting_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_CompanySetting]'))
ALTER TABLE [dbo].[sys_CompanySetting] CHECK CONSTRAINT [FK_sys_CompanySetting_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_CompanySetting_sys_Setting]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_CompanySetting]'))
ALTER TABLE [dbo].[sys_CompanySetting]  WITH CHECK ADD  CONSTRAINT [FK_sys_CompanySetting_sys_Setting] FOREIGN KEY([settingId])
REFERENCES [dbo].[sys_Setting] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_CompanySetting_sys_Setting]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_CompanySetting]'))
ALTER TABLE [dbo].[sys_CompanySetting] CHECK CONSTRAINT [FK_sys_CompanySetting_sys_Setting]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_CompanySetting_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_CompanySetting]'))
ALTER TABLE [dbo].[sys_CompanySetting]  WITH CHECK ADD  CONSTRAINT [FK_sys_CompanySetting_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_CompanySetting_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_CompanySetting]'))
ALTER TABLE [dbo].[sys_CompanySetting] CHECK CONSTRAINT [FK_sys_CompanySetting_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_EnumReference_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_EnumReference]'))
ALTER TABLE [dbo].[sys_EnumReference]  WITH NOCHECK ADD  CONSTRAINT [FK_sys_EnumReference_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_EnumReference_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_EnumReference]'))
ALTER TABLE [dbo].[sys_EnumReference] CHECK CONSTRAINT [FK_sys_EnumReference_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_ErrorLogs_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_ErrorLogs]'))
ALTER TABLE [dbo].[sys_ErrorLogs]  WITH CHECK ADD  CONSTRAINT [FK_sys_ErrorLogs_sys_User] FOREIGN KEY([createdBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_ErrorLogs_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_ErrorLogs]'))
ALTER TABLE [dbo].[sys_ErrorLogs] CHECK CONSTRAINT [FK_sys_ErrorLogs_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_IdentificationDocument_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_IdentificationDocument]'))
ALTER TABLE [dbo].[sys_IdentificationDocument]  WITH CHECK ADD  CONSTRAINT [FK_sys_IdentificationDocument_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_IdentificationDocument_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_IdentificationDocument]'))
ALTER TABLE [dbo].[sys_IdentificationDocument] CHECK CONSTRAINT [FK_sys_IdentificationDocument_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Location_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Location]'))
ALTER TABLE [dbo].[sys_Location]  WITH CHECK ADD  CONSTRAINT [FK_sys_Location_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Location_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Location]'))
ALTER TABLE [dbo].[sys_Location] CHECK CONSTRAINT [FK_sys_Location_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Location_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Location]'))
ALTER TABLE [dbo].[sys_Location]  WITH CHECK ADD  CONSTRAINT [FK_sys_Location_sys_User1] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Location_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Location]'))
ALTER TABLE [dbo].[sys_Location] CHECK CONSTRAINT [FK_sys_Location_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Menu_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Menu]'))
ALTER TABLE [dbo].[sys_Menu]  WITH CHECK ADD  CONSTRAINT [FK_sys_Menu_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Menu_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Menu]'))
ALTER TABLE [dbo].[sys_Menu] CHECK CONSTRAINT [FK_sys_Menu_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Permission_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Permission]'))
ALTER TABLE [dbo].[sys_Permission]  WITH CHECK ADD  CONSTRAINT [FK_sys_Permission_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Permission_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Permission]'))
ALTER TABLE [dbo].[sys_Permission] CHECK CONSTRAINT [FK_sys_Permission_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Permission_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Permission]'))
ALTER TABLE [dbo].[sys_Permission]  WITH CHECK ADD  CONSTRAINT [FK_sys_Permission_sys_User1] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Permission_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Permission]'))
ALTER TABLE [dbo].[sys_Permission] CHECK CONSTRAINT [FK_sys_Permission_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Role_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Role]'))
ALTER TABLE [dbo].[sys_Role]  WITH CHECK ADD  CONSTRAINT [FK_sys_Role_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Role_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Role]'))
ALTER TABLE [dbo].[sys_Role] CHECK CONSTRAINT [FK_sys_Role_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Role_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Role]'))
ALTER TABLE [dbo].[sys_Role]  WITH CHECK ADD  CONSTRAINT [FK_sys_Role_sys_User1] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_Role_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_Role]'))
ALTER TABLE [dbo].[sys_Role] CHECK CONSTRAINT [FK_sys_Role_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RoleMenu_sys_Menu]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RoleMenu]'))
ALTER TABLE [dbo].[sys_RoleMenu]  WITH CHECK ADD  CONSTRAINT [FK_sys_RoleMenu_sys_Menu] FOREIGN KEY([sourceMenuId])
REFERENCES [dbo].[sys_Menu] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RoleMenu_sys_Menu]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RoleMenu]'))
ALTER TABLE [dbo].[sys_RoleMenu] CHECK CONSTRAINT [FK_sys_RoleMenu_sys_Menu]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RoleMenu_sys_Role]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RoleMenu]'))
ALTER TABLE [dbo].[sys_RoleMenu]  WITH CHECK ADD  CONSTRAINT [FK_sys_RoleMenu_sys_Role] FOREIGN KEY([roleId])
REFERENCES [dbo].[sys_Role] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RoleMenu_sys_Role]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RoleMenu]'))
ALTER TABLE [dbo].[sys_RoleMenu] CHECK CONSTRAINT [FK_sys_RoleMenu_sys_Role]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RoleMenu_sys_RoleMenu]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RoleMenu]'))
ALTER TABLE [dbo].[sys_RoleMenu]  WITH CHECK ADD  CONSTRAINT [FK_sys_RoleMenu_sys_RoleMenu] FOREIGN KEY([parentRoleMenuId])
REFERENCES [dbo].[sys_RoleMenu] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RoleMenu_sys_RoleMenu]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RoleMenu]'))
ALTER TABLE [dbo].[sys_RoleMenu] CHECK CONSTRAINT [FK_sys_RoleMenu_sys_RoleMenu]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RoleMenu_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RoleMenu]'))
ALTER TABLE [dbo].[sys_RoleMenu]  WITH CHECK ADD  CONSTRAINT [FK_sys_RoleMenu_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RoleMenu_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RoleMenu]'))
ALTER TABLE [dbo].[sys_RoleMenu] CHECK CONSTRAINT [FK_sys_RoleMenu_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RolePermission_sys_Permission]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RolePermission]'))
ALTER TABLE [dbo].[sys_RolePermission]  WITH CHECK ADD  CONSTRAINT [FK_sys_RolePermission_sys_Permission] FOREIGN KEY([permissionId])
REFERENCES [dbo].[sys_Permission] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RolePermission_sys_Permission]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RolePermission]'))
ALTER TABLE [dbo].[sys_RolePermission] CHECK CONSTRAINT [FK_sys_RolePermission_sys_Permission]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RolePermission_sys_Role]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RolePermission]'))
ALTER TABLE [dbo].[sys_RolePermission]  WITH CHECK ADD  CONSTRAINT [FK_sys_RolePermission_sys_Role] FOREIGN KEY([roleId])
REFERENCES [dbo].[sys_Role] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RolePermission_sys_Role]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RolePermission]'))
ALTER TABLE [dbo].[sys_RolePermission] CHECK CONSTRAINT [FK_sys_RolePermission_sys_Role]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RolePermission_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RolePermission]'))
ALTER TABLE [dbo].[sys_RolePermission]  WITH CHECK ADD  CONSTRAINT [FK_sys_RolePermission_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_RolePermission_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_RolePermission]'))
ALTER TABLE [dbo].[sys_RolePermission] CHECK CONSTRAINT [FK_sys_RolePermission_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_User_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_User]'))
ALTER TABLE [dbo].[sys_User]  WITH CHECK ADD  CONSTRAINT [FK_sys_User_mf_Employee] FOREIGN KEY([employeeId])
REFERENCES [dbo].[mf_Employee] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_User_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_User]'))
ALTER TABLE [dbo].[sys_User] CHECK CONSTRAINT [FK_sys_User_mf_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_User_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_User]'))
ALTER TABLE [dbo].[sys_User]  WITH CHECK ADD  CONSTRAINT [FK_sys_User_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_User_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_User]'))
ALTER TABLE [dbo].[sys_User] CHECK CONSTRAINT [FK_sys_User_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_User_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_User]'))
ALTER TABLE [dbo].[sys_User]  WITH CHECK ADD  CONSTRAINT [FK_sys_User_sys_User1] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_User_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_User]'))
ALTER TABLE [dbo].[sys_User] CHECK CONSTRAINT [FK_sys_User_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_UserRole_sys_Role]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_UserRole]'))
ALTER TABLE [dbo].[sys_UserRole]  WITH CHECK ADD  CONSTRAINT [FK_sys_UserRole_sys_Role] FOREIGN KEY([roleId])
REFERENCES [dbo].[sys_Role] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_UserRole_sys_Role]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_UserRole]'))
ALTER TABLE [dbo].[sys_UserRole] CHECK CONSTRAINT [FK_sys_UserRole_sys_Role]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_UserRole_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_UserRole]'))
ALTER TABLE [dbo].[sys_UserRole]  WITH CHECK ADD  CONSTRAINT [FK_sys_UserRole_sys_User] FOREIGN KEY([userId])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_UserRole_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_UserRole]'))
ALTER TABLE [dbo].[sys_UserRole] CHECK CONSTRAINT [FK_sys_UserRole_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_UserRole_sys_User2]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_UserRole]'))
ALTER TABLE [dbo].[sys_UserRole]  WITH CHECK ADD  CONSTRAINT [FK_sys_UserRole_sys_User2] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_UserRole_sys_User2]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_UserRole]'))
ALTER TABLE [dbo].[sys_UserRole] CHECK CONSTRAINT [FK_sys_UserRole_sys_User2]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_UserSession_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_UserSession]'))
ALTER TABLE [dbo].[sys_UserSession]  WITH CHECK ADD  CONSTRAINT [FK_sys_UserSession_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_UserSession_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_UserSession]'))
ALTER TABLE [dbo].[sys_UserSession] CHECK CONSTRAINT [FK_sys_UserSession_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_UserSession_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_UserSession]'))
ALTER TABLE [dbo].[sys_UserSession]  WITH CHECK ADD  CONSTRAINT [FK_sys_UserSession_sys_User] FOREIGN KEY([userId])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_sys_UserSession_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[sys_UserSession]'))
ALTER TABLE [dbo].[sys_UserSession] CHECK CONSTRAINT [FK_sys_UserSession_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequest_mf_ApplicationRequestType]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequest]'))
ALTER TABLE [dbo].[ta_ApplicationRequest]  WITH CHECK ADD  CONSTRAINT [FK_ta_ApplicationRequest_mf_ApplicationRequestType] FOREIGN KEY([applicationRequestTypeId])
REFERENCES [dbo].[mf_ApplicationRequestType] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequest_mf_ApplicationRequestType]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequest]'))
ALTER TABLE [dbo].[ta_ApplicationRequest] CHECK CONSTRAINT [FK_ta_ApplicationRequest_mf_ApplicationRequestType]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequest_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequest]'))
ALTER TABLE [dbo].[ta_ApplicationRequest]  WITH CHECK ADD  CONSTRAINT [FK_ta_ApplicationRequest_sys_User] FOREIGN KEY([assignTo])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequest_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequest]'))
ALTER TABLE [dbo].[ta_ApplicationRequest] CHECK CONSTRAINT [FK_ta_ApplicationRequest_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequest_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequest]'))
ALTER TABLE [dbo].[ta_ApplicationRequest]  WITH CHECK ADD  CONSTRAINT [FK_ta_ApplicationRequest_sys_User1] FOREIGN KEY([requestedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequest_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequest]'))
ALTER TABLE [dbo].[ta_ApplicationRequest] CHECK CONSTRAINT [FK_ta_ApplicationRequest_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequest_sys_User2]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequest]'))
ALTER TABLE [dbo].[ta_ApplicationRequest]  WITH CHECK ADD  CONSTRAINT [FK_ta_ApplicationRequest_sys_User2] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequest_sys_User2]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequest]'))
ALTER TABLE [dbo].[ta_ApplicationRequest] CHECK CONSTRAINT [FK_ta_ApplicationRequest_sys_User2]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequestApprover_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestApprover]'))
ALTER TABLE [dbo].[ta_ApplicationRequestApprover]  WITH CHECK ADD  CONSTRAINT [FK_ta_ApplicationRequestApprover_sys_User] FOREIGN KEY([approverId])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequestApprover_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestApprover]'))
ALTER TABLE [dbo].[ta_ApplicationRequestApprover] CHECK CONSTRAINT [FK_ta_ApplicationRequestApprover_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequestApprover_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestApprover]'))
ALTER TABLE [dbo].[ta_ApplicationRequestApprover]  WITH CHECK ADD  CONSTRAINT [FK_ta_ApplicationRequestApprover_sys_User1] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequestApprover_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestApprover]'))
ALTER TABLE [dbo].[ta_ApplicationRequestApprover] CHECK CONSTRAINT [FK_ta_ApplicationRequestApprover_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequestApprover_ta_ApplicationRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestApprover]'))
ALTER TABLE [dbo].[ta_ApplicationRequestApprover]  WITH CHECK ADD  CONSTRAINT [FK_ta_ApplicationRequestApprover_ta_ApplicationRequest] FOREIGN KEY([applicationRequestId])
REFERENCES [dbo].[ta_ApplicationRequest] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequestApprover_ta_ApplicationRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestApprover]'))
ALTER TABLE [dbo].[ta_ApplicationRequestApprover] CHECK CONSTRAINT [FK_ta_ApplicationRequestApprover_ta_ApplicationRequest]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequestGatePass_ta_ApplicationRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestGatePass]'))
ALTER TABLE [dbo].[ta_ApplicationRequestGatePass]  WITH CHECK ADD  CONSTRAINT [FK_ta_ApplicationRequestGatePass_ta_ApplicationRequest] FOREIGN KEY([applicationRequestId])
REFERENCES [dbo].[ta_ApplicationRequest] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequestGatePass_ta_ApplicationRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestGatePass]'))
ALTER TABLE [dbo].[ta_ApplicationRequestGatePass] CHECK CONSTRAINT [FK_ta_ApplicationRequestGatePass_ta_ApplicationRequest]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequestLeave_ta_ApplicationRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestLeave]'))
ALTER TABLE [dbo].[ta_ApplicationRequestLeave]  WITH CHECK ADD  CONSTRAINT [FK_ta_ApplicationRequestLeave_ta_ApplicationRequest] FOREIGN KEY([applicationRequestId])
REFERENCES [dbo].[ta_ApplicationRequest] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_ApplicationRequestLeave_ta_ApplicationRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_ApplicationRequestLeave]'))
ALTER TABLE [dbo].[ta_ApplicationRequestLeave] CHECK CONSTRAINT [FK_ta_ApplicationRequestLeave_ta_ApplicationRequest]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendance_mf_PayrollGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendance]'))
ALTER TABLE [dbo].[ta_CutOffAttendance]  WITH CHECK ADD  CONSTRAINT [FK_ta_CutOffAttendance_mf_PayrollGroup] FOREIGN KEY([payrollGroupId])
REFERENCES [dbo].[mf_PayrollGroup] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendance_mf_PayrollGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendance]'))
ALTER TABLE [dbo].[ta_CutOffAttendance] CHECK CONSTRAINT [FK_ta_CutOffAttendance_mf_PayrollGroup]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendance_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendance]'))
ALTER TABLE [dbo].[ta_CutOffAttendance]  WITH CHECK ADD  CONSTRAINT [FK_ta_CutOffAttendance_sys_Company] FOREIGN KEY([companyId])
REFERENCES [dbo].[sys_Company] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendance_sys_Company]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendance]'))
ALTER TABLE [dbo].[ta_CutOffAttendance] CHECK CONSTRAINT [FK_ta_CutOffAttendance_sys_Company]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendance_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendance]'))
ALTER TABLE [dbo].[ta_CutOffAttendance]  WITH CHECK ADD  CONSTRAINT [FK_ta_CutOffAttendance_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendance_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendance]'))
ALTER TABLE [dbo].[ta_CutOffAttendance] CHECK CONSTRAINT [FK_ta_CutOffAttendance_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendance_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendance]'))
ALTER TABLE [dbo].[ta_CutOffAttendance]  WITH CHECK ADD  CONSTRAINT [FK_ta_CutOffAttendance_sys_User1] FOREIGN KEY([changeStatusBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendance_sys_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendance]'))
ALTER TABLE [dbo].[ta_CutOffAttendance] CHECK CONSTRAINT [FK_ta_CutOffAttendance_sys_User1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummary_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummary]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummary]  WITH CHECK ADD  CONSTRAINT [FK_ta_CutOffAttendanceSummary_mf_Employee] FOREIGN KEY([employeeId])
REFERENCES [dbo].[mf_Employee] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummary_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummary]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummary] CHECK CONSTRAINT [FK_ta_CutOffAttendanceSummary_mf_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummary_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummary]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummary]  WITH CHECK ADD  CONSTRAINT [FK_ta_CutOffAttendanceSummary_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummary_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummary]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummary] CHECK CONSTRAINT [FK_ta_CutOffAttendanceSummary_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummary_ta_CutOffAttendance]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummary]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummary]  WITH CHECK ADD  CONSTRAINT [FK_ta_CutOffAttendanceSummary_ta_CutOffAttendance] FOREIGN KEY([cutOffAttendanceId])
REFERENCES [dbo].[ta_CutOffAttendance] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummary_ta_CutOffAttendance]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummary]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummary] CHECK CONSTRAINT [FK_ta_CutOffAttendanceSummary_ta_CutOffAttendance]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummaryDetail_mf_HolidayType]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummaryDetail]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummaryDetail]  WITH CHECK ADD  CONSTRAINT [FK_ta_CutOffAttendanceSummaryDetail_mf_HolidayType] FOREIGN KEY([holidayTypeId])
REFERENCES [dbo].[mf_HolidayType] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummaryDetail_mf_HolidayType]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummaryDetail]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummaryDetail] CHECK CONSTRAINT [FK_ta_CutOffAttendanceSummaryDetail_mf_HolidayType]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummaryDetail_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummaryDetail]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummaryDetail]  WITH CHECK ADD  CONSTRAINT [FK_ta_CutOffAttendanceSummaryDetail_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummaryDetail_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummaryDetail]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummaryDetail] CHECK CONSTRAINT [FK_ta_CutOffAttendanceSummaryDetail_sys_User]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummaryDetail_ta_CutOffAttendanceSummary]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummaryDetail]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummaryDetail]  WITH CHECK ADD  CONSTRAINT [FK_ta_CutOffAttendanceSummaryDetail_ta_CutOffAttendanceSummary] FOREIGN KEY([cutOffAttendanceSummaryId])
REFERENCES [dbo].[ta_CutOffAttendanceSummary] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_CutOffAttendanceSummaryDetail_ta_CutOffAttendanceSummary]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_CutOffAttendanceSummaryDetail]'))
ALTER TABLE [dbo].[ta_CutOffAttendanceSummaryDetail] CHECK CONSTRAINT [FK_ta_CutOffAttendanceSummaryDetail_ta_CutOffAttendanceSummary]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_EmployeeAttendance_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_EmployeeAttendance]'))
ALTER TABLE [dbo].[ta_EmployeeAttendance]  WITH CHECK ADD  CONSTRAINT [FK_ta_EmployeeAttendance_mf_Employee] FOREIGN KEY([employeeId])
REFERENCES [dbo].[mf_Employee] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_EmployeeAttendance_mf_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_EmployeeAttendance]'))
ALTER TABLE [dbo].[ta_EmployeeAttendance] CHECK CONSTRAINT [FK_ta_EmployeeAttendance_mf_Employee]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_EmployeeAttendance_mf_WorkDays]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_EmployeeAttendance]'))
ALTER TABLE [dbo].[ta_EmployeeAttendance]  WITH CHECK ADD  CONSTRAINT [FK_ta_EmployeeAttendance_mf_WorkDays] FOREIGN KEY([workDayId])
REFERENCES [dbo].[mf_WorkDays] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_EmployeeAttendance_mf_WorkDays]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_EmployeeAttendance]'))
ALTER TABLE [dbo].[ta_EmployeeAttendance] CHECK CONSTRAINT [FK_ta_EmployeeAttendance_mf_WorkDays]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_EmployeeAttendance_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_EmployeeAttendance]'))
ALTER TABLE [dbo].[ta_EmployeeAttendance]  WITH CHECK ADD  CONSTRAINT [FK_ta_EmployeeAttendance_sys_User] FOREIGN KEY([updatedBy])
REFERENCES [dbo].[sys_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ta_EmployeeAttendance_sys_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[ta_EmployeeAttendance]'))
ALTER TABLE [dbo].[ta_EmployeeAttendance] CHECK CONSTRAINT [FK_ta_EmployeeAttendance_sys_User]
GO
