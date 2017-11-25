using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class ta_CutOffAttendanceSummaryConfiguration : EntityTypeConfiguration<ta_CutOffAttendanceSummary>
    {
        public ta_CutOffAttendanceSummaryConfiguration()
            : this("dbo")
        {
        }

        public ta_CutOffAttendanceSummaryConfiguration(string schema)
        {
            ToTable(schema + ".ta_CutOffAttendanceSummary");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.cutOffAttendanceId).HasColumnName("cutOffAttendanceId").IsRequired();
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired();
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_Employee).WithMany(b => b.ta_CutOffAttendanceSummaries).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.ta_CutOffAttendanceSummaries).HasForeignKey(c => c.updatedBy);
            HasRequired(a => a.ta_CutOffAttendance).WithMany(b => b.ta_CutOffAttendanceSummaries).HasForeignKey(c => c.cutOffAttendanceId);
        }
    }
}