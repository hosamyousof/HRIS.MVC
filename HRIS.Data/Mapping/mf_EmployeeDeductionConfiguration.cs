using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class mf_EmployeeDeductionConfiguration : EntityTypeConfiguration<mf_EmployeeDeduction>
    {
        public mf_EmployeeDeductionConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeDeductionConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeDeduction");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired();
            Property(x => x.deductionId).HasColumnName("deductionId").IsRequired();
            Property(x => x.amount).HasColumnName("amount").IsOptional().HasColumnType("float");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_Deduction).WithMany(b => b.mf_EmployeeDeductions).HasForeignKey(c => c.deductionId);
            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeDeductions).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.mf_EmployeeDeductions).HasForeignKey(c => c.updatedBy);
        }
    }
}