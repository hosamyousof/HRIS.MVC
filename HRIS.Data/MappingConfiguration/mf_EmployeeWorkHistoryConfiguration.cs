using System;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data
{
    internal partial class mf_EmployeeWorkHistoryConfiguration : EntityTypeConfiguration<mf_EmployeeWorkHistory>
    {
        public mf_EmployeeWorkHistoryConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeWorkHistoryConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeWorkHistory");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.companyName).HasColumnName("companyName").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.position).HasColumnName("position").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.joinedMonth).HasColumnName("joinedMonth").IsRequired().HasColumnType("int");
            Property(x => x.joinedYear).HasColumnName("joinedYear").IsRequired().HasColumnType("int");
            Property(x => x.resignedMonth).HasColumnName("resignedMonth").IsOptional().HasColumnType("int");
            Property(x => x.resignedYear).HasColumnName("resignedYear").IsOptional().HasColumnType("int");
            Property(x => x.isPresent).HasColumnName("isPresent").IsOptional().HasColumnType("bit");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeWorkHistories).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeWorkHistories).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}