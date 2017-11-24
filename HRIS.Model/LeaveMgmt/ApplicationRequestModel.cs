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

namespace HRIS.Model.LeaveMgmt
{
    public class ApplicationRequestModel
    {
        [PrimaryKey]
        public int? id { get; set; }

        [ExcludeToUpdate]
        public int? applicationRequestTypeId { get; set; }

        [DisplayName("Note")]
        public string note { get; set; }
        [DisplayName("Status")]
        public int status { get; set; }
        [DisplayName("Employee Name")]
        public int assignTo { get; set; }
        public int requestedBy { get; set; }
        public DateTime requestedDate { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }
    }
}
