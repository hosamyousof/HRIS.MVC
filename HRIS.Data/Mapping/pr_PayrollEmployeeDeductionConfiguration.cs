using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class pr_PayrollEmployeeDeductionConfiguration : EntityTypeConfiguration<pr_PayrollEmployeeDeduction>
    {
        public pr_PayrollEmployeeDeductionConfiguration()
            : this("dbo")
        {
        }

        public pr_PayrollEmployeeDeductionConfiguration(string schema)
        {
            ToTable(schema + ".pr_PayrollEmployeeDeductions");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.payrollEmployeeId).HasColumnName("payrollEmployeeId").IsRequired().HasColumnType("int");
            Property(x => x.deductionId).HasColumnName("deductionId").IsOptional().HasColumnType("int");
            Property(x => x.paySlipDetail).HasColumnName("paySlipDetail").IsOptional().HasColumnType("int");
            Property(x => x.value).HasColumnName("value").IsRequired().HasColumnType("float");

            HasOptional(a => a.mf_Deduction).WithMany(b => b.pr_PayrollEmployeeDeductions).HasForeignKey(c => c.deductionId);
            HasRequired(a => a.pr_PayrollEmployee).WithMany(b => b.pr_PayrollEmployeeDeductions).HasForeignKey(c => c.payrollEmployeeId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}