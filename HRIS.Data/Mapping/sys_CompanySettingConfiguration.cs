using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class sys_CompanySettingConfiguration : EntityTypeConfiguration<sys_CompanySetting>
    {
        public sys_CompanySettingConfiguration()
            : this("dbo")
        {
        }

        public sys_CompanySettingConfiguration(string schema)
        {
            ToTable(schema + ".sys_CompanySetting");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.settingId).HasColumnName("settingId").IsRequired().HasColumnType("int");
            Property(x => x.companyId).HasColumnName("companyId").IsOptional().HasColumnType("int");
            Property(x => x.value).HasColumnName("value").IsRequired().HasColumnType("nvarchar");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasOptional(a => a.sys_Company).WithMany(b => b.sys_CompanySettings).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_Setting).WithMany(b => b.sys_CompanySettings).HasForeignKey(c => c.settingId);
            HasRequired(a => a.sys_User).WithMany(b => b.sys_CompanySettings).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}