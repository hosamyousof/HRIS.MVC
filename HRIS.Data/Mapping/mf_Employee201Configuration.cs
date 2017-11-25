using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal class mf_Employee201Configuration : EntityTypeConfiguration<mf_Employee201>
    {
        public mf_Employee201Configuration()
            : this("dbo")
        {
        }

        public mf_Employee201Configuration(string schema)
        {
            ToTable(schema + ".mf_Employee201");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeCode).HasColumnName("employeeCode").IsRequired().HasMaxLength(250);
            Property(x => x.departmentId).HasColumnName("departmentId").IsOptional();
            Property(x => x.departmentSectionId).HasColumnName("departmentSectionId").IsOptional();
            Property(x => x.positionId).HasColumnName("positionId").IsOptional();
            Property(x => x.email).HasColumnName("email").IsOptional().HasMaxLength(150);
            Property(x => x.employmentTypeId).HasColumnName("employmentTypeId").IsOptional();
            Property(x => x.employmentStatusId).HasColumnName("employmentStatusId").IsOptional();
            Property(x => x.positionLevel).HasColumnName("positionLevel").IsOptional();
            Property(x => x.dateHired).HasColumnName("dateHired").IsOptional().HasColumnType("datetime");
            Property(x => x.resignedDate).HasColumnName("resignedDate").IsOptional().HasColumnType("datetime");
            Property(x => x.taxStatus).HasColumnName("taxStatus").IsOptional();
            Property(x => x.timeSheetRequired).HasColumnName("timeSheetRequired").IsOptional();
            Property(x => x.entitledUnworkRegularHoliday).HasColumnName("entitledUnworkRegularHoliday").IsOptional();
            Property(x => x.entitledUnworkSpecialHoliday).HasColumnName("entitledUnworkSpecialHoliday").IsOptional();
            Property(x => x.entitledOvertime).HasColumnName("entitledOvertime").IsOptional();
            Property(x => x.entitledHolidayPay).HasColumnName("entitledHolidayPay").IsOptional();
            Property(x => x.payrollGroupId).HasColumnName("payrollGroupId").IsOptional();
            Property(x => x.agencyId).HasColumnName("agencyId").IsOptional();
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();
            Property(x => x.confidential).HasColumnName("confidential").IsRequired();

            HasOptional(a => a.mf_Agency).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.agencyId);
            HasOptional(a => a.mf_Department).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.departmentId);
            HasOptional(a => a.mf_DepartmentSection).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.departmentSectionId);
            HasOptional(a => a.mf_EmploymentStatu).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.employmentStatusId);
            HasOptional(a => a.mf_EmploymentType).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.employmentTypeId);
            HasOptional(a => a.mf_PayrollGroup).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.payrollGroupId);
            HasOptional(a => a.mf_Position).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.positionId);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.mf_Employee201).HasForeignKey(c => c.updatedBy);
        }
    }
}