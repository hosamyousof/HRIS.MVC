using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class mf_EmploymentStatuConfiguration : EntityTypeConfiguration<mf_EmploymentStatu>
    {
        public mf_EmploymentStatuConfiguration()
            : this("dbo")
        {
        }

        public mf_EmploymentStatuConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmploymentStatus");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.allowProcessPayroll).HasColumnName("allowProcessPayroll").IsRequired();
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            InitializePartial();
        }

        partial void InitializePartial();
    }
}