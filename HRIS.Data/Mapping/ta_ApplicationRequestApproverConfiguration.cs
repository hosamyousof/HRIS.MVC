using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class ta_ApplicationRequestApproverConfiguration : EntityTypeConfiguration<ta_ApplicationRequestApprover>
    {
        public ta_ApplicationRequestApproverConfiguration()
            : this("dbo")
        {
        }

        public ta_ApplicationRequestApproverConfiguration(string schema)
        {
            ToTable(schema + ".ta_ApplicationRequestApprover");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.applicationRequestId).HasColumnName("applicationRequestId").IsRequired().HasColumnType("int");
            Property(x => x.approverId).HasColumnName("approverId").IsRequired().HasColumnType("int");
            Property(x => x.status).HasColumnName("status").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.ta_ApplicationRequest).WithMany(b => b.ta_ApplicationRequestApprovers).HasForeignKey(c => c.applicationRequestId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}