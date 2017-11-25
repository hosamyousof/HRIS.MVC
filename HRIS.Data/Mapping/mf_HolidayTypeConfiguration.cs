using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class mf_HolidayTypeConfiguration : EntityTypeConfiguration<mf_HolidayType>
    {
        public mf_HolidayTypeConfiguration()
            : this("dbo")
        {
        }

        public mf_HolidayTypeConfiguration(string schema)
        {
            ToTable(schema + ".mf_HolidayType");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.code).HasColumnName("code").IsRequired().HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasMaxLength(250);
            Property(x => x.rateNotWork).HasColumnName("rateNotWork").IsRequired().HasColumnType("float");
            Property(x => x.rateWork).HasColumnName("rateWork").IsRequired().HasColumnType("float");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.mf_HolidayTypes).HasForeignKey(c => c.updatedBy);
        }
    }
}