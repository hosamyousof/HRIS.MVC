using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal class mf_EmployeeConfiguration : EntityTypeConfiguration<mf_Employee>
    {
        public mf_EmployeeConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeConfiguration(string schema)
        {
            ToTable(schema + ".mf_Employee");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired();
            Property(x => x.firstName).HasColumnName("firstName").IsRequired().HasMaxLength(50);
            Property(x => x.lastName).HasColumnName("lastName").IsRequired().HasMaxLength(50);
            Property(x => x.middleName).HasColumnName("middleName").IsOptional().HasMaxLength(50);
            Property(x => x.birthDate).HasColumnName("birthDate").IsOptional().HasColumnType("datetime");
            Property(x => x.email).HasColumnName("email").IsOptional().HasMaxLength(100);
            Property(x => x.gender).HasColumnName("gender").IsOptional();
            Property(x => x.maritalStatus).HasColumnName("maritalStatus").IsOptional();
            Property(x => x.contact1).HasColumnName("contact1").IsOptional().HasMaxLength(50);
            Property(x => x.contact2).HasColumnName("contact2").IsOptional().HasMaxLength(50);
            Property(x => x.contact3).HasColumnName("contact3").IsOptional().HasMaxLength(50);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();
            Property(x => x.employeeAddressId).HasColumnName("employeeAddressId").IsOptional();
            Property(x => x.employee201Id).HasColumnName("employee201Id").IsOptional();
            Property(x => x.pictureExtension).HasColumnName("pictureExtension").IsOptional().HasMaxLength(50);

            HasOptional(a => a.mf_Employee201).WithMany(b => b.mf_Employees).HasForeignKey(c => c.employee201Id);
            HasOptional(a => a.mf_EmployeeAddress).WithMany(b => b.mf_Employees).HasForeignKey(c => c.employeeAddressId);
            HasRequired(a => a.sys_Company).WithMany(b => b.mf_Employees).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.mf_Employees).HasForeignKey(c => c.updatedBy);
        }
    }
}