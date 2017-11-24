using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class ta_CutOffAttendanceSummaryConfiguration : EntityTypeConfiguration<ta_CutOffAttendanceSummary>
    {
        public ta_CutOffAttendanceSummaryConfiguration()
            : this("dbo")
        {
        }

        public ta_CutOffAttendanceSummaryConfiguration(string schema)
        {
            ToTable(schema + ".ta_CutOffAttendanceSummary");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.cutOffAttendanceId).HasColumnName("cutOffAttendanceId").IsRequired().HasColumnType("int");
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.ta_CutOffAttendanceSummaries).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.ta_CutOffAttendanceSummaries).HasForeignKey(c => c.updatedBy);
            HasRequired(a => a.ta_CutOffAttendance).WithMany(b => b.ta_CutOffAttendanceSummaries).HasForeignKey(c => c.cutOffAttendanceId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}