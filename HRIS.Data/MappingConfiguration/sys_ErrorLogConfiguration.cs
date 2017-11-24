using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data
{
    internal partial class sys_ErrorLogConfiguration : EntityTypeConfiguration<sys_ErrorLog>
    {
        public sys_ErrorLogConfiguration()
            : this("dbo")
        {
        }

        public sys_ErrorLogConfiguration(string schema)
        {
            ToTable(schema + ".sys_ErrorLogs");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.message).HasColumnName("message").IsOptional().HasColumnType("nvarchar");
            Property(x => x.innerException).HasColumnName("innerException").IsOptional().HasColumnType("nvarchar");
            Property(x => x.loggedType).HasColumnName("loggedType").IsRequired().HasColumnType("int");
            Property(x => x.controllerName).HasColumnName("controllerName").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.actionName).HasColumnName("actionName").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.areaName).HasColumnName("areaName").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.createdBy).HasColumnName("createdBy").IsOptional().HasColumnType("int");
            Property(x => x.createdDate).HasColumnName("createdDate").IsRequired().HasColumnType("datetime");

            HasOptional(a => a.sys_User).WithMany(b => b.sys_ErrorLogs).HasForeignKey(c => c.createdBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}