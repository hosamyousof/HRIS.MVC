using System;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data
{
    internal partial class ta_EmployeeAttendanceConfiguration : EntityTypeConfiguration<ta_EmployeeAttendance>
    {
        public ta_EmployeeAttendanceConfiguration()
            : this("dbo")
        {
        }

        public ta_EmployeeAttendanceConfiguration(string schema)
        {
            ToTable(schema + ".ta_EmployeeAttendance");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.timeLogType).HasColumnName("timeLogType").IsRequired().HasColumnType("int");
            Property(x => x.workDate).HasColumnName("workDate").IsRequired().HasColumnType("datetime");
            Property(x => x.timeLog).HasColumnName("timeLog").IsRequired().HasColumnType("datetime");
            Property(x => x.workDayId).HasColumnName("workDayId").IsOptional().HasColumnType("int");
            Property(x => x.remarks).HasColumnName("remarks").IsOptional().HasColumnType("nvarchar");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasOptional(a => a.mf_WorkDay).WithMany(b => b.ta_EmployeeAttendances).HasForeignKey(c => c.workDayId);
            HasRequired(a => a.mf_Employee).WithMany(b => b.ta_EmployeeAttendances).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.ta_EmployeeAttendances).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}