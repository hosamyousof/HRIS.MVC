using System;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data
{
    internal partial class mf_EmployeeIdentificationDocumentConfiguration : EntityTypeConfiguration<mf_EmployeeIdentificationDocument>
    {
        public mf_EmployeeIdentificationDocumentConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeIdentificationDocumentConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeIdentificationDocument");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired().HasColumnType("int");
            Property(x => x.identificationDocumentId).HasColumnName("identificationDocumentId").IsRequired().HasColumnType("int");
            Property(x => x.idNumber).HasColumnName("idNumber").IsRequired().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeIdentificationDocuments).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_IdentificationDocument).WithMany(b => b.mf_EmployeeIdentificationDocuments).HasForeignKey(c => c.identificationDocumentId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeIdentificationDocuments).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}