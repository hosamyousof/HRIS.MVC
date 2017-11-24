using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class sys_SettingConfiguration : EntityTypeConfiguration<sys_Setting>
    {
        public sys_SettingConfiguration()
            : this("dbo")
        {
        }

        public sys_SettingConfiguration(string schema)
        {
            ToTable(schema + ".sys_Setting");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.name).HasColumnName("name").IsRequired().HasMaxLength(150);
            Property(x => x.description).HasColumnName("description").IsOptional().HasMaxLength(500);
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();
        }
    }
}