using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal class ta_EmployeeAttendanceConfiguration : EntityTypeConfiguration<ta_EmployeeAttendance>
    {
        public ta_EmployeeAttendanceConfiguration()
            : this("dbo")
        {
        }

        public ta_EmployeeAttendanceConfiguration(string schema)
        {
            ToTable(schema + ".ta_EmployeeAttendance");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired();
            Property(x => x.timeLogType).HasColumnName("timeLogType").IsRequired();
            Property(x => x.workDate).HasColumnName("workDate").IsRequired().HasColumnType("datetime");
            Property(x => x.timeLog).HasColumnName("timeLog").IsRequired().HasColumnType("datetime");
            Property(x => x.workDayId).HasColumnName("workDayId").IsOptional();
            Property(x => x.remarks).HasColumnName("remarks").IsOptional();
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasOptional(a => a.mf_WorkDay).WithMany(b => b.ta_EmployeeAttendances).HasForeignKey(c => c.workDayId);
            HasRequired(a => a.mf_Employee).WithMany(b => b.ta_EmployeeAttendances).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.ta_EmployeeAttendances).HasForeignKey(c => c.updatedBy);
        }
    }
}