using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class mf_WorkDayConfiguration : EntityTypeConfiguration<mf_WorkDay>
    {
        public mf_WorkDayConfiguration()
            : this("dbo")
        {
        }

        public mf_WorkDayConfiguration(string schema)
        {
            ToTable(schema + ".mf_WorkDays");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired();
            Property(x => x.code).HasColumnName("code").IsRequired().HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasMaxLength(250);
            Property(x => x.monday).HasColumnName("monday").IsRequired();
            Property(x => x.tuesday).HasColumnName("tuesday").IsRequired();
            Property(x => x.wednesday).HasColumnName("wednesday").IsRequired();
            Property(x => x.thursday).HasColumnName("thursday").IsRequired();
            Property(x => x.friday).HasColumnName("friday").IsRequired();
            Property(x => x.saturday).HasColumnName("saturday").IsRequired();
            Property(x => x.sunday).HasColumnName("sunday").IsRequired();
            Property(x => x.fromTimeHour).HasColumnName("fromTimeHour").IsRequired();
            Property(x => x.fromTimeMinute).HasColumnName("fromTimeMinute").IsRequired();
            Property(x => x.toTimeHour).HasColumnName("toTimeHour").IsRequired();
            Property(x => x.toTimeMinute).HasColumnName("toTimeMinute").IsRequired();
            Property(x => x.breakHours).HasColumnName("breakHours").IsRequired().HasColumnType("float");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.sys_Company).WithMany(b => b.mf_WorkDays).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_WorkDays).HasForeignKey(c => c.updatedBy);
        }
    }
}