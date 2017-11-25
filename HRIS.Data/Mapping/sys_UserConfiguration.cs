using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal class sys_UserConfiguration : EntityTypeConfiguration<sys_User>
    {
        public sys_UserConfiguration()
            : this("dbo")
        {
        }

        public sys_UserConfiguration(string schema)
        {
            ToTable(schema + ".sys_User");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsOptional();
            Property(x => x.username).HasColumnName("username").IsRequired().HasMaxLength(50);
            Property(x => x.password).HasColumnName("password").IsOptional();
            Property(x => x.hashKey).HasColumnName("hashKey").IsOptional();
            Property(x => x.vector).HasColumnName("vector").IsOptional();
            Property(x => x.email).HasColumnName("email").IsOptional().HasMaxLength(50);
            Property(x => x.employeeId).HasColumnName("employeeId").IsOptional();
            Property(x => x.status).HasColumnName("status").IsRequired();
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsOptional();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasOptional(a => a.mf_Employee).WithMany(b => b.sys_Users).HasForeignKey(c => c.employeeId);
            HasOptional(a => a.sys_User_updatedBy).WithMany(b => b.sys_Users).HasForeignKey(c => c.updatedBy);
            HasOptional(a => a.sys_Company).WithMany(b => b.sys_Users).HasForeignKey(c => c.companyId);
        }
    }
}