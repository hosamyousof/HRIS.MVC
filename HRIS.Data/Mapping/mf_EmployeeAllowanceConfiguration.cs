using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class mf_EmployeeAllowanceConfiguration : EntityTypeConfiguration<mf_EmployeeAllowance>
    {
        public mf_EmployeeAllowanceConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeAllowanceConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeAllowance");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired();
            Property(x => x.allowanceId).HasColumnName("allowanceId").IsRequired();
            Property(x => x.amount).HasColumnName("amount").IsOptional().HasColumnType("float");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_Allowance).WithMany(b => b.mf_EmployeeAllowances).HasForeignKey(c => c.allowanceId);
            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeAllowances).HasForeignKey(c => c.employeeId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}