using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class mf_DepartmentSectionConfiguration : EntityTypeConfiguration<mf_DepartmentSection>
    {
        public mf_DepartmentSectionConfiguration()
            : this("dbo")
        {
        }

        public mf_DepartmentSectionConfiguration(string schema)
        {
            ToTable(schema + ".mf_DepartmentSection");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.departmentId).HasColumnName("departmentId").IsRequired().HasColumnType("int");
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Department).WithMany(b => b.mf_DepartmentSections).HasForeignKey(c => c.departmentId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}