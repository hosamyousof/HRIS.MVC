using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class sys_MenuConfiguration : EntityTypeConfiguration<sys_Menu>
    {
        public sys_MenuConfiguration()
            : this("dbo")
        {
        }

        public sys_MenuConfiguration(string schema)
        {
            ToTable(schema + ".sys_Menu");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.description).HasColumnName("description").IsRequired().HasMaxLength(250);
            Property(x => x.controllerName).HasColumnName("controllerName").IsOptional().HasMaxLength(250);
            Property(x => x.actionName).HasColumnName("actionName").IsOptional().HasMaxLength(150);
            Property(x => x.areaName).HasColumnName("areaName").IsOptional().HasMaxLength(150);
            Property(x => x.parameter).HasColumnName("parameter").IsOptional().HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.sys_User).WithMany(b => b.sys_Menus).HasForeignKey(c => c.updatedBy);
        }
    }
}