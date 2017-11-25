using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class mf_EmployeeWorkHistoryConfiguration : EntityTypeConfiguration<mf_EmployeeWorkHistory>
    {
        public mf_EmployeeWorkHistoryConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeWorkHistoryConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeWorkHistory");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired();
            Property(x => x.companyName).HasColumnName("companyName").IsRequired().HasMaxLength(250);
            Property(x => x.position).HasColumnName("position").IsOptional().HasMaxLength(250);
            Property(x => x.joinedMonth).HasColumnName("joinedMonth").IsRequired();
            Property(x => x.joinedYear).HasColumnName("joinedYear").IsRequired();
            Property(x => x.resignedMonth).HasColumnName("resignedMonth").IsOptional();
            Property(x => x.resignedYear).HasColumnName("resignedYear").IsOptional();
            Property(x => x.isPresent).HasColumnName("isPresent").IsOptional();
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeWorkHistories).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.mf_EmployeeWorkHistories).HasForeignKey(c => c.updatedBy);
        }
    }
}