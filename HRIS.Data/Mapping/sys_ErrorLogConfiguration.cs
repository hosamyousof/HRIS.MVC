using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class sys_ErrorLogConfiguration : EntityTypeConfiguration<sys_ErrorLog>
    {
        public sys_ErrorLogConfiguration()
            : this("dbo")
        {
        }

        public sys_ErrorLogConfiguration(string schema)
        {
            ToTable(schema + ".sys_ErrorLogs");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.message).HasColumnName("message").IsOptional();
            Property(x => x.innerException).HasColumnName("innerException").IsOptional();
            Property(x => x.loggedType).HasColumnName("loggedType").IsRequired();
            Property(x => x.controllerName).HasColumnName("controllerName").IsOptional().HasMaxLength(250);
            Property(x => x.actionName).HasColumnName("actionName").IsOptional().HasMaxLength(250);
            Property(x => x.areaName).HasColumnName("areaName").IsOptional().HasMaxLength(250);
            Property(x => x.createdBy).HasColumnName("createdBy").IsOptional();
            Property(x => x.createdDate).HasColumnName("createdDate").IsRequired().HasColumnType("datetime");

            HasOptional(a => a.sys_User).WithMany(b => b.sys_ErrorLogs).HasForeignKey(c => c.createdBy);
        }
    }
}