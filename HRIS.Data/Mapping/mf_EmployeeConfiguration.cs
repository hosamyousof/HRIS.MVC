using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class mf_EmployeeConfiguration : EntityTypeConfiguration<mf_Employee>
    {
        public mf_EmployeeConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeConfiguration(string schema)
        {
            ToTable(schema + ".mf_Employee");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired().HasColumnType("int");
            Property(x => x.firstName).HasColumnName("firstName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.lastName).HasColumnName("lastName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.middleName).HasColumnName("middleName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.birthDate).HasColumnName("birthDate").IsOptional().HasColumnType("datetime");
            Property(x => x.email).HasColumnName("email").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.gender).HasColumnName("gender").IsOptional().HasColumnType("int");
            Property(x => x.maritalStatus).HasColumnName("maritalStatus").IsOptional().HasColumnType("int");
            Property(x => x.contact1).HasColumnName("contact1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.contact2).HasColumnName("contact2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.contact3).HasColumnName("contact3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");
            Property(x => x.employeeAddressId).HasColumnName("employeeAddressId").IsOptional().HasColumnType("int");
            Property(x => x.employee201Id).HasColumnName("employee201Id").IsOptional().HasColumnType("int");
            Property(x => x.pictureExtension).HasColumnName("pictureExtension").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);

            HasOptional(a => a.mf_Employee201).WithMany(b => b.mf_Employees).HasForeignKey(c => c.employee201Id);
            HasOptional(a => a.mf_EmployeeAddress).WithMany(b => b.mf_Employees).HasForeignKey(c => c.employeeAddressId);
            HasRequired(a => a.sys_Company).WithMany(b => b.mf_Employees).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_Employees).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}