using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class mf_WorkDayConfiguration : EntityTypeConfiguration<mf_WorkDay>
    {
        public mf_WorkDayConfiguration()
            : this("dbo")
        {
        }

        public mf_WorkDayConfiguration(string schema)
        {
            ToTable(schema + ".mf_WorkDays");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.monday).HasColumnName("monday").IsRequired().HasColumnType("bit");
            Property(x => x.tuesday).HasColumnName("tuesday").IsRequired().HasColumnType("bit");
            Property(x => x.wednesday).HasColumnName("wednesday").IsRequired().HasColumnType("bit");
            Property(x => x.thursday).HasColumnName("thursday").IsRequired().HasColumnType("bit");
            Property(x => x.friday).HasColumnName("friday").IsRequired().HasColumnType("bit");
            Property(x => x.saturday).HasColumnName("saturday").IsRequired().HasColumnType("bit");
            Property(x => x.sunday).HasColumnName("sunday").IsRequired().HasColumnType("bit");
            Property(x => x.fromTimeHour).HasColumnName("fromTimeHour").IsRequired().HasColumnType("int");
            Property(x => x.fromTimeMinute).HasColumnName("fromTimeMinute").IsRequired().HasColumnType("int");
            Property(x => x.toTimeHour).HasColumnName("toTimeHour").IsRequired().HasColumnType("int");
            Property(x => x.toTimeMinute).HasColumnName("toTimeMinute").IsRequired().HasColumnType("int");
            Property(x => x.breakHours).HasColumnName("breakHours").IsRequired().HasColumnType("float");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.sys_Company).WithMany(b => b.mf_WorkDays).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_WorkDays).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}