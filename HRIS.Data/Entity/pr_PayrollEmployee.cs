using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public class pr_PayrollEmployee : EntityBase
    {
        public Guid payrollId { get; set; }
        public Guid employeeId { get; set; }
        public double noOfDays { get; set; }
        public double totalHours { get; set; }
        public double hourlyRates { get; set; }
        public int payRateType { get; set; }
        public double basicRate { get; set; }
        public double totalDeduction { get; set; }
        public double totalIncome { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual ICollection<pr_PayrollEmployeeDeduction> pr_PayrollEmployeeDeductions { get; set; }
        public virtual ICollection<pr_PayrollEmployeeEarning> pr_PayrollEmployeeEarnings { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual pr_Payroll pr_Payroll { get; set; }

        public pr_PayrollEmployee()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            pr_PayrollEmployeeDeductions = new List<pr_PayrollEmployeeDeduction>();
            pr_PayrollEmployeeEarnings = new List<pr_PayrollEmployeeEarning>();
        }
    }
}