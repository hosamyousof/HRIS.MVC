using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data
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

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.allowanceId).HasColumnName("allowanceId").IsRequired().HasColumnType("int");
            Property(x => x.amount).HasColumnName("amount").IsOptional().HasColumnType("float");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Allowance).WithMany(b => b.mf_EmployeeAllowances).HasForeignKey(c => c.allowanceId);
            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeAllowances).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeAllowances).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}