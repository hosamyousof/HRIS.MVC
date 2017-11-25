using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class sys_CompanyConfiguration : EntityTypeConfiguration<sys_Company>
    {
        public sys_CompanyConfiguration()
            : this("dbo")
        {
        }

        public sys_CompanyConfiguration(string schema)
        {
            ToTable(schema + ".sys_Company");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.code).HasColumnName("code").IsRequired().HasMaxLength(50);
            Property(x => x.businessName).HasColumnName("businessName").IsRequired().HasMaxLength(250);
            Property(x => x.address1).HasColumnName("address1").IsOptional();
            Property(x => x.address2).HasColumnName("address2").IsOptional();
            Property(x => x.address3).HasColumnName("address3").IsOptional();
            Property(x => x.countryId).HasColumnName("countryId").IsOptional();
            Property(x => x.city).HasColumnName("city").IsOptional().HasMaxLength(150);
            Property(x => x.postalCode).HasColumnName("postalCode").IsOptional().HasMaxLength(50);
            Property(x => x.email).HasColumnName("email").IsOptional().HasMaxLength(50);
            Property(x => x.telephone).HasColumnName("telephone").IsOptional().HasMaxLength(50);
            Property(x => x.mobile).HasColumnName("mobile").IsOptional().HasMaxLength(50);
            Property(x => x.fax).HasColumnName("fax").IsOptional().HasMaxLength(50);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsOptional();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasOptional(a => a.mf_Country).WithMany(b => b.sys_Companies).HasForeignKey(c => c.countryId);
            HasOptional(a => a.sys_User_updatedBy).WithMany(b => b.sys_Companies).HasForeignKey(c => c.updatedBy);
        }
    }
}