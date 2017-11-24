using System;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data
{
    internal partial class mf_EmployeeAddressConfiguration : EntityTypeConfiguration<mf_EmployeeAddress>
    {
        public mf_EmployeeAddressConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeAddressConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeAddress");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.address1).HasColumnName("address1").IsOptional().HasColumnType("nvarchar");
            Property(x => x.address2).HasColumnName("address2").IsOptional().HasColumnType("nvarchar");
            Property(x => x.address3).HasColumnName("address3").IsOptional().HasColumnType("nvarchar");
            Property(x => x.countryId).HasColumnName("countryId").IsRequired().HasColumnType("int");
            Property(x => x.city).HasColumnName("city").IsOptional().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.postalCode).HasColumnName("postalCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_Country).WithMany(b => b.mf_EmployeeAddresses).HasForeignKey(c => c.countryId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeAddresses).HasForeignKey(c => c.updatedBy);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}