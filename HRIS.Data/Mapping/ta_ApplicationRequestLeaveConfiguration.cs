using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class ta_ApplicationRequestLeaveConfiguration : EntityTypeConfiguration<ta_ApplicationRequestLeave>
    {
        public ta_ApplicationRequestLeaveConfiguration()
            : this("dbo")
        {
        }

        public ta_ApplicationRequestLeaveConfiguration(string schema)
        {
            ToTable(schema + ".ta_ApplicationRequestLeave");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.applicationRequestId).HasColumnName("applicationRequestId").IsRequired().HasColumnType("int");
            Property(x => x.startDate).HasColumnName("startDate").IsRequired().HasColumnType("datetime");
            Property(x => x.endDate).HasColumnName("endDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.ta_ApplicationRequest).WithMany(b => b.ta_ApplicationRequestLeaves).HasForeignKey(c => c.applicationRequestId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}