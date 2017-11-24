using System;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data
{
    internal partial class mf_EmployeeSkillConfiguration : EntityTypeConfiguration<mf_EmployeeSkill>
    {
        public mf_EmployeeSkillConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeSkillConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeSkill");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.skillName).HasColumnName("skillName").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.skillProficiencyLevel).HasColumnName("skillProficiencyLevel").IsOptional().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeSkills).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeSkills).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}