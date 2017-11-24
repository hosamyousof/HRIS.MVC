using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class sys_RoleMenuConfiguration : EntityTypeConfiguration<sys_RoleMenu>
    {
        public sys_RoleMenuConfiguration()
            : this("dbo")
        {
        }

        public sys_RoleMenuConfiguration(string schema)
        {
            ToTable(schema + ".sys_RoleMenu");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.roleId).HasColumnName("roleId").IsRequired().HasColumnType("int");
            Property(x => x.sourceMenuId).HasColumnName("sourceMenuId").IsRequired().HasColumnType("int");
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.parentRoleMenuId).HasColumnName("parentRoleMenuId").IsOptional().HasColumnType("int");
            Property(x => x.displayOrder).HasColumnName("displayOrder").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasOptional(a => a.sys_RoleMenu_parentRoleMenuId).WithMany(b => b.sys_RoleMenus).HasForeignKey(c => c.parentRoleMenuId);
            HasRequired(a => a.sys_Menu).WithMany(b => b.sys_RoleMenus).HasForeignKey(c => c.sourceMenuId);
            HasRequired(a => a.sys_Role).WithMany(b => b.sys_RoleMenus).HasForeignKey(c => c.roleId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}