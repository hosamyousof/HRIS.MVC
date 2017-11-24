using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class mf_OffenseConfiguration : EntityTypeConfiguration<mf_Offense>
    {
        public mf_OffenseConfiguration()
            : this("dbo")
        {
        }

        public mf_OffenseConfiguration(string schema)
        {
            ToTable(schema + ".mf_Offense");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired();
            Property(x => x.code).HasColumnName("code").IsRequired().HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.sys_Company).WithMany(b => b.mf_Offenses).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_Offenses).HasForeignKey(c => c.updatedBy);
        }
    }
}