using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class mf_EmployeeWorkDayConfiguration : EntityTypeConfiguration<mf_EmployeeWorkDay>
    {
        public mf_EmployeeWorkDayConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeWorkDayConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeWorkDays");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.workDayId).HasColumnName("workDayId").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeWorkDays).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.mf_WorkDay).WithMany(b => b.mf_EmployeeWorkDays).HasForeignKey(c => c.workDayId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeWorkDays).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}