using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class ta_CutOffAttendanceConfiguration : EntityTypeConfiguration<ta_CutOffAttendance>
    {
        public ta_CutOffAttendanceConfiguration()
            : this("dbo")
        {
        }

        public ta_CutOffAttendanceConfiguration(string schema)
        {
            ToTable(schema + ".ta_CutOffAttendance");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.payrollGroupId).HasColumnName("payrollGroupId").IsRequired();
            Property(x => x.companyId).HasColumnName("companyId").IsRequired();
            Property(x => x.generatedDate).HasColumnName("generatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.startDate).HasColumnName("startDate").IsRequired().HasColumnType("datetime");
            Property(x => x.endDate).HasColumnName("endDate").IsRequired().HasColumnType("datetime");
            Property(x => x.status).HasColumnName("status").IsRequired();
            Property(x => x.remarks).HasColumnName("remarks").IsOptional().HasColumnType("nvarchar");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.changeStatusById).HasColumnName("changeStatusById").IsRequired();
            Property(x => x.changeStatusDate).HasColumnName("changeStatusDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_PayrollGroup).WithMany(b => b.ta_CutOffAttendances).HasForeignKey(c => c.payrollGroupId);
            HasRequired(a => a.sys_Company).WithMany(b => b.ta_CutOffAttendances).HasForeignKey(c => c.companyId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}