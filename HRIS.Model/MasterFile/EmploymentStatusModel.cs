﻿using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.MasterFile
{
    public class EmploymentStatusModel : ModelAuditInfo
    {
        public Guid? id { get; set; }

        [DisplayName("Code")]
        public string code { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("Process Payroll?")]
        public bool allowProcessPayroll { get; set; }
    }
}