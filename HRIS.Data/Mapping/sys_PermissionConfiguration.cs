using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class sys_PermissionConfiguration : EntityTypeConfiguration<sys_Permission>
    {
        public sys_PermissionConfiguration()
            : this("dbo")
        {
        }

        public sys_PermissionConfiguration(string schema)
        {
            ToTable(schema + ".sys_Permission");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired();
            Property(x => x.code).HasColumnName("code").IsRequired().HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.sys_Company).WithMany(b => b.sys_Permissions).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.sys_Permissions).HasForeignKey(c => c.updatedBy);
        }
    }
}