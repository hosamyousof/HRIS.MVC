using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class mf_EmployeeBasicPayConfiguration : EntityTypeConfiguration<mf_EmployeeBasicPay>
    {
        public mf_EmployeeBasicPayConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeBasicPayConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeBasicPay");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired();
            Property(x => x.basicPay).HasColumnName("basicPay").IsRequired().HasColumnType("float");
            Property(x => x.rateType).HasColumnName("rateType").IsRequired();
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeBasicPays).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.mf_EmployeeBasicPays).HasForeignKey(c => c.updatedBy);
        }
    }
}