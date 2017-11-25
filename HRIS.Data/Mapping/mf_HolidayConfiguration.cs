using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class mf_HolidayConfiguration : EntityTypeConfiguration<mf_Holiday>
    {
        public mf_HolidayConfiguration()
            : this("dbo")
        {
        }

        public mf_HolidayConfiguration(string schema)
        {
            ToTable(schema + ".mf_Holidays");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.holidayDate).HasColumnName("holidayDate").IsRequired().HasColumnType("datetime");
            Property(x => x.description).HasColumnName("description").IsRequired().HasMaxLength(250);
            Property(x => x.holidayTypeId).HasColumnName("holidayTypeId").IsRequired();
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_HolidayType).WithMany(b => b.mf_Holidays).HasForeignKey(c => c.holidayTypeId);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.mf_Holidays).HasForeignKey(c => c.updatedBy);
        }
    }
}