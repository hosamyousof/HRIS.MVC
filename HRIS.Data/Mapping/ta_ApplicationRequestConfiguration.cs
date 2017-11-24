using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class ta_ApplicationRequestConfiguration : EntityTypeConfiguration<ta_ApplicationRequest>
    {
        public ta_ApplicationRequestConfiguration()
            : this("dbo")
        {
        }

        public ta_ApplicationRequestConfiguration(string schema)
        {
            ToTable(schema + ".ta_ApplicationRequest");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.applicationRequestTypeId).HasColumnName("applicationRequestTypeId").IsRequired();
            Property(x => x.note).HasColumnName("note").IsRequired();
            Property(x => x.status).HasColumnName("status").IsRequired();
            Property(x => x.assignTo).HasColumnName("assignTo").IsRequired();
            Property(x => x.requestedBy).HasColumnName("requestedBy").IsRequired();
            Property(x => x.requestedDate).HasColumnName("requestedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_ApplicationRequestType).WithMany(b => b.ta_ApplicationRequests).HasForeignKey(c => c.applicationRequestTypeId);
            HasRequired(a => a.sys_User_assignTo).WithMany(b => b.ta_ApplicationRequests_assignTo).HasForeignKey(c => c.assignTo);
            HasRequired(a => a.sys_User_requestedBy).WithMany(b => b.ta_ApplicationRequests_requestedBy).HasForeignKey(c => c.requestedBy);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.ta_ApplicationRequests_updatedBy).HasForeignKey(c => c.updatedBy);
        }
    }
}