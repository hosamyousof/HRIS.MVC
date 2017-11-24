using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class ta_ApplicationRequestGatePassConfiguration : EntityTypeConfiguration<ta_ApplicationRequestGatePass>
    {
        public ta_ApplicationRequestGatePassConfiguration()
            : this("dbo")
        {
        }

        public ta_ApplicationRequestGatePassConfiguration(string schema)
        {
            ToTable(schema + ".ta_ApplicationRequestGatePass");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.applicationRequestId).HasColumnName("applicationRequestId").IsRequired();
            Property(x => x.startDateTime).HasColumnName("startDateTime").IsRequired().HasColumnType("datetime");
            Property(x => x.endDateTime).HasColumnName("endDateTime").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.ta_ApplicationRequest).WithMany(b => b.ta_ApplicationRequestGatePasses).HasForeignKey(c => c.applicationRequestId);
        }
    }
}