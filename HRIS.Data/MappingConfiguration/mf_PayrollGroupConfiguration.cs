using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data
{
    internal partial class mf_PayrollGroupConfiguration : EntityTypeConfiguration<mf_PayrollGroup>
    {
        public mf_PayrollGroupConfiguration()
            : this("dbo")
        {
        }

        public mf_PayrollGroupConfiguration(string schema)
        {
            ToTable(schema + ".mf_PayrollGroup");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_User).WithMany(b => b.mf_PayrollGroups).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}