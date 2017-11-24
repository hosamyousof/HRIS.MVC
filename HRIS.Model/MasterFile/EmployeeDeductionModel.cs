using HRIS.Model.Sys;
using Repository;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HRIS.Model.MasterFile
{
    public class EmployeeDeductionModel : ModelAuditInfo
    {
        [PrimaryKey]
        public int? id { get; set; }

        [Required]
        [DisplayName("Deduction")]
        public ReferenceModel Deduction { get; set; }

        [Required]
        [DisplayName("Amount")]
        public double? amount { get; set; }
    }
}