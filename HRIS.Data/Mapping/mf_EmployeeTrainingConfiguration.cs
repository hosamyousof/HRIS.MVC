using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace HRIS.Data.Entity
{
    internal class mf_EmployeeTrainingConfiguration : EntityTypeConfiguration<mf_EmployeeTraining>
    {
        public mf_EmployeeTrainingConfiguration()
            : this("dbo")
        {
        }

        public mf_EmployeeTrainingConfiguration(string schema)
        {
            ToTable(schema + ".mf_EmployeeTraining");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.employeeId).HasColumnName("employeeId").IsRequired();
            Property(x => x.trainingDate).HasColumnName("trainingDate").IsRequired().HasColumnType("datetime");
            Property(x => x.trainingName).HasColumnName("trainingName").IsRequired().HasMaxLength(250);
            Property(x => x.description).HasColumnName("description").IsOptional();
            Property(x => x.startDate).HasColumnName("startDate").IsOptional().HasColumnType("datetime");
            Property(x => x.endDate).HasColumnName("endDate").IsOptional().HasColumnType("datetime");
            Property(x => x.updatedBy).HasColumnName("updatedBy").IsRequired();
            Property(x => x.updatedDate).HasColumnName("updatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.deleted).HasColumnName("deleted").IsRequired();

            HasRequired(a => a.mf_Employee).WithMany(b => b.mf_EmployeeTrainings).HasForeignKey(c => c.employeeId);
            HasRequired(a => a.sys_User_updatedBy).WithMany(b => b.mf_EmployeeTrainings).HasForeignKey(c => c.updatedBy);
        }
    }
}