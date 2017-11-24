using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class mf_EmployeeEducationConfiguration : EntityTypeConfiguration<mf_EmployeeEducation>
    {
        public mf_EmployeeEducationConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeEducationConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeEducation");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired();
            Property(x => x.schoolName).HasColumnName("schoolName").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.fromYear).HasColumnName("fromYear").IsOptional();
            Property(x => x.toYear).HasColumnName("toYear").IsOptional();
            Property(x => x.isGraduated).HasColumnName("isGraduated").IsOptional();
            Property(x => x.course).HasColumnName("course").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.createdBy).HasColumnName("createdBy").IsRequired();
            Property(x => x.createdDate).HasColumnName("createdDate").IsRequired().HasColumnType("datetime");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeEducations).HasForeignKey(c => c.employeeId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}