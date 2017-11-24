using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class sys_CompanyConfiguration : EntityTypeConfiguration<sys_Company>
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
            Property(x => x.code).HasColumnName("code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.businessName).HasColumnName("businessName").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.address1).HasColumnName("address1").IsOptional().HasColumnType("nvarchar");
            Property(x => x.address2).HasColumnName("address2").IsOptional().HasColumnType("nvarchar");
            Property(x => x.address3).HasColumnName("address3").IsOptional().HasColumnType("nvarchar");
            Property(x => x.countryId).HasColumnName("countryId").IsRequired();
            Property(x => x.city).HasColumnName("city").IsOptional().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.postalCode).HasColumnName("postalCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.email).HasColumnName("email").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.telephone).HasColumnName("telephone").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.mobile).HasColumnName("mobile").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.fax).HasColumnName("fax").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_Country).WithMany(b => b.sys_Companies).HasForeignKey(c => c.countryId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}