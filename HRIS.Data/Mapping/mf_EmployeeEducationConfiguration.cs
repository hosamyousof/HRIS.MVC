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

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.schoolName).HasColumnName("schoolName").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.fromYear).HasColumnName("fromYear").IsOptional().HasColumnType("int");
            Property(x => x.toYear).HasColumnName("toYear").IsOptional().HasColumnType("int");
            Property(x => x.isGraduated).HasColumnName("isGraduated").IsOptional().HasColumnType("bit");
            Property(x => x.course).HasColumnName("course").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.createdBy).HasColumnName("createdBy").IsRequired().HasColumnType("int");
            Property(x => x.createdDate).HasColumnName("createdDate").IsRequired().HasColumnType("datetime");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeEducations).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeEducations).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}