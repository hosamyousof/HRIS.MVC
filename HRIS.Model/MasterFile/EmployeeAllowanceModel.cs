using Common;
using HRIS.Model.Sys;
using Repository;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HRIS.Model.MasterFile
{
    public class EmployeeAllowanceModel : ModelAuditInfo
    {
        [PrimaryKey]
        public Guid? id { get; set; }

        [Required]
        [DisplayName("Allowance")]
        public DataReference Allowance { get; set; }

        [Required]
        [DisplayName("Amount")]
        public double? amount { get; set; }
    }
}