using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class mf_DepartmentSectionRequestApproverConfiguration : EntityTypeConfiguration<mf_DepartmentSectionRequestApprover>
    {
        public mf_DepartmentSectionRequestApproverConfiguration()
            : this("dbo")
        {
        }

        public mf_DepartmentSectionRequestApproverConfiguration(string schema)
        {
            ToTable(schema + ".mf_DepartmentSectionRequestApprover");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.approverId).HasColumnName("approverId").IsRequired().HasColumnType("int");
            Property(x => x.departmentSectionId).HasColumnName("departmentSectionId").IsRequired().HasColumnType("int");
            Property(x => x.applicationRequestTypeId).HasColumnName("applicationRequestTypeId").IsRequired().HasColumnType("int");
            Property(x => x.orderNo).HasColumnName("orderNo").IsRequired().HasColumnType("int");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired().HasColumnType("int");
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired().HasColumnType("bit");

            HasRequired(a => a.mf_ApplicationRequestType).WithMany(b => b.mf_DepartmentSectionRequestApprovers).HasForeignKey(c => c.applicationRequestTypeId);
            HasRequired(a => a.mf_DepartmentSection).WithMany(b => b.mf_DepartmentSectionRequestApprovers).HasForeignKey(c => c.departmentSectionId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}