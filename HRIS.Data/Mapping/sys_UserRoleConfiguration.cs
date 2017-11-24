using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class sys_UserRoleConfiguration : EntityTypeConfiguration<sys_UserRole>
    {
        public sys_UserRoleConfiguration()
            : this("dbo")
        {
        }

        public sys_UserRoleConfiguration(string schema)
        {
            ToTable(schema + ".sys_UserRole");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.roleId).HasColumnName("roleId").IsRequired();
            Property(x => x.userId).HasColumnName("userId").IsRequired();
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.sys_Role).WithMany(b => b.sys_UserRoles).HasForeignKey(c => c.roleId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}