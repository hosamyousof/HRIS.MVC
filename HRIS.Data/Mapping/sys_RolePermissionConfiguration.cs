using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class sys_RolePermissionConfiguration : EntityTypeConfiguration<sys_RolePermission>
    {
        public sys_RolePermissionConfiguration()
            : this("dbo")
        {
        }

        public sys_RolePermissionConfiguration(string schema)
        {
            ToTable(schema + ".sys_RolePermission");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.roleId).HasColumnName("roleId").IsRequired();
            Property(x => x.permissionId).HasColumnName("permissionId").IsRequired();
            Property(x => x.viewAccess).HasColumnName("viewAccess").IsRequired();
            Property(x => x.createAccess).HasColumnName("createAccess").IsRequired();
            Property(x => x.updateAccess).HasColumnName("updateAccess").IsRequired();
            Property(x => x.deleteAccess).HasColumnName("deleteAccess").IsRequired();
            Property(x => x.printAccess).HasColumnName("printAccess").IsRequired();
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.sys_Permission).WithMany(b => b.sys_RolePermissions).HasForeignKey(c => c.permissionId);
            HasRequired(a => a.sys_Role).WithMany(b => b.sys_RolePermissions).HasForeignKey(c => c.roleId);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.sys_RolePermissions).HasForeignKey(c => c.updatedBy);
        }
    }
}