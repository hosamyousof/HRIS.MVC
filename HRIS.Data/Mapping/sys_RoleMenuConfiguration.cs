using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class sys_RoleMenuConfiguration : EntityTypeConfiguration<sys_RoleMenu>
    {
        public sys_RoleMenuConfiguration()
            : this("dbo")
        {
        }

        public sys_RoleMenuConfiguration(string schema)
        {
            ToTable(schema + ".sys_RoleMenu");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.roleId).HasColumnName("roleId").IsRequired();
            Property(x => x.sourceMenuId).HasColumnName("sourceMenuId").IsRequired();
            Property(x => x.description).HasColumnName("description").IsRequired().HasMaxLength(250);
            Property(x => x.parentRoleMenuId).HasColumnName("parentRoleMenuId").IsOptional();
            Property(x => x.displayOrder).HasColumnName("displayOrder").IsRequired();
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasOptional(a => a.sys_RoleMenu_parentRoleMenuId).WithMany(b => b.sys_RoleMenus).HasForeignKey(c => c.parentRoleMenuId);
            HasRequired(a => a.sys_Menu).WithMany(b => b.sys_RoleMenus).HasForeignKey(c => c.sourceMenuId);
            HasRequired(a => a.sys_Role).WithMany(b => b.sys_RoleMenus).HasForeignKey(c => c.roleId);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.sys_RoleMenus).HasForeignKey(c => c.updatedBy);
        }
    }
}