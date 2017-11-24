using Common;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Sys
{
    public class UserModel : ModelAuditInfo
    {
        public int? id { get; set; }

        public string username { get; set; }

        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        public ReferenceModel UserStatus { get; set; }
        
    }
}