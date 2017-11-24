using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class pr_PayrollConfiguration : EntityTypeConfiguration<pr_Payroll>
    {
        public pr_PayrollConfiguration()
            : this("dbo")
        {
        }

        public pr_PayrollConfiguration(string schema)
        {
            ToTable(schema + ".pr_Payroll");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.companyId).HasColumnName("companyId").IsRequired();
            Property(x => x.cutOffAttendanceId).HasColumnName("cutOffAttendanceId").IsRequired();
            Property(x => x.status).HasColumnName("status").IsRequired();
            Property(x => x.includeLegalDeduction).HasColumnName("includeLegalDeduction").IsRequired();
            Property(x => x.generatedBy).HasColumnName("generatedBy").IsRequired();
            Property(x => x.generatedDate).HasColumnName("generatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.sys_Company).WithMany(b => b.pr_Payrolls).HasForeignKey(c => c.companyId);
            HasRequired(a => a.sys_User_generatedBy).WithMany(b => b.pr_Payrolls_generatedBy).HasForeignKey(c => c.generatedBy);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.pr_Payrolls_updatedBy).HasForeignKey(c => c.updatedBy);
            HasRequired(a => a.ta_CutOffAttendance).WithMany(b => b.pr_Payrolls).HasForeignKey(c => c.cutOffAttendanceId);
        }
    }
}