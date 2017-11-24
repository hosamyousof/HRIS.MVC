using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class sys_RolePermissionConfiguration : EntityTypeConfiguration<sys_RolePermission>
    {
        public sys_RolePermissionConfiguration()
            : this("dbo")
        {
        }

        public sys_RolePermissionConfiguration(string schema)
        {
            ToTable(schema + ".sys_RolePermission");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.roleId).HasColumnName("roleId").IsRequired().HasColumnType("int");
            Property(x => x.permissionId).HasColumnName("permissionId").IsRequired().HasColumnType("int");
            Property(x => x.viewAccess).HasColumnName("viewAccess").IsRequired().HasColumnType("bit");
            Property(x => x.createAccess).HasColumnName("createAccess").IsRequired().HasColumnType("bit");
            Property(x => x.updateAccess).HasColumnName("updateAccess").IsRequired().HasColumnType("bit");
            Property(x => x.deleteAccess).HasColumnName("deleteAccess").IsRequired().HasColumnType("bit");
            Property(x => x.printAccess).HasColumnName("printAccess").IsRequired().HasColumnType("bit");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Permission).WithMany(b => b.sys_RolePermissions).HasForeignKey(c => c.permissionId);
            HasRequired(a => a.sys_Role).WithMany(b => b.sys_RolePermissions).HasForeignKey(c => c.roleId);
            HasRequired(a => a.sys_User).WithMany(b => b.sys_RolePermissions).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}