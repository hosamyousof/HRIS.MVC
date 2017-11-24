using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data
{
    internal partial class sys_SettingConfiguration : EntityTypeConfiguration<sys_Setting>
    {
        public sys_SettingConfiguration()
            : this("dbo")
        {
        }

        public sys_SettingConfiguration(string schema)
        {
            ToTable(schema + ".sys_Setting");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.name).HasColumnName("name").IsRequired().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.description).HasColumnName("description").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");
            InitializePartial();
        }

        partial void InitializePartial();
    }
}