using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model
{
    public class ModelAuditInfo
    {
        [ExcludeToUpdate]
        [DisplayName("Updated By")]
        public string updatedBy { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]
        [ExcludeToUpdate]
        [DisplayName("Updated Date")]
        public DateTime? updatedDate { get; set; }
    }
}
