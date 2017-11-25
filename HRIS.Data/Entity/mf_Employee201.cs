using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public class mf_Employee201 : EntityBase
    {
        public string employeeCode { get; set; }
        public Guid? departmentId { get; set; }
        public Guid? departmentSectionId { get; set; }
        public Guid? positionId { get; set; }
        public string email { get; set; }
        public Guid? employmentTypeId { get; set; }
        public Guid? employmentStatusId { get; set; }
        public int? positionLevel { get; set; }
        public DateTime? dateHired { get; set; }
        public DateTime? resignedDate { get; set; }
        public int? taxStatus { get; set; }
        public bool? timeSheetRequired { get; set; }
        public bool? entitledUnworkRegularHoliday { get; set; }
        public bool? entitledUnworkSpecialHoliday { get; set; }
        public bool? entitledOvertime { get; set; }
        public bool? entitledHolidayPay { get; set; }
        public Guid? payrollGroupId { get; set; }
        public Guid? agencyId { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }
        public bool confidential { get; set; }

        public virtual ICollection<mf_Employee> mf_Employees { get; set; }

        public virtual mf_Agency mf_Agency { get; set; }
        public virtual mf_Department mf_Department { get; set; }
        public virtual mf_DepartmentSection mf_DepartmentSection { get; set; }
        public virtual mf_EmploymentStatu mf_EmploymentStatu { get; set; }
        public virtual mf_EmploymentType mf_EmploymentType { get; set; }
        public virtual mf_PayrollGroup mf_PayrollGroup { get; set; }
        public virtual mf_Position mf_Position { get; set; }
        public virtual sys_User sys_User_updatedBy { get; set; }

        public mf_Employee201()
        {
            timeSheetRequired = true;
            entitledUnworkRegularHoliday = true;
            entitledUnworkSpecialHoliday = true;
            updatedDate = System.DateTime.Now;
            deleted = false;
            confidential = false;
            mf_Employees = new List<mf_Employee>();
        }
    }
}