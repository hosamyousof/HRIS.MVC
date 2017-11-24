using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class mf_DepartmentSectionRequestApproverConfiguration : EntityTypeConfiguration<mf_DepartmentSectionRequestApprover>
    {
        public mf_DepartmentSectionRequestApproverConfiguration()
            : this("dbo")
        {
        }

        public mf_DepartmentSectionRequestApproverConfiguration(string schema)
        {
            ToTable(schema + ".mf_DepartmentSectionRequestApprover");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.approverId).HasColumnName("approverId").IsRequired();
            Property(x => x.departmentSectionId).HasColumnName("departmentSectionId").IsRequired();
            Property(x => x.applicationRequestTypeId).HasColumnName("applicationRequestTypeId").IsRequired();
            Property(x => x.orderNo).HasColumnName("orderNo").IsRequired();
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_ApplicationRequestType).WithMany(b => b.mf_DepartmentSectionRequestApprovers).HasForeignKey(c => c.applicationRequestTypeId);
            HasRequired(a => a.mf_DepartmentSection).WithMany(b => b.mf_DepartmentSectionRequestApprovers).HasForeignKey(c => c.departmentSectionId);
            HasRequired(a => a.sys_User_approverId).WithMany(b => b.mf_DepartmentSectionRequestApprovers_approverId).HasForeignKey(c => c.approverId);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.mf_DepartmentSectionRequestApprovers_updatedBy).HasForeignKey(c => c.updatedBy);
        }
    }
}