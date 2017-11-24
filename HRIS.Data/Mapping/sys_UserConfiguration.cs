using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class sys_UserConfiguration : EntityTypeConfiguration<sys_User>
    {
        public sys_UserConfiguration()
            : this("dbo")
        {
        }

        public sys_UserConfiguration(string schema)
        {
            ToTable(schema + ".sys_User");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.username).HasColumnName("username").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.password).HasColumnName("password").IsOptional().HasColumnType("nvarchar");
            Property(x => x.hashKey).HasColumnName("hashKey").IsOptional().HasColumnType("nvarchar");
            Property(x => x.vector).HasColumnName("vector").IsOptional().HasColumnType("nvarchar");
            Property(x => x.email).HasColumnName("email").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.employeeId).HasColumnName("employeeId").IsOptional().HasColumnType("int");
            Property(x => x.status).HasColumnName("status").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsOptional().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            InitializePartial();
        }

        partial void InitializePartial();
    }
}