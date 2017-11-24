using HRIS.Model.Sys;
using Repository;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HRIS.Model.MasterFile
{
    public class EmployeeOffenseModel : ModelAuditInfo
    {
        [PrimaryKey]
        public int? id { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Offense Date")]
        [Required]
        public DateTime offenseDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Memo Date")]
        public DateTime? memoDate { get; set; }

        [Required]
        [DisplayName("Offense")]
        public ReferenceModel Offense { get; set; }

        [Required]
        [DisplayName("Penalty Type")]
        public ReferenceModel penaltyType { get; set; }

        [Required]
        [DisplayName("Degree")]
        public ReferenceModel degree { get; set; }

        [DisplayName("Frequency")]
        public int frequency { get; set; }

        [DisplayName("Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? startDate { get; set; }

        [DisplayName("End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? endDate { get; set; }

        [Required]
        [DisplayName("Remarks")]
        public string remarks { get; set; }
        
    }
}