using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class sys_UserSessionConfiguration : EntityTypeConfiguration<sys_UserSession>
    {
        public sys_UserSessionConfiguration()
            : this("dbo")
        {
        }

        public sys_UserSessionConfiguration(string schema)
        {
            ToTable(schema + ".sys_UserSession");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.userId).HasColumnName("userId").IsRequired().HasColumnType("int");
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.loggedDate).HasColumnName("loggedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.ipAddress).HasColumnName("ipAddress").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.expiredDate).HasColumnName("expiredDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Company).WithMany(b => b.sys_UserSessions).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.sys_UserSessions).HasForeignKey(c => c.userId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}