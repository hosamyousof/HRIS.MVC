using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data
{
    internal partial class sys_EnumReferenceConfiguration : EntityTypeConfiguration<sys_EnumReference>
    {
        public sys_EnumReferenceConfiguration()
            : this("dbo")
        {
        }

        public sys_EnumReferenceConfiguration(string schema)
        {
            ToTable(schema + ".sys_EnumReference");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.name).HasColumnName("name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.value).HasColumnName("value").IsRequired().HasColumnType("int");
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.displayOrder).HasColumnName("displayOrder").IsRequired().HasColumnType("int");
            Property(x => x.hidden).HasColumnName("hidden").IsRequired().HasColumnType("bit");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");
            Property(x => x.field1).HasColumnName("field1").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.field2).HasColumnName("field2").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.field3).HasColumnName("field3").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.field4).HasColumnName("field4").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.field5).HasColumnName("field5").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);

            HasRequired(a => a.sys_Company).WithMany(b => b.sys_EnumReferences).HasForeignKey(c => c.companyId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}