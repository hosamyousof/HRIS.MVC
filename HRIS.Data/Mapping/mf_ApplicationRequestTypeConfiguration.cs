using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class mf_ApplicationRequestTypeConfiguration : EntityTypeConfiguration<mf_ApplicationRequestType>
    {
        public mf_ApplicationRequestTypeConfiguration()
            : this("dbo")
        {
        }

        public mf_ApplicationRequestTypeConfiguration(string schema)
        {
            ToTable(schema + ".mf_ApplicationRequestType");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.requiredLeavePoints).HasColumnName("requiredLeavePoints").IsRequired();
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            InitializePartial();
        }

        partial void InitializePartial();
    }
}