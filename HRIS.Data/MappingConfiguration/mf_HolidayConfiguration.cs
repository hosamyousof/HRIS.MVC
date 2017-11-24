using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data
{
    internal partial class mf_HolidayConfiguration : EntityTypeConfiguration<mf_Holiday>
    {
        public mf_HolidayConfiguration()
            : this("dbo")
        {
        }

        public mf_HolidayConfiguration(string schema)
        {
            ToTable(schema + ".mf_Holidays");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.holidayDate).HasColumnName("holidayDate").IsRequired().HasColumnType("datetime");
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.holidayTypeId).HasColumnName("holidayTypeId").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_HolidayType).WithMany(b => b.mf_Holidays).HasForeignKey(c => c.holidayTypeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_Holidays).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}