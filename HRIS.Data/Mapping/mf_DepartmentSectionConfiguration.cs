using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class mf_DepartmentSectionConfiguration : EntityTypeConfiguration<mf_DepartmentSection>
    {
        public mf_DepartmentSectionConfiguration()
            : this("dbo")
        {
        }

        public mf_DepartmentSectionConfiguration(string schema)
        {
            ToTable(schema + ".mf_DepartmentSection");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.departmentId).HasColumnName("departmentId").IsRequired();
            Property(x => x.code).HasColumnName("code").IsRequired().HasMaxLength(50);
            Property(x => x.description).HasColumnName("description").IsRequired().HasMaxLength(250);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_Department).WithMany(b => b.mf_DepartmentSections).HasForeignKey(c => c.departmentId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_DepartmentSections).HasForeignKey(c => c.updatedBy);
        }
    }
}