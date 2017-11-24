using System;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data
{
    internal partial class sys_MenuConfiguration : EntityTypeConfiguration<sys_Menu>
    {
        public sys_MenuConfiguration()
            : this("dbo")
        {
        }

        public sys_MenuConfiguration(string schema)
        {
            ToTable(schema + ".sys_Menu");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.controllerName).HasColumnName("controllerName").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.actionName).HasColumnName("actionName").IsOptional().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.areaName).HasColumnName("areaName").IsOptional().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.parameter).HasColumnName("parameter").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_User).WithMany(b => b.sys_Menus).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}