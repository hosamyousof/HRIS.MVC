using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class ta_CutOffAttendanceSummaryDetailConfiguration : EntityTypeConfiguration<ta_CutOffAttendanceSummaryDetail>
    {
        public ta_CutOffAttendanceSummaryDetailConfiguration()
            : this("dbo")
        {
        }

        public ta_CutOffAttendanceSummaryDetailConfiguration(string schema)
        {
            ToTable(schema + ".ta_CutOffAttendanceSummaryDetail");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.cutOffAttendanceSummaryId).HasColumnName("cutOffAttendanceSummaryId").IsRequired().HasColumnType("int");
            Property(x => x.workDate).HasColumnName("workDate").IsRequired().HasColumnType("datetime");
            Property(x => x.workHours).HasColumnName("workHours").IsRequired().HasColumnType("float");
            Property(x => x.undertimeHours).HasColumnName("undertimeHours").IsRequired().HasColumnType("float");
            Property(x => x.lateHours).HasColumnName("lateHours").IsRequired().HasColumnType("float");
            Property(x => x.overtimeHours).HasColumnName("overtimeHours").IsRequired().HasColumnType("float");
            Property(x => x.workHolidayHours).HasColumnName("workHolidayHours").IsOptional().HasColumnType("float");
            Property(x => x.holidayTypeId).HasColumnName("holidayTypeId").IsOptional().HasColumnType("int");
            Property(x => x.absent).HasColumnName("absent").IsRequired().HasColumnType("bit");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasOptional(a => a.mf_HolidayType).WithMany(b => b.ta_CutOffAttendanceSummaryDetails).HasForeignKey(c => c.holidayTypeId);
            HasRequired(a => a.sys_User).WithMany(b => b.ta_CutOffAttendanceSummaryDetails).HasForeignKey(c => c.updatedBy);
            HasRequired(a => a.ta_CutOffAttendanceSummary).WithMany(b => b.ta_CutOffAttendanceSummaryDetails).HasForeignKey(c => c.cutOffAttendanceSummaryId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}