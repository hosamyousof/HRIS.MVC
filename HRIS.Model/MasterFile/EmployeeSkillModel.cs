using Common;
using HRIS.Model.Sys;
using Repository;
using System;
using System.ComponentModel.DataAnnotations;

namespace HRIS.Model.MasterFile
{
    public class EmployeeSkillModel : ModelAuditInfo
    {
        public EmployeeSkillModel()
        {
            this.skillProficiencyLevel = new ReferenceModel();
        }

        [PrimaryKey]
        public int? id { get; set; }

        public string skillName { get; set; }

        public ReferenceModel skillProficiencyLevel { get; set; }

    }
}
