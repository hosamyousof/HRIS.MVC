using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class pr_PayrollEmployeeEarningConfiguration : EntityTypeConfiguration<pr_PayrollEmployeeEarning>
    {
        public pr_PayrollEmployeeEarningConfiguration()
            : this("dbo")
        {
        }

        public pr_PayrollEmployeeEarningConfiguration(string schema)
        {
            ToTable(schema + ".pr_PayrollEmployeeEarnings");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.payrollEmployeeId).HasColumnName("payrollEmployeeId").IsRequired();
            Property(x => x.allowanceId).HasColumnName("allowanceId").IsOptional();
            //Property(x => x.paySlipDetail).HasColumnName("paySlipDetail").IsOptional();
            Property(x => x.value).HasColumnName("value").IsRequired().HasColumnType("float");

            HasOptional(a => a.mf_Allowance).WithMany(b => b.pr_PayrollEmployeeEarnings).HasForeignKey(c => c.allowanceId);
            HasRequired(a => a.pr_PayrollEmployee).WithMany(b => b.pr_PayrollEmployeeEarnings).HasForeignKey(c => c.payrollEmployeeId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}