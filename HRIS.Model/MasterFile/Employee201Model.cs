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
            this.EmploymentTypeList = new List<ReferenceModel>();
            this.PositionLevelList = new List<ReferenceModel>();
            this.PayRateTypeList = new List<ReferenceModel>();
            this.TaxStatusList = new List<ReferenceModel>();
            this.EmploymentStatusList = new List<ReferenceModel>();
        }

        [PrimaryKey]
        public int? id { get; set; }

        [ExcludeToUpdate]
        public int? employeeId { get; set; }

        [DisplayName("Employee Code")]
        public string employeeCode { get; set; }

        [DisplayName("Department")]
        public int? departmentId { get; set; }

        [DisplayName("Section")]
        public int? departmentSectionId { get; set; }

        [DisplayName("Position")]
        public int? positionId { get; set; }

        [DisplayName("Email")]
        public string email { get; set; }

        [DisplayName("Employment Type")]
        public int? employmentTypeId { get; set; }

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
        public int? payrollGroupId { get; set; }

        [DisplayName("Employment Status")]
        public int? employmentStatusId { get; set; }

        [DisplayName("Agency")]
        public int? agencyId { get; set; }

        [Required]
        [DisplayName("Confidential")]
        public bool confidential { get; set; }

        #region Reference

        [ExcludeToUpdate]
        public List<ReferenceModel> EmploymentTypeList { get; set; }

        [ExcludeToUpdate]
        public List<ReferenceModel> PositionLevelList { get; set; }

        [ExcludeToUpdate]
        public List<ReferenceModel> PayRateTypeList { get; set; }

        [ExcludeToUpdate]
        public List<ReferenceModel> TaxStatusList { get; set; }

        public List<ReferenceModel> EmploymentStatusList { get; set; }

        #endregion Reference
    }
}