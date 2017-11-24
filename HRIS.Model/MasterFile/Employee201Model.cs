using Common;
using HRIS.Model.Sys;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.MasterFile
{
    public class Employee201Model
    {
        public Employee201Model()
        {
            this.EmploymentTypeList = new List<DataReference>();
            this.PositionLevelList = new List<ReferenceModel>();
            this.PayRateTypeList = new List<ReferenceModel>();
            this.TaxStatusList = new List<ReferenceModel>();
            this.EmploymentStatusList = new List<DataReference>();
        }

        [PrimaryKey]
        public Guid? id { get; set; }

        [ExcludeToUpdate]
        public Guid? employeeId { get; set; }

        [DisplayName("Employee Code")]
        public string employeeCode { get; set; }

        [DisplayName("Department")]
        public Guid? departmentId { get; set; }

        [DisplayName("Section")]
        public Guid? departmentSectionId { get; set; }

        [DisplayName("Position")]
        public Guid? positionId { get; set; }

        [DisplayName("Email")]
        public string email { get; set; }

        [DisplayName("Employment Type")]
        public Guid? employmentTypeId { get; set; }

        [DisplayName("Position Level")]
        public int? positionLevel { get; set; }

        [DisplayName("Date Hired")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? dateHired { get; set; }

        [DisplayName("Resigned Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? resignedDate { get; set; }

        [DisplayName("Tax Status")]
        public int? taxStatus { get; set; }

        [DisplayName("Time Sheet Required")]
        public bool? timeSheetRequired { get; set; }

        [DisplayName("Entitled Unwork Regular Holiday")]
        public bool? entitledUnworkRegularHoliday { get; set; }

        [DisplayName("Entitled Unwork Special Holiday")]
        public bool? entitledUnworkSpecialHoliday { get; set; }

        [DisplayName("Entitled Overtime")]
        public bool? entitledOvertime { get; set; }

        [DisplayName("Entitled Holiday Pay")]
        public bool? entitledHolidayPay { get; set; }

        [DisplayName("Payroll Group")]
        public Guid? payrollGroupId { get; set; }

        [DisplayName("Employment Status")]
        public Guid? employmentStatusId { get; set; }

        [DisplayName("Agency")]
        public Guid? agencyId { get; set; }

        [Required]
        [DisplayName("Confidential")]
        public bool confidential { get; set; }

        #region Reference

        [ExcludeToUpdate]
        public List<DataReference> EmploymentTypeList { get; set; }

        [ExcludeToUpdate]
        public List<ReferenceModel> PositionLevelList { get; set; }

        [ExcludeToUpdate]
        public List<ReferenceModel> PayRateTypeList { get; set; }

        [ExcludeToUpdate]
        public List<ReferenceModel> TaxStatusList { get; set; }

        public List<DataReference> EmploymentStatusList { get; set; }

        #endregion Reference
    }
}