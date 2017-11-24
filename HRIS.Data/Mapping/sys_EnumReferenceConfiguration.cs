using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class sys_EnumReferenceConfiguration : EntityTypeConfiguration<sys_EnumReference>
    {
        public sys_EnumReferenceConfiguration()
            : this("dbo")
        {
        }

        public sys_EnumReferenceConfiguration(string schema)
        {
            ToTable(schema + ".sys_EnumReference");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired();
            Property(x => x.name).HasColumnName("name").IsRequired().HasMaxLength(50);
            Property(x => x.value).HasColumnName("value").IsRequired();
            Property(x => x.description).HasColumnName("description").IsRequired().HasMaxLength(250);
            Property(x => x.displayOrder).HasColumnName("displayOrder").IsRequired();
            Property(x => x.hidden).HasColumnName("hidden").IsRequired();
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();
            Property(x => x.field1).HasColumnName("field1").IsOptional().HasMaxLength(250);
            Property(x => x.field2).HasColumnName("field2").IsOptional().HasMaxLength(250);
            Property(x => x.field3).HasColumnName("field3").IsOptional().HasMaxLength(250);
            Property(x => x.field4).HasColumnName("field4").IsOptional().HasMaxLength(250);
            Property(x => x.field5).HasColumnName("field5").IsOptional().HasMaxLength(250);

            HasRequired(a => a.sys_Company).WithMany(b => b.sys_EnumReferences).HasForeignKey(c => c.companyId);
        }
    }
}