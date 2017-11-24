using HRIS.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Mapping
{
    internal partial class mf_EmployeeOffenseConfiguration : EntityTypeConfiguration<mf_EmployeeOffense>
    {
        public mf_EmployeeOffenseConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeOffenseConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeOffense");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired();
            Property(x => x.offenseId).HasColumnName("offenseId").IsRequired();
            Property(x => x.offenseDate).HasColumnName("offenseDate").IsRequired().HasColumnType("datetime");
            Property(x => x.memoDate).HasColumnName("memoDate").IsOptional().HasColumnType("datetime");
            Property(x => x.penaltyTypeId).HasColumnName("penaltyTypeId").IsRequired();
            Property(x => x.frequency).HasColumnName("frequency").IsRequired();
            Property(x => x.degree).HasColumnName("degree").IsRequired();
            Property(x => x.startDate).HasColumnName("startDate").IsOptional().HasColumnType("datetime");
            Property(x => x.endDate).HasColumnName("endDate").IsOptional().HasColumnType("datetime");
            Property(x => x.remarks).HasColumnName("remarks").IsRequired().HasColumnType("nvarchar");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeOffenses).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.mf_Offense).WithMany(b => b.mf_EmployeeOffenses).HasForeignKey(c => c.offenseId);
            HasRequired(a => a.mf_PenaltyType).WithMany(b => b.mf_EmployeeOffenses).HasForeignKey(c => c.penaltyTypeId);
            InitializePartial();
        }

        partial void InitializePartial();
    }
}