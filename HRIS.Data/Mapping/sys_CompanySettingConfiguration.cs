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

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.settingId).HasColumnName("settingId").IsRequired();
            Property(x => x.companyId).HasColumnName("companyId").IsOptional();
            Property(x => x.value).HasColumnName("value").IsRequired().HasColumnType("nvarchar");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasOptional(a => a.sys_Company).WithMany(b => b.sys_CompanySettings).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_Setting).WithMany(b => b.sys_CompanySettings).HasForeignKey(c => c.settingId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}