namespace HRIS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.mf_Agency",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.mf_Employee201",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employeeCode = c.String(nullable: false, maxLength: 250),
                        departmentId = c.Int(),
                        departmentSectionId = c.Int(),
                        positionId = c.Int(),
                        email = c.String(maxLength: 150),
                        employmentTypeId = c.Int(),
                        employmentStatusId = c.Int(),
                        positionLevel = c.Int(),
                        dateHired = c.DateTime(),
                        resignedDate = c.DateTime(),
                        taxStatus = c.Int(),
                        timeSheetRequired = c.Boolean(),
                        entitledUnworkRegularHoliday = c.Boolean(),
                        entitledUnworkSpecialHoliday = c.Boolean(),
                        entitledOvertime = c.Boolean(),
                        entitledHolidayPay = c.Boolean(),
                        payrollGroupId = c.Int(),
                        agencyId = c.Int(),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        confidential = c.Boolean(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Agency", t => t.agencyId)
                .ForeignKey("dbo.mf_Department", t => t.departmentId)
                .ForeignKey("dbo.mf_DepartmentSection", t => t.departmentSectionId)
                .ForeignKey("dbo.mf_EmploymentStatus", t => t.employmentStatusId)
                .ForeignKey("dbo.mf_EmploymentType", t => t.employmentTypeId)
                .ForeignKey("dbo.mf_PayrollGroup", t => t.payrollGroupId)
                .ForeignKey("dbo.mf_Position", t => t.positionId)
                .Index(t => t.departmentId)
                .Index(t => t.departmentSectionId)
                .Index(t => t.positionId)
                .Index(t => t.employmentTypeId)
                .Index(t => t.employmentStatusId)
                .Index(t => t.payrollGroupId)
                .Index(t => t.agencyId);
            
            CreateTable(
                "dbo.mf_Department",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.mf_DepartmentSection",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        departmentId = c.Int(nullable: false),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Department", t => t.departmentId)
                .Index(t => t.departmentId);
            
            CreateTable(
                "dbo.mf_DepartmentSectionRequestApprover",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        approverId = c.Int(nullable: false),
                        departmentSectionId = c.Int(nullable: false),
                        applicationRequestTypeId = c.Int(nullable: false),
                        orderNo = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_ApplicationRequestType", t => t.applicationRequestTypeId)
                .ForeignKey("dbo.mf_DepartmentSection", t => t.departmentSectionId)
                .Index(t => t.departmentSectionId)
                .Index(t => t.applicationRequestTypeId);
            
            CreateTable(
                "dbo.mf_ApplicationRequestType",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        requiredLeavePoints = c.Boolean(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.mf_EmployeeBalanceLeave",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employeeId = c.Int(nullable: false),
                        balance = c.Double(nullable: false),
                        applicationRequestTypeId = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_ApplicationRequestType", t => t.applicationRequestTypeId)
                .ForeignKey("dbo.mf_Employee", t => t.employeeId)
                .Index(t => t.employeeId)
                .Index(t => t.applicationRequestTypeId);
            
            CreateTable(
                "dbo.mf_Employee",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        firstName = c.String(nullable: false, maxLength: 50),
                        lastName = c.String(nullable: false, maxLength: 50),
                        middleName = c.String(maxLength: 50),
                        birthDate = c.DateTime(),
                        email = c.String(maxLength: 100),
                        gender = c.Int(),
                        maritalStatus = c.Int(),
                        contact1 = c.String(maxLength: 50),
                        contact2 = c.String(maxLength: 50),
                        contact3 = c.String(maxLength: 50),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        employeeAddressId = c.Int(),
                        employee201Id = c.Int(),
                        pictureExtension = c.String(maxLength: 50),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Employee201", t => t.employee201Id)
                .ForeignKey("dbo.mf_EmployeeAddress", t => t.employeeAddressId)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .Index(t => t.employeeAddressId)
                .Index(t => t.employee201Id)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.mf_EmployeeAddress",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        address1 = c.String(maxLength: 4000),
                        address2 = c.String(maxLength: 4000),
                        address3 = c.String(maxLength: 4000),
                        countryId = c.Int(nullable: false),
                        city = c.String(maxLength: 150),
                        postalCode = c.String(maxLength: 50),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Country", t => t.countryId)
                .Index(t => t.countryId);
            
            CreateTable(
                "dbo.mf_Country",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.sys_Company",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        businessName = c.String(nullable: false, maxLength: 250),
                        address1 = c.String(maxLength: 4000),
                        address2 = c.String(maxLength: 4000),
                        address3 = c.String(maxLength: 4000),
                        countryId = c.Int(nullable: false),
                        city = c.String(maxLength: 150),
                        postalCode = c.String(maxLength: 50),
                        email = c.String(maxLength: 50),
                        telephone = c.String(maxLength: 50),
                        mobile = c.String(maxLength: 50),
                        fax = c.String(maxLength: 50),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Country", t => t.countryId)
                .Index(t => t.countryId);
            
            CreateTable(
                "dbo.mf_Allowance",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        isTaxable = c.Boolean(nullable: false),
                        description = c.String(nullable: false, maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.mf_EmployeeAllowance",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employeeId = c.Int(nullable: false),
                        allowanceId = c.Int(nullable: false),
                        amount = c.Double(),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Allowance", t => t.allowanceId)
                .ForeignKey("dbo.mf_Employee", t => t.employeeId)
                .Index(t => t.employeeId)
                .Index(t => t.allowanceId);
            
            CreateTable(
                "dbo.pr_PayrollEmployeeEarnings",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        payrollEmployeeId = c.Int(nullable: false),
                        allowanceId = c.Int(),
                        paySlipDetail = c.Int(),
                        value = c.Double(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Allowance", t => t.allowanceId)
                .ForeignKey("dbo.pr_PayrollEmployee", t => t.payrollEmployeeId)
                .Index(t => t.payrollEmployeeId)
                .Index(t => t.allowanceId);
            
            CreateTable(
                "dbo.pr_PayrollEmployee",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        payrollId = c.Int(nullable: false),
                        employeeId = c.Int(nullable: false),
                        noOfDays = c.Double(nullable: false),
                        totalHours = c.Double(nullable: false),
                        hourlyRates = c.Double(nullable: false),
                        payRateType = c.Int(nullable: false),
                        basicRate = c.Double(nullable: false),
                        totalDeduction = c.Double(nullable: false),
                        totalIncome = c.Double(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Employee", t => t.employeeId)
                .ForeignKey("dbo.pr_Payroll", t => t.payrollId)
                .Index(t => t.payrollId)
                .Index(t => t.employeeId);
            
            CreateTable(
                "dbo.pr_Payroll",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cutOffAttendanceId = c.Int(nullable: false),
                        status = c.Int(nullable: false),
                        includeLegalDeduction = c.Boolean(nullable: false),
                        generatedBy = c.Int(nullable: false),
                        generatedDate = c.DateTime(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .ForeignKey("dbo.ta_CutOffAttendance", t => t.cutOffAttendanceId)
                .Index(t => t.cutOffAttendanceId)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.ta_CutOffAttendance",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        payrollGroupId = c.Int(nullable: false),
                        generatedDate = c.DateTime(nullable: false),
                        startDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(nullable: false),
                        status = c.Int(nullable: false),
                        remarks = c.String(maxLength: 4000),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        changeStatusBy = c.Int(nullable: false),
                        changeStatusDate = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                        sys_User_changeStatusBy_id = c.Int(),
                        sys_User_updatedBy_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_PayrollGroup", t => t.payrollGroupId)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .ForeignKey("dbo.sys_User", t => t.sys_User_changeStatusBy_id)
                .ForeignKey("dbo.sys_User", t => t.sys_User_updatedBy_id)
                .Index(t => t.payrollGroupId)
                .Index(t => t.companyId)
                .Index(t => t.sys_User_changeStatusBy_id)
                .Index(t => t.sys_User_updatedBy_id);
            
            CreateTable(
                "dbo.mf_PayrollGroup",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.sys_User",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        username = c.String(nullable: false, maxLength: 50),
                        password = c.String(maxLength: 4000),
                        hashKey = c.String(maxLength: 4000),
                        vector = c.String(maxLength: 4000),
                        email = c.String(maxLength: 50),
                        employeeId = c.Int(),
                        status = c.Int(nullable: false),
                        updatedBy = c.Int(),
                        updatedDate = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                        sys_Company_id = c.Int(),
                        mf_Employee_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.sys_Company_id)
                .ForeignKey("dbo.mf_Employee", t => t.mf_Employee_id)
                .Index(t => t.sys_Company_id)
                .Index(t => t.mf_Employee_id);
            
            CreateTable(
                "dbo.ta_CutOffAttendanceSummary",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cutOffAttendanceId = c.Int(nullable: false),
                        employeeId = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Employee", t => t.employeeId)
                .ForeignKey("dbo.ta_CutOffAttendance", t => t.cutOffAttendanceId)
                .Index(t => t.cutOffAttendanceId)
                .Index(t => t.employeeId);
            
            CreateTable(
                "dbo.ta_CutOffAttendanceSummaryDetail",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cutOffAttendanceSummaryId = c.Int(nullable: false),
                        workDate = c.DateTime(nullable: false),
                        workHours = c.Double(nullable: false),
                        undertimeHours = c.Double(nullable: false),
                        lateHours = c.Double(nullable: false),
                        overtimeHours = c.Double(nullable: false),
                        workHolidayHours = c.Double(),
                        holidayTypeId = c.Int(),
                        absent = c.Boolean(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_HolidayType", t => t.holidayTypeId)
                .ForeignKey("dbo.ta_CutOffAttendanceSummary", t => t.cutOffAttendanceSummaryId)
                .Index(t => t.cutOffAttendanceSummaryId)
                .Index(t => t.holidayTypeId);
            
            CreateTable(
                "dbo.mf_HolidayType",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        rateNotWork = c.Double(nullable: false),
                        rateWork = c.Double(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.mf_Holidays",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        holidayDate = c.DateTime(nullable: false),
                        description = c.String(nullable: false, maxLength: 250),
                        holidayTypeId = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_HolidayType", t => t.holidayTypeId)
                .Index(t => t.holidayTypeId);
            
            CreateTable(
                "dbo.pr_PayrollEmployeeDeductions",
                c => new
                    {
                        id = c.Int(nullable: false),
                        payrollEmployeeId = c.Int(nullable: false),
                        deductionId = c.Int(),
                        paySlipDetail = c.Int(),
                        value = c.Double(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Deduction", t => t.deductionId)
                .ForeignKey("dbo.pr_PayrollEmployee", t => t.payrollEmployeeId)
                .Index(t => t.payrollEmployeeId)
                .Index(t => t.deductionId);
            
            CreateTable(
                "dbo.mf_Deduction",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.mf_EmployeeDeduction",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employeeId = c.Int(nullable: false),
                        deductionId = c.Int(nullable: false),
                        amount = c.Double(),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Deduction", t => t.deductionId)
                .ForeignKey("dbo.mf_Employee", t => t.employeeId)
                .Index(t => t.employeeId)
                .Index(t => t.deductionId);
            
            CreateTable(
                "dbo.mf_Offense",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.mf_EmployeeOffense",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employeeId = c.Int(nullable: false),
                        offenseId = c.Int(nullable: false),
                        offenseDate = c.DateTime(nullable: false),
                        memoDate = c.DateTime(),
                        penaltyTypeId = c.Int(nullable: false),
                        frequency = c.Int(nullable: false),
                        degree = c.Int(nullable: false),
                        startDate = c.DateTime(),
                        endDate = c.DateTime(),
                        remarks = c.String(nullable: false, maxLength: 4000),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Employee", t => t.employeeId)
                .ForeignKey("dbo.mf_Offense", t => t.offenseId)
                .ForeignKey("dbo.mf_PenaltyType", t => t.penaltyTypeId)
                .Index(t => t.employeeId)
                .Index(t => t.offenseId)
                .Index(t => t.penaltyTypeId);
            
            CreateTable(
                "dbo.mf_PenaltyType",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.mf_Position",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.mf_WorkDays",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        monday = c.Boolean(nullable: false),
                        tuesday = c.Boolean(nullable: false),
                        wednesday = c.Boolean(nullable: false),
                        thursday = c.Boolean(nullable: false),
                        friday = c.Boolean(nullable: false),
                        saturday = c.Boolean(nullable: false),
                        sunday = c.Boolean(nullable: false),
                        fromTimeHour = c.Int(nullable: false),
                        fromTimeMinute = c.Int(nullable: false),
                        toTimeHour = c.Int(nullable: false),
                        toTimeMinute = c.Int(nullable: false),
                        breakHours = c.Double(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.mf_EmployeeWorkDays",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employeeId = c.Int(nullable: false),
                        workDayId = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Employee", t => t.employeeId)
                .ForeignKey("dbo.mf_WorkDays", t => t.workDayId)
                .Index(t => t.employeeId)
                .Index(t => t.workDayId);
            
            CreateTable(
                "dbo.ta_EmployeeAttendance",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employeeId = c.Int(nullable: false),
                        timeLogType = c.Int(nullable: false),
                        workDate = c.DateTime(nullable: false),
                        timeLog = c.DateTime(nullable: false),
                        workDayId = c.Int(),
                        remarks = c.String(maxLength: 4000),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Employee", t => t.employeeId)
                .ForeignKey("dbo.mf_WorkDays", t => t.workDayId)
                .Index(t => t.employeeId)
                .Index(t => t.workDayId);
            
            CreateTable(
                "dbo.sys_CompanySetting",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        settingId = c.Int(nullable: false),
                        companyId = c.Int(),
                        value = c.String(nullable: false, maxLength: 4000),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .ForeignKey("dbo.sys_Setting", t => t.settingId)
                .Index(t => t.settingId)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.sys_Setting",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 150),
                        description = c.String(maxLength: 500),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.sys_EnumReference",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        value = c.Int(nullable: false),
                        description = c.String(nullable: false, maxLength: 250),
                        displayOrder = c.Int(nullable: false),
                        hidden = c.Boolean(nullable: false),
                        field1 = c.String(maxLength: 250),
                        field2 = c.String(maxLength: 250),
                        field3 = c.String(maxLength: 250),
                        field4 = c.String(maxLength: 250),
                        field5 = c.String(maxLength: 250),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.sys_Location",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.sys_Permission",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.sys_RolePermission",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        roleId = c.Int(nullable: false),
                        permissionId = c.Int(nullable: false),
                        viewAccess = c.Boolean(nullable: false),
                        createAccess = c.Boolean(nullable: false),
                        updateAccess = c.Boolean(nullable: false),
                        deleteAccess = c.Boolean(nullable: false),
                        printAccess = c.Boolean(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Permission", t => t.permissionId)
                .ForeignKey("dbo.sys_Role", t => t.roleId)
                .Index(t => t.roleId)
                .Index(t => t.permissionId);
            
            CreateTable(
                "dbo.sys_Role",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.sys_RoleMenu",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        roleId = c.Int(nullable: false),
                        sourceMenuId = c.Int(nullable: false),
                        description = c.String(nullable: false, maxLength: 250),
                        parentRoleMenuId = c.Int(),
                        displayOrder = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Menu", t => t.sourceMenuId)
                .ForeignKey("dbo.sys_Role", t => t.roleId)
                .ForeignKey("dbo.sys_RoleMenu", t => t.parentRoleMenuId)
                .Index(t => t.roleId)
                .Index(t => t.sourceMenuId)
                .Index(t => t.parentRoleMenuId);
            
            CreateTable(
                "dbo.sys_Menu",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        description = c.String(nullable: false, maxLength: 250),
                        controllerName = c.String(maxLength: 250),
                        actionName = c.String(maxLength: 150),
                        areaName = c.String(maxLength: 150),
                        parameter = c.String(maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.sys_UserRole",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        roleId = c.Int(nullable: false),
                        userId = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Role", t => t.roleId)
                .Index(t => t.roleId);
            
            CreateTable(
                "dbo.sys_UserSession",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                        loggedDate = c.DateTime(nullable: false),
                        ipAddress = c.String(nullable: false, maxLength: 50),
                        expiredDate = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_Company", t => t.companyId)
                .Index(t => t.companyId);
            
            CreateTable(
                "dbo.mf_EmployeeBasicPay",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employeeId = c.Int(nullable: false),
                        basicPay = c.Double(nullable: false),
                        rateType = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Employee", t => t.employeeId)
                .Index(t => t.employeeId);
            
            CreateTable(
                "dbo.mf_EmployeeEducation",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employeeId = c.Int(nullable: false),
                        schoolName = c.String(nullable: false, maxLength: 250),
                        fromYear = c.Int(),
                        toYear = c.Int(),
                        isGraduated = c.Boolean(),
                        course = c.String(maxLength: 250),
                        createdBy = c.Int(nullable: false),
                        createdDate = c.DateTime(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Employee", t => t.employeeId)
                .Index(t => t.employeeId);
            
            CreateTable(
                "dbo.mf_EmployeeIdentificationDocument",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employeeId = c.Int(nullable: false),
                        identificationDocumentId = c.Int(nullable: false),
                        idNumber = c.String(nullable: false, maxLength: 150),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Employee", t => t.employeeId)
                .ForeignKey("dbo.sys_IdentificationDocument", t => t.identificationDocumentId)
                .Index(t => t.employeeId)
                .Index(t => t.identificationDocumentId);
            
            CreateTable(
                "dbo.sys_IdentificationDocument",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.mf_EmployeeSkill",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employeeId = c.Int(nullable: false),
                        skillName = c.String(nullable: false, maxLength: 250),
                        skillProficiencyLevel = c.Int(),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Employee", t => t.employeeId)
                .Index(t => t.employeeId);
            
            CreateTable(
                "dbo.mf_EmployeeTraining",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employeeId = c.Int(nullable: false),
                        trainingDate = c.DateTime(nullable: false),
                        trainingName = c.String(nullable: false, maxLength: 250),
                        description = c.String(maxLength: 4000),
                        startDate = c.DateTime(),
                        endDate = c.DateTime(),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Employee", t => t.employeeId)
                .Index(t => t.employeeId);
            
            CreateTable(
                "dbo.mf_EmployeeWorkHistory",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        employeeId = c.Int(nullable: false),
                        companyName = c.String(nullable: false, maxLength: 250),
                        position = c.String(maxLength: 250),
                        joinedMonth = c.Int(nullable: false),
                        joinedYear = c.Int(nullable: false),
                        resignedMonth = c.Int(),
                        resignedYear = c.Int(),
                        isPresent = c.Boolean(),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_Employee", t => t.employeeId)
                .Index(t => t.employeeId);
            
            CreateTable(
                "dbo.ta_ApplicationRequest",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        applicationRequestTypeId = c.Int(nullable: false),
                        note = c.String(nullable: false, maxLength: 4000),
                        status = c.Int(nullable: false),
                        assignTo = c.Int(nullable: false),
                        requestedBy = c.Int(nullable: false),
                        requestedDate = c.DateTime(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.mf_ApplicationRequestType", t => t.applicationRequestTypeId)
                .Index(t => t.applicationRequestTypeId);
            
            CreateTable(
                "dbo.ta_ApplicationRequestApprover",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        applicationRequestId = c.Int(nullable: false),
                        approverId = c.Int(nullable: false),
                        status = c.Int(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                        sys_User_approverId_id = c.Int(),
                        sys_User_updatedBy_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sys_User", t => t.sys_User_approverId_id)
                .ForeignKey("dbo.sys_User", t => t.sys_User_updatedBy_id)
                .ForeignKey("dbo.ta_ApplicationRequest", t => t.applicationRequestId)
                .Index(t => t.applicationRequestId)
                .Index(t => t.sys_User_approverId_id)
                .Index(t => t.sys_User_updatedBy_id);
            
            CreateTable(
                "dbo.ta_ApplicationRequestGatePass",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        applicationRequestId = c.Int(nullable: false),
                        startDateTime = c.DateTime(nullable: false),
                        endDateTime = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ta_ApplicationRequest", t => t.applicationRequestId)
                .Index(t => t.applicationRequestId);
            
            CreateTable(
                "dbo.ta_ApplicationRequestLeave",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        applicationRequestId = c.Int(nullable: false),
                        startDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ta_ApplicationRequest", t => t.applicationRequestId)
                .Index(t => t.applicationRequestId);
            
            CreateTable(
                "dbo.mf_EmploymentStatus",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        allowProcessPayroll = c.Boolean(nullable: false),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.mf_EmploymentType",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 250),
                        updatedBy = c.Int(nullable: false),
                        updatedDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.sys_ErrorLogs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        message = c.String(maxLength: 4000),
                        innerException = c.String(maxLength: 4000),
                        loggedType = c.Int(nullable: false),
                        controllerName = c.String(maxLength: 250),
                        actionName = c.String(maxLength: 250),
                        areaName = c.String(maxLength: 250),
                        createdBy = c.Int(),
                        createdDate = c.DateTime(nullable: false),
                        deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.mf_Agency", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.mf_Employee201", "positionId", "dbo.mf_Position");
            DropForeignKey("dbo.mf_Employee201", "payrollGroupId", "dbo.mf_PayrollGroup");
            DropForeignKey("dbo.mf_Employee201", "employmentTypeId", "dbo.mf_EmploymentType");
            DropForeignKey("dbo.mf_Employee201", "employmentStatusId", "dbo.mf_EmploymentStatus");
            DropForeignKey("dbo.mf_Employee201", "departmentSectionId", "dbo.mf_DepartmentSection");
            DropForeignKey("dbo.mf_Employee201", "departmentId", "dbo.mf_Department");
            DropForeignKey("dbo.mf_Department", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.mf_DepartmentSectionRequestApprover", "departmentSectionId", "dbo.mf_DepartmentSection");
            DropForeignKey("dbo.mf_DepartmentSectionRequestApprover", "applicationRequestTypeId", "dbo.mf_ApplicationRequestType");
            DropForeignKey("dbo.ta_ApplicationRequestLeave", "applicationRequestId", "dbo.ta_ApplicationRequest");
            DropForeignKey("dbo.ta_ApplicationRequestGatePass", "applicationRequestId", "dbo.ta_ApplicationRequest");
            DropForeignKey("dbo.ta_ApplicationRequestApprover", "applicationRequestId", "dbo.ta_ApplicationRequest");
            DropForeignKey("dbo.ta_ApplicationRequestApprover", "sys_User_updatedBy_id", "dbo.sys_User");
            DropForeignKey("dbo.ta_ApplicationRequestApprover", "sys_User_approverId_id", "dbo.sys_User");
            DropForeignKey("dbo.ta_ApplicationRequest", "applicationRequestTypeId", "dbo.mf_ApplicationRequestType");
            DropForeignKey("dbo.mf_EmployeeBalanceLeave", "employeeId", "dbo.mf_Employee");
            DropForeignKey("dbo.sys_User", "mf_Employee_id", "dbo.mf_Employee");
            DropForeignKey("dbo.mf_Employee", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.mf_EmployeeWorkHistory", "employeeId", "dbo.mf_Employee");
            DropForeignKey("dbo.mf_EmployeeTraining", "employeeId", "dbo.mf_Employee");
            DropForeignKey("dbo.mf_EmployeeSkill", "employeeId", "dbo.mf_Employee");
            DropForeignKey("dbo.mf_EmployeeIdentificationDocument", "identificationDocumentId", "dbo.sys_IdentificationDocument");
            DropForeignKey("dbo.mf_EmployeeIdentificationDocument", "employeeId", "dbo.mf_Employee");
            DropForeignKey("dbo.mf_EmployeeEducation", "employeeId", "dbo.mf_Employee");
            DropForeignKey("dbo.mf_EmployeeBasicPay", "employeeId", "dbo.mf_Employee");
            DropForeignKey("dbo.mf_Employee", "employeeAddressId", "dbo.mf_EmployeeAddress");
            DropForeignKey("dbo.mf_EmployeeAddress", "countryId", "dbo.mf_Country");
            DropForeignKey("dbo.sys_UserSession", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.sys_User", "sys_Company_id", "dbo.sys_Company");
            DropForeignKey("dbo.sys_RolePermission", "roleId", "dbo.sys_Role");
            DropForeignKey("dbo.sys_UserRole", "roleId", "dbo.sys_Role");
            DropForeignKey("dbo.sys_RoleMenu", "parentRoleMenuId", "dbo.sys_RoleMenu");
            DropForeignKey("dbo.sys_RoleMenu", "roleId", "dbo.sys_Role");
            DropForeignKey("dbo.sys_RoleMenu", "sourceMenuId", "dbo.sys_Menu");
            DropForeignKey("dbo.sys_Role", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.sys_RolePermission", "permissionId", "dbo.sys_Permission");
            DropForeignKey("dbo.sys_Permission", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.sys_Location", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.sys_EnumReference", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.sys_CompanySetting", "settingId", "dbo.sys_Setting");
            DropForeignKey("dbo.sys_CompanySetting", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.ta_EmployeeAttendance", "workDayId", "dbo.mf_WorkDays");
            DropForeignKey("dbo.ta_EmployeeAttendance", "employeeId", "dbo.mf_Employee");
            DropForeignKey("dbo.mf_WorkDays", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.mf_EmployeeWorkDays", "workDayId", "dbo.mf_WorkDays");
            DropForeignKey("dbo.mf_EmployeeWorkDays", "employeeId", "dbo.mf_Employee");
            DropForeignKey("dbo.mf_Position", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.mf_Offense", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.mf_EmployeeOffense", "penaltyTypeId", "dbo.mf_PenaltyType");
            DropForeignKey("dbo.mf_PenaltyType", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.mf_EmployeeOffense", "offenseId", "dbo.mf_Offense");
            DropForeignKey("dbo.mf_EmployeeOffense", "employeeId", "dbo.mf_Employee");
            DropForeignKey("dbo.sys_Company", "countryId", "dbo.mf_Country");
            DropForeignKey("dbo.mf_Allowance", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.pr_PayrollEmployeeEarnings", "payrollEmployeeId", "dbo.pr_PayrollEmployee");
            DropForeignKey("dbo.pr_PayrollEmployeeDeductions", "payrollEmployeeId", "dbo.pr_PayrollEmployee");
            DropForeignKey("dbo.pr_PayrollEmployeeDeductions", "deductionId", "dbo.mf_Deduction");
            DropForeignKey("dbo.mf_Deduction", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.mf_EmployeeDeduction", "employeeId", "dbo.mf_Employee");
            DropForeignKey("dbo.mf_EmployeeDeduction", "deductionId", "dbo.mf_Deduction");
            DropForeignKey("dbo.pr_PayrollEmployee", "payrollId", "dbo.pr_Payroll");
            DropForeignKey("dbo.pr_Payroll", "cutOffAttendanceId", "dbo.ta_CutOffAttendance");
            DropForeignKey("dbo.ta_CutOffAttendanceSummaryDetail", "cutOffAttendanceSummaryId", "dbo.ta_CutOffAttendanceSummary");
            DropForeignKey("dbo.ta_CutOffAttendanceSummaryDetail", "holidayTypeId", "dbo.mf_HolidayType");
            DropForeignKey("dbo.mf_Holidays", "holidayTypeId", "dbo.mf_HolidayType");
            DropForeignKey("dbo.ta_CutOffAttendanceSummary", "cutOffAttendanceId", "dbo.ta_CutOffAttendance");
            DropForeignKey("dbo.ta_CutOffAttendanceSummary", "employeeId", "dbo.mf_Employee");
            DropForeignKey("dbo.ta_CutOffAttendance", "sys_User_updatedBy_id", "dbo.sys_User");
            DropForeignKey("dbo.ta_CutOffAttendance", "sys_User_changeStatusBy_id", "dbo.sys_User");
            DropForeignKey("dbo.ta_CutOffAttendance", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.ta_CutOffAttendance", "payrollGroupId", "dbo.mf_PayrollGroup");
            DropForeignKey("dbo.pr_Payroll", "companyId", "dbo.sys_Company");
            DropForeignKey("dbo.pr_PayrollEmployee", "employeeId", "dbo.mf_Employee");
            DropForeignKey("dbo.pr_PayrollEmployeeEarnings", "allowanceId", "dbo.mf_Allowance");
            DropForeignKey("dbo.mf_EmployeeAllowance", "employeeId", "dbo.mf_Employee");
            DropForeignKey("dbo.mf_EmployeeAllowance", "allowanceId", "dbo.mf_Allowance");
            DropForeignKey("dbo.mf_Employee", "employee201Id", "dbo.mf_Employee201");
            DropForeignKey("dbo.mf_EmployeeBalanceLeave", "applicationRequestTypeId", "dbo.mf_ApplicationRequestType");
            DropForeignKey("dbo.mf_DepartmentSection", "departmentId", "dbo.mf_Department");
            DropForeignKey("dbo.mf_Employee201", "agencyId", "dbo.mf_Agency");
            DropIndex("dbo.ta_ApplicationRequestLeave", new[] { "applicationRequestId" });
            DropIndex("dbo.ta_ApplicationRequestGatePass", new[] { "applicationRequestId" });
            DropIndex("dbo.ta_ApplicationRequestApprover", new[] { "sys_User_updatedBy_id" });
            DropIndex("dbo.ta_ApplicationRequestApprover", new[] { "sys_User_approverId_id" });
            DropIndex("dbo.ta_ApplicationRequestApprover", new[] { "applicationRequestId" });
            DropIndex("dbo.ta_ApplicationRequest", new[] { "applicationRequestTypeId" });
            DropIndex("dbo.mf_EmployeeWorkHistory", new[] { "employeeId" });
            DropIndex("dbo.mf_EmployeeTraining", new[] { "employeeId" });
            DropIndex("dbo.mf_EmployeeSkill", new[] { "employeeId" });
            DropIndex("dbo.mf_EmployeeIdentificationDocument", new[] { "identificationDocumentId" });
            DropIndex("dbo.mf_EmployeeIdentificationDocument", new[] { "employeeId" });
            DropIndex("dbo.mf_EmployeeEducation", new[] { "employeeId" });
            DropIndex("dbo.mf_EmployeeBasicPay", new[] { "employeeId" });
            DropIndex("dbo.sys_UserSession", new[] { "companyId" });
            DropIndex("dbo.sys_UserRole", new[] { "roleId" });
            DropIndex("dbo.sys_RoleMenu", new[] { "parentRoleMenuId" });
            DropIndex("dbo.sys_RoleMenu", new[] { "sourceMenuId" });
            DropIndex("dbo.sys_RoleMenu", new[] { "roleId" });
            DropIndex("dbo.sys_Role", new[] { "companyId" });
            DropIndex("dbo.sys_RolePermission", new[] { "permissionId" });
            DropIndex("dbo.sys_RolePermission", new[] { "roleId" });
            DropIndex("dbo.sys_Permission", new[] { "companyId" });
            DropIndex("dbo.sys_Location", new[] { "companyId" });
            DropIndex("dbo.sys_EnumReference", new[] { "companyId" });
            DropIndex("dbo.sys_CompanySetting", new[] { "companyId" });
            DropIndex("dbo.sys_CompanySetting", new[] { "settingId" });
            DropIndex("dbo.ta_EmployeeAttendance", new[] { "workDayId" });
            DropIndex("dbo.ta_EmployeeAttendance", new[] { "employeeId" });
            DropIndex("dbo.mf_EmployeeWorkDays", new[] { "workDayId" });
            DropIndex("dbo.mf_EmployeeWorkDays", new[] { "employeeId" });
            DropIndex("dbo.mf_WorkDays", new[] { "companyId" });
            DropIndex("dbo.mf_Position", new[] { "companyId" });
            DropIndex("dbo.mf_PenaltyType", new[] { "companyId" });
            DropIndex("dbo.mf_EmployeeOffense", new[] { "penaltyTypeId" });
            DropIndex("dbo.mf_EmployeeOffense", new[] { "offenseId" });
            DropIndex("dbo.mf_EmployeeOffense", new[] { "employeeId" });
            DropIndex("dbo.mf_Offense", new[] { "companyId" });
            DropIndex("dbo.mf_EmployeeDeduction", new[] { "deductionId" });
            DropIndex("dbo.mf_EmployeeDeduction", new[] { "employeeId" });
            DropIndex("dbo.mf_Deduction", new[] { "companyId" });
            DropIndex("dbo.pr_PayrollEmployeeDeductions", new[] { "deductionId" });
            DropIndex("dbo.pr_PayrollEmployeeDeductions", new[] { "payrollEmployeeId" });
            DropIndex("dbo.mf_Holidays", new[] { "holidayTypeId" });
            DropIndex("dbo.ta_CutOffAttendanceSummaryDetail", new[] { "holidayTypeId" });
            DropIndex("dbo.ta_CutOffAttendanceSummaryDetail", new[] { "cutOffAttendanceSummaryId" });
            DropIndex("dbo.ta_CutOffAttendanceSummary", new[] { "employeeId" });
            DropIndex("dbo.ta_CutOffAttendanceSummary", new[] { "cutOffAttendanceId" });
            DropIndex("dbo.sys_User", new[] { "mf_Employee_id" });
            DropIndex("dbo.sys_User", new[] { "sys_Company_id" });
            DropIndex("dbo.ta_CutOffAttendance", new[] { "sys_User_updatedBy_id" });
            DropIndex("dbo.ta_CutOffAttendance", new[] { "sys_User_changeStatusBy_id" });
            DropIndex("dbo.ta_CutOffAttendance", new[] { "companyId" });
            DropIndex("dbo.ta_CutOffAttendance", new[] { "payrollGroupId" });
            DropIndex("dbo.pr_Payroll", new[] { "companyId" });
            DropIndex("dbo.pr_Payroll", new[] { "cutOffAttendanceId" });
            DropIndex("dbo.pr_PayrollEmployee", new[] { "employeeId" });
            DropIndex("dbo.pr_PayrollEmployee", new[] { "payrollId" });
            DropIndex("dbo.pr_PayrollEmployeeEarnings", new[] { "allowanceId" });
            DropIndex("dbo.pr_PayrollEmployeeEarnings", new[] { "payrollEmployeeId" });
            DropIndex("dbo.mf_EmployeeAllowance", new[] { "allowanceId" });
            DropIndex("dbo.mf_EmployeeAllowance", new[] { "employeeId" });
            DropIndex("dbo.mf_Allowance", new[] { "companyId" });
            DropIndex("dbo.sys_Company", new[] { "countryId" });
            DropIndex("dbo.mf_EmployeeAddress", new[] { "countryId" });
            DropIndex("dbo.mf_Employee", new[] { "companyId" });
            DropIndex("dbo.mf_Employee", new[] { "employee201Id" });
            DropIndex("dbo.mf_Employee", new[] { "employeeAddressId" });
            DropIndex("dbo.mf_EmployeeBalanceLeave", new[] { "applicationRequestTypeId" });
            DropIndex("dbo.mf_EmployeeBalanceLeave", new[] { "employeeId" });
            DropIndex("dbo.mf_DepartmentSectionRequestApprover", new[] { "applicationRequestTypeId" });
            DropIndex("dbo.mf_DepartmentSectionRequestApprover", new[] { "departmentSectionId" });
            DropIndex("dbo.mf_DepartmentSection", new[] { "departmentId" });
            DropIndex("dbo.mf_Department", new[] { "companyId" });
            DropIndex("dbo.mf_Employee201", new[] { "agencyId" });
            DropIndex("dbo.mf_Employee201", new[] { "payrollGroupId" });
            DropIndex("dbo.mf_Employee201", new[] { "employmentStatusId" });
            DropIndex("dbo.mf_Employee201", new[] { "employmentTypeId" });
            DropIndex("dbo.mf_Employee201", new[] { "positionId" });
            DropIndex("dbo.mf_Employee201", new[] { "departmentSectionId" });
            DropIndex("dbo.mf_Employee201", new[] { "departmentId" });
            DropIndex("dbo.mf_Agency", new[] { "companyId" });
            DropTable("dbo.sys_ErrorLogs");
            DropTable("dbo.mf_EmploymentType");
            DropTable("dbo.mf_EmploymentStatus");
            DropTable("dbo.ta_ApplicationRequestLeave");
            DropTable("dbo.ta_ApplicationRequestGatePass");
            DropTable("dbo.ta_ApplicationRequestApprover");
            DropTable("dbo.ta_ApplicationRequest");
            DropTable("dbo.mf_EmployeeWorkHistory");
            DropTable("dbo.mf_EmployeeTraining");
            DropTable("dbo.mf_EmployeeSkill");
            DropTable("dbo.sys_IdentificationDocument");
            DropTable("dbo.mf_EmployeeIdentificationDocument");
            DropTable("dbo.mf_EmployeeEducation");
            DropTable("dbo.mf_EmployeeBasicPay");
            DropTable("dbo.sys_UserSession");
            DropTable("dbo.sys_UserRole");
            DropTable("dbo.sys_Menu");
            DropTable("dbo.sys_RoleMenu");
            DropTable("dbo.sys_Role");
            DropTable("dbo.sys_RolePermission");
            DropTable("dbo.sys_Permission");
            DropTable("dbo.sys_Location");
            DropTable("dbo.sys_EnumReference");
            DropTable("dbo.sys_Setting");
            DropTable("dbo.sys_CompanySetting");
            DropTable("dbo.ta_EmployeeAttendance");
            DropTable("dbo.mf_EmployeeWorkDays");
            DropTable("dbo.mf_WorkDays");
            DropTable("dbo.mf_Position");
            DropTable("dbo.mf_PenaltyType");
            DropTable("dbo.mf_EmployeeOffense");
            DropTable("dbo.mf_Offense");
            DropTable("dbo.mf_EmployeeDeduction");
            DropTable("dbo.mf_Deduction");
            DropTable("dbo.pr_PayrollEmployeeDeductions");
            DropTable("dbo.mf_Holidays");
            DropTable("dbo.mf_HolidayType");
            DropTable("dbo.ta_CutOffAttendanceSummaryDetail");
            DropTable("dbo.ta_CutOffAttendanceSummary");
            DropTable("dbo.sys_User");
            DropTable("dbo.mf_PayrollGroup");
            DropTable("dbo.ta_CutOffAttendance");
            DropTable("dbo.pr_Payroll");
            DropTable("dbo.pr_PayrollEmployee");
            DropTable("dbo.pr_PayrollEmployeeEarnings");
            DropTable("dbo.mf_EmployeeAllowance");
            DropTable("dbo.mf_Allowance");
            DropTable("dbo.sys_Company");
            DropTable("dbo.mf_Country");
            DropTable("dbo.mf_EmployeeAddress");
            DropTable("dbo.mf_Employee");
            DropTable("dbo.mf_EmployeeBalanceLeave");
            DropTable("dbo.mf_ApplicationRequestType");
            DropTable("dbo.mf_DepartmentSectionRequestApprover");
            DropTable("dbo.mf_DepartmentSection");
            DropTable("dbo.mf_Department");
            DropTable("dbo.mf_Employee201");
            DropTable("dbo.mf_Agency");
        }
    }
}
