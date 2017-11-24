using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal class pr_PayrollEmployeeConfiguration : EntityTypeConfiguration<pr_PayrollEmployee>
    {
        public pr_PayrollEmployeeConfiguration()
            : this("dbo")
        {
        }

        public pr_PayrollEmployeeConfiguration(string schema)
        {
            ToTable(schema + ".pr_PayrollEmployee");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.payrollId).HasColumnName("payrollId").IsRequired();
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired();
            Property(x => x.noOfDays).HasColumnName("noOfDays").IsRequired().HasColumnType("float");
            Property(x => x.totalHours).HasColumnName("totalHours").IsRequired().HasColumnType("float");
            Property(x => x.hourlyRates).HasColumnName("hourlyRates").IsRequired().HasColumnType("float");
            Property(x => x.payRateType).HasColumnName("payRateType").IsRequired();
            Property(x => x.basicRate).HasColumnName("basicRate").IsRequired().HasColumnType("float");
            Property(x => x.totalDeduction).HasColumnName("totalDeduction").IsRequired().HasColumnType("float");
            Property(x => x.totalIncome).HasColumnName("totalIncome").IsRequired().HasColumnType("float");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_Employee).WithMany(b => b.pr_PayrollEmployees).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.pr_Payroll).WithMany(b => b.pr_PayrollEmployees).HasForeignKey(c => c.payrollId);
        }
    }
}