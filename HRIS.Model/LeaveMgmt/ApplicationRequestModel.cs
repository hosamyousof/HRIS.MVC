using Repository;
using System;
using System.ComponentModel;

namespace HRIS.Model.LeaveMgmt
{
    public class ApplicationRequestModel
    {
        [PrimaryKey]
        public Guid? id { get; set; }

        [ExcludeToUpdate]
        public Guid? applicationRequestTypeId { get; set; }

        [DisplayName("Note")]
        public string note { get; set; }

        [DisplayName("Status")]
        public int status { get; set; }

        [DisplayName("Employee Name")]
        public Guid assignTo { get; set; }

        public Guid requestedBy { get; set; }

        public DateTime requestedDate { get; set; }

        public Guid updatedBy { get; set; }

        public DateTime updatedDate { get; set; }
    }
}