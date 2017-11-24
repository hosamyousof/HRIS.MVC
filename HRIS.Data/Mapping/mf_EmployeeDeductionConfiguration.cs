using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class mf_EmployeeDeductionConfiguration : EntityTypeConfiguration<mf_EmployeeDeduction>
    {
        public mf_EmployeeDeductionConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeDeductionConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeDeduction");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.deductionId).HasColumnName("deductionId").IsRequired().HasColumnType("int");
            Property(x => x.amount).HasColumnName("amount").IsOptional().HasColumnType("float");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Deduction).WithMany(b => b.mf_EmployeeDeductions).HasForeignKey(c => c.deductionId);
            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeDeductions).HasForeignKey(c => c.employeeId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}