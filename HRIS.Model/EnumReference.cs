using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model
{
    public enum ReferenceList
    {
        CUT_OFF_ATTENDANCE, ERROR_TYPE, GENDER, HOUR, MARITAL_STATUS, MONTH_LIST, PAY_RATE_TYPE, PAYROLL_STATUS, PAYSLIP_DETAILS, PENALTY_DEGREE, POSITION_LEVEL, SKILL_PROFICIENCY_LEVEL, TAX_STATUS, TIME_LOG_TYPE, USER_STATUS,
    }

    public enum CUT_OFF_ATTENDANCE
    {
        Draft = 1, Submitted = 2, Accept = 3, Reject = 4, Posted = 5, Cancel = 6,
    }
    public enum ERROR_TYPE
    {
        UserError = 1, SystemError = 2,
    }
    public enum GENDER
    {
        Male = 1, Female = 2,
    }
    public enum HOUR
    {
        _12AM = 0, _1AM = 1, _2AM = 2, _3AM = 3, _4AM = 4, _5AM = 5, _6AM = 6, _7AM = 7, _8AM = 8, _9AM = 9, _10AM = 10, _11AM = 11, _12PM = 12, _1PM = 13, _2PM = 14, _3PM = 15, _4PM = 16, _5PM = 17, _6PM = 18, _7PM = 19, _8PM = 20, _9PM = 21, _10PM = 22, _11PM = 23,
    }
    public enum MARITAL_STATUS
    {
        Single = 1, Married = 2, Separated = 3, Widowed = 4, Divorced = 5,
    }
    public enum MONTH_LIST
    {
        January = 1, February = 2, March = 3, April = 4, May = 5, June = 6, July = 7, August = 8, September = 9, October = 10, November = 11, December = 12,
    }
    public enum PAY_RATE_TYPE
    {
        Daily = 1, Monthly = 2, Hourly = 3,
    }
    public enum PAYROLL_STATUS
    {
        New = 1, Verify = 2, Posted = 3,
    }
    public enum PAYSLIP_DETAILS
    {
        NoOfDays = 1, NoOfAbesencesTardiness = 2, NoOfOvertimeHours = 3, DailyMonthlyRate = 4, BasicPay = 5, OvertimePay = 6, WHoldingTask = 7,
    }
    public enum PENALTY_DEGREE
    {
        Minor = 1, Moderate = 2, Serious = 3,
    }
    public enum POSITION_LEVEL
    {
        Junior = 1, Senior = 2, TeamLead = 3, Manager = 4, Executive = 5,
    }
    public enum SKILL_PROFICIENCY_LEVEL
    {
        Beginner = 1, Awareness = 2, Knowledge = 3, Expert = 4,
    }
    public enum TAX_STATUS
    {
        Single = 1, Single1Dependent = 2, Single2Dependents = 3, Single3Dependents = 4, Single4Dependents = 5, Married = 6, Married1Dependent = 7, Married2Dependents = 8, Married3Dependents = 9, Married4Dependents = 10, NoExemptionZ = 11,
    }
    public enum TIME_LOG_TYPE
    {
        DutyOn = 0, DutyOff = 1, OvertimeBegin = 2, OvertimeEnd = 3, LockOut = 4, LockIn = 5,
    }
    public enum USER_STATUS
    {
        Active = 1, Disabled = 2, Locked = 3, ResetPassword = 4,
    }

}