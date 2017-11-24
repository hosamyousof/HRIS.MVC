using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class mf_EmployeeBalanceLeaveConfiguration : EntityTypeConfiguration<mf_EmployeeBalanceLeave>
    {
        public mf_EmployeeBalanceLeaveConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeBalanceLeaveConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeBalanceLeave");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired();
            Property(x => x.balance).HasColumnName("balance").IsRequired().HasColumnType("float");
            Property(x => x.applicationRequestTypeId).HasColumnName("applicationRequestTypeId").IsRequired();
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_ApplicationRequestType).WithMany(b => b.mf_EmployeeBalanceLeaves).HasForeignKey(c => c.applicationRequestTypeId);
            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeBalanceLeaves).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeBalanceLeaves).HasForeignKey(c => c.updatedBy);
        }
    }
}