using Common;
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
    public class EmployeeWorkHistoryModel : ModelAuditInfo
    {
        [PrimaryKey]
        public int? id { get; set; }

        [Required]
        [DisplayName("Company Name")]
        public string companyName { get; set; }

        [Required]
        [DisplayName("Position")]
        public string position { get; set; }

        [Required]
        [DisplayName("Joined Date")]
        public int joinedMonth { get; set; }

        [Required]
        [DisplayName("Joined Year")]
        public int joinedYear { get; set; }

        [DisplayName("Resigned Month")]
        public int? resignedMonth { get; set; }

        [DisplayName("Resigned Year")]
        public int? resignedYear { get; set; }

        [DisplayName("Present")]
        public bool? isPresent { get; set; }

        [DisplayName("Joined Date")]
        [ExcludeToUpdate]
        public string joined { get; set; }

        [ExcludeToUpdate]
        [DisplayName("Until")]
        public string until { get; set; }
    }
}