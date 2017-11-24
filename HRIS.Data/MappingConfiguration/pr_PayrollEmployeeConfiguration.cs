using System;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data
{
    internal partial class pr_PayrollEmployeeConfiguration : EntityTypeConfiguration<pr_PayrollEmployee>
    {
        public pr_PayrollEmployeeConfiguration()
            : this("dbo")
        {
        }

        public pr_PayrollEmployeeConfiguration(string schema)
        {
            ToTable(schema + ".pr_PayrollEmployee");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.payrollId).HasColumnName("payrollId").IsRequired().HasColumnType("int");
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.noOfDays).HasColumnName("noOfDays").IsRequired().HasColumnType("float");
            Property(x => x.totalHours).HasColumnName("totalHours").IsRequired().HasColumnType("float");
            Property(x => x.hourlyRates).HasColumnName("hourlyRates").IsRequired().HasColumnType("float");
            Property(x => x.payRateType).HasColumnName("payRateType").IsRequired().HasColumnType("int");
            Property(x => x.basicRate).HasColumnName("basicRate").IsRequired().HasColumnType("float");
            Property(x => x.totalDeduction).HasColumnName("totalDeduction").IsRequired().HasColumnType("float");
            Property(x => x.totalIncome).HasColumnName("totalIncome").IsRequired().HasColumnType("float");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.pr_PayrollEmployees).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.pr_Payroll).WithMany(b => b.pr_PayrollEmployees).HasForeignKey(c => c.payrollId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}