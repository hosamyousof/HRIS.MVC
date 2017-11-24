using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class mf_EmployeeAddressConfiguration : EntityTypeConfiguration<mf_EmployeeAddress>
    {
        public mf_EmployeeAddressConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeAddressConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeAddress");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.address1).HasColumnName("address1").IsOptional();
            Property(x => x.address2).HasColumnName("address2").IsOptional();
            Property(x => x.address3).HasColumnName("address3").IsOptional();
            Property(x => x.countryId).HasColumnName("countryId").IsRequired();
            Property(x => x.city).HasColumnName("city").IsOptional().HasMaxLength(150);
            Property(x => x.postalCode).HasColumnName("postalCode").IsOptional().HasMaxLength(50);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_Country).WithMany(b => b.mf_EmployeeAddresses).HasForeignKey(c => c.countryId);
            HasRequired(a => a.sys_User).WithMany(b => b.mf_EmployeeAddresses).HasForeignKey(c => c.updatedBy);
        }
    }
}